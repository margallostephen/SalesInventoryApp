using MySqlConnector;
using System.Text;

namespace SalesInventoryApp
{
    public partial class Login : Form
    {
        private readonly MySqlConnection Connection = new("Server=localhost;Database=sales_inventory;User=root;Password=password;");
        private Boolean isFound;

        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Username.Text) && !string.IsNullOrWhiteSpace(Password.Text))
            {
                try
                {
                    Connection.Open();
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(Password.Text.ToString());

                    using (MySqlCommand getAllUsers = new("SELECT * FROM users", Connection))
                    {
                        using MySqlDataReader dataReader = getAllUsers.ExecuteReader();

                        while (dataReader.Read())
                        {
                            byte[] salt = Convert.FromBase64String(dataReader[2].ToString());

                            if (dataReader[0].ToString() == Username.Text.Trim() &&
                                PasswordSecurity.VerifyHash(passwordBytes, salt, Convert.FromBase64String(dataReader[1].ToString())))
                            {
                                ShowMessage(false, "Success", "You have successfuly login " + Username.Text.Trim() + ".");
                                Connection.Close();
                                Main dashboard = new(Username.Text.Trim()) { LoginForm = this, Connection = Connection };
                                dashboard.Show();
                                Username.Text = Password.Text = "";
                                ShowPassBtn.Checked = false;
                                isFound = true;
                                break;
                            }
                        }
                    }

                    if (!isFound)
                        ShowMessage(true, "Invalid", "Incorrect username or password.");
                    else
                        isFound = false;
                }
                catch (Exception er)
                {
                    ShowMessage(true, "Error", er.Message.ToString());
                }

                if (Connection.State == System.Data.ConnectionState.Open)
                    Connection.Close();
            }
            else
                ShowMessage(true, "Warning", "Please fill out the required fields.");
        }

        private void ShowMessage(Boolean showLoginForm, String info, String Message)
        {
            Message messageform = new(info, Message);
            Hide();
            messageform.ShowDialog();

            if (showLoginForm)
                Show();
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassBtn.Checked == true)
                Password.UseSystemPasswordChar = false;
            else
                Password.UseSystemPasswordChar = true;
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
