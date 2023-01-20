
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
            connection.Open();
            using MySqlCommand command = new("SELECT SUM(quantity) FROM inventory_stocks", connection);
            command.Prepare();
            decimal quantity = (decimal)command.ExecuteScalar();
            connection.Close();

            SellItem sellPrompt;

            if (quantity < 1)
            {
                sellPrompt = null;
                Message messageform = new("Error", "All items are out of stock.");
                messageform.ShowDialog(this);
            }
            else
                sellPrompt = new(this) { connection = connection };

            if (sellPrompt != null)
            {
                DialogResult result = sellPrompt.ShowDialog(this);
                Dashboard.DisposePrompt(result, sellPrompt, SalesTable, null, NoLabel, connection);
            }
        }

        private new void MouseWheel(object sender, MouseEventArgs e)
        {
            Dashboard.ScrollUpDown(SalesTable, e);
        }
    }
}
