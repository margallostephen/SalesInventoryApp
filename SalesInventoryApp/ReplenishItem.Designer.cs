namespace SalesInventoryApp
{
    partial class ReplenishItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplenishItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeaderText = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemSelectionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ItemImage = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ItemPreviewPanel = new System.Windows.Forms.Panel();
            this.NewQuantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MinusQuantityBtn = new FontAwesome.Sharp.IconButton();
            this.AddQuantityBtn = new FontAwesome.Sharp.IconButton();
            this.AddQuantity = new System.Windows.Forms.Label();
            this.RemainingQuantity = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ReplenishBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).BeginInit();
            this.ItemPreviewPanel.SuspendLayout();
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
            this.panel1.TabIndex = 8;
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
            this.HeaderText.Text = "Replenish Item";
            this.HeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel5.Location = new System.Drawing.Point(11, 75);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(532, 2);
            this.panel5.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 26);
            this.label1.TabIndex = 54;
            this.label1.Text = "Select item below";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ItemSelectionPanel
            // 
            this.ItemSelectionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemSelectionPanel.AutoScroll = true;
            this.ItemSelectionPanel.BackColor = System.Drawing.Color.White;
            this.ItemSelectionPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ItemSelectionPanel.Location = new System.Drawing.Point(11, 78);
            this.ItemSelectionPanel.Name = "ItemSelectionPanel";
            this.ItemSelectionPanel.Size = new System.Drawing.Size(532, 101);
            this.ItemSelectionPanel.TabIndex = 53;
            // 
            // ItemImage
            // 
            this.ItemImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ItemImage.Location = new System.Drawing.Point(0, 9);
            this.ItemImage.Name = "ItemImage";
            this.ItemImage.Size = new System.Drawing.Size(168, 134);
            this.ItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ItemImage.TabIndex = 0;
            this.ItemImage.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Location = new System.Drawing.Point(0, 150);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(531, 2);
            this.panel4.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 2);
            this.panel3.TabIndex = 60;
            // 
            // ItemPreviewPanel
            // 
            this.ItemPreviewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemPreviewPanel.BackColor = System.Drawing.Color.White;
            this.ItemPreviewPanel.Controls.Add(this.NewQuantity);
            this.ItemPreviewPanel.Controls.Add(this.label3);
            this.ItemPreviewPanel.Controls.Add(this.MinusQuantityBtn);
            this.ItemPreviewPanel.Controls.Add(this.AddQuantityBtn);
            this.ItemPreviewPanel.Controls.Add(this.AddQuantity);
            this.ItemPreviewPanel.Controls.Add(this.RemainingQuantity);
            this.ItemPreviewPanel.Controls.Add(this.ItemName);
            this.ItemPreviewPanel.Controls.Add(this.label5);
            this.ItemPreviewPanel.Controls.Add(this.label7);
            this.ItemPreviewPanel.Controls.Add(this.label2);
            this.ItemPreviewPanel.Controls.Add(this.panel3);
            this.ItemPreviewPanel.Controls.Add(this.panel4);
            this.ItemPreviewPanel.Controls.Add(this.ItemImage);
            this.ItemPreviewPanel.Location = new System.Drawing.Point(11, 179);
            this.ItemPreviewPanel.Name = "ItemPreviewPanel";
            this.ItemPreviewPanel.Size = new System.Drawing.Size(531, 154);
            this.ItemPreviewPanel.TabIndex = 52;
            // 
            // NewQuantity
            // 
            this.NewQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewQuantity.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewQuantity.ForeColor = System.Drawing.Color.Black;
            this.NewQuantity.Location = new System.Drawing.Point(172, 110);
            this.NewQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewQuantity.Name = "NewQuantity";
            this.NewQuantity.Size = new System.Drawing.Size(170, 21);
            this.NewQuantity.TabIndex = 70;
            this.NewQuantity.Text = "0";
            this.NewQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(173, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 69;
            this.label3.Text = "New Quantity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.MinusQuantityBtn.Location = new System.Drawing.Point(498, 105);
            this.MinusQuantityBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MinusQuantityBtn.Name = "MinusQuantityBtn";
            this.MinusQuantityBtn.Size = new System.Drawing.Size(34, 32);
            this.MinusQuantityBtn.TabIndex = 68;
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
            this.AddQuantityBtn.Location = new System.Drawing.Point(454, 105);
            this.AddQuantityBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddQuantityBtn.Name = "AddQuantityBtn";
            this.AddQuantityBtn.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.AddQuantityBtn.Size = new System.Drawing.Size(34, 32);
            this.AddQuantityBtn.TabIndex = 67;
            this.AddQuantityBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddQuantityBtn.UseVisualStyleBackColor = false;
            this.AddQuantityBtn.Click += new System.EventHandler(this.AddQuantityBtn_Click);
            // 
            // AddQuantity
            // 
            this.AddQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddQuantity.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddQuantity.ForeColor = System.Drawing.Color.Black;
            this.AddQuantity.Location = new System.Drawing.Point(357, 63);
            this.AddQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddQuantity.Name = "AddQuantity";
            this.AddQuantity.Size = new System.Drawing.Size(170, 21);
            this.AddQuantity.TabIndex = 66;
            this.AddQuantity.Text = "0";
            this.AddQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RemainingQuantity
            // 
            this.RemainingQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemainingQuantity.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemainingQuantity.ForeColor = System.Drawing.Color.Black;
            this.RemainingQuantity.Location = new System.Drawing.Point(172, 63);
            this.RemainingQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RemainingQuantity.Name = "RemainingQuantity";
            this.RemainingQuantity.Size = new System.Drawing.Size(176, 21);
            this.RemainingQuantity.TabIndex = 65;
            this.RemainingQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ItemName
            // 
            this.ItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemName.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemName.ForeColor = System.Drawing.Color.Black;
            this.ItemName.Location = new System.Drawing.Point(265, 9);
            this.ItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(262, 21);
            this.ItemName.TabIndex = 64;
            this.ItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(358, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 63;
            this.label5.Text = "Add Quantity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(173, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 62;
            this.label7.Text = "Remaining Qty";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(173, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 61;
            this.label2.Text = "Item Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(59)))), ((int)(((byte)(46)))));
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(464, 339);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(78, 33);
            this.CancelBtn.TabIndex = 57;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ReplenishBtn
            // 
            this.ReplenishBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReplenishBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.ReplenishBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReplenishBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplenishBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReplenishBtn.ForeColor = System.Drawing.Color.White;
            this.ReplenishBtn.Location = new System.Drawing.Point(11, 339);
            this.ReplenishBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReplenishBtn.Name = "ReplenishBtn";
            this.ReplenishBtn.Size = new System.Drawing.Size(106, 33);
            this.ReplenishBtn.TabIndex = 56;
            this.ReplenishBtn.Text = "Replenish";
            this.ReplenishBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ReplenishBtn.UseVisualStyleBackColor = false;
            this.ReplenishBtn.Click += new System.EventHandler(this.ReplenishBtn_Click);
            // 
            // ReplenishItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 381);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ReplenishBtn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemSelectionPanel);
            this.Controls.Add(this.ItemPreviewPanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReplenishItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Replenish Item";
            this.Load += new System.EventHandler(this.ReplenishItem_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).EndInit();
            this.ItemPreviewPanel.ResumeLayout(false);
            this.ItemPreviewPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label HeaderText;
        private Panel panel5;
        private Label label1;
        private FlowLayoutPanel ItemSelectionPanel;
        private PictureBox ItemImage;
        private Panel panel4;
        private Panel panel3;
        private Panel ItemPreviewPanel;
        private Label label2;
        private Label label7;
        private Label label5;
        private Label ItemName;
        private Label RemainingQuantity;
        private Label AddQuantity;
        private FontAwesome.Sharp.IconButton MinusQuantityBtn;
        private FontAwesome.Sharp.IconButton AddQuantityBtn;
        private Button CancelBtn;
        private Button ReplenishBtn;
        private Label NewQuantity;
        private Label label3;
    }
}