using MySqlConnector;
using System.Data;
using System.Text.RegularExpressions;

namespace SalesInventoryApp
{
    public partial class ItemPrompt : Form
    {
        public MySqlConnection connection { get; set; }
        private readonly Item itemForm;
        private Dictionary<int, string> category = new();
        private Dictionary<int, string> supplier = new();
        private Boolean imageChange = false;

        public ItemPrompt(string operation, Item itemForm)
        {
            InitializeComponent();
            this.itemForm = itemForm;

            if (operation != "Delete")
            {
                if (operation == "Edit")
                {
                    Text = HeaderText.Text = "Edit Item";
                    BtnOne.Text = "Save";
                    Quantity.Visible = false;
                    panel3.Visible = false;
                    Price.Width = 215;
                    Price.Location = new Point(125, 115);
                    panel2.Width = 220;
                    panel2.Location = new Point(123, 139);
                }
                else if (operation == "ViewImage")
                {
                    Text = HeaderText.Text = "View Image";
                    Size = new Size(275, 306);
                    InputPanel.Height = 245;
                    ItemImage.Size = new Size(243, 204);
                    BtnOne.Visible = false;
                    BtnTwo.Text = "Close";
                    BtnTwo.Location = new Point(100, 264);
                }

                MessagePanel.Visible = false;
            }
            else
            {
                Size = new Size(375, 145);
                InputPanel.Visible = false;
                Text = HeaderText.Text = "Delete Item";
                MessageText.Text += this.itemForm.selectedRowItem + "?";
                MessagePanel.BringToFront();
                BtnOne.Text = "Yes";
                BtnTwo.Text = "No";
                BtnOne.BringToFront();
                BtnTwo.BringToFront();
            }
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            string itemName = Item.Text.Trim(),
                   price = Price.Text.Trim(),
                   quantity = Quantity.Text.Trim(),
                   info = "Invalid",
                   message = "";

            bool alreadyExist = false,
                 imageNull = ItemImage.Image == null,
                 categoryNull = Category.Text == "",
                 supplierNull = Supplier.Text == "",
                 itemNull = string.IsNullOrWhiteSpace(itemName),
                 priceNull = string.IsNullOrWhiteSpace(price),
                 quantityNull = string.IsNullOrWhiteSpace(quantity),
                 priceValid = Regex.IsMatch(price, "^[0-9.]+$"),
                 quantityValid = Regex.IsMatch(quantity, "^[0-9.]+$");

            DialogResult = DialogResult.None;

            connection.Open();

            using (MySqlCommand command = connection.CreateCommand())
            {
                if (BtnOne.Text != "Yes")
                {
                    if (!imageNull && !categoryNull && !supplierNull && !itemNull && !priceNull &&
                       (quantityNull && BtnOne.Text == "Save" || !quantityNull && BtnOne.Text == "Add"))
                    {
                        using (MySqlCommand getAllItems = new("SELECT * FROM items", connection))
                        {
                            using MySqlDataReader dataReader = getAllItems.ExecuteReader();

                            while (dataReader.Read())
                            {
                                if (dataReader[2].ToString() == itemName)
                                {
                                    alreadyExist = true;
                                    break;
                                }
                            }
                        }

                        if (alreadyExist && BtnOne.Text == "Add" || alreadyExist && itemName != itemForm.selectedRowItem)
                            message = "Item " + itemName + " already exist.";
                        else
                        {
                            if (!priceValid && (!quantityValid && BtnOne.Text == "Add"))
                                message = "Please input a valid price and quantity.";
                            else if (!priceValid)
                                message = "Please input a valid price.";
                            else if (!quantityValid && BtnOne.Text == "Add")
                                message = "Please input a valid quantity.";
                            else
                            {
                                byte[] itemImage;

                                if (BtnOne.Text == "Add")
                                {
                                    command.CommandText = "INSERT INTO items(image, name, category_id, price, supplier_name) VALUES(?, ?, ?, ?, ?)";
                                    message = "New item added successfully.";
                                    itemImage = ConvertImageToByte();
                                }
                                else
                                {
                                    command.CommandText = "UPDATE items SET image = ?, name = ?, category_id = ?, price = ?, supplier_name = ? WHERE id = ?";
                                    message = "Item " + itemForm.selectedRowItem + " updated successfully.";

                                    if (imageChange)
                                        itemImage = ConvertImageToByte();
                                    else
                                        itemImage = itemForm.selectedItemImage;
                                }

                                command.Parameters.Add("image", (DbType)SqlDbType.Binary).Value = itemImage;
                                command.Parameters.Add("itemName", (DbType)SqlDbType.VarChar).Value = itemName;
                                command.Parameters.Add("categoryId", (DbType)SqlDbType.Int).Value = Convert.ToInt32(Category.Text);
                                command.Parameters.Add("price", (DbType)SqlDbType.Decimal).Value = Convert.ToDecimal(price);
                                command.Parameters.Add("supplierName", (DbType)SqlDbType.VarChar).Value = Supplier.Text;

                                if (BtnOne.Text == "Save")
                                    command.Parameters.Add("id", (DbType)SqlDbType.VarChar).Value = itemForm.selectedRowItemId;

                                info = "Success";
                                DialogResult = DialogResult.OK;
                            }
                        }
                    }
                    else
                    {
                        info = "Warning";

                        if (imageNull)
                            message = "Please select a picture.";
                        else if (categoryNull)
                            message = "Please select a category.";
                        else if (supplierNull)
                            message = "Please select a supplier.";
                        else if (itemNull)
                            message = "Please input an item name.";
                        else if (priceNull)
                            message = "Please input a price.";
                        else
                            message = "Please input a quantity.";
                    }
                }
                else
                {
                    command.CommandText = "DELETE FROM items WHERE id = ?";
                    command.Parameters.Add("id", (DbType)SqlDbType.Int).Value = itemForm.selectedRowItemId;
                    message = "Item " + itemName + " deleted successfully.";
                    info = "Success";
                    DialogResult = DialogResult.OK;
                }

                if (command.CommandText != "")
                {
                    command.Prepare();
                    command.ExecuteNonQuery();
                    int itemId = (int)command.LastInsertedId;

                    if (BtnOne.Text == "Add")
                    {
                        command.Parameters.Clear();
                        command.CommandText = "INSERT INTO inventory_stocks(item_id, quantity) VALUES(?, ?)";
                        command.Parameters.Add("itemId", (DbType)SqlDbType.Int).Value = itemId;
                        command.Parameters.Add("quantity", (DbType)SqlDbType.Int).Value = Convert.ToInt32(quantity);
                        command.Prepare();
                        command.ExecuteNonQuery();
                    }
                }
            }

            connection.Close();
            Main.ShowMessage(this, itemForm, info, message, DialogResult);
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ItemImage_Click(object sender, EventArgs e)
        {
            if (HeaderText.Text != "View Image")
            {
                using OpenFileDialog selectPic = new();
                selectPic.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.jfif;) | *.jpg; *.jpeg; *.png; *.jfif;";

                if (selectPic.ShowDialog(itemForm) == DialogResult.OK)
                {
                    ItemImage.Image = new Bitmap(selectPic.FileName);
                    imageChange = true;
                }
            }
        }

