using SalesInventoryApp.Properties;
using System.Windows.Forms;

namespace SalesInventoryApp
{
    public partial class Message : Form
    {
        public Message(String Info, String message)
        {
            InitializeComponent();
            MessageLabel.Text = message;

            if (Info == "Success")
            {
                panel1.BackColor = panel2.BackColor = ColorTranslator.FromHtml("#00bf52");
                PictureBox.Image = Resources.Check;
            }

            if (Info == "Error" || Info == "Invalid" || Info == "Logout")
            {
                panel1.BackColor = panel2.BackColor = ColorTranslator.FromHtml("#cf3b2e");

                if (Info == "Logout")
                    PictureBox.Image = Resources.Logout;
                else
                    PictureBox.Image = Resources.Error;
            }

            Activated += CloseForm;
        }

        private async void CloseForm(object sender, EventArgs e)
        {
            await Task.Run(() => Thread.Sleep(1000));
            Close();
            Dispose();
        }
    }
}
