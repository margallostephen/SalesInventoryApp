using MySqlConnector;

namespace SalesInventoryApp
{
    public partial class Sales : Form
    {
        public MySqlConnection connection { get; set; }

        public Sales()
        {
            InitializeComponent();
            SalesTable.MouseWheel += new MouseEventHandler(MouseWheel);
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            Dashboard.LoadTableRecord(SalesTable, null, NoLabel, connection);
        }

        private void SelItemBtn_Click(object sender, EventArgs e)
        {
            Dashboard.MinimizedSideBar();
            connection.Open();
            using MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM inventory_stocks";
            command.Prepare();
            using MySqlDataReader dataReader = command.ExecuteReader();

            Message messageForm = null;

            if (dataReader.HasRows)
            {
                dataReader.Close();
                command.CommandText = "SELECT SUM(quantity) FROM inventory_stocks";
                command.Prepare();
                decimal quantity = (decimal)command.ExecuteScalar();

                if (quantity < 1)
                    messageForm = new("Error", "All items are out of stock.");
                else
                {
                    connection.Close();
                    SellItem sellPrompt = new(this) { connection = connection };
                    DialogResult result = sellPrompt.ShowDialog();
                    Dashboard.DisposePrompt(result, sellPrompt, SalesTable, null, NoLabel, connection);
                }
            }
            else
                messageForm = new("Warning", "No items are available. Please add first item.");

            if (messageForm != null)
            {
                connection.Close();
                messageForm.ShowDialog(this);
            }
        }

        private new void MouseWheel(object sender, MouseEventArgs e)
        {
            Dashboard.ScrollUpDown(SalesTable, e);
        }
    }
}
