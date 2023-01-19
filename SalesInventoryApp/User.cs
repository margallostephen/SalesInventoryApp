using MySqlConnector;

namespace SalesInventoryApp
{
    public partial class User : Form
    {
        public MySqlConnection connection { get; set; }
        public string selectedRowUsername, selectedRowPassword;

        public User()
        {
            InitializeComponent();
            UserTable.MouseWheel += new MouseEventHandler(MouseWheel);
        }

        private void User_Load(object sender, EventArgs e)
        {
            Dashboard.LoadTableRecord(UserTable, ActionLabel, NoLabel, connection);
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            UserPrompt userPrompt = new("Add", this) { connection = connection };
            DialogResult result = userPrompt.ShowDialog(this);
            Dashboard.DisposePrompt(result, userPrompt, UserTable, ActionLabel, NoLabel, connection);
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
                Dashboard.SelectedRowChangeColor(UserTable, true);
                UserPrompt userPrompt;

                if (columnName == "ColumnEdit")
                {
                    userPrompt = new("Edit", this) { connection = connection };
                    userPrompt.Username.Text = selectedRowUsername;
                }
                else
                    userPrompt = new("Delete", this) { connection = connection };

                DialogResult result = userPrompt.ShowDialog(this);
                Dashboard.DisposePrompt(result, userPrompt, UserTable, ActionLabel, NoLabel, connection);
                Dashboard.SelectedRowChangeColor(UserTable, false);
            }
        }

        private void UserTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            Dashboard.ChangeCursor(UserTable, e);
        }

        private new void MouseWheel(object sender, MouseEventArgs e)
        {
            Dashboard.ScrollUpDown(UserTable, e);
        }
    }
}
