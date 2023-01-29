using MySqlConnector;

namespace SalesInventoryApp
{
    public partial class Sales : Form
    {
        public MySqlConnection Connection { get; set; }

        public Sales()
        {
            InitializeComponent();
            SalesTable.MouseWheel += new MouseEventHandler(MouseWheel);
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            Main.LoadTableRecord(SalesTable, null, NoLabel, Connection);
        }

        private void SelItemBtn_Click(object sender, EventArgs e)
        {
            Main.MinimizedSideBar();
            Connection.Open();
            using MySqlCommand command = Connection.CreateCommand();
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
                    Connection.Close();
                    SellItem sellPrompt = new(this) { Connection = Connection };
                    DialogResult result = sellPrompt.ShowDialog();
                    Main.DisposePrompt(result, sellPrompt, SalesTable, null, NoLabel, Connection);
                }
            }
            else
                messageForm = new("Warning", "No items are available. Please add first item.");

            if (messageForm != null)
            {
                Connection.Close();
                messageForm.ShowDialog(this);
            }
        }

        private new void MouseWheel(object sender, MouseEventArgs e)
        {
            Main.ScrollUpDown(SalesTable, e);
        }
    }
}
