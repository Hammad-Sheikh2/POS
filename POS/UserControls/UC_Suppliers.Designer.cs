namespace POS.UserControls
{
	partial class UC_Suppliers
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
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.panelSearch = new System.Windows.Forms.Panel();
			this.cbxFilter = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnSettings = new FontAwesome.Sharp.IconPictureBox();
			this.btnEdit = new FontAwesome.Sharp.IconPictureBox();
			this.btnAdd = new FontAwesome.Sharp.IconPictureBox();
			this.btnExportToExcel = new FontAwesome.Sharp.IconPictureBox();
			this.btnDelete = new FontAwesome.Sharp.IconPictureBox();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contact1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contact2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.airtelMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bankAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			this.panelSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExportToExcel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
			this.SuspendLayout();
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
            this.nameDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.contact1DataGridViewTextBoxColumn,
            this.contact2DataGridViewTextBoxColumn,
            this.airtelMoneyDataGridViewTextBoxColumn,
            this.bankAccountDataGridViewTextBoxColumn});
			this.dg.DataSource = this.supplierBindingSource;
			this.dg.DoubleBuffered = true;
			this.dg.EnableHeadersVisualStyles = false;
			this.dg.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.dg.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.Location = new System.Drawing.Point(46, 92);
			this.dg.Name = "dg";
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.RowHeadersVisible = false;
			this.dg.Size = new System.Drawing.Size(984, 452);
			this.dg.TabIndex = 2;
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 10;
			this.bunifuElipse1.TargetControl = this.panelSearch;
			// 
			// panelSearch
			// 
			this.panelSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panelSearch.BackColor = System.Drawing.Color.Silver;
			this.panelSearch.Controls.Add(this.cbxFilter);
			this.panelSearch.Controls.Add(this.label5);
			this.panelSearch.Controls.Add(this.tbSearch);
			this.panelSearch.Location = new System.Drawing.Point(304, 14);
			this.panelSearch.Name = "panelSearch";
			this.panelSearch.Size = new System.Drawing.Size(443, 72);
			this.panelSearch.TabIndex = 0;
			// 
			// cbxFilter
			// 
			this.cbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbxFilter.FormattingEnabled = true;
			this.cbxFilter.Items.AddRange(new object[] {
            "Id",
            "Name",
            "Address",
            "Proprietor",
            "Email",
            "Contact",
            "Fax"});
			this.cbxFilter.Location = new System.Drawing.Point(55, 37);
			this.cbxFilter.Name = "cbxFilter";
			this.cbxFilter.Size = new System.Drawing.Size(105, 26);
			this.cbxFilter.TabIndex = 1;
			this.cbxFilter.Text = "Select Filter";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(199, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Search";
			// 
			// tbSearch
			// 
			this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbSearch.Location = new System.Drawing.Point(166, 36);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(229, 26);
			this.tbSearch.TabIndex = 0;
			this.tbSearch.Text = "Search by Filter";
			this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
			// 
			// bunifuElipse3
			// 
			this.bunifuElipse3.ElipseRadius = 10;
			this.bunifuElipse3.TargetControl = this.dg;
			// 
			// bunifuElipse2
			// 
			this.bunifuElipse2.ElipseRadius = 10;
			// 
			// btnSettings
			// 
			this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSettings.BackColor = System.Drawing.Color.Transparent;
			this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
			this.btnSettings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnSettings.IconSize = 26;
			this.btnSettings.Location = new System.Drawing.Point(1056, 212);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(26, 27);
			this.btnSettings.TabIndex = 97;
			this.btnSettings.TabStop = false;
			this.toolTip1.SetToolTip(this.btnSettings, "Settings");
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.BackColor = System.Drawing.Color.Transparent;
			this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
			this.btnEdit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnEdit.IconSize = 26;
			this.btnEdit.Location = new System.Drawing.Point(1056, 126);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(26, 27);
			this.btnEdit.TabIndex = 81;
			this.btnEdit.TabStop = false;
			this.toolTip1.SetToolTip(this.btnEdit, "Update && Save");
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.BackColor = System.Drawing.Color.Transparent;
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnAdd.IconSize = 26;
			this.btnAdd.Location = new System.Drawing.Point(1056, 98);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(26, 27);
			this.btnAdd.TabIndex = 78;
			this.btnAdd.TabStop = false;
			this.toolTip1.SetToolTip(this.btnAdd, "New Supplier");
			this.btnAdd.UseGdi = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
			this.btnExportToExcel.Location = new System.Drawing.Point(1057, 183);
			this.btnExportToExcel.Name = "btnExportToExcel";
			this.btnExportToExcel.Size = new System.Drawing.Size(26, 27);
			this.btnExportToExcel.TabIndex = 83;
			this.btnExportToExcel.TabStop = false;
			this.toolTip1.SetToolTip(this.btnExportToExcel, "Export All Suppliers");
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.BackColor = System.Drawing.Color.Transparent;
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
			this.btnDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnDelete.IconSize = 26;
			this.btnDelete.Location = new System.Drawing.Point(1057, 155);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(26, 27);
			this.btnDelete.TabIndex = 84;
			this.btnDelete.TabStop = false;
			this.toolTip1.SetToolTip(this.btnDelete, "Delete Supplier");
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
			// cityDataGridViewTextBoxColumn
			// 
			this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
			this.cityDataGridViewTextBoxColumn.HeaderText = "City";
			this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			// 
			// contact1DataGridViewTextBoxColumn
			// 
			this.contact1DataGridViewTextBoxColumn.DataPropertyName = "Contact1";
			this.contact1DataGridViewTextBoxColumn.HeaderText = "Contact 2";
			this.contact1DataGridViewTextBoxColumn.Name = "contact1DataGridViewTextBoxColumn";
			// 
			// contact2DataGridViewTextBoxColumn
			// 
			this.contact2DataGridViewTextBoxColumn.DataPropertyName = "Contact2";
			this.contact2DataGridViewTextBoxColumn.HeaderText = "Contact 2";
			this.contact2DataGridViewTextBoxColumn.Name = "contact2DataGridViewTextBoxColumn";
			// 
			// airtelMoneyDataGridViewTextBoxColumn
			// 
			this.airtelMoneyDataGridViewTextBoxColumn.DataPropertyName = "AirtelMoney";
			this.airtelMoneyDataGridViewTextBoxColumn.HeaderText = "Airtel Money";
			this.airtelMoneyDataGridViewTextBoxColumn.Name = "airtelMoneyDataGridViewTextBoxColumn";
			// 
			// bankAccountDataGridViewTextBoxColumn
			// 
			this.bankAccountDataGridViewTextBoxColumn.DataPropertyName = "BankAccount";
			this.bankAccountDataGridViewTextBoxColumn.HeaderText = "Bank Account";
			this.bankAccountDataGridViewTextBoxColumn.Name = "bankAccountDataGridViewTextBoxColumn";
			// 
			// supplierBindingSource
			// 
			this.supplierBindingSource.DataSource = typeof(POS.Classes.Supplier);
			// 
			// UC_Suppliers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
			this.Controls.Add(this.btnSettings);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.panelSearch);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnExportToExcel);
			this.Controls.Add(this.btnDelete);
			this.Name = "UC_Suppliers";
			this.Size = new System.Drawing.Size(1085, 563);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			this.panelSearch.ResumeLayout(false);
			this.panelSearch.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExportToExcel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private FontAwesome.Sharp.IconPictureBox btnDelete;
		private FontAwesome.Sharp.IconPictureBox btnExportToExcel;
		private FontAwesome.Sharp.IconPictureBox btnEdit;
		private FontAwesome.Sharp.IconPictureBox btnAdd;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.Panel panelSearch;
		private System.Windows.Forms.ComboBox cbxFilter;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbSearch;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
		private System.Windows.Forms.ToolTip toolTip1;
		private FontAwesome.Sharp.IconPictureBox btnSettings;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn contact1DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn contact2DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn airtelMoneyDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bankAccountDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource supplierBindingSource;
	}
}
