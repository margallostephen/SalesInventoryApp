using MySqlConnector;

namespace SalesInventoryApp
{
    public partial class Category : Form
    {
        public MySqlConnection Connection { get; set; }
        public int selectedRowId;
        public string selectedRowCategory;

        public Category()
        {
            InitializeComponent();
            this.CategoryTable.MouseWheel += new MouseEventHandler(MouseWheel);
        }

        public void LoadTableRecord()
        {
            CategoryTable.Rows.Clear();
            Connection.Open();

            using (MySqlCommand command = new("SELECT * FROM item_category ORDER BY id ASC", Connection))
            {
                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        CategoryTable.BringToFront();
                        ActionLabel.BringToFront();
                        while (dataReader.Read())
                            CategoryTable.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString());
                    }
                    else
                        NoUserLabel.BringToFront();
                }
            }

            Connection.Close();
            CategoryTable.ClearSelection();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            LoadTableRecord();
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            CategoryPrompt categoryPrompt = new("Add", this) { Connection = Connection };
            categoryPrompt.ShowDialog(this);
            LoadTableRecord();
        }

        private void CategoryTable_SelectionChanged(object sender, EventArgs e)
        {
            if (CategoryTable.Rows.Count > 0)
            {
                int index = CategoryTable.CurrentRow.Index;
                selectedRowId = Convert.ToInt32(CategoryTable[0, index].Value);
                selectedRowCategory = CategoryTable[1, index].Value.ToString();
            }
        }

        private void CategoryTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = CategoryTable.Columns[e.ColumnIndex].Name;

            if (columnName == "ColumnEdit" || columnName == "ColumnDelete")
            {
                CategoryTable.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
                CategoryTable.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.White;

                CategoryPrompt categoryPrompt;

                if (columnName == "ColumnEdit")
                {
                    categoryPrompt = new("Edit", this) { Connection = Connection };
                    categoryPrompt.Category.Text = selectedRowCategory;
                }
                else
                    categoryPrompt = new("Delete", this) { Connection = Connection };

                categoryPrompt.ShowDialog(this);
                LoadTableRecord();
            }
        }

        private void CategoryTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = CategoryTable.Columns[e.ColumnIndex].Name;

            if (columnName != "ColumnEdit" && columnName != "ColumnDelete")
                CategoryTable.Cursor = Cursors.Default;
            else
                CategoryTable.Cursor = Cursors.Hand;
        }

        private new void MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && CategoryTable.FirstDisplayedScrollingRowIndex > 0)
                CategoryTable.FirstDisplayedScrollingRowIndex--;
            else if (e.Delta < 0 && CategoryTable.FirstDisplayedScrollingRowIndex < CategoryTable.RowCount)
                CategoryTable.FirstDisplayedScrollingRowIndex++;
        }
    }
}
