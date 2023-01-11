﻿namespace SalesInventoryApp
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new FontAwesome.Sharp.IconButton();
            this.LogoutBtn = new FontAwesome.Sharp.IconButton();
            this.PasswordIcon = new System.Windows.Forms.Panel();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.ShowPassBtn = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Password = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.UsernameIcon = new System.Windows.Forms.Panel();
            this.Username = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 367);
            this.panel1.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = null;
            this.Logo.Location = new System.Drawing.Point(41, 118);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(124, 122);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 7;
            this.Logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.MinimizeBtn);
            this.panel2.Controls.Add(this.LogoutBtn);
            this.panel2.Controls.Add(this.PasswordIcon);
            this.panel2.Controls.Add(this.LoginBtn);
            this.panel2.Controls.Add(this.Label);
            this.panel2.Controls.Add(this.ShowPassBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Password);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.UsernameIcon);
            this.panel2.Controls.Add(this.Username);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(210, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 367);
            this.panel2.TabIndex = 1;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimizeBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeBtn.IconColor = System.Drawing.Color.White;
            this.MinimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.MinimizeBtn.IconSize = 20;
            this.MinimizeBtn.Location = new System.Drawing.Point(321, -3);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Padding = new System.Windows.Forms.Padding(5, 0, 4, 0);
            this.MinimizeBtn.Size = new System.Drawing.Size(22, 22);
            this.MinimizeBtn.TabIndex = 25;
            this.MinimizeBtn.Text = " ";
            this.MinimizeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.White;
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.LogoutBtn.IconColor = System.Drawing.Color.Crimson;
            this.LogoutBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.LogoutBtn.IconSize = 38;
            this.LogoutBtn.Location = new System.Drawing.Point(340, -3);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(0);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LogoutBtn.Size = new System.Drawing.Size(26, 22);
            this.LogoutBtn.TabIndex = 24;
            this.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // PasswordIcon
            // 
            this.PasswordIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PasswordIcon.BackgroundImage")));
            this.PasswordIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PasswordIcon.Location = new System.Drawing.Point(29, 189);
            this.PasswordIcon.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordIcon.Name = "PasswordIcon";
            this.PasswordIcon.Size = new System.Drawing.Size(40, 32);
            this.PasswordIcon.TabIndex = 16;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(87, 282);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LoginBtn.MaximumSize = new System.Drawing.Size(190, 45);
            this.LoginBtn.MinimumSize = new System.Drawing.Size(190, 45);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(190, 45);
            this.LoginBtn.TabIndex = 20;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.Transparent;
            this.Label.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label.ForeColor = System.Drawing.Color.Black;
            this.Label.Location = new System.Drawing.Point(2, 36);
            this.Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(360, 57);
            this.Label.TabIndex = 19;
            this.Label.Text = "Login";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowPassBtn
            // 
            this.ShowPassBtn.BackColor = System.Drawing.Color.White;
            this.ShowPassBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowPassBtn.ForeColor = System.Drawing.Color.Black;
            this.ShowPassBtn.Location = new System.Drawing.Point(74, 225);
            this.ShowPassBtn.Name = "ShowPassBtn";
            this.ShowPassBtn.Size = new System.Drawing.Size(123, 19);
            this.ShowPassBtn.TabIndex = 18;
            this.ShowPassBtn.Text = "Show Password";
            this.ShowPassBtn.UseVisualStyleBackColor = false;
            this.ShowPassBtn.CheckedChanged += new System.EventHandler(this.ShowPass_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(74, 219);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 2);
            this.panel3.TabIndex = 17;
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(75, 189);
            this.Password.Margin = new System.Windows.Forms.Padding(2);
            this.Password.MaximumSize = new System.Drawing.Size(249, 27);
            this.Password.MinimumSize = new System.Drawing.Size(249, 27);
            this.Password.Name = "Password";
            this.Password.PlaceholderText = "Password";
            this.Password.Size = new System.Drawing.Size(249, 27);
            this.Password.TabIndex = 15;
            this.Password.UseSystemPasswordChar = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.panel5.Location = new System.Drawing.Point(74, 152);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 2);
            this.panel5.TabIndex = 14;
            // 
            // UsernameIcon
            // 
            this.UsernameIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UsernameIcon.BackgroundImage")));
            this.UsernameIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UsernameIcon.Location = new System.Drawing.Point(31, 122);
            this.UsernameIcon.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameIcon.Name = "UsernameIcon";
            this.UsernameIcon.Size = new System.Drawing.Size(38, 32);
            this.UsernameIcon.TabIndex = 13;
            // 
            // Username
            // 
            this.Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(75, 122);
            this.Username.Margin = new System.Windows.Forms.Padding(2);
            this.Username.MaximumSize = new System.Drawing.Size(249, 27);
            this.Username.MinimumSize = new System.Drawing.Size(249, 27);
            this.Username.Name = "Username";
            this.Username.PlaceholderText = "Username";
            this.Username.Size = new System.Drawing.Size(249, 27);
            this.Username.TabIndex = 12;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(574, 367);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(574, 367);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(574, 367);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox Logo;
        private Panel panel2;
        private Button LoginBtn;
        private Panel PasswordIcon;
        private CheckBox ShowPassBtn;
        private Panel panel3;
        private TextBox Password;
        private Panel panel5;
        private Panel UsernameIcon;
        private TextBox Username;
        private Label Label;
        private FontAwesome.Sharp.IconButton LogoutBtn;
        private FontAwesome.Sharp.IconButton MinimizeBtn;
    }
}