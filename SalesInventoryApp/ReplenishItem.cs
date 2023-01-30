using MySqlConnector;
using System.Data;

namespace SalesInventoryApp
{
    public partial class ReplenishItem : Form
    {
        public MySqlConnection Connection { get; set; }
        readonly Delivery deliveryForm;
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
            Connection.Open();

            using (MySqlCommand command = new(
                "SELECT items.image, items.id " +
                "FROM inventory_stocks " +
                "INNER JOIN items ON inventory_stocks.item_id = items.id " +
                "ORDER BY item_id ASC", Connection))
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
                Height = 400;
                ItemPreviewPanel.Location = new Point(12, 197);
            }
        }

        private void SelectItem(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            itemId = Convert.ToInt32(picBox.Controls[0].Text);

            Connection.Open();

            using (MySqlCommand command = new(
                "SELECT items.name, inventory_stocks.quantity, items.supplier_name FROM items " +
                "LEFT JOIN inventory_stocks ON items.id = inventory_stocks.item_id WHERE items.id = ?", Connection))
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

            Connection.Close();
            AddQuantity.Text = NewQuantity.Text = "0";
        }

        private void ChangeQuantity(string operation)
        {
            if (operation == "Add")
            {
                quantityToAdd = Convert.ToInt32(AddQuantity.Text);
                quantityToAdd++;
            }
            else
                quantityToAdd--;

            AddQuantity.Text = quantityToAdd.ToString();
            NewQuantity.Text = (remainingQuantity + quantityToAdd).ToString();
        }

        private void AddQuantityBtn_Click(object sender, EventArgs e)
        {
            if (ItemName.Text != "")
                ChangeQuantity("Add");
        }

        private void MinusQuantityBtn_Click(object sender, EventArgs e)
        {
            if (ItemName.Text != "" && quantityToAdd > 0)
                ChangeQuantity("Minus");
        }

        private void ReplenishBtn_Click(object sender, EventArgs e)
        {
            string info, message;

            if (NewQuantity.Text != "0")
            {
                Connection.Open();

                using (MySqlCommand command = new("UPDATE inventory_stocks SET quantity = ? WHERE item_id = ?", Connection))
                {
                    command.Parameters.Add("quantity", (DbType)SqlDbType.Int).Value = Convert.ToInt32(NewQuantity.Text);
                    command.Parameters.Add("itemId", (DbType)SqlDbType.Int).Value = itemId;
                    command.Prepare();
                    command.ExecuteNonQuery();

                    command.CommandText = "INSERT INTO delivery(date, time, item_name, quantity, supplier_name) VALUES(?, ?, ?, ?, ?)";
                    command.Parameters.Clear();
                    command.Parameters.Add("date", (DbType)SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();
                    command.Parameters.Add("time", (DbType)SqlDbType.VarChar).Value = DateTime.Now.ToShortTimeString();
                    command.Parameters.Add("itemName", (DbType)SqlDbType.Int).Value = ItemName.Text;
                    command.Parameters.Add("quantity", (DbType)SqlDbType.Int).Value = quantityToAdd;
                    command.Parameters.Add("supplierName", (DbType)SqlDbType.VarChar).Value = supplierName;
                    command.Prepare();
                    command.ExecuteNonQuery();
                }

                Connection.Close();
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