        private byte[] ConvertImageToByte()
        {
            using MemoryStream ms = new();
            ItemImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.GetBuffer();
        }

        private void BindSource(ComboBox comboBox, Dictionary<int, string> source)
        {
            comboBox.DataSource = new BindingSource(source, null);
            comboBox.ValueMember = "Key";
            comboBox.DisplayMember = "Value";
        }

        private string ComboBoxFindValue(int id, Dictionary<int, string> keyValuePairs)
        {
            foreach (KeyValuePair<int, string> items in keyValuePairs)
                if (items.Key == id)
                    return items.Value;
            
            return "Not Found";
        }

        private void ItemPrompt_Load(object sender, EventArgs e)
        {
            connection.Open();

            int supplierId = 0;
            bool supplierNotExist = false;

            if (BtnOne.Text == "Save")
            {
                using (MySqlCommand command = new("SELECT id FROM supplier WHERE name = ?", connection))
                {
                    command.Parameters.Add("supplierName", (DbType)SqlDbType.VarChar).Value = itemForm.selectedRowSupplierName;
                    command.Prepare();

                    if (command.ExecuteReader().HasRows)
                    {
                        connection.Close();
                        connection.Open();
                        supplierId = (int)command.ExecuteScalar();
                    } 
                    else
                        supplierNotExist = true;
                }
            }

            connection.Close();

            int[] selectedId = { itemForm.selectedRowCategoryId, supplierId };
            string[] queryTable = { "item_category", "supplier" };
            Dictionary<int, string>[] keyValuePairs = { category, supplier };
            ComboBox[] comboBox = { CategoryComboBox, SupplierComboBox };
            TextBox[] textBox = { Category, Supplier };

            connection.Open();

            for (int i = 0; i < 2; i++)
            {
                using (MySqlCommand command = new("SELECT id, name FROM " + queryTable[i] + " ORDER BY id ASC", connection))
                {
                    using MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                        keyValuePairs[i].Add((int)dataReader[0], dataReader[1].ToString());
                }

                if (BtnOne.Text == "Add" || supplierNotExist)
                    keyValuePairs[i].Add(-1, "Select a " + textBox[i].Name.ToLower());

                if (BtnOne.Text != "Yes" || supplierNotExist)
                    BindSource(comboBox[i], keyValuePairs[i]);

                if (BtnOne.Text == "Save")
                {
                    string value = ComboBoxFindValue(selectedId[i], keyValuePairs[i]);

                    if (value != "Not Found")
                    {
                        comboBox[i].Text = value;

                        if (i == 0)
                            textBox[i].Text = selectedId[i].ToString();
                        else
                            textBox[i].Text = itemForm.selectedRowSupplierName;
                    }
                    else
                        ComboBoxSelectDefaultValue(comboBox[i]);
                }
                else
                    ComboBoxSelectDefaultValue(comboBox[i]);
            }

            connection.Close();
        }

