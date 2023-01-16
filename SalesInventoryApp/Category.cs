using MySqlConnector;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
            CategoryTable.MouseWheel += new MouseEventHandler(MouseWheel);
            Dashboard.ReduceFlicker(this);
        }

        private void Category_Load(object sender, EventArgs e)
        {
            Dashboard.LoadTableRecord(CategoryTable, ActionLabel, NoLabel, connection);
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            CategoryPrompt categoryPrompt = new("Add", this) { connection = connection };
            DialogResult result = categoryPrompt.ShowDialog(this);
            Dashboard.DisposePrompt(result, categoryPrompt, CategoryTable, ActionLabel, NoLabel, connection);
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
                Dashboard.SelectedRowChangeColor(CategoryTable, true);

                CategoryPrompt categoryPrompt;

                if (columnName == "ColumnEdit")
                {
                    categoryPrompt = new("Edit", this) { connection = connection };
                    categoryPrompt.Category.Text = selectedRowCategory;
                }
                else
                {
                    connection.Open();
                    using MySqlCommand command = new("SELECT * FROM items WHERE category_id = ?", connection);
                    command.Parameters.Add("id", (DbType)SqlDbType.Int).Value = selectedRowId;
                    command.Prepare();
                    using MySqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        connection.Close();
                        categoryPrompt = null;
                        Message messageform = new("Error", "This category cannot be deleted because there are items in it.");
                        messageform.ShowDialog(this);
                    }
                    else
                    {
                        connection.Close();
                        categoryPrompt = new("Delete", this) { connection = connection };
                    }
                }
                
                if (categoryPrompt != null)
                {
                    DialogResult result = categoryPrompt.ShowDialog(this);
                    Dashboard.DisposePrompt(result, categoryPrompt, CategoryTable, ActionLabel, NoLabel, connection);
                }

                Dashboard.SelectedRowChangeColor(CategoryTable, false);
            }
        }

        private void CategoryTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            Dashboard.ChangeCursor(CategoryTable, e);
        }

        private new void MouseWheel(object sender, MouseEventArgs e)
        {
            Dashboard.ScrollUpDown(CategoryTable, e);
        }
    }
}
