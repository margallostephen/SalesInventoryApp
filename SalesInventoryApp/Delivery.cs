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
            Dashboard.LoadTableRecord(DeliveryTable, null, NoLabel, connection);
        }

        private void ReplenishItemBtn_Click(object sender, EventArgs e)
        {

        }

        private new void MouseWheel(object sender, MouseEventArgs e)
        {
            Dashboard.ScrollUpDown(DeliveryTable, e);
        }
    }
}
