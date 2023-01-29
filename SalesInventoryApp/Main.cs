using FontAwesome.Sharp;
using MySqlConnector;
using System.Runtime.InteropServices;

namespace SalesInventoryApp
{
    public partial class Main : Form
    {
        public Form LoginForm { get; set; }
        public MySqlConnection Connection { get; set; }
        private IconButton activeBtn;
        private readonly Panel activeBtnPanel;
        private Form currentChildForm;
        private Dashboard dashboardForm;
        private Inventory inventoryForm;
        private Sales salesForm;
        private Delivery deliveryForm;
        private Category categoryForm;
        private Supplier supplierForm;
        private Item itemForm;
        private User userForm;

        public Main(string username)
        {
            InitializeComponent();
            UserLabel.Text = "Welcome " + username;

            activeBtnPanel = new Panel
            {
                Size = new Size(4, 51),
                BackColor = Color.FromArgb(235, 230, 255),
            };

            SideBar.Controls.Add(activeBtnPanel);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DashboardBtn.PerformClick();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            if (SideBar.Width == 52)
            {
                SideBar.Width = 211;

                foreach (Button subMenuBtn in MaintenanceSubMenu.Controls.OfType<Button>())
                    subMenuBtn.Location = new Point(52, subMenuBtn.Location.Y);

                if (SideBar.Width > 160)
                    foreach (Button menuBtn in SideBar.Controls.OfType<Button>())
                        menuBtn.Text = menuBtn.Tag.ToString();
            }
            else
            {
                SideBar.Width = 52;

                if (SideBar.Width < 106)
                    foreach (Button subMenuBtn in MaintenanceSubMenu.Controls.OfType<Button>())
                        subMenuBtn.Location = new Point(0, subMenuBtn.Location.Y);

                if (SideBar.Width < 150)
                    foreach (Button menuBtn in SideBar.Controls.OfType<Button>())
                        menuBtn.Text = "";
            }

            Refresh();
        }

        private void ActiveButton(object senderBtn)
        {
            if (activeBtn != null)
                activeBtn.BackColor = Color.SlateBlue;

            activeBtn = (IconButton)senderBtn;
            activeBtn.BackColor = Color.DarkSlateBlue;
            activeBtnPanel.Height = activeBtn.Height;
            activeBtnPanel.Location = new Point(0, activeBtn.Location.Y);
            activeBtnPanel.BringToFront();

            if (activeBtn != MaintenanceBtn)
                MaintenanceSubMenu.Visible = false;
            else
                MaintenanceSubMenu.Visible = true;
        }

        public void OpenChildForm(Form ChildForm)
        {
            if (currentChildForm == null || currentChildForm.Name != ChildForm.Name)
            {
                currentChildForm?.Close();
                currentChildForm = ChildForm;
                currentChildForm.Dock = DockStyle.Fill;
                currentChildForm.TopLevel = false;
                MainPanel.Controls.Add(currentChildForm);
                currentChildForm.Show();
            }
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            dashboardForm = new() { Connection = Connection };
            OpenChildForm(dashboardForm);
        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            inventoryForm = new() { Connection = Connection };
            OpenChildForm(inventoryForm);
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            salesForm = new() { Connection = Connection };
            OpenChildForm(salesForm);
        }

        private void DeliveryBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            deliveryForm = new() { Connection = Connection };
            OpenChildForm(deliveryForm);
        }

        private void MaintenanceBtn_Click(object sender, EventArgs? e)
        {
            ActiveButton(sender);
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            userForm = new() { Connection = Connection };
            OpenChildForm(userForm);
        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            categoryForm = new() { Connection = Connection };
            OpenChildForm(categoryForm);
        }

        private void SupplierBtn_Click(object sender, EventArgs e)
        {
            supplierForm = new() { Connection = Connection };
            OpenChildForm(supplierForm);
        }

        private void ItemBtn_Click(object sender, EventArgs e)
        {
            itemForm = new() { Connection = Connection };
            OpenChildForm(itemForm);
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Message message = new("Logout", "Logging out" + UserLabel.Text.ToString().Remove(0, 7) + ".");
            Close();
            Dispose();
            message.ShowDialog();
            LoginForm.Show();
        }

