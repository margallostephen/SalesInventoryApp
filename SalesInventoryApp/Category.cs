using MySqlConnector;
using System.Data;

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
            CategoryTable.MouseWheel += new MouseEventHandler(MouseWheel);
        }

        private void Category_Load(object sender, EventArgs e)
        {
            Main.LoadTableRecord(CategoryTable, ActionLabel, NoLabel, Connection);
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            Main.MinimizedSideBar();
            CategoryPrompt categoryPrompt = new("Add", this) { Connection = Connection };
            DialogResult result = categoryPrompt.ShowDialog(this);
            Main.DisposePrompt(result, categoryPrompt, CategoryTable, ActionLabel, NoLabel, Connection);
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
                Main.MinimizedSideBar();
                Main.SelectedRowChangeColor(CategoryTable, true);
                CategoryPrompt categoryPrompt;

                if (columnName == "ColumnEdit")
                {
                    categoryPrompt = new("Edit", this) { Connection = Connection };
                    categoryPrompt.Category.Text = selectedRowCategory;
                }
                else
                {
                    Connection.Open();
                    using MySqlCommand command = new("SELECT * FROM items WHERE category_id = ?", Connection);
                    command.Parameters.Add("id", (DbType)SqlDbType.Int).Value = selectedRowId;
                    command.Prepare();
                    using MySqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        Connection.Close();
                        categoryPrompt = null;
                        Message messageForm = new("Error", "This category cannot be deleted because there are items in it.");
                        messageForm.ShowDialog(this);
                    }
                    else
                    {
                        Connection.Close();
                        categoryPrompt = new("Delete", this) { Connection = Connection };
                    }
                }

                if (categoryPrompt != null)
                {
                    DialogResult result = categoryPrompt.ShowDialog(this);
                    Main.DisposePrompt(result, categoryPrompt, CategoryTable, ActionLabel, NoLabel, Connection);
                }

                Main.SelectedRowChangeColor(CategoryTable, false);
            }
        }

        private void CategoryTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            Main.ChangeCursor(CategoryTable, e);
        }

        private new void MouseWheel(object sender, MouseEventArgs e)
        {
            Main.ScrollUpDown(CategoryTable, e);
        }
    }
}
