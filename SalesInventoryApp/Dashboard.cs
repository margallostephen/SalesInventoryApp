using FontAwesome.Sharp;
using MySqlConnector;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SalesInventoryApp
{
    public partial class Dashboard : Form
    {
        public Form loginForm { get; set; }
        public MySqlConnection connection { get; set; }
        private IconButton activeBtn;
        private Panel activeBtnPanel;
        private Form currentChildForm;
        private Category categoryForm;
        private Supplier supplierForm;
        private Item itemForm;
        private User userForm;

        public Dashboard(string username)
        {
            InitializeComponent();
            UserLabel.Text = "Welcome " + username;

            activeBtnPanel = new Panel
            {
                Size = new Size(4, 51),
                BackColor = Color.White
            };

            SidePanel.Controls.Add(activeBtnPanel);
            MaintenanceBtn_Click(MaintenanceBtn, null);
            ReduceFlicker(this);
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            if (SidePanel.Width > 200)
            {
                SidePanel.Width = 52;

                foreach (Button menuBtn in SidePanel.Controls.OfType<Button>())
                    menuBtn.Text = "";

                foreach (Button subMenuBtn in MaintenanceSubMenu.Controls.OfType<Button>())
                    subMenuBtn.Location = new Point(0, subMenuBtn.Location.Y);
            }
            else
            {
                SidePanel.Width = 211;

                foreach (Button menuBtn in SidePanel.Controls.OfType<Button>())
                    menuBtn.Text = menuBtn.Tag.ToString();

                foreach (Button subMenuBtn in MaintenanceSubMenu.Controls.OfType<Button>())
                    subMenuBtn.Location = new Point(51, subMenuBtn.Location.Y);
            }
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

        private void OpenChildForm(Form ChildForm)
        {
            if (currentChildForm != ChildForm)
            {
                currentChildForm?.Hide();
                currentChildForm = ChildForm;
                currentChildForm.Dock = DockStyle.Fill;
                currentChildForm.TopLevel = false;
                MainPanel.Controls.Add(currentChildForm);
                currentChildForm.Show();
            }
        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void DeliveryBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
        private void MaintenanceBtn_Click(object sender, EventArgs? e)
        {
            ActiveButton(sender);
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            userForm ??= new() { connection = connection };
            OpenChildForm(userForm);
        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            categoryForm ??= new() { connection = connection };
            OpenChildForm(categoryForm);
        }

        private void SupplierBtn_Click(object sender, EventArgs e)
        {
            supplierForm ??= new() { connection = connection };
            OpenChildForm(supplierForm);
        }

        private void ItemBtn_Click(object sender, EventArgs e)
        {
            itemForm ??= new() { connection = connection };
            OpenChildForm(itemForm);
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Message message = new("Logout", "Logging out" + UserLabel.Text.ToString().Remove(0, 7) + ".");
            Close();
            Dispose();
            message.ShowDialog();
            loginForm.Show();
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
            }

            using (MySqlCommand command = new(query, connection))
            {
                using MySqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    formTable.BringToFront();
                    actionLabel.BringToFront();
                    while (dataReader.Read())
                    {
                        switch (formTable.Name.ToString())
                        {
                            case "UserTable":
                                formTable.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString());
                                break;
                            case "SupplierTable":
                                formTable.Rows.Add(dataReader[0], dataReader[1], dataReader[2], dataReader[3]);
                                break;
                            case "CategoryTable":
                                formTable.Rows.Add(dataReader[0], dataReader[1]);
                                break;
                            case "ItemTable":
                                formTable.Rows.Add(dataReader[0], dataReader[1], dataReader[2], dataReader[3], dataReader[4]);
                                break;
                        }
                    }
                }
                else
                    noLabel.BringToFront();
            }

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
            {
                LoadTableRecord(formTable, actionLabel, noLabel, connection);

                if (promptForm.Name.ToString() == "CategoryPrompt")
                {
                    FormCollection forms = Application.OpenForms;

                    foreach (Form form in forms)
                        if (form.Name == "Item")
                        {
                            Item itemForm = form as Item;
                            LoadTableRecord(itemForm.ItemTable, itemForm.ActionLabel, itemForm.NoLabel, connection);
                        }
                }
            }

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

        public static void ReduceFlicker(Form form)
        {
            foreach (Control control in form.Controls)
            {
                var doubleBuffer = control.GetType().GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
                doubleBuffer.SetValue(control, true, null);
            }
        }
    }
}
