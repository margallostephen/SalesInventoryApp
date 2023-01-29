using MySqlConnector;
using System.Data;

namespace SalesInventoryApp
{
    public partial class SellItem : Form
    {
        public MySqlConnection connection { get; set; }
        Sales salesForm;
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
            connection.Open();

            using (MySqlCommand command = new(
                "SELECT items.image, items.id " +
                "FROM inventory_stocks " +
                "INNER JOIN items ON inventory_stocks.item_id = items.id " +
                "WHERE quantity > 0 ORDER BY item_id ASC", connection))
            {
                using MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    pic = new();
                    pic.Width = 100;
                    pic.Height = 95;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Image = Main.ByteToImage((byte[])dataReader[0]);
                    id = new();
                    id.Text = dataReader[1].ToString();
                    id.Hide();
                    pic.Controls.Add(id);
                    pic.Click += SelectItem;
                    ItemSelectionPanel.Controls.Add(pic);
                }
            }

            connection.Close();

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

            connection.Open();

            using (MySqlCommand command = new(
                "SELECT items.name, items.price, item_category.name, inventory_stocks.quantity FROM items " +
                "LEFT JOIN item_category ON items.category_id = item_category.id " +
                "LEFT JOIN inventory_stocks ON items.id = inventory_stocks.item_id WHERE items.id = ?", connection))
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

            connection.Close();
            Quantity.Text = "0";
            TotalAmount.Text = "0.00";
        }

        private void AddQuantityBtn_Click(object sender, EventArgs e)
        {
            if (ItemName.Text != "")
            {
                quantityToSell = Convert.ToInt32(Quantity.Text);

                if (remainingQuantity != 0)
                {
                    quantityToSell++;
                    remainingQuantity--;
                    Quantity.Text = quantityToSell.ToString();
                    RemainingQuantity.Text = remainingQuantity.ToString();
                    TotalAmount.Text = ComputePrice();
                }
            }
        }

        private void MinusQuantityBtn_Click(object sender, EventArgs e)
        {
            if (quantityToSell != 0)
            {
                quantityToSell--;
                remainingQuantity++;
                Quantity.Text = quantityToSell.ToString();
                RemainingQuantity.Text = remainingQuantity.ToString();
                TotalAmount.Text = ComputePrice();
            }
        }

        private string ComputePrice()
        {
            return (Convert.ToDecimal(quantityToSell) * Convert.ToDecimal(Price.Text)).ToString();
        }

        private void SellBtn_Click(object sender, EventArgs e)
        {
            string info, message;

            if (TotalAmount.Text != "0.00")
            {
                connection.Open();

                using (MySqlCommand command = new("UPDATE inventory_stocks SET quantity = ? WHERE item_id = ?", connection))
                {
                    command.Parameters.Add("quantity", (DbType)SqlDbType.Int).Value = remainingQuantity;
                    command.Parameters.Add("itemId", (DbType)SqlDbType.Int).Value = itemId;
                    command.Prepare();
                    command.ExecuteNonQuery();

                    command.CommandText = "INSERT INTO sales(date, time, item_name, quantity, total_amount) VALUES(?, ?, ?, ?, ?)";
                    command.Parameters.Clear();
                    command.Parameters.Add("date", (DbType)SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();
                    command.Parameters.Add("time", (DbType)SqlDbType.VarChar).Value = DateTime.Now.ToShortTimeString();
                    command.Parameters.Add("itemName", (DbType)SqlDbType.Int).Value = ItemName.Text;
                    command.Parameters.Add("quantity", (DbType)SqlDbType.Int).Value = quantityToSell;
                    command.Parameters.Add("totalAmount", (DbType)SqlDbType.Decimal).Value = Convert.ToDecimal(TotalAmount.Text);
                    command.Prepare();
                    command.ExecuteNonQuery();
                }

                connection.Close();
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
