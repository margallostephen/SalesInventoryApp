﻿using MySqlConnector;
using System.Text;
using System.Data;

namespace SalesInventoryApp
{
    public partial class UserPrompt : Form
    {
        public MySqlConnection connection { get; set; }
        private readonly User userForm;

        public UserPrompt(string operation, User userForm)
        {
            InitializeComponent();
            this.userForm = userForm;

            if (operation != "Delete")
            {
                if (operation == "Edit")
                {
                    Text = HeaderText.Text = "Edit User";
                    BtnOne.Text = "Save";
                }
            }
            else
            {
                Size = new Size(350, 153);
                Text = HeaderText.Text = "Delete User";
                BtnOne.Text = "Yes";
                BtnTwo.Text = "No";
                MessageText.Text += this.userForm.selectedRowUsername + "?";
                MessagePanel.BringToFront();
                BtnOne.BringToFront();
                BtnTwo.BringToFront();
            }

            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            string username = Username.Text.Trim(),
                   info = "Invalid", 
                   message;

            Boolean alreadyTaken = false;

            DialogResult = DialogResult.None;

            connection.Open();

            using (MySqlCommand getAllUsers = new("SELECT * FROM users", connection))
            {
                using MySqlDataReader dataReader = getAllUsers.ExecuteReader();

                while (dataReader.Read())
                {
                    if (dataReader[0].ToString() == username)
                    {
                        if (BtnOne.Text != "Yes")
                            alreadyTaken = true;

                        break;
                    }
                }
            }

            using (MySqlCommand command = connection.CreateCommand())
            {
                if (BtnOne.Text != "Yes")
                {
                    if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(Password.Text))
                    {
                        if (alreadyTaken && BtnOne.Text == "Add" || alreadyTaken && username != userForm.selectedRowUsername)
                            message = "Username have already been taken.";
                        else
                        {
                            byte[] passwordBytes = Encoding.UTF8.GetBytes(Password.Text.ToString()), salt = PasswordSecurity.GenerateSalt();
                            String password = Convert.ToBase64String(PasswordSecurity.CreateHash(passwordBytes, salt)), saltString = Convert.ToBase64String(salt);

                            if (BtnOne.Text == "Add")
                            {
                                command.CommandText = "INSERT INTO users(username, password, salt) VALUES(?, ?, ?)";
                                message = "New user added successfully.";
                            }
                            else
                            {
                                command.CommandText = "UPDATE users SET username = ?, password = ?, salt = ? WHERE password = ?";
                                message = "User updated successfully.";
                            }

                            command.Parameters.Add("username", (DbType)SqlDbType.VarChar).Value = username;
                            command.Parameters.Add("password", (DbType)SqlDbType.VarChar).Value = password;
                            command.Parameters.Add("salt", (DbType)SqlDbType.VarChar).Value = saltString;

                            if (BtnOne.Text == "Save")
                                command.Parameters.Add("oldPassword", (DbType)SqlDbType.VarChar).Value = userForm.selectedRowPassword;

                            info = "Success";
                            DialogResult = DialogResult.OK;
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
                    DialogResult = DialogResult.OK;
                }

                if (command.CommandText != "")
                {
                    command.Prepare();
                    command.ExecuteNonQuery();
                }
            }

            connection.Close();
            Dashboard.ShowMessage(this, userForm, info, message, DialogResult);      
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
