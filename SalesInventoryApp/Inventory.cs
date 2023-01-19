using MySqlConnector;

namespace SalesInventoryApp
{
    public partial class Inventory : Form
    {
        public MySqlConnection connection { get; set; }

        public Inventory()
        {
            InitializeComponent();
            InventoryTable.MouseWheel += new MouseEventHandler(MouseWheel);
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            Dashboard.LoadTableRecord(InventoryTable, null, NoLabel, connection);
        }

        private new void MouseWheel(object sender, MouseEventArgs e)
        {
            Dashboard.ScrollUpDown(InventoryTable, e);
        }
    }
}
