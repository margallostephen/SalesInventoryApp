

using MySqlConnector;
using System.Data;

namespace SalesInventoryApp
{
    public partial class CategoryPrompt : Form
    {
        public MySqlConnection Connection { get; set; }
        private readonly Category categoryForm = null;

        public CategoryPrompt(string operation, Category CategoryForm)
        {
            InitializeComponent();
            categoryForm = CategoryForm;

            if (operation != "Delete")
            {
                if (operation == "Edit")
                {
                    HeaderText.Text = "Edit Category";
                    BtnOne.Text = "Save";
                }
            }
            else
            {
                HeaderText.Text = "Delete Category";
                MessageText.Text += categoryForm.selectedRowCategory + "?";
                MessagePanel.BringToFront();
                BtnOne.Text = "Yes";
                BtnTwo.Text = "No";
            }
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            string categoryName = "", 
                   info = "Invalid", 
                   message = "";

            Boolean alreadyExist = false, 
                    closePrompt = false;

            Connection.Open();

            using (MySqlCommand getAllCategories = new("SELECT * FROM item_category", Connection))
            {
                using (MySqlDataReader dataReader = getAllCategories.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        if (dataReader[1].ToString() == Category.Text)
                        {
                            categoryName = dataReader[1].ToString();

                            if (BtnOne.Text != "Yes")
                                alreadyExist = true;

                            break;
                        }
                    }
                }
            }

            using (MySqlCommand command = Connection.CreateCommand())
            {
                if (BtnOne.Text != "Yes")
                {
                    if (!string.IsNullOrWhiteSpace(Category.Text))
                    {
                        if (alreadyExist)
                            message = "Category already exist.";
                        else
                        {
                            if (BtnOne.Text == "Add")
                            {
                                command.CommandText = "INSERT INTO item_category(name) VALUES(?)";
                                command.Parameters.Add("name", (DbType)SqlDbType.VarChar).Value = Category.Text.Trim();
                                message = "New category added successfully.";
                            }
                            else
                            {
                                command.CommandText = "UPDATE item_category SET name = ? WHERE id = ?";
                                command.Parameters.Add("name", (DbType)SqlDbType.VarChar).Value = Category.Text.Trim();
                                command.Parameters.Add("id", (DbType)SqlDbType.Int).Value = categoryForm.selectedRowId;
                                message = "Category updated successfully.";
                            }

                            info = "Success";
                            closePrompt = true;
                        }
                    }
                    else
                    {
                        info = "Warning";
                        message = "Please fill out the required fields.";
                    }
                }
                else
                {
                    command.CommandText = "DELETE FROM item_category WHERE id = ?";
                    command.Parameters.Add("id", (DbType)SqlDbType.VarChar).Value = categoryForm.selectedRowId;
                    message = "Category " + categoryName + " deleted successfully.";
                    info = "Success";
                    closePrompt = true;
                }

                if (command.CommandText != "")
                    command.ExecuteNonQuery();
            }

            Dashboard.ShowMessage(this, categoryForm, info, message, closePrompt);
            Connection.Close();
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
