﻿using MySqlConnector;
using System.Data;
using System.Text.RegularExpressions;

namespace SalesInventoryApp
{
    public partial class ItemPrompt : Form
    {
        public MySqlConnection connection { get; set; }
        private readonly Item itemForm;
        private Dictionary<int, string> category = new();
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
                    Price.Width = 217;
                    panel2.Width = 222;
                } 
                else if (operation == "ViewImage")
                {
                    Text = HeaderText.Text = "View Image";
                    Size = new Size(275, 306);
                    InputPanel.Height = 245;
                    ItemImage.Size = new Size(243, 204);
                    BtnOne.Visible = false;
                    BtnTwo.Text = "Close";
                    BtnTwo.Location = new Point(100, 263);
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
                    if (!imageNull && !categoryNull && !itemNull && !priceNull && (quantityNull && BtnOne.Text == "Save" || !quantityNull && BtnOne.Text == "Add"))
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
                                    command.CommandText = "INSERT INTO items(image, name, category_id, price) VALUES(?, ?, ?, ?)";
                                    message = "New item added successfully.";
                                    itemImage = ConvertImageToByte();
                                }
                                else
                                {
                                    command.CommandText = "UPDATE items SET image = ?, name = ?, category_id = ?, price = ? WHERE id = ?";
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

                        if (imageNull && categoryNull && itemNull && priceNull && quantityNull)
                            message = "Please fill all the required fields.";
                        else if (imageNull && categoryNull && itemNull && priceNull)
                            message = "Please select picture and a category, then input the item name and price.";
                        else if (imageNull && categoryNull && itemNull && quantityNull)
                            message = "Please select picture and a category, then input the item name and quantity.";
                        else if (imageNull && categoryNull && priceNull && quantityNull)
                            message = "Please select picture and a category, then input the price and quantity.";
                        else if (imageNull && itemNull && priceNull && quantityNull)
                            message = "Please select a picture, then input the item name, price, and quantity.";
                        else if (categoryNull && itemNull && priceNull && quantityNull)
                            message = "Please select a category, then input the item name, price, and quantity.";
                        else if (imageNull && categoryNull && itemNull)
                            message = "Please select picture and a category, then input the item name.";
                        else if (imageNull && categoryNull && priceNull)
                            message = "Please select picture and a category, then input the price.";
                        else if (imageNull && categoryNull && quantityNull)
                            message = "Please select picture and a category, then input the quantity.";
                        else if (categoryNull && itemNull && priceNull)
                            message = "Please select a category, then input the item name and price.";
                        else if (categoryNull && itemNull && quantityNull)
                            message = "Please select a category, then input the item name and quantity.";
                        else if (itemNull && priceNull && quantityNull)
                            message = "Please input the item name, price, and quantity.";
                        else if (imageNull && categoryNull)
                            message = "Please select picture and a category.";
                        else if (imageNull && itemNull)
                            message = "Please select picture and input the item name.";
                        else if (imageNull && priceNull)
                            message = "Please select picture and input the price.";
                        else if (imageNull && quantityNull)
                            message = "Please select picture and input the quantity.";
                        else if (categoryNull && itemNull)
                            message = "Please select category and input the item name.";
                        else if (categoryNull && priceNull)
                            message = "Please select category and input the price.";
                        else if (categoryNull && quantityNull)
                            message = "Please select category and input the quantity.";
                        else if (itemNull && priceNull)
                            message = "Please input the item name and price.";
                        else if (itemNull && quantityNull)
                            message = "Please input the item name and quantity.";
                        else if (priceNull && quantityNull)
                            message = "Please input the price and quantity.";
                        else if (imageNull)
                            message = "Please select a picture.";
                        else if (categoryNull)
                            message = "Please select a category.";
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
            Dashboard.ShowMessage(this, itemForm, info, message, DialogResult);
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
                selectPic.Filter = "Image Files(*.jpg; *.jpeg; *.png;) | *.jpg; *.jpeg; *.png;";

                Dashboard dashboard = Dashboard.FindForm("Dashboard") as Dashboard;

                if (selectPic.ShowDialog(dashboard) == DialogResult.OK)
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

        private void BindSource()
        {
            ComboBox.DataSource = new BindingSource(category, null);
            ComboBox.ValueMember = "Key";
            ComboBox.DisplayMember = "Value";
        }

        private string ComboBoxFindValue(int categoryId)
        { 
            foreach (KeyValuePair<int, string> items in category)
                if (items.Key == categoryId)
                    return items.Value;

            return "Not Found";
        }

        private void ItemPrompt_Load(object sender, EventArgs e)
        {
            ComboBox.Items.Clear();
            connection.Open();

            using (MySqlCommand command = new("SELECT id, name FROM item_category ORDER BY id ASC", connection))
            {
                using MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                    category.Add((int)dataReader[0], dataReader[1].ToString());
            }
            
            connection.Close();
            category.Add(-1, "Select a category");
            BindSource();

            if (BtnOne.Text == "Save")
            {
                string value = ComboBoxFindValue(itemForm.selectedRowCategoryId);

                if (value != "Not Found")
                {
                    ComboBox.Text = value;
                    Category.Text = itemForm.selectedRowCategoryId.ToString();
                }
            }
            else
                ComboBox.SelectedIndex = ComboBox.Items.Count - 1;
        }

        private void ComboBox_DropDown(object sender, EventArgs e)
        {
            if (category.ContainsKey(-1))
            {
                ComboBox.SelectedIndex = 0;
                ComboBox.DataSource = null;
                category.Remove(-1);
                BindSource();
            }
        }

        private void ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Category.Text))
            {
                category.Add(-1, "Select a category");
                BindSource();
                ComboBox.SelectedIndex = ComboBox.Items.Count - 1;
            }
        }

        private void ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Category.Text = ((KeyValuePair<int, string>)ComboBox.SelectedItem).Key.ToString();
        }
    }
}