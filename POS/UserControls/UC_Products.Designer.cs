namespace POS.UserControls
{
	partial class UC_Products
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelListings = new System.Windows.Forms.Panel();
			this.btnInStock = new FontAwesome.Sharp.IconButton();
			this.btnOutOfStock = new FontAwesome.Sharp.IconButton();
			this.btnExpired = new FontAwesome.Sharp.IconButton();
			this.btnDormant = new FontAwesome.Sharp.IconButton();
			this.btnReturned = new FontAwesome.Sharp.IconButton();
			this.btnInShelves = new FontAwesome.Sharp.IconButton();
			this.btnInStore = new FontAwesome.Sharp.IconButton();
			this.btnAll = new FontAwesome.Sharp.IconButton();
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnSettings = new FontAwesome.Sharp.IconPictureBox();
			this.btnDelete = new FontAwesome.Sharp.IconPictureBox();
			this.btnExportToExcel = new FontAwesome.Sharp.IconPictureBox();
			this.btnEdit = new FontAwesome.Sharp.IconPictureBox();
			this.btnAdd = new FontAwesome.Sharp.IconPictureBox();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shapeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.marginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityInStoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityInShelvesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.netProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityInBoxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shelfCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.alertThresholdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityMaxInShelveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.storeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.panelListings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExportToExcel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
			this.SuspendLayout();
			// 
			// panelListings
			// 
			this.panelListings.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panelListings.BackColor = System.Drawing.Color.Transparent;
			this.panelListings.Controls.Add(this.btnInStock);
			this.panelListings.Controls.Add(this.btnOutOfStock);
			this.panelListings.Controls.Add(this.btnExpired);
			this.panelListings.Controls.Add(this.btnDormant);
			this.panelListings.Controls.Add(this.btnReturned);
			this.panelListings.Controls.Add(this.btnInShelves);
			this.panelListings.Controls.Add(this.btnInStore);
			this.panelListings.Controls.Add(this.btnAll);
			this.panelListings.Location = new System.Drawing.Point(116, 24);
			this.panelListings.Name = "panelListings";
			this.panelListings.Size = new System.Drawing.Size(848, 49);
			this.panelListings.TabIndex = 11;
			// 
			// btnInStock
			// 
			this.btnInStock.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnInStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInStock.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnInStock.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnInStock.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnInStock.IconColor = System.Drawing.Color.Black;
			this.btnInStock.IconSize = 16;
			this.btnInStock.Location = new System.Drawing.Point(735, 0);
			this.btnInStock.Name = "btnInStock";
			this.btnInStock.Rotation = 0D;
			this.btnInStock.Size = new System.Drawing.Size(105, 49);
			this.btnInStock.TabIndex = 123;
			this.btnInStock.Text = "With Stock";
			this.btnInStock.UseVisualStyleBackColor = true;
			// 
			// btnOutOfStock
			// 
			this.btnOutOfStock.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnOutOfStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOutOfStock.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnOutOfStock.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnOutOfStock.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnOutOfStock.IconColor = System.Drawing.Color.Black;
			this.btnOutOfStock.IconSize = 16;
			this.btnOutOfStock.Location = new System.Drawing.Point(630, 0);
			this.btnOutOfStock.Name = "btnOutOfStock";
			this.btnOutOfStock.Rotation = 0D;
			this.btnOutOfStock.Size = new System.Drawing.Size(105, 49);
			this.btnOutOfStock.TabIndex = 122;
			this.btnOutOfStock.Text = "Out of Stock";
			this.btnOutOfStock.UseVisualStyleBackColor = true;
			// 
			// btnExpired
			// 
			this.btnExpired.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnExpired.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExpired.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnExpired.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnExpired.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnExpired.IconColor = System.Drawing.Color.Black;
			this.btnExpired.IconSize = 16;
			this.btnExpired.Location = new System.Drawing.Point(525, 0);
			this.btnExpired.Name = "btnExpired";
			this.btnExpired.Rotation = 0D;
			this.btnExpired.Size = new System.Drawing.Size(105, 49);
			this.btnExpired.TabIndex = 121;
			this.btnExpired.Text = "Expired";
			this.btnExpired.UseVisualStyleBackColor = true;
			// 
			// btnDormant
			// 
			this.btnDormant.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnDormant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDormant.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnDormant.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnDormant.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnDormant.IconColor = System.Drawing.Color.Black;
			this.btnDormant.IconSize = 16;
			this.btnDormant.Location = new System.Drawing.Point(420, 0);
			this.btnDormant.Name = "btnDormant";
			this.btnDormant.Rotation = 0D;
			this.btnDormant.Size = new System.Drawing.Size(105, 49);
			this.btnDormant.TabIndex = 120;
			this.btnDormant.Text = "Dormant";
			this.btnDormant.UseVisualStyleBackColor = true;
			// 
			// btnReturned
			// 
			this.btnReturned.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnReturned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReturned.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnReturned.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnReturned.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnReturned.IconColor = System.Drawing.Color.Black;
			this.btnReturned.IconSize = 16;
			this.btnReturned.Location = new System.Drawing.Point(315, 0);
			this.btnReturned.Name = "btnReturned";
			this.btnReturned.Rotation = 0D;
			this.btnReturned.Size = new System.Drawing.Size(105, 49);
			this.btnReturned.TabIndex = 119;
			this.btnReturned.Text = "Returned";
			this.btnReturned.UseVisualStyleBackColor = true;
			// 
			// btnInShelves
			// 
			this.btnInShelves.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnInShelves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInShelves.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnInShelves.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnInShelves.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnInShelves.IconColor = System.Drawing.Color.Black;
			this.btnInShelves.IconSize = 16;
			this.btnInShelves.Location = new System.Drawing.Point(210, 0);
			this.btnInShelves.Name = "btnInShelves";
			this.btnInShelves.Rotation = 0D;
			this.btnInShelves.Size = new System.Drawing.Size(105, 49);
			this.btnInShelves.TabIndex = 118;
			this.btnInShelves.Text = "In Shelves";
			this.btnInShelves.UseVisualStyleBackColor = true;
			// 
			// btnInStore
			// 
			this.btnInStore.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnInStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInStore.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnInStore.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnInStore.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnInStore.IconColor = System.Drawing.Color.Black;
			this.btnInStore.IconSize = 16;
			this.btnInStore.Location = new System.Drawing.Point(105, 0);
			this.btnInStore.Name = "btnInStore";
			this.btnInStore.Rotation = 0D;
			this.btnInStore.Size = new System.Drawing.Size(105, 49);
			this.btnInStore.TabIndex = 117;
			this.btnInStore.Text = "In Store";
			this.btnInStore.UseVisualStyleBackColor = true;
			// 
			// btnAll
			// 
			this.btnAll.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAll.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnAll.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnAll.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnAll.IconColor = System.Drawing.Color.Black;
			this.btnAll.IconSize = 16;
			this.btnAll.Location = new System.Drawing.Point(0, 0);
			this.btnAll.Name = "btnAll";
			this.btnAll.Rotation = 0D;
			this.btnAll.Size = new System.Drawing.Size(105, 49);
			this.btnAll.TabIndex = 116;
			this.btnAll.Text = "All";
			this.btnAll.UseVisualStyleBackColor = true;
			// 
			// dg
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dg.AutoGenerateColumns = false;
			this.dg.BackgroundColor = System.Drawing.Color.Silver;
			this.dg.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.shapeDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.marginDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.quantityInStoreDataGridViewTextBoxColumn,
            this.quantityInShelvesDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.netProfitDataGridViewTextBoxColumn,
            this.quantityInBoxDataGridViewTextBoxColumn,
            this.shelfCodeDataGridViewTextBoxColumn,
            this.alertThresholdDataGridViewTextBoxColumn,
            this.quantityMaxInShelveDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.expiryDateDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.storeDataGridViewCheckBoxColumn});
			this.dg.DataSource = this.productBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dg.DefaultCellStyle = dataGridViewCellStyle3;
			this.dg.DoubleBuffered = true;
			this.dg.EnableHeadersVisualStyles = false;
			this.dg.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.dg.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.Location = new System.Drawing.Point(23, 92);
			this.dg.Name = "dg";
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.RowHeadersVisible = false;
			this.dg.Size = new System.Drawing.Size(1028, 454);
			this.dg.TabIndex = 104;
			this.dg.Paint += new System.Windows.Forms.PaintEventHandler(this.dg_Paint);
			// 
			// productBindingSource
			// 
			this.productBindingSource.DataSource = typeof(POS.Classes.Products.Product);
			// 
			// btnSettings
			// 
			this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSettings.BackColor = System.Drawing.Color.Silver;
			this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
			this.btnSettings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnSettings.IconSize = 26;
			this.btnSettings.Location = new System.Drawing.Point(1057, 205);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(26, 27);
			this.btnSettings.TabIndex = 103;
			this.btnSettings.TabStop = false;
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.BackColor = System.Drawing.Color.Silver;
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
			this.btnDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnDelete.IconSize = 26;
			this.btnDelete.Location = new System.Drawing.Point(1057, 149);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(26, 27);
			this.btnDelete.TabIndex = 102;
			this.btnDelete.TabStop = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnExportToExcel
			// 
			this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportToExcel.BackColor = System.Drawing.Color.Silver;
			this.btnExportToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExportToExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnExportToExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
			this.btnExportToExcel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnExportToExcel.IconSize = 26;
			this.btnExportToExcel.Location = new System.Drawing.Point(1057, 177);
			this.btnExportToExcel.Name = "btnExportToExcel";
			this.btnExportToExcel.Size = new System.Drawing.Size(26, 27);
			this.btnExportToExcel.TabIndex = 101;
			this.btnExportToExcel.TabStop = false;
			this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.BackColor = System.Drawing.Color.Silver;
			this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
			this.btnEdit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnEdit.IconSize = 26;
			this.btnEdit.Location = new System.Drawing.Point(1057, 121);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(26, 27);
			this.btnEdit.TabIndex = 99;
			this.btnEdit.TabStop = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.BackColor = System.Drawing.Color.Silver;
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnAdd.IconSize = 26;
			this.btnAdd.Location = new System.Drawing.Point(1057, 93);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(26, 27);
			this.btnAdd.TabIndex = 98;
			this.btnAdd.TabStop = false;
			this.btnAdd.UseGdi = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// shapeDataGridViewTextBoxColumn
			// 
			this.shapeDataGridViewTextBoxColumn.DataPropertyName = "Shape";
			this.shapeDataGridViewTextBoxColumn.HeaderText = "Shape";
			this.shapeDataGridViewTextBoxColumn.Name = "shapeDataGridViewTextBoxColumn";
			// 
			// purchasePriceDataGridViewTextBoxColumn
			// 
			this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
			this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "Purchase Price";
			this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
			// 
			// sellingPriceDataGridViewTextBoxColumn
			// 
			this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "SellingPrice";
			this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "Selling Price";
			this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
			// 
			// marginDataGridViewTextBoxColumn
			// 
			this.marginDataGridViewTextBoxColumn.DataPropertyName = "Margin";
			this.marginDataGridViewTextBoxColumn.HeaderText = "Margin";
			this.marginDataGridViewTextBoxColumn.Name = "marginDataGridViewTextBoxColumn";
			// 
			// weightDataGridViewTextBoxColumn
			// 
			this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
			this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
			this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
			// 
			// quantityInStoreDataGridViewTextBoxColumn
			// 
			this.quantityInStoreDataGridViewTextBoxColumn.DataPropertyName = "QuantityInStore";
			this.quantityInStoreDataGridViewTextBoxColumn.HeaderText = "In Store";
			this.quantityInStoreDataGridViewTextBoxColumn.Name = "quantityInStoreDataGridViewTextBoxColumn";
			// 
			// quantityInShelvesDataGridViewTextBoxColumn
			// 
			this.quantityInShelvesDataGridViewTextBoxColumn.DataPropertyName = "QuantityInShelves";
			this.quantityInShelvesDataGridViewTextBoxColumn.HeaderText = "In Shelves";
			this.quantityInShelvesDataGridViewTextBoxColumn.Name = "quantityInShelvesDataGridViewTextBoxColumn";
			// 
			// unitPriceDataGridViewTextBoxColumn
			// 
			this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
			this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price";
			this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
			// 
			// netProfitDataGridViewTextBoxColumn
			// 
			this.netProfitDataGridViewTextBoxColumn.DataPropertyName = "NetProfit";
			this.netProfitDataGridViewTextBoxColumn.HeaderText = "NetProfit";
			this.netProfitDataGridViewTextBoxColumn.Name = "netProfitDataGridViewTextBoxColumn";
			// 
			// quantityInBoxDataGridViewTextBoxColumn
			// 
			this.quantityInBoxDataGridViewTextBoxColumn.DataPropertyName = "QuantityInBox";
			this.quantityInBoxDataGridViewTextBoxColumn.HeaderText = "Quantity In Box";
			this.quantityInBoxDataGridViewTextBoxColumn.Name = "quantityInBoxDataGridViewTextBoxColumn";
			// 
			// shelfCodeDataGridViewTextBoxColumn
			// 
			this.shelfCodeDataGridViewTextBoxColumn.DataPropertyName = "ShelfCode";
			this.shelfCodeDataGridViewTextBoxColumn.HeaderText = "Shelf Code";
			this.shelfCodeDataGridViewTextBoxColumn.Name = "shelfCodeDataGridViewTextBoxColumn";
			// 
			// alertThresholdDataGridViewTextBoxColumn
			// 
			this.alertThresholdDataGridViewTextBoxColumn.DataPropertyName = "AlertThreshold";
			this.alertThresholdDataGridViewTextBoxColumn.HeaderText = "Alert Threshold";
			this.alertThresholdDataGridViewTextBoxColumn.Name = "alertThresholdDataGridViewTextBoxColumn";
			// 
			// quantityMaxInShelveDataGridViewTextBoxColumn
			// 
			this.quantityMaxInShelveDataGridViewTextBoxColumn.DataPropertyName = "QuantityMaxInShelve";
			this.quantityMaxInShelveDataGridViewTextBoxColumn.HeaderText = "Max In Shelve";
			this.quantityMaxInShelveDataGridViewTextBoxColumn.Name = "quantityMaxInShelveDataGridViewTextBoxColumn";
			// 
			// createdByDataGridViewTextBoxColumn
			// 
			this.createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
			this.createdByDataGridViewTextBoxColumn.HeaderText = "Created By";
			this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
			// 
			// dateCreatedDataGridViewTextBoxColumn
			// 
			this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
			this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "Date Created";
			this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
			// 
			// expiryDateDataGridViewTextBoxColumn
			// 
			this.expiryDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiryDate";
			this.expiryDateDataGridViewTextBoxColumn.HeaderText = "Expiry Date";
			this.expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
			// 
			// supplierNameDataGridViewTextBoxColumn
			// 
			this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
			this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier Name";
			this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
			// 
			// storeDataGridViewCheckBoxColumn
			// 
			this.storeDataGridViewCheckBoxColumn.DataPropertyName = "Store";
			this.storeDataGridViewCheckBoxColumn.HeaderText = "Store";
			this.storeDataGridViewCheckBoxColumn.Name = "storeDataGridViewCheckBoxColumn";
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this.dg;
			// 
			// UC_Products
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dg);
			this.Controls.Add(this.btnSettings);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.panelListings);
			this.Controls.Add(this.btnExportToExcel);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Name = "UC_Products";
			this.Size = new System.Drawing.Size(1085, 563);
			this.panelListings.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExportToExcel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelListings;
		private FontAwesome.Sharp.IconPictureBox btnSettings;
		private FontAwesome.Sharp.IconPictureBox btnDelete;
		private FontAwesome.Sharp.IconPictureBox btnExportToExcel;
		private FontAwesome.Sharp.IconPictureBox btnEdit;
		private FontAwesome.Sharp.IconPictureBox btnAdd;
		private FontAwesome.Sharp.IconButton btnInStock;
		private FontAwesome.Sharp.IconButton btnOutOfStock;
		private FontAwesome.Sharp.IconButton btnExpired;
		private FontAwesome.Sharp.IconButton btnDormant;
		private FontAwesome.Sharp.IconButton btnReturned;
		private FontAwesome.Sharp.IconButton btnInShelves;
		private FontAwesome.Sharp.IconButton btnInStore;
		private FontAwesome.Sharp.IconButton btnAll;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
		private System.Windows.Forms.BindingSource productBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shapeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn marginDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityInStoreDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityInShelvesDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn netProfitDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityInBoxDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shelfCodeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn alertThresholdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityMaxInShelveDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn storeDataGridViewCheckBoxColumn;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
	}
}
