using MySqlConnector;

namespace SalesInventoryApp
{
    public partial class Supplier : Form
    {
        public MySqlConnection Connection { get; set; }
        public int selectedRowId;
        public string selectedRowSupplier, selectedRowAddress, selectedRowContactNumber;

        public Supplier()
        {
            InitializeComponent();
            SupplierTable.MouseWheel += new MouseEventHandler(MouseWheel);
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            Main.LoadTableRecord(SupplierTable, ActionLabel, NoLabel, Connection);
        }

        private void AddSupplierBtn_Click(object sender, EventArgs e)
        {
            Main.MinimizedSideBar();
            SupplierPrompt supplierPrompt = new("Add", this) { Connection = Connection };
            DialogResult result = supplierPrompt.ShowDialog(this);
            Main.DisposePrompt(result, supplierPrompt, SupplierTable, ActionLabel, NoLabel, Connection);
        }

        private void SupplierTable_SelectionChanged(object sender, EventArgs e)
        {
            if (SupplierTable.Rows.Count > 0)
            {
                int index = SupplierTable.CurrentRow.Index;
                selectedRowId = Convert.ToInt32(SupplierTable[0, index].Value);
                selectedRowSupplier = SupplierTable[1, index].Value.ToString();
                selectedRowAddress = SupplierTable[2, index].Value.ToString();
                selectedRowContactNumber = SupplierTable[3, index].Value.ToString();
            }
        }

        private void SupplierTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = SupplierTable.Columns[e.ColumnIndex].Name;

            if (columnName == "ColumnEdit" || columnName == "ColumnDelete")
            {
                Main.MinimizedSideBar();
                Main.SelectedRowChangeColor(SupplierTable, true);
                SupplierPrompt supplierPrompt;

                if (columnName == "ColumnEdit")
                {
                    supplierPrompt = new("Edit", this) { Connection = Connection };
                    supplierPrompt.Supplier.Text = selectedRowSupplier;
                    supplierPrompt.Address.Text = selectedRowAddress;
                    supplierPrompt.ContactNumber.Text = selectedRowContactNumber;
                }
                else
                    supplierPrompt = new("Delete", this) { Connection = Connection };

                DialogResult result = supplierPrompt.ShowDialog(this);
                Main.DisposePrompt(result, supplierPrompt, SupplierTable, ActionLabel, NoLabel, Connection);
                Main.SelectedRowChangeColor(SupplierTable, false);
            }
        }

        private void SupplierTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            Main.ChangeCursor(SupplierTable, e);
        }

        private new void MouseWheel(object sender, MouseEventArgs e)
        {
            Main.ScrollUpDown(SupplierTable, e);
        }
    }
}
