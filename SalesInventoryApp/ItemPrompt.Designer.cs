﻿namespace SalesInventoryApp
{
    partial class ItemPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemPrompt));
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeaderText = new System.Windows.Forms.Label();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.ItemImage = new System.Windows.Forms.PictureBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Price = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Item = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.TextBox();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.BtnOne = new System.Windows.Forms.Button();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.MessageText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(373, 40);
            this.panel1.TabIndex = 6;
            // 
            // HeaderText
            // 
            this.HeaderText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderText.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeaderText.ForeColor = System.Drawing.Color.White;
            this.HeaderText.Location = new System.Drawing.Point(0, 0);
            this.HeaderText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(373, 40);
            this.HeaderText.TabIndex = 5;
            this.HeaderText.Text = "Add Item";
            this.HeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputPanel
            // 
            this.InputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputPanel.BackColor = System.Drawing.Color.White;
            this.InputPanel.Controls.Add(this.ItemImage);
            this.InputPanel.Controls.Add(this.Quantity);
            this.InputPanel.Controls.Add(this.panel3);
            this.InputPanel.Controls.Add(this.Price);
            this.InputPanel.Controls.Add(this.panel2);
            this.InputPanel.Controls.Add(this.Item);
            this.InputPanel.Controls.Add(this.panel4);
            this.InputPanel.Controls.Add(this.ComboBox);
            this.InputPanel.Controls.Add(this.Category);
            this.InputPanel.Location = new System.Drawing.Point(12, 46);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(349, 116);
            this.InputPanel.TabIndex = 28;
            // 
            // ItemImage
            // 
            this.ItemImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ItemImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ItemImage.BackgroundImage")));
            this.ItemImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ItemImage.InitialImage = null;
            this.ItemImage.Location = new System.Drawing.Point(5, 3);
            this.ItemImage.Name = "ItemImage";
            this.ItemImage.Size = new System.Drawing.Size(113, 110);
            this.ItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ItemImage.TabIndex = 36;
            this.ItemImage.TabStop = false;
            this.ItemImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Quantity
            // 
            this.Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Quantity.BackColor = System.Drawing.Color.White;
            this.Quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Quantity.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quantity.Location = new System.Drawing.Point(239, 79);
            this.Quantity.Margin = new System.Windows.Forms.Padding(2);
            this.Quantity.Name = "Quantity";
            this.Quantity.PlaceholderText = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(104, 22);
            this.Quantity.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Location = new System.Drawing.Point(239, 103);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(105, 2);
            this.panel3.TabIndex = 39;
            // 
            // Price
            // 
            this.Price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Price.BackColor = System.Drawing.Color.White;
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Price.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price.Location = new System.Drawing.Point(123, 79);
            this.Price.Margin = new System.Windows.Forms.Padding(2);
            this.Price.Name = "Price";
            this.Price.PlaceholderText = "Price";
            this.Price.Size = new System.Drawing.Size(104, 22);
            this.Price.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Location = new System.Drawing.Point(122, 103);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 2);
            this.panel2.TabIndex = 31;
            // 
            // Item
            // 
            this.Item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Item.BackColor = System.Drawing.Color.White;
            this.Item.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Item.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Item.Location = new System.Drawing.Point(123, 45);
            this.Item.Margin = new System.Windows.Forms.Padding(2);
            this.Item.Name = "Item";
            this.Item.PlaceholderText = "Item Name";
            this.Item.Size = new System.Drawing.Size(220, 22);
            this.Item.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Location = new System.Drawing.Point(122, 69);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 2);
            this.panel4.TabIndex = 29;
            // 
            // ComboBox
            // 
            this.ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBox.DropDownHeight = 128;
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBox.ForeColor = System.Drawing.Color.Black;
            this.ComboBox.IntegralHeight = false;
            this.ComboBox.ItemHeight = 21;
            this.ComboBox.Location = new System.Drawing.Point(122, 9);
            this.ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox.MaxDropDownItems = 4;
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(222, 29);
            this.ComboBox.TabIndex = 37;
            this.ComboBox.DropDown += new System.EventHandler(this.ComboBox_DropDown);
            this.ComboBox.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_SelectionChangeCommitted);
            this.ComboBox.DropDownClosed += new System.EventHandler(this.ComboBox_DropDownClosed);
            // 
            // Category
            // 
            this.Category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Category.BackColor = System.Drawing.Color.White;
            this.Category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Category.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Category.Location = new System.Drawing.Point(125, 12);
            this.Category.Margin = new System.Windows.Forms.Padding(2);
            this.Category.Name = "Category";
            this.Category.PlaceholderText = "Category";
            this.Category.Size = new System.Drawing.Size(94, 22);
            this.Category.TabIndex = 38;
            // 
            // BtnTwo
            // 
            this.BtnTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.BtnTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTwo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTwo.ForeColor = System.Drawing.Color.White;
            this.BtnTwo.Location = new System.Drawing.Point(278, 171);
            this.BtnTwo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(78, 33);
            this.BtnTwo.TabIndex = 31;
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
            this.BtnOne.Location = new System.Drawing.Point(17, 171);
            this.BtnOne.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(78, 33);
            this.BtnOne.TabIndex = 30;
            this.BtnOne.Text = "Add";
            this.BtnOne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnOne.UseVisualStyleBackColor = false;
            this.BtnOne.Click += new System.EventHandler(this.BtnOne_Click);
            // 
            // MessagePanel
            // 
            this.MessagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessagePanel.BackColor = System.Drawing.Color.White;
            this.MessagePanel.Controls.Add(this.MessageText);
            this.MessagePanel.Location = new System.Drawing.Point(12, 42);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(349, 71);
            this.MessagePanel.TabIndex = 32;
            // 
            // MessageText
            // 
            this.MessageText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MessageText.Location = new System.Drawing.Point(5, 0);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(338, 61);
            this.MessageText.TabIndex = 0;
            this.MessageText.Text = "Do you really want to delete item ";
            this.MessageText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 215);
            this.Controls.Add(this.BtnTwo);
            this.Controls.Add(this.BtnOne);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.MessagePanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = ".";
            this.Load += new System.EventHandler(this.ItemPrompt_Load);
            this.panel1.ResumeLayout(false);
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).EndInit();
            this.MessagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label HeaderText;
        private Panel InputPanel;
        public TextBox Price;
        private Panel panel2;
        public TextBox Item;
        private Panel panel4;
        public ComboBox ComboBox;
        private Button BtnTwo;
        private Button BtnOne;
        private Panel MessagePanel;
        private Label MessageText;
        public TextBox Category;
        public PictureBox ItemImage;
        public TextBox Quantity;
        private Panel panel3;
    }
}