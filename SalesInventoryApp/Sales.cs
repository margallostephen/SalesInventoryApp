
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

        }

        private new void MouseWheel(object sender, MouseEventArgs e)
        {
            Dashboard.ScrollUpDown(SalesTable, e);
        }
    }
}
