
namespace POS.UserControls
{
	partial class UC_Purchases
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
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.panelDetails = new System.Windows.Forms.Panel();
			this.cbxProducts = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxSuppliers = new System.Windows.Forms.ComboBox();
			this.lblId = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnNewSupplier = new FontAwesome.Sharp.IconPictureBox();
			this.btnNewProduct = new FontAwesome.Sharp.IconPictureBox();
			this.tbQty = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.dp = new System.Windows.Forms.DateTimePicker();
			this.btnClear = new FontAwesome.Sharp.IconButton();
			this.btnSave = new FontAwesome.Sharp.IconButton();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.btnExportToExcel = new FontAwesome.Sharp.IconPictureBox();
			this.purchaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			this.panelDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnNewSupplier)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnNewProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbQty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExportToExcel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse3
			// 
			this.bunifuElipse3.ElipseRadius = 10;
			this.bunifuElipse3.TargetControl = this.dg;
			// 
			// dg
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dg.AutoGenerateColumns = false;
			this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.productNameDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.totalPaidDataGridViewTextBoxColumn});
			this.dg.DataSource = this.purchaseBindingSource;
			this.dg.DoubleBuffered = true;
			this.dg.EnableHeadersVisualStyles = false;
			this.dg.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.dg.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.Location = new System.Drawing.Point(50, 211);
			this.dg.Name = "dg";
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.RowHeadersVisible = false;
			this.dg.Size = new System.Drawing.Size(984, 347);
			this.dg.TabIndex = 3;
			// 
			// panelDetails
			// 
			this.panelDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panelDetails.BackColor = System.Drawing.Color.Silver;
			this.panelDetails.Controls.Add(this.btnExportToExcel);
			this.panelDetails.Controls.Add(this.label12);
			this.panelDetails.Controls.Add(this.label13);
			this.panelDetails.Controls.Add(this.numericUpDown2);
			this.panelDetails.Controls.Add(this.label9);
			this.panelDetails.Controls.Add(this.label11);
			this.panelDetails.Controls.Add(this.numericUpDown1);
			this.panelDetails.Controls.Add(this.label8);
			this.panelDetails.Controls.Add(this.btnClear);
			this.panelDetails.Controls.Add(this.btnSave);
			this.panelDetails.Controls.Add(this.dp);
			this.panelDetails.Controls.Add(this.label7);
			this.panelDetails.Controls.Add(this.label10);
			this.panelDetails.Controls.Add(this.label1);
			this.panelDetails.Controls.Add(this.label2);
			this.panelDetails.Controls.Add(this.tbQty);
			this.panelDetails.Controls.Add(this.btnNewProduct);
			this.panelDetails.Controls.Add(this.btnNewSupplier);
			this.panelDetails.Controls.Add(this.cbxProducts);
			this.panelDetails.Controls.Add(this.label5);
			this.panelDetails.Controls.Add(this.label6);
			this.panelDetails.Controls.Add(this.cbxSuppliers);
			this.panelDetails.Controls.Add(this.lblId);
			this.panelDetails.Controls.Add(this.label15);
			this.panelDetails.Controls.Add(this.label14);
			this.panelDetails.Controls.Add(this.label3);
			this.panelDetails.Controls.Add(this.label4);
			this.panelDetails.Location = new System.Drawing.Point(180, 17);
			this.panelDetails.Name = "panelDetails";
			this.panelDetails.Size = new System.Drawing.Size(697, 188);
			this.panelDetails.TabIndex = 4;
			// 
			// cbxProducts
			// 
			this.cbxProducts.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseBindingSource1, "ProductName", true));
			this.cbxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbxProducts.FormattingEnabled = true;
			this.cbxProducts.Location = new System.Drawing.Point(150, 69);
			this.cbxProducts.Name = "cbxProducts";
			this.cbxProducts.Size = new System.Drawing.Size(165, 26);
			this.cbxProducts.TabIndex = 1;
			this.cbxProducts.Text = "Select";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(133, 77);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(11, 15);
			this.label5.TabIndex = 93;
			this.label5.Text = ":";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label6.Location = new System.Drawing.Point(73, 75);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 17);
			this.label6.TabIndex = 92;
			this.label6.Text = "Product";
			// 
			// cbxSuppliers
			// 
			this.cbxSuppliers.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseBindingSource1, "SupplierName", true));
			this.cbxSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbxSuppliers.FormattingEnabled = true;
			this.cbxSuppliers.Location = new System.Drawing.Point(150, 37);
			this.cbxSuppliers.Name = "cbxSuppliers";
			this.cbxSuppliers.Size = new System.Drawing.Size(165, 26);
			this.cbxSuppliers.TabIndex = 0;
			this.cbxSuppliers.Text = "Select";
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseBindingSource1, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
			this.lblId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
			this.lblId.Location = new System.Drawing.Point(396, 6);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(17, 19);
			this.lblId.TabIndex = 46;
			this.lblId.Text = "0";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
			this.label15.Location = new System.Drawing.Point(290, 6);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 19);
			this.label15.TabIndex = 45;
			this.label15.Text = "Purchase ID#";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(119, 352);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(11, 15);
			this.label14.TabIndex = 20;
			this.label14.Text = ":";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(133, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(11, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = ":";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label4.Location = new System.Drawing.Point(73, 45);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 17);
			this.label4.TabIndex = 5;
			this.label4.Text = "Supplier";
			// 
			// btnNewSupplier
			// 
			this.btnNewSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNewSupplier.BackColor = System.Drawing.Color.Transparent;
			this.btnNewSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnNewSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNewSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnNewSupplier.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnNewSupplier.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnNewSupplier.IconSize = 26;
			this.btnNewSupplier.Location = new System.Drawing.Point(318, 37);
			this.btnNewSupplier.Name = "btnNewSupplier";
			this.btnNewSupplier.Size = new System.Drawing.Size(26, 27);
			this.btnNewSupplier.TabIndex = 94;
			this.btnNewSupplier.TabStop = false;
			this.toolTip1.SetToolTip(this.btnNewSupplier, "New Supplier");
			this.btnNewSupplier.UseGdi = true;
			this.btnNewSupplier.Click += new System.EventHandler(this.btnNewSupplier_Click);
			// 
			// btnNewProduct
			// 
			this.btnNewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNewProduct.BackColor = System.Drawing.Color.Transparent;
			this.btnNewProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnNewProduct.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNewProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnNewProduct.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnNewProduct.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnNewProduct.IconSize = 26;
			this.btnNewProduct.Location = new System.Drawing.Point(318, 68);
			this.btnNewProduct.Name = "btnNewProduct";
			this.btnNewProduct.Size = new System.Drawing.Size(26, 27);
			this.btnNewProduct.TabIndex = 95;
			this.btnNewProduct.TabStop = false;
			this.toolTip1.SetToolTip(this.btnNewProduct, "New Product");
			this.btnNewProduct.UseGdi = true;
			this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
			// 
			// tbQty
			// 
			this.tbQty.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseBindingSource1, "Quantity", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
			this.tbQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbQty.Location = new System.Drawing.Point(478, 32);
			this.tbQty.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.tbQty.Name = "tbQty";
			this.tbQty.Size = new System.Drawing.Size(165, 26);
			this.tbQty.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(461, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(11, 15);
			this.label1.TabIndex = 98;
			this.label1.Text = ":";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label2.Location = new System.Drawing.Point(350, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 17);
			this.label2.TabIndex = 97;
			this.label2.Text = "Quantity";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(133, 105);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(11, 15);
			this.label7.TabIndex = 100;
			this.label7.Text = ":";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label10.Location = new System.Drawing.Point(68, 105);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 17);
			this.label10.TabIndex = 99;
			this.label10.Text = "Date";
			// 
			// dp
			// 
			this.dp.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseBindingSource1, "PurchaseDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
			this.dp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.dp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dp.Location = new System.Drawing.Point(150, 101);
			this.dp.Name = "dp";
			this.dp.Size = new System.Drawing.Size(165, 23);
			this.dp.TabIndex = 2;
			// 
			// btnClear
			// 
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnClear.Font = new System.Drawing.Font("Calibri", 11F);
			this.btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnClear.IconColor = System.Drawing.Color.Black;
			this.btnClear.IconSize = 16;
			this.btnClear.Location = new System.Drawing.Point(353, 133);
			this.btnClear.Name = "btnClear";
			this.btnClear.Rotation = 0D;
			this.btnClear.Size = new System.Drawing.Size(109, 26);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnSave
			// 
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnSave.Font = new System.Drawing.Font("Calibri", 11F);
			this.btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnSave.IconColor = System.Drawing.Color.Black;
			this.btnSave.IconSize = 16;
			this.btnSave.Location = new System.Drawing.Point(236, 133);
			this.btnSave.Name = "btnSave";
			this.btnSave.Rotation = 0D;
			this.btnSave.Size = new System.Drawing.Size(111, 26);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 8F);
			this.label8.Location = new System.Drawing.Point(182, 166);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(331, 14);
			this.label8.TabIndex = 105;
			this.label8.Text = "TIP: Stock and Purchase price will be updated once a purchase is saved";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(461, 69);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(11, 15);
			this.label9.TabIndex = 108;
			this.label9.Text = ":";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label11.Location = new System.Drawing.Point(350, 72);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(98, 17);
			this.label11.TabIndex = 107;
			this.label11.Text = "Purchase Price";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseBindingSource1, "PurchasePrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"));
			this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.numericUpDown1.Location = new System.Drawing.Point(478, 63);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(165, 26);
			this.numericUpDown1.TabIndex = 4;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(461, 101);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(11, 15);
			this.label12.TabIndex = 111;
			this.label12.Text = ":";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label13.Location = new System.Drawing.Point(350, 104);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(67, 17);
			this.label13.TabIndex = 110;
			this.label13.Text = "Total Paid";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseBindingSource1, "TotalPaid", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"));
			this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.numericUpDown2.Location = new System.Drawing.Point(478, 95);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(165, 26);
			this.numericUpDown2.TabIndex = 5;
			// 
			// btnExportToExcel
			// 
			this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportToExcel.BackColor = System.Drawing.Color.Transparent;
			this.btnExportToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExportToExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnExportToExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
			this.btnExportToExcel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnExportToExcel.IconSize = 26;
			this.btnExportToExcel.Location = new System.Drawing.Point(668, 160);
			this.btnExportToExcel.Name = "btnExportToExcel";
			this.btnExportToExcel.Size = new System.Drawing.Size(26, 27);
			this.btnExportToExcel.TabIndex = 112;
			this.btnExportToExcel.TabStop = false;
			this.toolTip1.SetToolTip(this.btnExportToExcel, "Export All Suppliers");
			this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
			// 
			// purchaseBindingSource1
			// 
			this.purchaseBindingSource1.DataSource = typeof(POS.Classes.Purchase);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// productNameDataGridViewTextBoxColumn
			// 
			this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
			this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
			this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
			// 
			// supplierNameDataGridViewTextBoxColumn
			// 
			this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
			this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier";
			this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
			// 
			// purchasePriceDataGridViewTextBoxColumn
			// 
			this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
			this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "Purchase Price";
			this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
			// 
			// quantityDataGridViewTextBoxColumn
			// 
			this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
			this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
			this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
			// 
			// purchaseDateDataGridViewTextBoxColumn
			// 
			this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
			this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "Purchase Date";
			this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
			// 
			// totalPaidDataGridViewTextBoxColumn
			// 
			this.totalPaidDataGridViewTextBoxColumn.DataPropertyName = "TotalPaid";
			this.totalPaidDataGridViewTextBoxColumn.HeaderText = "Total Paid";
			this.totalPaidDataGridViewTextBoxColumn.Name = "totalPaidDataGridViewTextBoxColumn";
			// 
			// purchaseBindingSource
			// 
			this.purchaseBindingSource.DataSource = typeof(POS.Classes.Purchase);
			// 
			// UC_Purchases
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelDetails);
			this.Controls.Add(this.dg);
			this.Name = "UC_Purchases";
			this.Size = new System.Drawing.Size(1085, 563);
			this.Load += new System.EventHandler(this.UC_Purchases_Load);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			this.panelDetails.ResumeLayout(false);
			this.panelDetails.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnNewSupplier)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnNewProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbQty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExportToExcel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip1;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
		private System.Windows.Forms.Panel panelDetails;
		private System.Windows.Forms.ComboBox cbxProducts;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbxSuppliers;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private FontAwesome.Sharp.IconPictureBox btnNewSupplier;
		private FontAwesome.Sharp.IconPictureBox btnNewProduct;
		private System.Windows.Forms.NumericUpDown tbQty;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dp;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private FontAwesome.Sharp.IconButton btnClear;
		private FontAwesome.Sharp.IconButton btnSave;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.BindingSource purchaseBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalPaidDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource purchaseBindingSource1;
		private FontAwesome.Sharp.IconPictureBox btnExportToExcel;
	}
}
