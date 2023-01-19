using MySqlConnector;
using System.Data;

namespace SalesInventoryApp
{
    public partial class CategoryPrompt : Form
    {
        public MySqlConnection connection { get; set; }
        private readonly Category categoryForm;

        public CategoryPrompt(string operation, Category categoryForm)
        {
            InitializeComponent();
            this.categoryForm = categoryForm;

            if (operation != "Delete")
            {
                if (operation == "Edit")
                {
                    Text = HeaderText.Text = "Edit Category";
                    BtnOne.Text = "Save";
                }

                MessagePanel.Visible = false;
            }
            else
            {
                Text = HeaderText.Text = "Delete Category";
                MessageText.Text += this.categoryForm.selectedRowCategory + "?";
                MessagePanel.BringToFront();
                BtnOne.Text = "Yes";
                BtnTwo.Text = "No";
            }
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            string categoryName = Category.Text.Trim(),
                   info = "Invalid",
                   message = "";

            bool alreadyExist = false,
                 categoryNull = string.IsNullOrWhiteSpace(categoryName);

            DialogResult = DialogResult.None;

            connection.Open();

            using (MySqlCommand command = connection.CreateCommand())
            {
                if (BtnOne.Text != "Yes")
                {
                    if (!categoryNull)
                    {
                        using (MySqlCommand getAllCategories = new("SELECT * FROM item_category", connection))
                        {
                            using MySqlDataReader dataReader = getAllCategories.ExecuteReader();

                            while (dataReader.Read())
                            {
                                if (dataReader[1].ToString() == categoryName)
                                {
                                    alreadyExist = true;
                                    break;
                                }
                            }
                        }

                        if (alreadyExist && BtnOne.Text == "Add" || alreadyExist && categoryName != categoryForm.selectedRowCategory)
                            message = "Category " + categoryName + " already exist.";
                        else
                        {
                            if (BtnOne.Text == "Add")
                            {
                                command.CommandText = "INSERT INTO item_category(name) VALUES(?)";
                                message = "New category added successfully.";
                            }
                            else
                            {
                                command.CommandText = "UPDATE item_category SET name = ? WHERE id = ?";
                                message = "Category " + categoryForm.selectedRowCategory + " updated successfully.";
                            }

                            command.Parameters.Add("name", (DbType)SqlDbType.VarChar).Value = categoryName;

                            if (BtnOne.Text == "Save")
                                command.Parameters.Add("id", (DbType)SqlDbType.Int).Value = categoryForm.selectedRowId;

                            info = "Success";
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        info = "Warning";
                        message = "Please input a category name.";
                    }
                }
                else
                {
                    command.CommandText = "DELETE FROM item_category WHERE id = ?";
                    command.Parameters.Add("id", (DbType)SqlDbType.Int).Value = categoryForm.selectedRowId;
                    message = "Category " + categoryName + " deleted successfully.";
                    info = "Success";
                    DialogResult = DialogResult.OK;
                }

                if (command.CommandText != "")
                {
                    command.Prepare();
                    command.ExecuteNonQuery();
                }
            }

            connection.Close();
            Dashboard.ShowMessage(this, categoryForm, info, message, DialogResult);
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
