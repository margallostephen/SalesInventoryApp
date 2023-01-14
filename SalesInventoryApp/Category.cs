using MySqlConnector;

namespace SalesInventoryApp
{
    public partial class Category : Form
    {
        public MySqlConnection connection { get; set; }
        public int selectedRowId;
        public string selectedRowCategory;

        public Category()
        {
            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            CategoryTable.MouseWheel += new MouseEventHandler(MouseWheel);
        }

        public void LoadTableRecord()
        {
            CategoryTable.Rows.Clear();

            connection.Open();

            using (MySqlCommand command = new("SELECT * FROM item_category ORDER BY id ASC", connection))
            {
                using MySqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    CategoryTable.BringToFront();
                    ActionLabel.BringToFront();
                    while (dataReader.Read())
                        CategoryTable.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString());
                }
                else
                    NoLabel.BringToFront();
            }

            connection.Close();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            LoadTableRecord();
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            CategoryPrompt categoryPrompt = new("Add", this) { connection = connection };
            DialogResult result = categoryPrompt.ShowDialog(this);
            DisposePrompt(result, categoryPrompt);
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
                    categoryPrompt = new("Edit", this) { connection = connection };
                    categoryPrompt.Category.Text = selectedRowCategory;
                }
                else
                    categoryPrompt = new("Delete", this) { connection = connection };

                DialogResult result = categoryPrompt.ShowDialog(this);
                DisposePrompt(result, categoryPrompt);

                if (CategoryTable.CurrentRow != null)
                {
                    CategoryTable.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 230, 255);
                    CategoryTable.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
        }

        private void DisposePrompt(DialogResult result, CategoryPrompt categoryPrompt)
        {
            if (result == DialogResult.OK)
                LoadTableRecord();

            if (result == DialogResult.OK || result == DialogResult.Cancel)
                categoryPrompt.Dispose();
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
            else if (e.Delta < 0 && CategoryTable.FirstDisplayedScrollingRowIndex < CategoryTable.RowCount - 1)
                CategoryTable.FirstDisplayedScrollingRowIndex++;
        }
    }
}
