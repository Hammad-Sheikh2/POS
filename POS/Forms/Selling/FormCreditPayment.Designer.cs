namespace POS.Forms.Selling
{
	partial class FormCreditPayment
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cbxInvoices = new System.Windows.Forms.ComboBox();
			this.btnConfirm = new FontAwesome.Sharp.IconButton();
			this.label3 = new System.Windows.Forms.Label();
			this.lblId = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cbxCustomers = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSaveInvoice = new FontAwesome.Sharp.IconButton();
			this.tbCashGiven = new System.Windows.Forms.NumericUpDown();
			this.tbTotalBill = new System.Windows.Forms.NumericUpDown();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.leftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbCashGiven)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbTotalBill)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(11, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 19);
			this.label1.TabIndex = 101;
			this.label1.Text = "Nom du client";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(12, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(222, 19);
			this.label2.TabIndex = 103;
			this.label2.Text = "Factures impayées par ce client";
			// 
			// dg
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dg.AutoGenerateColumns = false;
			this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dg.BackgroundColor = System.Drawing.Color.Silver;
			this.dg.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.invoiceDateDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn,
            this.leftDataGridViewTextBoxColumn});
			this.dg.DataSource = this.invoiceBindingSource;
			this.dg.DoubleBuffered = true;
			this.dg.EnableHeadersVisualStyles = false;
			this.dg.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.dg.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.Location = new System.Drawing.Point(12, 155);
			this.dg.Name = "dg";
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.RowHeadersVisible = false;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
			this.dg.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dg.Size = new System.Drawing.Size(411, 120);
			this.dg.TabIndex = 104;
			// 
			// invoiceBindingSource
			// 
			this.invoiceBindingSource.DataSource = typeof(POS.Classes.Finances.Invoice);
			// 
			// cbxInvoices
			// 
			this.cbxInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cbxInvoices.Font = new System.Drawing.Font("Times New Roman", 13F);
			this.cbxInvoices.FormattingEnabled = true;
			this.cbxInvoices.Location = new System.Drawing.Point(438, 211);
			this.cbxInvoices.Name = "cbxInvoices";
			this.cbxInvoices.Size = new System.Drawing.Size(144, 27);
			this.cbxInvoices.TabIndex = 112;
			this.cbxInvoices.Text = "facture#";
			this.cbxInvoices.SelectedIndexChanged += new System.EventHandler(this.cbxInvoices_SelectedIndexChanged);
			// 
			// btnConfirm
			// 
			this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfirm.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnConfirm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConfirm.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnConfirm.IconColor = System.Drawing.Color.Black;
			this.btnConfirm.IconSize = 16;
			this.btnConfirm.Location = new System.Drawing.Point(438, 244);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Rotation = 0D;
			this.btnConfirm.Size = new System.Drawing.Size(144, 31);
			this.btnConfirm.TabIndex = 111;
			this.btnConfirm.Text = "Récupérer";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(434, 189);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(148, 19);
			this.label3.TabIndex = 109;
			this.label3.Text = "Récupérer la facture";
			// 
			// lblId
			// 
			this.lblId.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblId.AutoSize = true;
			this.lblId.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
			this.lblId.Location = new System.Drawing.Point(323, 9);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(20, 23);
			this.lblId.TabIndex = 114;
			this.lblId.Text = "0";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(196, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(121, 23);
			this.label5.TabIndex = 113;
			this.label5.Text = "ID de facture#";
			// 
			// cbxCustomers
			// 
			this.cbxCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbxCustomers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbxCustomers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.cbxCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbxCustomers.FormattingEnabled = true;
			this.cbxCustomers.Location = new System.Drawing.Point(133, 42);
			this.cbxCustomers.Name = "cbxCustomers";
			this.cbxCustomers.Size = new System.Drawing.Size(434, 26);
			this.cbxCustomers.TabIndex = 115;
			this.cbxCustomers.Text = "Comptant";
			this.cbxCustomers.SelectedIndexChanged += new System.EventHandler(this.cbxCustomers_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 12F);
			this.label4.Location = new System.Drawing.Point(85, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 19);
			this.label4.TabIndex = 119;
			this.label4.Text = "Total";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 12F);
			this.label6.Location = new System.Drawing.Point(249, 81);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 19);
			this.label6.TabIndex = 120;
			this.label6.Text = "payé";
			// 
			// btnSaveInvoice
			// 
			this.btnSaveInvoice.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnSaveInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveInvoice.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnSaveInvoice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveInvoice.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnSaveInvoice.IconColor = System.Drawing.Color.Black;
			this.btnSaveInvoice.IconSize = 16;
			this.btnSaveInvoice.Location = new System.Drawing.Point(404, 75);
			this.btnSaveInvoice.Name = "btnSaveInvoice";
			this.btnSaveInvoice.Rotation = 0D;
			this.btnSaveInvoice.Size = new System.Drawing.Size(163, 31);
			this.btnSaveInvoice.TabIndex = 122;
			this.btnSaveInvoice.Text = "Enregistrer la facture";
			this.btnSaveInvoice.UseVisualStyleBackColor = true;
			this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
			// 
			// tbCashGiven
			// 
			this.tbCashGiven.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbCashGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbCashGiven.Location = new System.Drawing.Point(293, 75);
			this.tbCashGiven.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.tbCashGiven.Name = "tbCashGiven";
			this.tbCashGiven.Size = new System.Drawing.Size(108, 29);
			this.tbCashGiven.TabIndex = 123;
			this.tbCashGiven.ThousandsSeparator = true;
			// 
			// tbTotalBill
			// 
			this.tbTotalBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbTotalBill.Enabled = false;
			this.tbTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbTotalBill.Location = new System.Drawing.Point(132, 77);
			this.tbTotalBill.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.tbTotalBill.Name = "tbTotalBill";
			this.tbTotalBill.Size = new System.Drawing.Size(112, 29);
			this.tbTotalBill.TabIndex = 124;
			this.tbTotalBill.ThousandsSeparator = true;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// invoiceDateDataGridViewTextBoxColumn
			// 
			this.invoiceDateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDate";
			this.invoiceDateDataGridViewTextBoxColumn.HeaderText = "Date";
			this.invoiceDateDataGridViewTextBoxColumn.Name = "invoiceDateDataGridViewTextBoxColumn";
			// 
			// totalDataGridViewTextBoxColumn
			// 
			this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
			this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
			this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
			// 
			// paidDataGridViewTextBoxColumn
			// 
			this.paidDataGridViewTextBoxColumn.DataPropertyName = "Paid";
			this.paidDataGridViewTextBoxColumn.HeaderText = "payé";
			this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
			// 
			// leftDataGridViewTextBoxColumn
			// 
			this.leftDataGridViewTextBoxColumn.DataPropertyName = "Left";
			this.leftDataGridViewTextBoxColumn.HeaderText = "restant";
			this.leftDataGridViewTextBoxColumn.Name = "leftDataGridViewTextBoxColumn";
			// 
			// FormCreditPayment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 284);
			this.Controls.Add(this.tbTotalBill);
			this.Controls.Add(this.tbCashGiven);
			this.Controls.Add(this.btnSaveInvoice);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbxCustomers);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbxInvoices);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(610, 264);
			this.Name = "FormCreditPayment";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Credit Payment";
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbCashGiven)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbTotalBill)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
		private System.Windows.Forms.ComboBox cbxInvoices;
		private FontAwesome.Sharp.IconButton btnConfirm;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbxCustomers;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private FontAwesome.Sharp.IconButton btnSaveInvoice;
		private System.Windows.Forms.BindingSource invoiceBindingSource;
		private System.Windows.Forms.NumericUpDown tbCashGiven;
		public System.Windows.Forms.NumericUpDown tbTotalBill;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn leftDataGridViewTextBoxColumn;
	}
}