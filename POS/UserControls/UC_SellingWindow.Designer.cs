namespace POS.UserControls
{
	partial class UC_SellingWindow
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
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.panelDetails = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.rbPayment = new System.Windows.Forms.RadioButton();
			this.rbReturn = new System.Windows.Forms.RadioButton();
			this.btnClear = new FontAwesome.Sharp.IconPictureBox();
			this.lblCashier = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCash = new FontAwesome.Sharp.IconButton();
			this.btnCredit = new FontAwesome.Sharp.IconButton();
			this.tbTotal = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxCustomers = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbxProductNames = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shapeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			this.panelDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dg
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.productNameDataGridViewTextBoxColumn,
            this.shapeDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
			this.dg.DataSource = this.cartBindingSource;
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
			this.dg.Location = new System.Drawing.Point(36, 68);
			this.dg.Name = "dg";
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.Size = new System.Drawing.Size(1035, 359);
			this.dg.TabIndex = 6;
			this.dg.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dg_CellBeginEdit);
			this.dg.Paint += new System.Windows.Forms.PaintEventHandler(this.dg_Paint);
			// 
			// panelDetails
			// 
			this.panelDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.panelDetails.BackColor = System.Drawing.Color.Silver;
			this.panelDetails.Controls.Add(this.label5);
			this.panelDetails.Controls.Add(this.label4);
			this.panelDetails.Controls.Add(this.rbPayment);
			this.panelDetails.Controls.Add(this.rbReturn);
			this.panelDetails.Controls.Add(this.btnClear);
			this.panelDetails.Controls.Add(this.lblCashier);
			this.panelDetails.Controls.Add(this.label2);
			this.panelDetails.Controls.Add(this.label3);
			this.panelDetails.Controls.Add(this.btnCash);
			this.panelDetails.Controls.Add(this.btnCredit);
			this.panelDetails.Controls.Add(this.tbTotal);
			this.panelDetails.Controls.Add(this.label1);
			this.panelDetails.Controls.Add(this.cbxCustomers);
			this.panelDetails.Controls.Add(this.label16);
			this.panelDetails.Controls.Add(this.label17);
			this.panelDetails.Controls.Add(this.label14);
			this.panelDetails.Location = new System.Drawing.Point(36, 435);
			this.panelDetails.Name = "panelDetails";
			this.panelDetails.Size = new System.Drawing.Size(1035, 89);
			this.panelDetails.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(83, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(11, 15);
			this.label5.TabIndex = 110;
			this.label5.Text = ":";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 18);
			this.label4.TabIndex = 109;
			this.label4.Text = "Facture";
			// 
			// rbPayment
			// 
			this.rbPayment.AutoSize = true;
			this.rbPayment.Checked = true;
			this.rbPayment.Font = new System.Drawing.Font("Sitka Small", 9F);
			this.rbPayment.Location = new System.Drawing.Point(181, 5);
			this.rbPayment.Name = "rbPayment";
			this.rbPayment.Size = new System.Drawing.Size(82, 22);
			this.rbPayment.TabIndex = 108;
			this.rbPayment.TabStop = true;
			this.rbPayment.Text = "Paiement";
			this.rbPayment.UseVisualStyleBackColor = true;
			this.rbPayment.CheckedChanged += new System.EventHandler(this.InvoiceType_CheckChanged);
			// 
			// rbReturn
			// 
			this.rbReturn.AutoSize = true;
			this.rbReturn.Font = new System.Drawing.Font("Sitka Small", 9F);
			this.rbReturn.Location = new System.Drawing.Point(100, 5);
			this.rbReturn.Name = "rbReturn";
			this.rbReturn.Size = new System.Drawing.Size(68, 22);
			this.rbReturn.TabIndex = 107;
			this.rbReturn.Text = "Retour";
			this.rbReturn.UseVisualStyleBackColor = true;
			this.rbReturn.CheckedChanged += new System.EventHandler(this.InvoiceType_CheckChanged);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.Silver;
			this.btnClear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClear.ForeColor = System.Drawing.Color.DarkRed;
			this.btnClear.IconChar = FontAwesome.Sharp.IconChar.Trash;
			this.btnClear.IconColor = System.Drawing.Color.DarkRed;
			this.btnClear.IconSize = 30;
			this.btnClear.Location = new System.Drawing.Point(1002, 52);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(30, 30);
			this.btnClear.TabIndex = 106;
			this.btnClear.TabStop = false;
			this.toolTip1.SetToolTip(this.btnClear, "Clear Cart");
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// lblCashier
			// 
			this.lblCashier.AutoSize = true;
			this.lblCashier.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.lblCashier.Location = new System.Drawing.Point(97, 30);
			this.lblCashier.Name = "lblCashier";
			this.lblCashier.Size = new System.Drawing.Size(92, 18);
			this.lblCashier.TabIndex = 105;
			this.lblCashier.Text = "Cashier name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(83, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(11, 15);
			this.label2.TabIndex = 104;
			this.label2.Text = ":";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 18);
			this.label3.TabIndex = 103;
			this.label3.Text = "Caissier";
			// 
			// btnCash
			// 
			this.btnCash.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCash.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCash.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCash.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnCash.IconColor = System.Drawing.Color.Black;
			this.btnCash.IconSize = 16;
			this.btnCash.Location = new System.Drawing.Point(873, 52);
			this.btnCash.Name = "btnCash";
			this.btnCash.Rotation = 0D;
			this.btnCash.Size = new System.Drawing.Size(127, 31);
			this.btnCash.TabIndex = 102;
			this.btnCash.Text = "Espèce";
			this.btnCash.UseVisualStyleBackColor = true;
			this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
			// 
			// btnCredit
			// 
			this.btnCredit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCredit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCredit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCredit.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnCredit.IconColor = System.Drawing.Color.Black;
			this.btnCredit.IconSize = 16;
			this.btnCredit.Location = new System.Drawing.Point(741, 52);
			this.btnCredit.Name = "btnCredit";
			this.btnCredit.Rotation = 0D;
			this.btnCredit.Size = new System.Drawing.Size(127, 31);
			this.btnCredit.TabIndex = 101;
			this.btnCredit.Text = "Crédit";
			this.btnCredit.UseVisualStyleBackColor = true;
			this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
			// 
			// tbTotal
			// 
			this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
			this.tbTotal.Location = new System.Drawing.Point(898, 3);
			this.tbTotal.Name = "tbTotal";
			this.tbTotal.Size = new System.Drawing.Size(134, 33);
			this.tbTotal.TabIndex = 100;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(844, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 99;
			this.label1.Text = "Total";
			// 
			// cbxCustomers
			// 
			this.cbxCustomers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbxCustomers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.cbxCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbxCustomers.FormattingEnabled = true;
			this.cbxCustomers.Location = new System.Drawing.Point(96, 55);
			this.cbxCustomers.Name = "cbxCustomers";
			this.cbxCustomers.Size = new System.Drawing.Size(377, 26);
			this.cbxCustomers.TabIndex = 3;
			this.cbxCustomers.Text = "Comptant";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(83, 60);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(11, 15);
			this.label16.TabIndex = 87;
			this.label16.Text = ":";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(8, 60);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(45, 18);
			this.label17.TabIndex = 86;
			this.label17.Text = "Client";
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
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.cbxProductNames);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Location = new System.Drawing.Point(36, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1035, 49);
			this.panel1.TabIndex = 103;
			// 
			// cbxProductNames
			// 
			this.cbxProductNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbxProductNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.cbxProductNames.Font = new System.Drawing.Font("Times New Roman", 13F);
			this.cbxProductNames.FormattingEnabled = true;
			this.cbxProductNames.Location = new System.Drawing.Point(11, 11);
			this.cbxProductNames.Name = "cbxProductNames";
			this.cbxProductNames.Size = new System.Drawing.Size(1010, 27);
			this.cbxProductNames.TabIndex = 3;
			this.cbxProductNames.Text = "Nom du produit ici";
			this.cbxProductNames.SelectedIndexChanged += new System.EventHandler(this.cbxProductNames_SelectedIndexChanged);
			this.cbxProductNames.Click += new System.EventHandler(this.cbxProductNames_Click);
			this.cbxProductNames.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxProductNames_KeyDown);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(119, 352);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(11, 15);
			this.label7.TabIndex = 20;
			this.label7.Text = ":";
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this.panelDetails;
			// 
			// bunifuElipse2
			// 
			this.bunifuElipse2.ElipseRadius = 5;
			this.bunifuElipse2.TargetControl = this.dg;
			// 
			// bunifuElipse3
			// 
			this.bunifuElipse3.ElipseRadius = 5;
			this.bunifuElipse3.TargetControl = this.panel1;
			// 
			// productNameDataGridViewTextBoxColumn
			// 
			this.productNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
			this.productNameDataGridViewTextBoxColumn.HeaderText = "Nom du produit";
			this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
			// 
			// shapeDataGridViewTextBoxColumn
			// 
			this.shapeDataGridViewTextBoxColumn.DataPropertyName = "Shape";
			this.shapeDataGridViewTextBoxColumn.HeaderText = "Forme";
			this.shapeDataGridViewTextBoxColumn.Name = "shapeDataGridViewTextBoxColumn";
			this.shapeDataGridViewTextBoxColumn.Width = 150;
			// 
			// unitPriceDataGridViewTextBoxColumn
			// 
			this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
			this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Prix unitaire";
			this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
			// 
			// quantityDataGridViewTextBoxColumn
			// 
			this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
			this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantité ";
			this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
			// 
			// totalDataGridViewTextBoxColumn
			// 
			this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
			this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
			this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
			this.totalDataGridViewTextBoxColumn.Width = 150;
			// 
			// cartBindingSource
			// 
			this.cartBindingSource.DataSource = typeof(POS.Classes.Cart);
			// 
			// UC_SellingWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelDetails);
			this.Controls.Add(this.dg);
			this.Name = "UC_SellingWindow";
			this.Size = new System.Drawing.Size(1103, 563);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			this.panelDetails.ResumeLayout(false);
			this.panelDetails.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
		private System.Windows.Forms.Panel panelDetails;
		private System.Windows.Forms.ComboBox cbxCustomers;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label14;
		private FontAwesome.Sharp.IconButton btnCash;
		private FontAwesome.Sharp.IconButton btnCredit;
		private System.Windows.Forms.TextBox tbTotal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cbxProductNames;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.BindingSource cartBindingSource;
		private System.Windows.Forms.Label lblCashier;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
		private FontAwesome.Sharp.IconPictureBox btnClear;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.RadioButton rbPayment;
		private System.Windows.Forms.RadioButton rbReturn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shapeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
	}
}
