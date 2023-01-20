namespace SalesInventoryApp
{
    partial class Delivery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery));
            this.NoLabel = new System.Windows.Forms.Label();
            this.ReplenishItemBtn = new FontAwesome.Sharp.IconButton();
            this.DeliveryTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // NoLabel
            // 
            this.NoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.NoLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NoLabel.ForeColor = System.Drawing.Color.Black;
            this.NoLabel.Location = new System.Drawing.Point(28, 114);
            this.NoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoLabel.Name = "NoLabel";
            this.NoLabel.Size = new System.Drawing.Size(877, 312);
            this.NoLabel.TabIndex = 45;
            this.NoLabel.Text = "No Delivery";
            this.NoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReplenishItemBtn
            // 
            this.ReplenishItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReplenishItemBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.ReplenishItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReplenishItemBtn.FlatAppearance.BorderSize = 0;
            this.ReplenishItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplenishItemBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReplenishItemBtn.ForeColor = System.Drawing.Color.White;
            this.ReplenishItemBtn.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            this.ReplenishItemBtn.IconColor = System.Drawing.Color.White;
            this.ReplenishItemBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReplenishItemBtn.IconSize = 35;
            this.ReplenishItemBtn.Location = new System.Drawing.Point(762, 454);
            this.ReplenishItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReplenishItemBtn.Name = "ReplenishItemBtn";
            this.ReplenishItemBtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ReplenishItemBtn.Size = new System.Drawing.Size(154, 46);
            this.ReplenishItemBtn.TabIndex = 44;
            this.ReplenishItemBtn.Text = "Replenish Item";
            this.ReplenishItemBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReplenishItemBtn.UseVisualStyleBackColor = false;
            this.ReplenishItemBtn.Click += new System.EventHandler(this.ReplenishItemBtn_Click);
            // 
            // DeliveryTable
            // 
            this.DeliveryTable.AllowUserToAddRows = false;
            this.DeliveryTable.AllowUserToDeleteRows = false;
            this.DeliveryTable.AllowUserToResizeColumns = false;
            this.DeliveryTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeliveryTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DeliveryTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.DeliveryTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DeliveryTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeliveryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DeliveryTable.ColumnHeadersHeight = 35;
            this.DeliveryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DeliveryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeliveryTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.DeliveryTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DeliveryTable.EnableHeadersVisualStyles = false;
            this.DeliveryTable.GridColor = System.Drawing.Color.DarkGray;
            this.DeliveryTable.Location = new System.Drawing.Point(17, 70);
            this.DeliveryTable.Margin = new System.Windows.Forms.Padding(2);
            this.DeliveryTable.MultiSelect = false;
            this.DeliveryTable.Name = "DeliveryTable";
            this.DeliveryTable.ReadOnly = true;
            this.DeliveryTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeliveryTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DeliveryTable.RowHeadersVisible = false;
            this.DeliveryTable.RowHeadersWidth = 62;
            this.DeliveryTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.DeliveryTable.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DeliveryTable.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DeliveryTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.DeliveryTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DeliveryTable.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.DeliveryTable.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DeliveryTable.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeliveryTable.RowTemplate.Height = 30;
            this.DeliveryTable.RowTemplate.ReadOnly = true;
            this.DeliveryTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeliveryTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DeliveryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeliveryTable.ShowCellErrors = false;
            this.DeliveryTable.ShowCellToolTips = false;
            this.DeliveryTable.ShowEditingIcon = false;
            this.DeliveryTable.ShowRowErrors = false;
            this.DeliveryTable.Size = new System.Drawing.Size(899, 366);
            this.DeliveryTable.TabIndex = 43;
            this.DeliveryTable.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.FillWeight = 16.49484F;
            this.Column1.HeaderText = "Delivery ID";
            this.Column1.MinimumWidth = 120;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.FillWeight = 183.5052F;
            this.Column2.HeaderText = "Date";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Item ID";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 115;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Supplier ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Location = new System.Drawing.Point(17, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 2);
            this.panel1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 37);
            this.label1.TabIndex = 41;
            this.label1.Text = "Delivery";
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(932, 518);
            this.Controls.Add(this.NoLabel);
            this.Controls.Add(this.ReplenishItemBtn);
            this.Controls.Add(this.DeliveryTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Delivery";
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.Delivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label NoLabel;
        private FontAwesome.Sharp.IconButton ReplenishItemBtn;
        public DataGridView DeliveryTable;
        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}