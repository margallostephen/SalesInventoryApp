using MySqlConnector;

namespace SalesInventoryApp
{
    public partial class User : Form
    {
        public MySqlConnection Connection { get; set; }
        public string selectedRowUsername;
        public string selectedRowPassword;

        public User()
        {
            InitializeComponent();
            this.UserTable.MouseWheel += new MouseEventHandler(MouseWheel);
        }

        public void LoadTableRecord()
        {
            UserTable.Rows.Clear();
            Connection.Open();

            using (MySqlCommand command = new("SELECT * FROM users ORDER BY username ASC", Connection))
            {
                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        UserTable.BringToFront();
                        ActionLabel.BringToFront();
                        while (dataReader.Read())
                            UserTable.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString());
                    }
                    else
                        NoUserLabel.BringToFront();
                }
            }
 
            Connection.Close();
            UserTable.ClearSelection();
        }

        private void User_Load(object sender, EventArgs e)
        {
            LoadTableRecord();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            UserPrompt userPrompt = new("Add", this) { Connection = Connection };
            userPrompt.ShowDialog(this);
            LoadTableRecord();
        }

        private void UserTable_SelectionChanged(object sender, EventArgs e)
        {
            if (UserTable.Rows.Count > 0)
            {
                int index = UserTable.CurrentRow.Index;
                selectedRowUsername = UserTable[0, index].Value.ToString();
                selectedRowPassword = UserTable[1, index].Value.ToString();
            }
        }

        private void UserTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = UserTable.Columns[e.ColumnIndex].Name;

            if (columnName == "ColumnEdit" || columnName == "ColumnDelete")
            {
                UserTable.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
                UserTable.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.White;

                UserPrompt userPrompt;

                if (columnName == "ColumnEdit")
                {
                    userPrompt = new("Edit", this) { Connection = Connection };
                    userPrompt.Username.Text = selectedRowUsername;
                }
                else
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
            else if (e.Delta < 0 && UserTable.FirstDisplayedScrollingRowIndex < UserTable.RowCount)
                UserTable.FirstDisplayedScrollingRowIndex++;
        }
    }
}
