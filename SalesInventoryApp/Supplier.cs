using MySqlConnector;

namespace SalesInventoryApp
{
    public partial class Supplier : Form
    {
        public MySqlConnection connection { get; set; }
        public int selectedRowId;
        public string selectedRowSupplier, selectedRowAddress, selectedRowContactNumber;

        public Supplier()
        {
            InitializeComponent();
            SupplierTable.MouseWheel += new MouseEventHandler(MouseWheel);
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            Dashboard.LoadTableRecord(SupplierTable, ActionLabel, NoLabel, connection);
        }

        private void AddSupplierBtn_Click(object sender, EventArgs e)
        {
            SupplierPrompt supplierPrompt = new("Add", this) { connection = connection };
            DialogResult result = supplierPrompt.ShowDialog(this);
            Dashboard.DisposePrompt(result, supplierPrompt, SupplierTable, ActionLabel, NoLabel, connection);
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
                Dashboard.SelectedRowChangeColor(SupplierTable, true);
                SupplierPrompt supplierPrompt;

                if (columnName == "ColumnEdit")
                {
                    supplierPrompt = new("Edit", this) { connection = connection };
                    supplierPrompt.Supplier.Text = selectedRowSupplier;
                    supplierPrompt.Address.Text = selectedRowAddress;
                    supplierPrompt.ContactNumber.Text = selectedRowContactNumber;
                }
                else
                    supplierPrompt = new("Delete", this) { connection = connection };

                DialogResult result = supplierPrompt.ShowDialog(this);
                Dashboard.DisposePrompt(result, supplierPrompt, SupplierTable, ActionLabel, NoLabel, connection);
                Dashboard.SelectedRowChangeColor(SupplierTable, false);
            }
        }

        private void SupplierTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            Dashboard.ChangeCursor(SupplierTable, e);
        }

        private new void MouseWheel(object sender, MouseEventArgs e)
        {
            Dashboard.ScrollUpDown(SupplierTable, e);
        }
    }
}
