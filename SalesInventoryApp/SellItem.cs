using MySqlConnector;
using System.Data;

namespace SalesInventoryApp
{
    public partial class SellItem : Form
    {
        public MySqlConnection Connection { get; set; }
        readonly Sales salesForm;
        PictureBox pic;
        Label id;
        int itemId, remainingQuantity, quantityToSell;

        public SellItem(Sales SalesForm)
        {
            InitializeComponent();
            salesForm = SalesForm;
        }

        private void SellItem_Load(object sender, EventArgs e)
        {
            Connection.Open();

            using (MySqlCommand command = new(
                "SELECT items.image, items.id " +
                "FROM inventory_stocks " +
                "INNER JOIN items ON inventory_stocks.item_id = items.id " +
                "WHERE quantity > 0 ORDER BY item_id ASC", Connection))
            {
                using MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    pic = new()
                    {
                        Width = 100,
                        Height = 95,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Image = Main.ByteToImage((byte[])dataReader[0])
                    };
                    id = new()
                    {
                        Text = dataReader[1].ToString()
                    };
                    id.Hide();
                    pic.Controls.Add(id);
                    pic.Click += SelectItem;
                    ItemSelectionPanel.Controls.Add(pic);
                }
            }

            Connection.Close();

            if (ItemSelectionPanel.Controls.OfType<PictureBox>().Count() > 5)
            {
                ItemSelectionPanel.Height = 118;
                Height = 452;
                ItemPreviewPanel.Location = new Point(12, 194);
            }
        }

        private void SelectItem(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            itemId = Convert.ToInt32(picBox.Controls[0].Text);

            Connection.Open();

            using (MySqlCommand command = new(
                "SELECT items.name, items.price, item_category.name, inventory_stocks.quantity FROM items " +
                "LEFT JOIN item_category ON items.category_id = item_category.id " +
                "LEFT JOIN inventory_stocks ON items.id = inventory_stocks.item_id WHERE items.id = ?", Connection))
            {
                command.Parameters.Add("itemId", (DbType)SqlDbType.Int).Value = itemId;
                command.Prepare();

                using MySqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();

                ItemImage.Image = picBox.Image;
                ItemName.Text = dataReader[0].ToString();
                Price.Text = dataReader[1].ToString();
                Category.Text = dataReader[2].ToString();
                remainingQuantity = (int)dataReader[3];
                RemainingQuantity.Text = remainingQuantity.ToString();
            }

            Connection.Close();
            Quantity.Text = "0";
            TotalAmount.Text = "0.00";
        }

        private void ChangeQuantity(string operation)
        {
            if (operation == "Add")
            {
                quantityToSell++;
                remainingQuantity--;
            }
            else
            {
                quantityToSell++;
                remainingQuantity--;
            }
            
            Quantity.Text = quantityToSell.ToString();
            RemainingQuantity.Text = remainingQuantity.ToString();
            TotalAmount.Text = (Convert.ToDecimal(quantityToSell) * Convert.ToDecimal(Price.Text)).ToString();
        }

        private void AddQuantityBtn_Click(object sender, EventArgs e)
        {
            if (ItemName.Text != "")
            {
                quantityToSell = Convert.ToInt32(Quantity.Text);

                if (remainingQuantity != 0)
                    ChangeQuantity("Add");
            }
        }

        private void MinusQuantityBtn_Click(object sender, EventArgs e)
        {
            if (quantityToSell != 0)
                ChangeQuantity("Minus");
        }

        private void SellBtn_Click(object sender, EventArgs e)
        {
            string info, message;

            if (TotalAmount.Text != "0.00")
            {
                Connection.Open();

                using (MySqlCommand command = new("UPDATE inventory_stocks SET quantity = ? WHERE item_id = ?", Connection))
                {
                    command.Parameters.Add("quantity", (DbType)SqlDbType.Int).Value = remainingQuantity;
                    command.Parameters.Add("itemId", (DbType)SqlDbType.Int).Value = itemId;
                    command.Prepare();
                    command.ExecuteNonQuery();

                    command.CommandText = "INSERT INTO sales(date, time, item_name, quantity, total_amount) VALUES(?, ?, ?, ?, ?)";
                    command.Parameters.Clear();
                    command.Parameters.Add("date", (DbType)SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();
                    command.Parameters.Add("time", (DbType)SqlDbType.VarChar).Value = DateTime.Now.ToShortTimeString();
                    command.Parameters.Add("itemName", (DbType)SqlDbType.VarChar).Value = ItemName.Text;
                    command.Parameters.Add("quantity", (DbType)SqlDbType.Int).Value = quantityToSell;
                    command.Parameters.Add("totalAmount", (DbType)SqlDbType.Decimal).Value = Convert.ToDecimal(TotalAmount.Text);
                    command.Prepare();
                    command.ExecuteNonQuery();
                }

                Connection.Close();
                DialogResult = DialogResult.OK;
                info = "Success";
                message = "Successfully sell an item.";
            }
            else if (ItemName.Text == "")
            {
                DialogResult = DialogResult.None;
                info = "Error";
                message = "Please select an item.";
            }
            else
            {
                DialogResult = DialogResult.None;
                info = "Error";
                message = "Please choose a quantity.";
            }

            Main.ShowMessage(this, salesForm, info, message, DialogResult);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
