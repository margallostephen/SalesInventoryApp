using MySqlConnector;

namespace SalesInventoryApp
{
    public partial class User : Form
    {
        public MySqlConnection Connection { get; set; }
        public string selectedRowUsername;

        public User()
        {
            InitializeComponent();
            this.UserTable.MouseWheel += new MouseEventHandler(MouseWheel);
        }

        public void LoadTableRecord()
        {
            UserTable.Rows.Clear();

            Connection.Open();
            using MySqlCommand command = new("SELECT * FROM users ORDER BY username ASC", Connection);
            using MySqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
                UserTable.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString());

            Connection.Close();
            UserTable.ClearSelection();
        }

        private void User_Load(object sender, EventArgs e)
        {
            LoadTableRecord();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            UserTable.ClearSelection();
            UserPrompt addUserForm = new("Add", this) { Connection = Connection };
            addUserForm.ShowDialog(this);
            LoadTableRecord();
        }

        private void UserTable_SelectionChanged(object sender, EventArgs e)
        {
            if (UserTable.Rows.Count > 0)
            {
                int index = UserTable.CurrentRow.Index;
                selectedRowUsername = UserTable[0, index].Value.ToString();
            }
        }

        private void UserTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = UserTable.Columns[e.ColumnIndex].Name;

            if (columnName == "ColumnEdit" || columnName == "ColumnDelete")
            {
                UserPrompt userPrompt= null;

                if (columnName == "ColumnEdit")
                {
                    userPrompt = new("Edit", this) { Connection = Connection };
                    userPrompt.Username.Text = selectedRowUsername;
                }
                else if (columnName == "ColumnDelete")
                    userPrompt = new("Delete", this) { Connection = Connection };

                userPrompt.ShowDialog(this);
                LoadTableRecord();
            }
        }

        private void UserTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = UserTable.Columns[e.ColumnIndex].Name;

            if (columnName != "ColumnEdit" && columnName != "ColumnDelete")
                UserTable.Cursor = Cursors.Default;
            else
                UserTable.Cursor = Cursors.Hand;
        }

        private new void MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && UserTable.FirstDisplayedScrollingRowIndex > 0)
                UserTable.FirstDisplayedScrollingRowIndex--;
            else if (e.Delta < 0 && UserTable.FirstDisplayedScrollingRowIndex < UserTable.RowCount - 1)
                UserTable.FirstDisplayedScrollingRowIndex++;
        }
    }
}
