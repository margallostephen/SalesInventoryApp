using MySqlConnector;
using System.Data;

namespace SalesInventoryApp
{
    public partial class Item : Form
    {
        public MySqlConnection Connection { get; set; }
        public int selectedRowItemId, selectedRowCategoryId;
        public string selectedRowItem, selectedRowBasePrice, selectedRowSupplierName;
        public byte[] selectedItemImage;

        public Item()
        {
            InitializeComponent();
            ItemTable.MouseWheel += new MouseEventHandler(MouseWheel);
        }

        private void Item_Load(object sender, EventArgs e)
        {
            Main.LoadTableRecord(ItemTable, ActionLabel, NoLabel, Connection);
        }

        private void ItemTable_SelectionChanged(object sender, EventArgs e)
        {
            if (ItemTable.Rows.Count > 0)
            {
                int index = ItemTable.CurrentRow.Index;
                selectedItemImage = (byte[])ItemTable[0, index].Value;
                selectedRowItemId = Convert.ToInt32(ItemTable[1, index].Value);
                selectedRowItem = ItemTable[2, index].Value.ToString();
                selectedRowCategoryId = Convert.ToInt32(ItemTable[3, index].Value);
                selectedRowBasePrice = ItemTable[4, index].Value.ToString();
                selectedRowSupplierName = ItemTable[5, index].Value.ToString();
            }
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            Main.MinimizedSideBar();
            bool[] tableNotNull = { false, false };
            string[] queryTable = { "item_category", "supplier" };

            Connection.Open();

            for (int i = 0; i < 2; i++)
            {
                using MySqlCommand command = new("SELECT * FROM " + queryTable[i], Connection);
                using MySqlDataReader dataReader = command.ExecuteReader();
                tableNotNull[i] = dataReader.HasRows;
            }

            Message messageForm = null;

            if (tableNotNull[0] && tableNotNull[1])
            {
                Connection.Close();
                ItemPrompt itemPrompt = new("Add", this) { Connection = Connection };
                DialogResult result = itemPrompt.ShowDialog(this);
                Main.DisposePrompt(result, itemPrompt, ItemTable, ActionLabel, NoLabel, Connection);
            }
            else if (!tableNotNull[0] && !tableNotNull[1])
                messageForm = new("Warning", "There are no categories and suppliers. Please add a category and supplier first.");
            else if (!tableNotNull[0])
                messageForm = new("Warning", "There are no categories. Please add a category first.");
            else
                messageForm = new("Warning", "There are no suppliers. Please add a supplier first.");

            if (messageForm != null)
            {
                Connection.Close();
                messageForm.ShowDialog(this);
            }
        }

        private void ItemTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = ItemTable.Columns[e.ColumnIndex].Name;

            if (columnName == "ColumnEdit" || columnName == "ColumnDelete" || columnName == "ColumnImage")
            {
                Main.MinimizedSideBar();
                Main.SelectedRowChangeColor(ItemTable, true);
                ItemPrompt itemPrompt;
                string message = "";


                if (columnName == "ColumnEdit")
                {
                    Connection.Open();
                    using MySqlCommand command = new("SELECT * FROM supplier", Connection);
                    using MySqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        Connection.Close();
                        itemPrompt = new("Edit", this) { Connection = Connection };
                        itemPrompt.ItemImage.Image = Main.ByteToImage(selectedItemImage);
                        itemPrompt.Item.Text = selectedRowItem;
                        itemPrompt.Price.Text = selectedRowBasePrice;
                    }
                    else
                    {
                        Connection.Close();
                        itemPrompt = null;
                        message = "Please add a supplier first before you can edit this item.";
                    }
                }
                else if (columnName == "ColumnDelete")
                {
                    Connection.Open();
                    using MySqlCommand command = new("SELECT quantity FROM inventory_stocks WHERE item_id = ?", Connection);
                    command.Parameters.Add("id", (DbType)SqlDbType.Int).Value = selectedRowItemId;
                    command.Prepare();
                    int quantity = (int)command.ExecuteScalar();
                    Connection.Close();

                    if (quantity > 0)
                    {
                        itemPrompt = null;
                        message = "This item cannot be deleted because there are still remaining stock.";
                    }
                    else
                        itemPrompt = new("Delete", this) { Connection = Connection };
                }
                else
                {
                    itemPrompt = new("ViewImage", this) { Connection = Connection };
                    itemPrompt.ItemImage.Image = Main.ByteToImage(selectedItemImage);
                }

                if (itemPrompt != null)
                {
                    DialogResult result = itemPrompt.ShowDialog(this);
                    Main.DisposePrompt(result, itemPrompt, ItemTable, ActionLabel, NoLabel, Connection);
                }

                if (message != "")
                {
                    Message messageForm = new("Error", message);
                    messageForm.ShowDialog(this);
                }

                Main.SelectedRowChangeColor(ItemTable, false);
            }
        }

        private void ItemTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            Main.ChangeCursor(ItemTable, e);
        }

        private new void MouseWheel(object sender, MouseEventArgs e)
        {
            Main.ScrollUpDown(ItemTable, e);
        }
    }
}
