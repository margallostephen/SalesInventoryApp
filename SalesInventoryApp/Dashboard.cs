using FontAwesome.Sharp;
using MySqlConnector;
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
        private User userForm;
        private Category categoryForm;
        private Supplier supplierForm;

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
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
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

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Message message = new("Logout", "Logging out" + UserLabel.Text.ToString().Remove(0, 7) + ".");
            Close();
            Dispose();
            message.ShowDialog();
            loginForm.Show();
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
