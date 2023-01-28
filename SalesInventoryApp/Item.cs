using MySqlConnector;
using System.Data;

namespace SalesInventoryApp
{
    public partial class Item : Form
    {
        public MySqlConnection connection { get; set; }
        public int selectedRowItemId, selectedRowCategoryId, selectedRowSupplierId;
        public string selectedRowItem, selectedRowBasePrice;
        public byte[] selectedItemImage;

        public Item()
        {
            InitializeComponent();
            ItemTable.MouseWheel += new MouseEventHandler(MouseWheel);
        }

        private void Item_Load(object sender, EventArgs e)
        {
            Main.LoadTableRecord(ItemTable, ActionLabel, NoLabel, connection);
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
                selectedRowSupplierId = Convert.ToInt32(ItemTable[5, index].Value);
            }
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            Main.MinimizedSideBar();
            bool[] tableNotNull = { false, false };
            string[] queryTable = { "item_category", "supplier" };

            connection.Open();

            for (int i = 0; i < 2; i++)
            {
                using MySqlCommand command = new("SELECT * FROM " + queryTable[i], connection);
                using MySqlDataReader dataReader = command.ExecuteReader();
                tableNotNull[i] = dataReader.HasRows;
            }

            Message messageForm = null;

            if (tableNotNull[0] && tableNotNull[1])
            {
                connection.Close();
                ItemPrompt itemPrompt = new("Add", this) { connection = connection };
                DialogResult result = itemPrompt.ShowDialog(this);
                Main.DisposePrompt(result, itemPrompt, ItemTable, ActionLabel, NoLabel, connection);
            }
            else if (!tableNotNull[0] && !tableNotNull[1])
                messageForm = new("Warning", "There are no categories and suppliers. Please add a category and supplier first.");
            else if (!tableNotNull[0])
                messageForm = new("Warning", "There are no categories. Please add a category first.");
            else
                messageForm = new("Warning", "There are no suppliers. Please add a supplier first.");

            if (messageForm != null)
            {
                connection.Close();
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

                if (columnName == "ColumnEdit")
                {
                    itemPrompt = new("Edit", this) { connection = connection };
                    itemPrompt.ItemImage.Image = Main.ByteToImage(selectedItemImage);
                    itemPrompt.Item.Text = selectedRowItem;
                    itemPrompt.Price.Text = selectedRowBasePrice;
                }
                else if (columnName == "ColumnDelete")
                {
                    connection.Open();
                    using MySqlCommand command = new("SELECT quantity FROM inventory_stocks WHERE item_id = ?", connection);
                    command.Parameters.Add("id", (DbType)SqlDbType.Int).Value = selectedRowItemId;
                    command.Prepare();
                    int quantity = (int)command.ExecuteScalar();
                    connection.Close();

                    if (quantity > 0)
                    {
                        itemPrompt = null;
                        Message messageForm = new("Error", "This item cannot be deleted because there are still remaining stock.");
                        messageForm.ShowDialog(this);
                    }
                    else
                        itemPrompt = new("Delete", this) { connection = connection };
                }
                else
                {
                    itemPrompt = new("ViewImage", this) { connection = connection };
                    itemPrompt.ItemImage.Image = Main.ByteToImage(selectedItemImage);
                }

                if (itemPrompt!= null)
                {
                    DialogResult result = itemPrompt.ShowDialog(this);
                    Main.DisposePrompt(result, itemPrompt, ItemTable, ActionLabel, NoLabel, connection);
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