        private void RemoveLabel(ComboBox comboBox, Dictionary<int, string> source)
        {
            if (source.ContainsKey(-1))
            {
                comboBox.SelectedIndex = 0;
                comboBox.DataSource = null;
                source.Remove(-1);
                BindSource(comboBox, source);
            }
        }

        private void AddLabel(TextBox textBox, ComboBox comboBox, Dictionary<int, string> source)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                source.Add(-1, "Select a " + textBox.Name.ToLower());
                BindSource(comboBox, source);
                comboBox.SelectedIndex = comboBox.Items.Count - 1;
            }
        }

        private void ComboBoxSelectDefaultValue(ComboBox comboBox)
        {
            comboBox.SelectedIndex = comboBox.Items.Count - 1;
        }

        private void CategoryComboBox_DropDown(object sender, EventArgs e)
        {
            RemoveLabel(CategoryComboBox, category);
        }

        private void CategoryComboBox_DropDownClosed(object sender, EventArgs e)
        {
            AddLabel(Category, CategoryComboBox, category);
        }

        private void CategoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Category.Text = ((KeyValuePair<int, string>)CategoryComboBox.SelectedItem).Key.ToString();
        }

        private void SupplierComboBox_DropDown(object sender, EventArgs e)
        {
            RemoveLabel(SupplierComboBox, supplier);
        }

        private void SupplierComboBox_DropDownClosed(object sender, EventArgs e)
        {
            AddLabel(Supplier, SupplierComboBox, supplier);
        }

        private void SupplierComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Supplier.Text = ((KeyValuePair<int, string>)SupplierComboBox.SelectedItem).Value;
        }
    }
}
