using MySqlConnector;

namespace SalesInventoryApp
{
    public partial class Inventory : Form
    {
        public MySqlConnection Connection { get; set; }

        public Inventory()
        {
            InitializeComponent();
            InventoryTable.MouseWheel += new MouseEventHandler(MouseWheel);
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            Main.LoadTableRecord(InventoryTable, null, NoLabel, Connection);
        }

        private new void MouseWheel(object sender, MouseEventArgs e)
        {
            Main.ScrollUpDown(InventoryTable, e);
        }
    }
}
