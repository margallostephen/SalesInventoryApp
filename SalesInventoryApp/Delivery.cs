using MySqlConnector;

namespace SalesInventoryApp
{
    public partial class Delivery : Form
    {
        public MySqlConnection connection { get; set; }

        public Delivery()
        {
            InitializeComponent();
            DeliveryTable.MouseWheel += new MouseEventHandler(MouseWheel);
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            Main.LoadTableRecord(DeliveryTable, null, NoLabel, connection);
        }

        private void ReplenishItemBtn_Click(object sender, EventArgs e)
        {
            Main.MinimizedSideBar();
            connection.Open();
            using MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM inventory_stocks";
            command.Prepare();
            using MySqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                connection.Close();
                ReplenishItem replenishPrompt = new(this) { connection = connection };
                DialogResult result = replenishPrompt.ShowDialog();
                Main.DisposePrompt(result, replenishPrompt, DeliveryTable, null, NoLabel, connection);
            }
            else
            {
                connection.Close();
                Message messageForm = new("Warning", "No items are available. Please add first item.");
                messageForm.ShowDialog(this);
            }
        }

        private new void MouseWheel(object sender, MouseEventArgs e)
        {
            Main.ScrollUpDown(DeliveryTable, e);
        }
    }
}
