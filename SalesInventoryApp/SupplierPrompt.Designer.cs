namespace SalesInventoryApp
{
    partial class SupplierPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierPrompt));
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeaderText = new System.Windows.Forms.Label();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.BtnOne = new System.Windows.Forms.Button();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.ContactNumber = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Address = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Supplier = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.MessageText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.InputPanel.SuspendLayout();
            this.MessagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.HeaderText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 40);
            this.panel1.TabIndex = 1;
            // 
            // HeaderText
            // 
            this.HeaderText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderText.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeaderText.ForeColor = System.Drawing.Color.White;
            this.HeaderText.Location = new System.Drawing.Point(0, 0);
            this.HeaderText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(375, 39);
            this.HeaderText.TabIndex = 4;
            this.HeaderText.Text = "Add Supplier";
            this.HeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnTwo
            // 
            this.BtnTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.BtnTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTwo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTwo.ForeColor = System.Drawing.Color.White;
            this.BtnTwo.Location = new System.Drawing.Point(270, 161);
            this.BtnTwo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(78, 33);
            this.BtnTwo.TabIndex = 29;
            this.BtnTwo.Text = "Cancel";
            this.BtnTwo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnTwo.UseVisualStyleBackColor = false;
            this.BtnTwo.Click += new System.EventHandler(this.BtnTwo_Click);
            // 
            // BtnOne
            // 
            this.BtnOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnOne.BackColor = System.Drawing.Color.SlateBlue;
            this.BtnOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnOne.ForeColor = System.Drawing.Color.White;
            this.BtnOne.Location = new System.Drawing.Point(26, 161);
            this.BtnOne.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(78, 33);
            this.BtnOne.TabIndex = 28;
            this.BtnOne.Text = "Add";
            this.BtnOne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnOne.UseVisualStyleBackColor = false;
            this.BtnOne.Click += new System.EventHandler(this.BtnOne_Click);
            // 
            // InputPanel
            // 
            this.InputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputPanel.BackColor = System.Drawing.Color.White;
            this.InputPanel.Controls.Add(this.ContactNumber);
            this.InputPanel.Controls.Add(this.panel3);
            this.InputPanel.Controls.Add(this.Address);
            this.InputPanel.Controls.Add(this.panel2);
            this.InputPanel.Controls.Add(this.Supplier);
            this.InputPanel.Controls.Add(this.panel4);
            this.InputPanel.Location = new System.Drawing.Point(12, 46);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(351, 110);
            this.InputPanel.TabIndex = 27;
            // 
            // ContactNumber
            // 
            this.ContactNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactNumber.BackColor = System.Drawing.Color.White;
            this.ContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContactNumber.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactNumber.Location = new System.Drawing.Point(18, 71);
            this.ContactNumber.Margin = new System.Windows.Forms.Padding(2);
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.PlaceholderText = "Contact Number";
            this.ContactNumber.Size = new System.Drawing.Size(314, 22);
            this.ContactNumber.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Location = new System.Drawing.Point(14, 95);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 2);
            this.panel3.TabIndex = 27;
            // 
            // Address
            // 
            this.Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Address.BackColor = System.Drawing.Color.White;
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Address.Location = new System.Drawing.Point(18, 39);
            this.Address.Margin = new System.Windows.Forms.Padding(2);
            this.Address.Name = "Address";
            this.Address.PlaceholderText = "Address";
            this.Address.Size = new System.Drawing.Size(314, 22);
            this.Address.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Location = new System.Drawing.Point(14, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 2);
            this.panel2.TabIndex = 25;
            // 
            // Supplier
            // 
            this.Supplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Supplier.BackColor = System.Drawing.Color.White;
            this.Supplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Supplier.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Supplier.Location = new System.Drawing.Point(18, 7);
            this.Supplier.Margin = new System.Windows.Forms.Padding(2);
            this.Supplier.Name = "Supplier";
            this.Supplier.PlaceholderText = "Supplier Name";
            this.Supplier.Size = new System.Drawing.Size(314, 22);
            this.Supplier.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Location = new System.Drawing.Point(14, 31);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(322, 2);
            this.panel4.TabIndex = 23;
            // 
            // MessagePanel
            // 
            this.MessagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessagePanel.BackColor = System.Drawing.Color.White;
            this.MessagePanel.Controls.Add(this.MessageText);
            this.MessagePanel.Location = new System.Drawing.Point(12, 42);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(351, 71);
            this.MessagePanel.TabIndex = 30;
            // 
            // MessageText
            // 
            this.MessageText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MessageText.Location = new System.Drawing.Point(14, 0);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(322, 61);
            this.MessageText.TabIndex = 0;
            this.MessageText.Text = "Do you really want to delete supplier ";
            this.MessageText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SupplierPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 212);
            this.Controls.Add(this.BtnTwo);
            this.Controls.Add(this.BtnOne);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.MessagePanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Supplier";
            this.panel1.ResumeLayout(false);
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.MessagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label HeaderText;
        private Button BtnTwo;
        private Button BtnOne;
        private Panel InputPanel;
        public TextBox Address;
        private Panel panel2;
        public TextBox Supplier;
        private Panel panel4;
        private Panel MessagePanel;
        private Label MessageText;
        public TextBox ContactNumber;
        private Panel panel3;
    }
}