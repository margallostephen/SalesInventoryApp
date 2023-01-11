using FontAwesome.Sharp;
using MySqlConnector;
using System.Runtime.InteropServices;

namespace SalesInventoryApp
{
    public partial class Dashboard : Form
    {
        public Form LoginForm { get; set; }
        public MySqlConnection Connection { get; set; }
        private IconButton ActiveBtn;
        private Panel ActiveBtnPanel;
        private Form CurrentChildForm;
        private User userForm;

        public Dashboard(string Username)
        {
            InitializeComponent();
            UserLabel.Text = "Welcome " + Username;
            ActiveBtnPanel = new Panel
            {
                Size = new Size(4, 51),
                BackColor = Color.White
            };
            SidePanel.Controls.Add(ActiveBtnPanel);
            MaintenanceBtn_Click(MaintenanceBtn, null);
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
            if (ActiveBtn != null)
                ActiveBtn.BackColor = Color.SlateBlue;

            ActiveBtn = (IconButton)senderBtn;
            ActiveBtn.BackColor = Color.DarkSlateBlue;
            ActiveBtnPanel.Height = ActiveBtn.Height;
            ActiveBtnPanel.Location = new Point(0, ActiveBtn.Location.Y);
            ActiveBtnPanel.BringToFront();

            if (ActiveBtn != MaintenanceBtn)
                MaintenanceSubMenu.Visible = false;
            else
                MaintenanceSubMenu.Visible = true;
        }

        private void OpenChildForm(Form ChildForm)
        {
            if (CurrentChildForm != ChildForm)
            {
                CurrentChildForm?.Hide();
                CurrentChildForm = ChildForm;
                CurrentChildForm.Dock = DockStyle.Fill;
                CurrentChildForm.TopLevel = false;
                MainPanel.Controls.Add(CurrentChildForm);
                CurrentChildForm.Show();
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
            userForm ??= new() { Connection = Connection };
            OpenChildForm(userForm);
        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {

        }

        private void SupplierBtn_Click(object sender, EventArgs e)
        {

        }

        private void ItemBtn_Click(object sender, EventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Close();
            Message message = new("Logout", "Logging out.");
            message.ShowDialog();
            LoginForm.Show();
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
    }
}
