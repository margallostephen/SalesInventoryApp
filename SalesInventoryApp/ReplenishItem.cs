using MySqlConnector;
using System.Data;

namespace SalesInventoryApp
{
    public partial class ReplenishItem : Form
    {
        public MySqlConnection connection { get; set; }
        Delivery deliveryForm;
        PictureBox pic;
        Label id;
        string supplierName;
        int itemId, remainingQuantity, quantityToAdd;

        public ReplenishItem(Delivery DeliveryForm)
        {
            InitializeComponent();
            deliveryForm = DeliveryForm;
        }

        private void ReplenishItem_Load(object sender, EventArgs e)
        {
            connection.Open();

            using (MySqlCommand command = new(
                "SELECT items.image, items.id " +
                "FROM inventory_stocks " +
                "INNER JOIN items ON inventory_stocks.item_id = items.id " +
                "ORDER BY item_id ASC", connection))
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
                Height = 400;
                ItemPreviewPanel.Location = new Point(12, 197);
            }
        }

        private void SelectItem(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            itemId = Convert.ToInt32(picBox.Controls[0].Text);

            connection.Open();

            using (MySqlCommand command = new(
                "SELECT items.name, inventory_stocks.quantity, items.supplier_name FROM items " +
                "LEFT JOIN inventory_stocks ON items.id = inventory_stocks.item_id WHERE items.id = ?", connection))
            {
                command.Parameters.Add("itemId", (DbType)SqlDbType.Int).Value = itemId;
                command.Prepare();

                using MySqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();

                ItemImage.Image = picBox.Image;
                ItemName.Text = dataReader[0].ToString();
                remainingQuantity = (int)dataReader[1];
                RemainingQuantity.Text = remainingQuantity.ToString();
                supplierName = dataReader[2].ToString();
            }

            connection.Close();
            AddQuantity.Text = NewQuantity.Text = "0";
        }

        private void AddQuantityBtn_Click(object sender, EventArgs e)
        {
            if (ItemName.Text != "")
            {
                quantityToAdd = Convert.ToInt32(AddQuantity.Text);
                quantityToAdd++;
                AddQuantity.Text = quantityToAdd.ToString();
                NewQuantity.Text = ComputePrice();
            }
        }

        private void MinusQuantityBtn_Click(object sender, EventArgs e)
        {
            if (ItemName.Text != "" && quantityToAdd > 0)
            {
                quantityToAdd--;
                AddQuantity.Text = quantityToAdd.ToString();
                NewQuantity.Text = ComputePrice();
            }
        }

        private string ComputePrice()
        {
            return (remainingQuantity + quantityToAdd).ToString();
        }

        private void ReplenishBtn_Click(object sender, EventArgs e)
        {
            string info, message;

            if (NewQuantity.Text != "0")
            {
                connection.Open();

                using (MySqlCommand command = new("UPDATE inventory_stocks SET quantity = ? WHERE item_id = ?", connection))
                {
                    command.Parameters.Add("quantity", (DbType)SqlDbType.Int).Value = Convert.ToInt32(NewQuantity.Text);
                    command.Parameters.Add("itemId", (DbType)SqlDbType.Int).Value = itemId;
                    command.Prepare();
                    command.ExecuteNonQuery();

                    command.CommandText = "INSERT INTO delivery(date, time, item_id, quantity, supplier_name) VALUES(?, ?, ?, ?, ?)";
                    command.Parameters.Clear();
                    command.Parameters.Add("date", (DbType)SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();
                    command.Parameters.Add("time", (DbType)SqlDbType.VarChar).Value = DateTime.Now.ToShortTimeString();
                    command.Parameters.Add("itemName", (DbType)SqlDbType.Int).Value = ItemName.Text;
                    command.Parameters.Add("quantity", (DbType)SqlDbType.Int).Value = quantityToAdd;
                    command.Parameters.Add("supplierName", (DbType)SqlDbType.VarChar).Value = supplierName;
                    command.Prepare();
                    command.ExecuteNonQuery();
                }

                connection.Close();
                DialogResult = DialogResult.OK;
                info = "Success";
                message = "Successfully replenish an item.";
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

            Main.ShowMessage(this, deliveryForm, info, message, DialogResult);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
