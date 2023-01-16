using SalesInventoryApp.Properties;

namespace SalesInventoryApp
{
    public partial class Message : Form
    {
        public Message(String info, String message)
        {
            InitializeComponent();
            MessageLabel.Text = message;

            if (info == "Success")
            {
                panel1.BackColor = panel2.BackColor = ColorTranslator.FromHtml("#00bf52");
                PictureBox.Image = Resources.Check;
            }

            if (info == "Error" || info == "Invalid" || info == "Logout")
            {
                panel1.BackColor = panel2.BackColor = ColorTranslator.FromHtml("#cf3b2e");

                if (info == "Logout")
                {
                    PictureBox.Image = Resources.Logout;
                    PictureBox.Location = new Point(26, 52);
                }
                else
                    PictureBox.Image = Resources.Error;
            }

            Dashboard.ReduceFlicker(this);
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
