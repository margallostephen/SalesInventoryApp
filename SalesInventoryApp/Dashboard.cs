using MySqlConnector;

namespace SalesInventoryApp
{
    public partial class Dashboard : Form
    {
        public Dashboard(string Username)
        {
            InitializeComponent();
        }

        public Form LoginForm { get; set; }
        public MySqlConnection Connection { get; set; }
    }
}
