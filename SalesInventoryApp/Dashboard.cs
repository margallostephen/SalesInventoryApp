using MySqlConnector;

namespace SalesInventoryApp
{
    public partial class Dashboard : Form
    {
        public MySqlConnection connection { get; set; }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            TotalRevenue.Text = GetData("SUM(total_amount)", "sales") != "" ? GetData("SUM(total_amount)", "sales") : "0";
            ItemsCount.Text = GetData("COUNT(*)", "items");
            CategoriesCount.Text = GetData("COUNT(*)", "item_category");
            UsersCount.Text = GetData("COUNT(*)", "users");
        }

        private string GetData(string operation, string tableName)
        {
            connection.Open();
            using MySqlCommand command = new("SELECT " + operation + " FROM " + tableName, connection);
            command.Prepare();
            string data = command.ExecuteScalar().ToString();
            connection.Close();
            return data;
        }
    }
}
