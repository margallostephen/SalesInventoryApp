namespace SalesInventoryApp
{
    partial class SellItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeaderText = new System.Windows.Forms.Label();
            this.ItemPreviewPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RemainingQuantity = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MinusQuantityBtn = new FontAwesome.Sharp.IconButton();
            this.AddQuantityBtn = new FontAwesome.Sharp.IconButton();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ItemName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemImage = new System.Windows.Forms.PictureBox();
            this.ItemSelectionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SellBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.ItemPreviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.HeaderText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 40);
            this.panel1.TabIndex = 7;
            // 
            // HeaderText
            // 
            this.HeaderText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderText.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeaderText.ForeColor = System.Drawing.Color.White;
            this.HeaderText.Location = new System.Drawing.Point(0, 0);
            this.HeaderText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(554, 40);
            this.HeaderText.TabIndex = 5;
            this.HeaderText.Text = "Sell Item";
            this.HeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemPreviewPanel
            // 
            this.ItemPreviewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemPreviewPanel.BackColor = System.Drawing.Color.White;
            this.ItemPreviewPanel.Controls.Add(this.panel3);
            this.ItemPreviewPanel.Controls.Add(this.RemainingQuantity);
            this.ItemPreviewPanel.Controls.Add(this.label7);
            this.ItemPreviewPanel.Controls.Add(this.MinusQuantityBtn);
            this.ItemPreviewPanel.Controls.Add(this.AddQuantityBtn);
            this.ItemPreviewPanel.Controls.Add(this.TotalAmount);
            this.ItemPreviewPanel.Controls.Add(this.Price);
            this.ItemPreviewPanel.Controls.Add(this.Category);
            this.ItemPreviewPanel.Controls.Add(this.Quantity);
            this.ItemPreviewPanel.Controls.Add(this.panel2);
            this.ItemPreviewPanel.Controls.Add(this.ItemName);
            this.ItemPreviewPanel.Controls.Add(this.panel4);
            this.ItemPreviewPanel.Controls.Add(this.label6);
            this.ItemPreviewPanel.Controls.Add(this.label5);
            this.ItemPreviewPanel.Controls.Add(this.label4);
            this.ItemPreviewPanel.Controls.Add(this.label3);
            this.ItemPreviewPanel.Controls.Add(this.label2);
            this.ItemPreviewPanel.Controls.Add(this.ItemImage);
            this.ItemPreviewPanel.Location = new System.Drawing.Point(12, 177);
            this.ItemPreviewPanel.Name = "ItemPreviewPanel";
            this.ItemPreviewPanel.Size = new System.Drawing.Size(530, 209);
            this.ItemPreviewPanel.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 2);
            this.panel3.TabIndex = 60;
            // 
            // RemainingQuantity
            // 
            this.RemainingQuantity.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemainingQuantity.ForeColor = System.Drawing.Color.Black;
            this.RemainingQuantity.Location = new System.Drawing.Point(303, 107);
            this.RemainingQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RemainingQuantity.Name = "RemainingQuantity";
            this.RemainingQuantity.Size = new System.Drawing.Size(216, 21);
            this.RemainingQuantity.TabIndex = 59;
            this.RemainingQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(174, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 58;
            this.label7.Text = "Remaining Qty";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MinusQuantityBtn
            // 
            this.MinusQuantityBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinusQuantityBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.MinusQuantityBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinusQuantityBtn.FlatAppearance.BorderSize = 0;
            this.MinusQuantityBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusQuantityBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinusQuantityBtn.ForeColor = System.Drawing.Color.White;
            this.MinusQuantityBtn.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            this.MinusQuantityBtn.IconColor = System.Drawing.Color.White;
            this.MinusQuantityBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinusQuantityBtn.IconSize = 25;
            this.MinusQuantityBtn.Location = new System.Drawing.Point(496, 130);
            this.MinusQuantityBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MinusQuantityBtn.Name = "MinusQuantityBtn";
            this.MinusQuantityBtn.Size = new System.Drawing.Size(34, 32);
            this.MinusQuantityBtn.TabIndex = 57;
            this.MinusQuantityBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MinusQuantityBtn.UseVisualStyleBackColor = false;
            this.MinusQuantityBtn.Click += new System.EventHandler(this.MinusQuantityBtn_Click);
            // 
            // AddQuantityBtn
            // 
            this.AddQuantityBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddQuantityBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.AddQuantityBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddQuantityBtn.FlatAppearance.BorderSize = 0;
            this.AddQuantityBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddQuantityBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddQuantityBtn.ForeColor = System.Drawing.Color.White;
            this.AddQuantityBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AddQuantityBtn.IconColor = System.Drawing.Color.White;
            this.AddQuantityBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddQuantityBtn.IconSize = 25;
            this.AddQuantityBtn.Location = new System.Drawing.Point(452, 130);
            this.AddQuantityBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddQuantityBtn.Name = "AddQuantityBtn";
            this.AddQuantityBtn.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.AddQuantityBtn.Size = new System.Drawing.Size(34, 32);
            this.AddQuantityBtn.TabIndex = 56;
            this.AddQuantityBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddQuantityBtn.UseVisualStyleBackColor = false;
            this.AddQuantityBtn.Click += new System.EventHandler(this.AddQuantityBtn_Click);
            // 
            // TotalAmount
            // 
            this.TotalAmount.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalAmount.ForeColor = System.Drawing.Color.Black;
            this.TotalAmount.Location = new System.Drawing.Point(303, 181);
            this.TotalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(216, 21);
            this.TotalAmount.TabIndex = 55;
            this.TotalAmount.Text = "0.00";
            this.TotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price.ForeColor = System.Drawing.Color.Black;
            this.Price.Location = new System.Drawing.Point(303, 47);
            this.Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(216, 21);
            this.Price.TabIndex = 52;
            this.Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Category
            // 
            this.Category.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Category.ForeColor = System.Drawing.Color.Black;
            this.Category.Location = new System.Drawing.Point(303, 77);
            this.Category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(216, 21);
            this.Category.TabIndex = 53;
            this.Category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Quantity.ForeColor = System.Drawing.Color.Black;
            this.Quantity.Location = new System.Drawing.Point(303, 137);
            this.Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(137, 21);
            this.Quantity.TabIndex = 54;
            this.Quantity.Text = "0";
            this.Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Location = new System.Drawing.Point(296, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 206);
            this.panel2.TabIndex = 52;
            // 
            // ItemName
            // 
            this.ItemName.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemName.ForeColor = System.Drawing.Color.Black;
            this.ItemName.Location = new System.Drawing.Point(303, 17);
            this.ItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(216, 21);
            this.ItemName.TabIndex = 51;
            this.ItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Location = new System.Drawing.Point(0, 173);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(530, 2);
            this.panel4.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(174, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 49;
            this.label6.Text = "Total Amount";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(174, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 48;
            this.label5.Text = "Quantity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(174, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "Category";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(174, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 46;
            this.label3.Text = "Price";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(174, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Item Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ItemImage
            // 
            this.ItemImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ItemImage.Location = new System.Drawing.Point(0, 9);
            this.ItemImage.Name = "ItemImage";
            this.ItemImage.Size = new System.Drawing.Size(169, 156);
            this.ItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ItemImage.TabIndex = 0;
            this.ItemImage.TabStop = false;
            // 
            // ItemSelectionPanel
            // 
            this.ItemSelectionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemSelectionPanel.AutoScroll = true;
            this.ItemSelectionPanel.BackColor = System.Drawing.Color.White;
            this.ItemSelectionPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ItemSelectionPanel.Location = new System.Drawing.Point(12, 76);
            this.ItemSelectionPanel.Name = "ItemSelectionPanel";
            this.ItemSelectionPanel.Size = new System.Drawing.Size(530, 101);
            this.ItemSelectionPanel.TabIndex = 41;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(464, 388);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(78, 33);
            this.CancelBtn.TabIndex = 43;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SellBtn
            // 
            this.SellBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SellBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.SellBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SellBtn.ForeColor = System.Drawing.Color.White;
            this.SellBtn.Location = new System.Drawing.Point(12, 388);
            this.SellBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SellBtn.Name = "SellBtn";
            this.SellBtn.Size = new System.Drawing.Size(78, 33);
            this.SellBtn.TabIndex = 42;
            this.SellBtn.Text = "Sell";
            this.SellBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SellBtn.UseVisualStyleBackColor = false;
            this.SellBtn.Click += new System.EventHandler(this.SellBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 26);
            this.label1.TabIndex = 44;
            this.label1.Text = "Select item below";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel5.Location = new System.Drawing.Point(12, 74);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(530, 2);
            this.panel5.TabIndex = 51;
            // 
            // SellItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 432);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SellBtn);
            this.Controls.Add(this.ItemSelectionPanel);
            this.Controls.Add(this.ItemPreviewPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SellItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sell Item";
            this.Load += new System.EventHandler(this.SellItem_Load);
            this.panel1.ResumeLayout(false);
            this.ItemPreviewPanel.ResumeLayout(false);
            this.ItemPreviewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Label HeaderText;
        private Panel ItemPreviewPanel;
        private FlowLayoutPanel ItemSelectionPanel;
        private Button CancelBtn;
        private Button SellBtn;
        private Label label1;
        private PictureBox ItemImage;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label TotalAmount;
        private Label Price;
        private Label Category;
        private Label Quantity;
        private Panel panel2;
        private Label ItemName;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton MinusQuantityBtn;
        private FontAwesome.Sharp.IconButton AddQuantityBtn;
        private Label label7;
        private Label RemainingQuantity;
        private Panel panel3;
        private Panel panel5;
    }
}