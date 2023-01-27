namespace SalesInventoryApp
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.SideBar = new System.Windows.Forms.Panel();
            this.MaintenanceSubMenu = new System.Windows.Forms.Panel();
            this.ItemBtn = new FontAwesome.Sharp.IconButton();
            this.SupplierBtn = new FontAwesome.Sharp.IconButton();
            this.CategoryBtn = new FontAwesome.Sharp.IconButton();
            this.UserBtn = new FontAwesome.Sharp.IconButton();
            this.MaintenanceBtn = new FontAwesome.Sharp.IconButton();
            this.DeliveryBtn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoutBtn = new FontAwesome.Sharp.IconButton();
            this.SalesBtn = new FontAwesome.Sharp.IconButton();
            this.InventoryBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MenuBtn = new FontAwesome.Sharp.IconButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.TopBar = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new FontAwesome.Sharp.IconButton();
            this.ClockTime = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.SideBar.SuspendLayout();
            this.MaintenanceSubMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.SlateBlue;
            this.SideBar.Controls.Add(this.MaintenanceSubMenu);
            this.SideBar.Controls.Add(this.MaintenanceBtn);
            this.SideBar.Controls.Add(this.DeliveryBtn);
            this.SideBar.Controls.Add(this.panel1);
            this.SideBar.Controls.Add(this.LogoutBtn);
            this.SideBar.Controls.Add(this.SalesBtn);
            this.SideBar.Controls.Add(this.InventoryBtn);
            this.SideBar.Controls.Add(this.panel2);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(52, 561);
            this.SideBar.TabIndex = 0;
            // 
            // MaintenanceSubMenu
            // 
            this.MaintenanceSubMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.MaintenanceSubMenu.Controls.Add(this.ItemBtn);
            this.MaintenanceSubMenu.Controls.Add(this.SupplierBtn);
            this.MaintenanceSubMenu.Controls.Add(this.CategoryBtn);
            this.MaintenanceSubMenu.Controls.Add(this.UserBtn);
            this.MaintenanceSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaintenanceSubMenu.Location = new System.Drawing.Point(0, 267);
            this.MaintenanceSubMenu.Name = "MaintenanceSubMenu";
            this.MaintenanceSubMenu.Size = new System.Drawing.Size(52, 238);
            this.MaintenanceSubMenu.TabIndex = 12;
            this.MaintenanceSubMenu.Visible = false;
            // 
            // ItemBtn
            // 
            this.ItemBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemBtn.FlatAppearance.BorderSize = 0;
            this.ItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemBtn.ForeColor = System.Drawing.Color.White;
            this.ItemBtn.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.ItemBtn.IconColor = System.Drawing.Color.White;
            this.ItemBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ItemBtn.IconSize = 25;
            this.ItemBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ItemBtn.Location = new System.Drawing.Point(0, 80);
            this.ItemBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ItemBtn.Name = "ItemBtn";
            this.ItemBtn.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.ItemBtn.Size = new System.Drawing.Size(160, 40);
            this.ItemBtn.TabIndex = 15;
            this.ItemBtn.Tag = "";
            this.ItemBtn.Text = "    Item";
            this.ItemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ItemBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ItemBtn.UseVisualStyleBackColor = false;
            this.ItemBtn.Click += new System.EventHandler(this.ItemBtn_Click);
            // 
            // SupplierBtn
            // 
            this.SupplierBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.SupplierBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SupplierBtn.FlatAppearance.BorderSize = 0;
            this.SupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupplierBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SupplierBtn.ForeColor = System.Drawing.Color.White;
            this.SupplierBtn.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.SupplierBtn.IconColor = System.Drawing.Color.White;
            this.SupplierBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SupplierBtn.IconSize = 25;
            this.SupplierBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SupplierBtn.Location = new System.Drawing.Point(0, 40);
            this.SupplierBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SupplierBtn.Name = "SupplierBtn";
            this.SupplierBtn.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.SupplierBtn.Size = new System.Drawing.Size(160, 40);
            this.SupplierBtn.TabIndex = 14;
            this.SupplierBtn.Tag = "";
            this.SupplierBtn.Text = "    Supplier";
            this.SupplierBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SupplierBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SupplierBtn.UseVisualStyleBackColor = false;
            this.SupplierBtn.Click += new System.EventHandler(this.SupplierBtn_Click);
            // 
            // CategoryBtn
            // 
            this.CategoryBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.CategoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryBtn.FlatAppearance.BorderSize = 0;
            this.CategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CategoryBtn.ForeColor = System.Drawing.Color.White;
            this.CategoryBtn.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.CategoryBtn.IconColor = System.Drawing.Color.White;
            this.CategoryBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CategoryBtn.IconSize = 25;
            this.CategoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CategoryBtn.Location = new System.Drawing.Point(0, 0);
            this.CategoryBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CategoryBtn.Name = "CategoryBtn";
            this.CategoryBtn.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.CategoryBtn.Size = new System.Drawing.Size(160, 40);
            this.CategoryBtn.TabIndex = 13;
            this.CategoryBtn.Tag = "";
            this.CategoryBtn.Text = "    Category";
            this.CategoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CategoryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CategoryBtn.UseVisualStyleBackColor = false;
            this.CategoryBtn.Click += new System.EventHandler(this.CategoryBtn_Click);
            // 
            // UserBtn
            // 
            this.UserBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.UserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserBtn.FlatAppearance.BorderSize = 0;
            this.UserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserBtn.ForeColor = System.Drawing.Color.White;
            this.UserBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            this.UserBtn.IconColor = System.Drawing.Color.White;
            this.UserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UserBtn.IconSize = 25;
            this.UserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserBtn.Location = new System.Drawing.Point(0, 120);
            this.UserBtn.Margin = new System.Windows.Forms.Padding(0);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.UserBtn.Size = new System.Drawing.Size(160, 40);
            this.UserBtn.TabIndex = 12;
            this.UserBtn.Tag = "";
            this.UserBtn.Text = "    User";
            this.UserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UserBtn.UseVisualStyleBackColor = false;
            this.UserBtn.Click += new System.EventHandler(this.UserBtn_Click);
            // 
            // MaintenanceBtn
            // 
            this.MaintenanceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaintenanceBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaintenanceBtn.FlatAppearance.BorderSize = 0;
            this.MaintenanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaintenanceBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaintenanceBtn.ForeColor = System.Drawing.Color.White;
            this.MaintenanceBtn.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.MaintenanceBtn.IconColor = System.Drawing.Color.White;
            this.MaintenanceBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaintenanceBtn.IconSize = 30;
            this.MaintenanceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MaintenanceBtn.Location = new System.Drawing.Point(0, 216);
            this.MaintenanceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MaintenanceBtn.Name = "MaintenanceBtn";
            this.MaintenanceBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.MaintenanceBtn.Size = new System.Drawing.Size(52, 51);
            this.MaintenanceBtn.TabIndex = 11;
            this.MaintenanceBtn.Tag = "   Maintenance";
            this.MaintenanceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MaintenanceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MaintenanceBtn.UseVisualStyleBackColor = true;
            this.MaintenanceBtn.Click += new System.EventHandler(this.MaintenanceBtn_Click);
            // 
            // DeliveryBtn
            // 
            this.DeliveryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeliveryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeliveryBtn.FlatAppearance.BorderSize = 0;
            this.DeliveryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliveryBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeliveryBtn.ForeColor = System.Drawing.Color.White;
            this.DeliveryBtn.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.DeliveryBtn.IconColor = System.Drawing.Color.White;
            this.DeliveryBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeliveryBtn.IconSize = 30;
            this.DeliveryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeliveryBtn.Location = new System.Drawing.Point(0, 165);
            this.DeliveryBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DeliveryBtn.Name = "DeliveryBtn";
            this.DeliveryBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.DeliveryBtn.Size = new System.Drawing.Size(52, 51);
            this.DeliveryBtn.TabIndex = 10;
            this.DeliveryBtn.Tag = "   Delivery";
            this.DeliveryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeliveryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeliveryBtn.UseVisualStyleBackColor = true;
            this.DeliveryBtn.Click += new System.EventHandler(this.DeliveryBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Location = new System.Drawing.Point(11, 506);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 2);
            this.panel1.TabIndex = 9;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.LogoutBtn.IconColor = System.Drawing.Color.White;
            this.LogoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogoutBtn.IconSize = 30;
            this.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.Location = new System.Drawing.Point(0, 509);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(0);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.LogoutBtn.Size = new System.Drawing.Size(52, 52);
            this.LogoutBtn.TabIndex = 6;
            this.LogoutBtn.Tag = "   Logout";
            this.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // SalesBtn
            // 
            this.SalesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalesBtn.FlatAppearance.BorderSize = 0;
            this.SalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SalesBtn.ForeColor = System.Drawing.Color.White;
            this.SalesBtn.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.SalesBtn.IconColor = System.Drawing.Color.White;
            this.SalesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SalesBtn.IconSize = 30;
            this.SalesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesBtn.Location = new System.Drawing.Point(0, 114);
            this.SalesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.SalesBtn.Size = new System.Drawing.Size(52, 51);
            this.SalesBtn.TabIndex = 5;
            this.SalesBtn.Tag = "   Sales";
            this.SalesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SalesBtn.UseVisualStyleBackColor = true;
            this.SalesBtn.Click += new System.EventHandler(this.SalesBtn_Click);
            // 
            // InventoryBtn
            // 
            this.InventoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InventoryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventoryBtn.FlatAppearance.BorderSize = 0;
            this.InventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InventoryBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InventoryBtn.ForeColor = System.Drawing.Color.White;
            this.InventoryBtn.IconChar = FontAwesome.Sharp.IconChar.CubesStacked;
            this.InventoryBtn.IconColor = System.Drawing.Color.White;
            this.InventoryBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InventoryBtn.IconSize = 30;
            this.InventoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventoryBtn.Location = new System.Drawing.Point(0, 63);
            this.InventoryBtn.Margin = new System.Windows.Forms.Padding(0);
            this.InventoryBtn.Name = "InventoryBtn";
            this.InventoryBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.InventoryBtn.Size = new System.Drawing.Size(52, 51);
            this.InventoryBtn.TabIndex = 4;
            this.InventoryBtn.Tag = "   Inventory";
            this.InventoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventoryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InventoryBtn.UseVisualStyleBackColor = true;
            this.InventoryBtn.Click += new System.EventHandler(this.InventoryBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MenuBtn);
            this.panel2.Controls.Add(this.Logo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(52, 63);
            this.panel2.TabIndex = 1;
            // 
            // MenuBtn
            // 
            this.MenuBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuBtn.FlatAppearance.BorderSize = 0;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.MenuBtn.IconColor = System.Drawing.Color.White;
            this.MenuBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuBtn.IconSize = 30;
            this.MenuBtn.Location = new System.Drawing.Point(0, 0);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(52, 63);
            this.MenuBtn.TabIndex = 2;
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(153, 63);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.TopBar.Controls.Add(this.MinimizeBtn);
            this.TopBar.Controls.Add(this.ClockTime);
            this.TopBar.Controls.Add(this.UserLabel);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(52, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(1048, 43);
            this.TopBar.TabIndex = 1;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.MinimizeBtn.Location = new System.Drawing.Point(1026, 0);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Padding = new System.Windows.Forms.Padding(5, 0, 4, 0);
            this.MinimizeBtn.Size = new System.Drawing.Size(22, 22);
            this.MinimizeBtn.TabIndex = 31;
            this.MinimizeBtn.Text = " ";
            this.MinimizeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MinimizeBtn.UseMnemonic = false;
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // ClockTime
            // 
            this.ClockTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClockTime.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClockTime.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClockTime.ForeColor = System.Drawing.Color.White;
            this.ClockTime.Location = new System.Drawing.Point(813, 11);
            this.ClockTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClockTime.Name = "ClockTime";
            this.ClockTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ClockTime.Size = new System.Drawing.Size(194, 18);
            this.ClockTime.TabIndex = 30;
            this.ClockTime.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.UserLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(10, 11);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(140, 22);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "Welcome User";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(52, 43);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1048, 518);
            this.MainPanel.TabIndex = 2;
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Interval = 1000;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 561);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.SideBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.SideBar.ResumeLayout(false);
            this.MaintenanceSubMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private PictureBox Logo;
        private FontAwesome.Sharp.IconButton MenuBtn;
        private FontAwesome.Sharp.IconButton SalesBtn;
        private FontAwesome.Sharp.IconButton InventoryBtn;
        private FontAwesome.Sharp.IconButton LogoutBtn;
        private Panel TopBar;
        private Label UserLabel;
        private Panel MainPanel;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton MaintenanceBtn;
        private FontAwesome.Sharp.IconButton DeliveryBtn;
        private Panel MaintenanceSubMenu;
        private FontAwesome.Sharp.IconButton ItemBtn;
        private FontAwesome.Sharp.IconButton SupplierBtn;
        private FontAwesome.Sharp.IconButton CategoryBtn;
        private FontAwesome.Sharp.IconButton UserBtn;
        private Label ClockTime;
        private System.Windows.Forms.Timer Time;
        private FontAwesome.Sharp.IconButton MinimizeBtn;
        public Panel SideBar;
    }
}