using MySqlConnector;

namespace SalesInventoryApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public readonly MySqlConnection connection = new("Server=localhost;Database=sales_inventory;User=root;Password=password;");
        private Boolean isFound = false;

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Username.Text) && !string.IsNullOrWhiteSpace(Password.Text))
            {
                try
                {
                    connection.Open();
                    MySqlCommand getAllUsers = new("SELECT * FROM users", connection);
                    MySqlDataReader dataReader = getAllUsers.ExecuteReader();

                    String password;

                    if (Username.Text == "Admin")
                        password = Password.Text;
                    else
                        password = HashedPassword(Password.Text);

                    while (dataReader.Read())
                    {
                        if (dataReader[0].ToString() == Username.Text.Trim() && dataReader[1].ToString() == password)
                        {
                            ShowMessage(false, "Success", "You have successfuly login " + Username.Text + ".");
                            connection.Close();
                            Dashboard dashboard = new(Username.Text) { LoginForm = this, Connection = connection };
                            dashboard.Show();
                            Username.Text = Password.Text = "";
                            isFound = true;
                            break;
                        }
                    }

                    dataReader.Close();

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
            if (ShowPass.Checked == true)
                Password.UseSystemPasswordChar = false;
            else
                Password.UseSystemPasswordChar = true;
        }

        public static string HashedPassword(string password)
        {
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                var bytes = System.Text.Encoding.UTF8.GetBytes(password.Trim());
                var hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
