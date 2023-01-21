namespace SalesInventoryApp
{
    partial class Category
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddCategoryBtn = new FontAwesome.Sharp.IconButton();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.CategoryTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NoLabel = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCategoryBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.AddCategoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCategoryBtn.FlatAppearance.BorderSize = 0;
            this.AddCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCategoryBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddCategoryBtn.ForeColor = System.Drawing.Color.White;
            this.AddCategoryBtn.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.AddCategoryBtn.IconColor = System.Drawing.Color.White;
            this.AddCategoryBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddCategoryBtn.IconSize = 35;
            this.AddCategoryBtn.Location = new System.Drawing.Point(762, 454);
            this.AddCategoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.AddCategoryBtn.Size = new System.Drawing.Size(154, 46);
            this.AddCategoryBtn.TabIndex = 21;
            this.AddCategoryBtn.Text = "Add Category";
            this.AddCategoryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddCategoryBtn.UseVisualStyleBackColor = false;
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // ActionLabel
            // 
            this.ActionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionLabel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ActionLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ActionLabel.ForeColor = System.Drawing.Color.White;
            this.ActionLabel.Location = new System.Drawing.Point(806, 72);
            this.ActionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(109, 33);
            this.ActionLabel.TabIndex = 20;
            this.ActionLabel.Text = "Action";
            this.ActionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryTable
            // 
            this.CategoryTable.AllowUserToAddRows = false;
            this.CategoryTable.AllowUserToDeleteRows = false;
            this.CategoryTable.AllowUserToResizeColumns = false;
            this.CategoryTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.CategoryTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.CategoryTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoryTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.CategoryTable.ColumnHeadersHeight = 35;
            this.CategoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CategoryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.ColumnEdit,
            this.ColumnDelete});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryTable.DefaultCellStyle = dataGridViewCellStyle16;
            this.CategoryTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CategoryTable.EnableHeadersVisualStyles = false;
            this.CategoryTable.GridColor = System.Drawing.Color.DarkGray;
            this.CategoryTable.Location = new System.Drawing.Point(17, 70);
            this.CategoryTable.Margin = new System.Windows.Forms.Padding(2);
            this.CategoryTable.MultiSelect = false;
            this.CategoryTable.Name = "CategoryTable";
            this.CategoryTable.ReadOnly = true;
            this.CategoryTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.CategoryTable.RowHeadersVisible = false;
            this.CategoryTable.RowHeadersWidth = 62;
            this.CategoryTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            this.CategoryTable.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.CategoryTable.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CategoryTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.CategoryTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.CategoryTable.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.CategoryTable.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CategoryTable.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryTable.RowTemplate.Height = 30;
            this.CategoryTable.RowTemplate.ReadOnly = true;
            this.CategoryTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CategoryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoryTable.ShowCellErrors = false;
            this.CategoryTable.ShowCellToolTips = false;
            this.CategoryTable.ShowEditingIcon = false;
            this.CategoryTable.ShowRowErrors = false;
            this.CategoryTable.Size = new System.Drawing.Size(899, 366);
            this.CategoryTable.TabIndex = 19;
            this.CategoryTable.TabStop = false;
            this.CategoryTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryTable_CellContentClick);
            this.CategoryTable.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryTable_CellMouseEnter);
            this.CategoryTable.SelectionChanged += new System.EventHandler(this.CategoryTable_SelectionChanged);
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
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Category";
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
            this.NoLabel.TabIndex = 22;
            this.NoLabel.Text = "No Category";
            this.NoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column1.FillWeight = 16.49484F;
            this.Column1.HeaderText = "Category ID";
            this.Column1.MinimumWidth = 200;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column2.FillWeight = 183.5052F;
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 300;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnEdit
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle14.NullValue")));
            this.ColumnEdit.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColumnEdit.HeaderText = "";
            this.ColumnEdit.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEdit.Image")));
            this.ColumnEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ColumnEdit.MinimumWidth = 55;
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            this.ColumnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnEdit.Width = 55;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle15.NullValue")));
            this.ColumnDelete.DefaultCellStyle = dataGridViewCellStyle15;
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.Image = ((System.Drawing.Image)(resources.GetObject("ColumnDelete.Image")));
            this.ColumnDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ColumnDelete.MinimumWidth = 55;
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDelete.Width = 55;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(932, 518);
            this.Controls.Add(this.NoLabel);
            this.Controls.Add(this.AddCategoryBtn);
            this.Controls.Add(this.ActionLabel);
            this.Controls.Add(this.CategoryTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton AddCategoryBtn;
        private Label ActionLabel;
        public DataGridView CategoryTable;
        private Panel panel1;
        private Label label1;
        private Label NoLabel;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewImageColumn ColumnEdit;
        private DataGridViewImageColumn ColumnDelete;
    }
}