        public static void LoadTableRecord(DataGridView formTable, Label actionLabel, Label noLabel, MySqlConnection connection)
        {
            formTable.Rows.Clear();
            connection.Open();
            string query = "";

            switch (formTable.Name.ToString())
            {
                case "UserTable":
                    query = "SELECT * FROM users ORDER BY username ASC";
                    break;
                case "SupplierTable":
                    query = "SELECT * FROM supplier ORDER BY id ASC";
                    break;
                case "CategoryTable":
                    query = "SELECT * FROM item_category ORDER BY id ASC";
                    break;
                case "ItemTable":
                    query = "SELECT * FROM items ORDER BY id ASC";
                    break;
                case "InventoryTable":
                    query = "SELECT items.id, items.name, inventory_stocks.quantity " +
                             "FROM items INNER JOIN inventory_stocks ON items.id = inventory_stocks.item_id " +
                             "ORDER BY id ASC";
                    break;
                case "SalesTable":
                    query = "SELECT * FROM sales ORDER BY id ASC";
                    break;
                case "DeliveryTable":
                    query = "SELECT * FROM delivery ORDER BY id ASC";
                    break;
            }

            using MySqlCommand command = new(query, connection);
            using MySqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                formTable.BringToFront();

                actionLabel?.BringToFront();

                while (dataReader.Read())
                {
                    switch (formTable.Name.ToString())
                    {
                        case "UserTable":
                        case "CategoryTable":
                            formTable.Rows.Add(dataReader[0], dataReader[1]);
                            break;
                        case "InventoryTable":
                            formTable.Rows.Add(dataReader[0], dataReader[1], dataReader[2]);
                            break;
                        case "SupplierTable":
                            formTable.Rows.Add(dataReader[0], dataReader[1], dataReader[2], dataReader[3]);
                            break;
                        case "ItemTable":
                        case "SalesTable":
                        case "DeliveryTable":
                            formTable.Rows.Add(dataReader[0], dataReader[1], dataReader[2], dataReader[3], dataReader[4], dataReader[5]);
                            break;
                    }
                }
            }
            else
                noLabel.BringToFront();

            connection.Close();
        }

        public static void ShowMessage(Form child, Form parent, String info, String Message, DialogResult result)
        {
            child.Hide();
            Message messageform = new(info, Message);
            messageform.ShowDialog(parent);
            child.Show();

            if (result == DialogResult.OK)
                child.Close();
        }

        public static void DisposePrompt(DialogResult result, Form promptForm, DataGridView formTable, Label actionLabel, Label noLabel, MySqlConnection connection)
        {
            if (result == DialogResult.OK)
                LoadTableRecord(formTable, actionLabel, noLabel, connection);

            if (result == DialogResult.OK || result == DialogResult.Cancel)
                promptForm.Dispose();
        }

        public static void SelectedRowChangeColor(DataGridView formTable, Boolean Selected)
        {
            if (Selected)
            {
                formTable.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.SlateBlue;
                formTable.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.White;
            }
            else
            {
                if (formTable.CurrentRow != null)
                {
                    formTable.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 230, 255);
                    formTable.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
        }

        public static void ChangeCursor(DataGridView formTable, DataGridViewCellEventArgs e)
        {
            string columnName = formTable.Columns[e.ColumnIndex].Name;

            if (columnName == "ColumnEdit" || columnName == "ColumnDelete" || columnName == "ColumnImage")
                formTable.Cursor = Cursors.Hand;
            else
                formTable.Cursor = Cursors.Default;
        }

        public static void ScrollUpDown(DataGridView formTable, MouseEventArgs e)
        {
            if (e.Delta > 0 && formTable.FirstDisplayedScrollingRowIndex > 0)
                formTable.FirstDisplayedScrollingRowIndex--;
            else if (e.Delta < 0 && formTable.FirstDisplayedScrollingRowIndex < formTable.RowCount - 1)
                formTable.FirstDisplayedScrollingRowIndex++;
        }

        public static void MinimizedSideBar()
        {
            FormCollection forms = Application.OpenForms;
            Main dashboardForm = null;

            foreach (Form form in forms)
                if (form.Name == "Main")
                    dashboardForm = form as Main;

            if (dashboardForm.SideBar.Width == 211)
                dashboardForm.MenuBtn.PerformClick();
        }

        public static Image ByteToImage(byte[] imageByte)
        {
            using MemoryStream ms = new(imageByte);
            return Image.FromStream(ms);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            ClockTime.Text = DateTime.Now.ToString();
        }
    }
}
