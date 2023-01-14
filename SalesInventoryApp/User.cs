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
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            UserTable.MouseWheel += new MouseEventHandler(MouseWheel);
        }

        public void LoadTableRecord()
        {
            UserTable.Rows.Clear();
            connection.Open();

            using (MySqlCommand command = new("SELECT * FROM users ORDER BY username ASC", connection))
            {
                using MySqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    UserTable.BringToFront();
                    ActionLabel.BringToFront();
                    while (dataReader.Read())
                        UserTable.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString());
                }
                else
                    NoLabel.BringToFront();
            }
 
            connection.Close();
        }

        private void User_Load(object sender, EventArgs e)
        {
            LoadTableRecord();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            UserPrompt userPrompt = new("Add", this) { connection = connection };
            DialogResult result = userPrompt.ShowDialog(this);
            DisposePrompt(result, userPrompt);
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
                    userPrompt = new("Edit", this) { connection = connection };
                    userPrompt.Username.Text = selectedRowUsername;
                }
                else
                    userPrompt = new("Delete", this) { connection = connection };

                DialogResult result = userPrompt.ShowDialog(this);
                DisposePrompt(result, userPrompt);

                if (UserTable.CurrentRow != null)
                {
                    UserTable.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 230, 255);
                    UserTable.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
        }

        private void DisposePrompt(DialogResult result, UserPrompt userPrompt)
        {
            if (result == DialogResult.OK)
                LoadTableRecord();

            if (result == DialogResult.OK || result == DialogResult.Cancel)
                userPrompt.Dispose();
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
