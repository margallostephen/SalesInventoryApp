using System.Text;
using MySqlConnector;

namespace SalesInventoryApp
{
    public partial class Login : Form
    {
        private readonly MySqlConnection connection = new("Server=localhost;Database=sales_inventory;User=root;Password=password;");
        private Boolean isFound;

        public Login()
        {
            InitializeComponent();
            Dashboard.ReduceFlicker(this);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Username.Text) && !string.IsNullOrWhiteSpace(Password.Text))
            {
                try
                {
                    connection.Open();
                    using MySqlCommand getAllUsers = new("SELECT * FROM users", connection);
                    using MySqlDataReader dataReader = getAllUsers.ExecuteReader();
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(Password.Text.ToString());

                    while (dataReader.Read())
                    {
                        byte[] salt = Convert.FromBase64String(dataReader[2].ToString());

                        if (dataReader[0].ToString() == Username.Text.Trim() && PasswordSecurity.VerifyHash(passwordBytes, salt, Convert.FromBase64String(dataReader[1].ToString())))
                        {
                            ShowMessage(false, "Success", "You have successfuly login " + Username.Text.Trim() + ".");
                            connection.Close();
                            Dashboard dashboard = new(Username.Text.Trim()) { loginForm = this, connection = connection };
                            dashboard.Show();
                            Username.Text = Password.Text = "";
                            ShowPassBtn.Checked = false;
                            isFound = true;
                            break;
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

                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
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
