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
            string query = "SELECT " + operation + " FROM " + tableName;

            if (tableName == "sales")
                query += " WHERE date = \"" + DateTime.Now.ToShortDateString() + "\"";

            using MySqlCommand command = new(query, connection);
            command.Prepare();
            string data = command.ExecuteScalar().ToString();
            connection.Close();
            return data;
        }
    }
}
