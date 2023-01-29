using MySqlConnector;

namespace SalesInventoryApp
{
    public partial class User : Form
    {
        public MySqlConnection Connection { get; set; }
        public string selectedRowUsername, selectedRowPassword;

        public User()
        {
            InitializeComponent();
            UserTable.MouseWheel += new MouseEventHandler(MouseWheel);
        }

        private void User_Load(object sender, EventArgs e)
        {
            Main.LoadTableRecord(UserTable, ActionLabel, NoLabel, Connection);
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            Main.MinimizedSideBar();
            UserPrompt userPrompt = new("Add", this) { Connection = Connection };
            DialogResult result = userPrompt.ShowDialog(this);
            Main.DisposePrompt(result, userPrompt, UserTable, ActionLabel, NoLabel, Connection);
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
                Main.MinimizedSideBar();
                Main.SelectedRowChangeColor(UserTable, true);
                UserPrompt userPrompt;

                if (columnName == "ColumnEdit")
                {
                    userPrompt = new("Edit", this) { Connection = Connection };
                    userPrompt.Username.Text = selectedRowUsername;
                }
                else
                    userPrompt = new("Delete", this) { Connection = Connection };

                DialogResult result = userPrompt.ShowDialog(this);
                Main.DisposePrompt(result, userPrompt, UserTable, ActionLabel, NoLabel, Connection);
                Main.SelectedRowChangeColor(UserTable, false);
            }
        }

        private void UserTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            Main.ChangeCursor(UserTable, e);
        }

        private new void MouseWheel(object sender, MouseEventArgs e)
        {
            Main.ScrollUpDown(UserTable, e);
        }
    }
}
