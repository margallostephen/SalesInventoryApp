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
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SupplierTable.MouseWheel += new MouseEventHandler(MouseWheel);
        }

        public void LoadTableRecord()
        {
            SupplierTable.Rows.Clear();

            connection.Open();

            using (MySqlCommand command = new("SELECT * FROM supplier ORDER BY id ASC", connection))
            {
                using MySqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    SupplierTable.BringToFront();
                    ActionLabel.BringToFront();
                    while (dataReader.Read())
                        SupplierTable.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString());
                }
                else
                    NoLabel.BringToFront();
            }

            connection.Close();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            LoadTableRecord();
        }

        private void AddSupplierBtn_Click(object sender, EventArgs e)
        {
            SupplierPrompt supplierPrompt = new("Add", this) { Connection = connection };
            DialogResult result = supplierPrompt.ShowDialog(this);
            DisposePrompt(result, supplierPrompt);
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
                SupplierTable.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
                SupplierTable.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.White;

                SupplierPrompt supplierPrompt;

                if (columnName == "ColumnEdit")
                {
                    supplierPrompt = new("Edit", this) { Connection = connection };
                    supplierPrompt.Supplier.Text = selectedRowSupplier;
                    supplierPrompt.Address.Text = selectedRowAddress;
                    supplierPrompt.ContactNumber.Text = selectedRowContactNumber;
                }
                else
                    supplierPrompt = new("Delete", this) { Connection = connection };

                DialogResult result = supplierPrompt.ShowDialog(this);
                DisposePrompt(result, supplierPrompt);

                if (SupplierTable.CurrentRow != null)
                {
                    SupplierTable.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 230, 255);
                    SupplierTable.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
        }

        private void DisposePrompt(DialogResult result, SupplierPrompt supplierPrompt)
        {
            if (result == DialogResult.OK)
                LoadTableRecord();

            if (result == DialogResult.OK || result == DialogResult.Cancel)
                supplierPrompt.Dispose();
        }

        private void SupplierTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = SupplierTable.Columns[e.ColumnIndex].Name;

            if (columnName != "ColumnEdit" && columnName != "ColumnDelete")
                SupplierTable.Cursor = Cursors.Default;
            else
                SupplierTable.Cursor = Cursors.Hand;
        }

        private new void MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && SupplierTable.FirstDisplayedScrollingRowIndex > 0)
                SupplierTable.FirstDisplayedScrollingRowIndex--;
            else if (e.Delta < 0 && SupplierTable.FirstDisplayedScrollingRowIndex < SupplierTable.RowCount - 1)
                SupplierTable.FirstDisplayedScrollingRowIndex++;
        }
    }
}
