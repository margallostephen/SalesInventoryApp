using MySqlConnector;
using System.Text;
using System.Data;

namespace SalesInventoryApp
{
    public partial class UserPrompt : Form
    {
        public MySqlConnection Connection { get; set; }
        private readonly User userForm = null;

        public UserPrompt(string operation, User UserForm)
        {
            InitializeComponent();
            userForm = UserForm;

            if (operation != "Delete")
            {
                if (operation == "Edit")
                {
                    HeaderText.Text = "Edit User";
                    BtnOne.Text = "Save";
                }
            }
            else
            {
                this.Size = new Size(350, 150);
                HeaderText.Text = "Delete User";
                BtnOne.Text = "Yes";
                BtnTwo.Text = "No";
                MessageText.Text += userForm.selectedRowUsername + "?";
                MessagePanel.BringToFront();
                BtnOne.BringToFront();
                BtnTwo.BringToFront();
            }
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            string username = "", info = "Invalid", message;
            Boolean alreadyTaken = false, closePrompt = false;

            Connection.Open();

            using (MySqlCommand getAllUsers = new("SELECT * FROM users", Connection))
            {
                using (MySqlDataReader dataReader = getAllUsers.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        if (dataReader[0].ToString() == Username.Text)
                        {
                            username = dataReader[0].ToString();

                            if (BtnOne.Text != "Yes")
                                alreadyTaken = true;

                            break;
                        }
                    }
                }
            }

            using (MySqlCommand command = Connection.CreateCommand())
            {
                if (BtnOne.Text != "Yes")
                {
                    if (!string.IsNullOrWhiteSpace(Username.Text) && !string.IsNullOrWhiteSpace(Password.Text))
                    {
                        if (alreadyTaken)
                            message = "Username have already been taken.";
                        else
                        {
                            byte[] passwordBytes = Encoding.UTF8.GetBytes(Password.Text.ToString()), salt = PasswordSecurity.GenerateSalt();
                            String password = Convert.ToBase64String(PasswordSecurity.CreateHash(passwordBytes, salt)), saltString = Convert.ToBase64String(salt);

                            if (BtnOne.Text == "Add")
                            {
                                command.CommandText = "INSERT INTO users(username, password, salt) VALUES(?, ?, ?)";
                                command.Parameters.Add("username", (DbType)SqlDbType.VarChar).Value = Username.Text.Trim();
                                command.Parameters.Add("password", (DbType)SqlDbType.VarChar).Value = password;
                                command.Parameters.Add("salt", (DbType)SqlDbType.VarChar).Value = saltString;
                                message = "New user added successfully.";
                            }
                            else
                            {
                                command.CommandText = "UPDATE users SET username = ?, password = ?, salt = ? WHERE password = ?";
                                command.Parameters.Add("newUsername", (DbType)SqlDbType.VarChar).Value = Username.Text.Trim();
                                command.Parameters.Add("password", (DbType)SqlDbType.VarChar).Value = password;
                                command.Parameters.Add("salt", (DbType)SqlDbType.VarChar).Value = saltString;
                                command.Parameters.Add("oldPassword", (DbType)SqlDbType.VarChar).Value = userForm.selectedRowPassword;
                                message = "User updated successfully.";
                            }

                            info = "Success";
                            closePrompt = true;
                        }
                    }
                    else
                    {
                        info = "Warning";
                        message = "Please fill out the required fields.";
                    }
                }
                else
                {
                    command.CommandText = "DELETE FROM users WHERE password = ?";
                    command.Parameters.Add("password", (DbType)SqlDbType.VarChar).Value = userForm.selectedRowPassword;
                    message = "User " + username + " deleted successfully.";
                    info = "Success";
                    closePrompt = true;
                }

                if (command.CommandText != "")
                    command.ExecuteNonQuery();
            }

            Dashboard.ShowMessage(this, userForm, info, message, closePrompt);
            Connection.Close();
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
