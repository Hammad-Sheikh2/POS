namespace POS.UserControls.Finances
{
	partial class UC_Invoices
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelSearch = new System.Windows.Forms.Panel();
			this.btnCash = new FontAwesome.Sharp.IconButton();
			this.btnCredit = new FontAwesome.Sharp.IconButton();
			this.btnAll = new FontAwesome.Sharp.IconButton();
			this.label6 = new System.Windows.Forms.Label();
			this.tbClientName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbCashierName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dpEnd = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dpStart = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.cbxDefinedPeriod = new System.Windows.Forms.ComboBox();
			this.tbDays = new System.Windows.Forms.TextBox();
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbLeft = new System.Windows.Forms.TextBox();
			this.tbPaid = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbTotal = new System.Windows.Forms.TextBox();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shiftIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.creditDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.thresholdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.leftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelSearch
			// 
			this.panelSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panelSearch.BackColor = System.Drawing.Color.Silver;
			this.panelSearch.Controls.Add(this.btnCash);
			this.panelSearch.Controls.Add(this.btnCredit);
			this.panelSearch.Controls.Add(this.btnAll);
			this.panelSearch.Controls.Add(this.label6);
			this.panelSearch.Controls.Add(this.tbClientName);
			this.panelSearch.Controls.Add(this.label3);
			this.panelSearch.Controls.Add(this.tbCashierName);
			this.panelSearch.Controls.Add(this.label2);
			this.panelSearch.Controls.Add(this.dpEnd);
			this.panelSearch.Controls.Add(this.label1);
			this.panelSearch.Controls.Add(this.dpStart);
			this.panelSearch.Controls.Add(this.label4);
			this.panelSearch.Controls.Add(this.cbxDefinedPeriod);
			this.panelSearch.Controls.Add(this.tbDays);
			this.panelSearch.Location = new System.Drawing.Point(206, 23);
			this.panelSearch.Name = "panelSearch";
			this.panelSearch.Size = new System.Drawing.Size(604, 115);
			this.panelSearch.TabIndex = 16;
			this.panelSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSearch_Paint);
			// 
			// btnCash
			// 
			this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCash.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCash.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnCash.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnCash.IconColor = System.Drawing.Color.Black;
			this.btnCash.IconSize = 16;
			this.btnCash.Location = new System.Drawing.Point(397, 77);
			this.btnCash.Name = "btnCash";
			this.btnCash.Rotation = 0D;
			this.btnCash.Size = new System.Drawing.Size(140, 32);
			this.btnCash.TabIndex = 117;
			this.btnCash.Text = "Espèce";
			this.btnCash.UseVisualStyleBackColor = true;
			this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
			// 
			// btnCredit
			// 
			this.btnCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCredit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCredit.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnCredit.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnCredit.IconColor = System.Drawing.Color.Black;
			this.btnCredit.IconSize = 16;
			this.btnCredit.Location = new System.Drawing.Point(251, 77);
			this.btnCredit.Name = "btnCredit";
			this.btnCredit.Rotation = 0D;
			this.btnCredit.Size = new System.Drawing.Size(140, 32);
			this.btnCredit.TabIndex = 116;
			this.btnCredit.Text = "Crédit";
			this.btnCredit.UseVisualStyleBackColor = true;
			this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
			// 
			// btnAll
			// 
			this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAll.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnAll.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnAll.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnAll.IconColor = System.Drawing.Color.Black;
			this.btnAll.IconSize = 16;
			this.btnAll.Location = new System.Drawing.Point(105, 77);
			this.btnAll.Name = "btnAll";
			this.btnAll.Rotation = 0D;
			this.btnAll.Size = new System.Drawing.Size(140, 32);
			this.btnAll.TabIndex = 115;
			this.btnAll.Text = "Tout";
			this.btnAll.UseVisualStyleBackColor = true;
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label6.Location = new System.Drawing.Point(379, 43);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 18);
			this.label6.TabIndex = 114;
			this.label6.Text = "Nom du client";
			// 
			// tbClientName
			// 
			this.tbClientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tbClientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.tbClientName.Location = new System.Drawing.Point(486, 39);
			this.tbClientName.Name = "tbClientName";
			this.tbClientName.Size = new System.Drawing.Size(100, 24);
			this.tbClientName.TabIndex = 113;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label3.Location = new System.Drawing.Point(379, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 18);
			this.label3.TabIndex = 112;
			this.label3.Text = "Nom du caissier";
			// 
			// tbCashierName
			// 
			this.tbCashierName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tbCashierName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbCashierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.tbCashierName.Location = new System.Drawing.Point(486, 11);
			this.tbCashierName.Name = "tbCashierName";
			this.tbCashierName.Size = new System.Drawing.Size(100, 24);
			this.tbCashierName.TabIndex = 111;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label2.Location = new System.Drawing.Point(9, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 18);
			this.label2.TabIndex = 110;
			this.label2.Text = "Date de fin";
			// 
			// dpEnd
			// 
			this.dpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.dpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dpEnd.Location = new System.Drawing.Point(110, 44);
			this.dpEnd.Name = "dpEnd";
			this.dpEnd.Size = new System.Drawing.Size(115, 24);
			this.dpEnd.TabIndex = 109;
			this.dpEnd.ValueChanged += new System.EventHandler(this.ValidateDateInterval);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label1.Location = new System.Drawing.Point(9, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 18);
			this.label1.TabIndex = 108;
			this.label1.Text = "Date de début";
			// 
			// dpStart
			// 
			this.dpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.dpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dpStart.Location = new System.Drawing.Point(110, 14);
			this.dpStart.Name = "dpStart";
			this.dpStart.Size = new System.Drawing.Size(115, 24);
			this.dpStart.TabIndex = 107;
			this.dpStart.ValueChanged += new System.EventHandler(this.ValidateDateInterval);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label4.Location = new System.Drawing.Point(231, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 18);
			this.label4.TabIndex = 106;
			this.label4.Text = "Journées";
			// 
			// cbxDefinedPeriod
			// 
			this.cbxDefinedPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbxDefinedPeriod.FormattingEnabled = true;
			this.cbxDefinedPeriod.Items.AddRange(new object[] {
            "Today",
            "1 Week",
            "1 Month",
            "3 Months",
            "6 Months",
            "1 Year"});
			this.cbxDefinedPeriod.Location = new System.Drawing.Point(251, 44);
			this.cbxDefinedPeriod.Name = "cbxDefinedPeriod";
			this.cbxDefinedPeriod.Size = new System.Drawing.Size(122, 26);
			this.cbxDefinedPeriod.TabIndex = 1;
			this.cbxDefinedPeriod.Text = "Période définie";
			this.cbxDefinedPeriod.SelectedIndexChanged += new System.EventHandler(this.cbxDefinedPeriod_SelectedIndexChanged);
			// 
			// tbDays
			// 
			this.tbDays.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tbDays.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbDays.Enabled = false;
			this.tbDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.tbDays.Location = new System.Drawing.Point(298, 16);
			this.tbDays.Name = "tbDays";
			this.tbDays.Size = new System.Drawing.Size(75, 24);
			this.tbDays.TabIndex = 0;
			this.tbDays.Text = "0";
			// 
			// dg
			// 
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.dg.AutoGenerateColumns = false;
			this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dg.BackgroundColor = System.Drawing.Color.Silver;
			this.dg.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.shiftIdDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.creditDataGridViewCheckBoxColumn,
            this.invoiceDateDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn,
            this.thresholdDataGridViewTextBoxColumn,
            this.leftDataGridViewTextBoxColumn});
			this.dg.DataSource = this.invoiceBindingSource;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dg.DefaultCellStyle = dataGridViewCellStyle9;
			this.dg.DoubleBuffered = true;
			this.dg.EnableHeadersVisualStyles = false;
			this.dg.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.dg.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.Location = new System.Drawing.Point(30, 149);
			this.dg.Name = "dg";
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.RowHeadersVisible = false;
			this.dg.Size = new System.Drawing.Size(1035, 359);
			this.dg.TabIndex = 17;
			this.dg.Paint += new System.Windows.Forms.PaintEventHandler(this.dg_Paint);
			// 
			// invoiceBindingSource
			// 
			this.invoiceBindingSource.DataSource = typeof(POS.Classes.Finances.Invoice);
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.tbLeft);
			this.panel1.Controls.Add(this.tbPaid);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.tbTotal);
			this.panel1.Location = new System.Drawing.Point(30, 515);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1035, 39);
			this.panel1.TabIndex = 118;
			// 
			// tbLeft
			// 
			this.tbLeft.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tbLeft.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.tbLeft.Location = new System.Drawing.Point(925, 8);
			this.tbLeft.Name = "tbLeft";
			this.tbLeft.Size = new System.Drawing.Size(107, 24);
			this.tbLeft.TabIndex = 116;
			this.toolTip1.SetToolTip(this.tbLeft, "Total Left");
			// 
			// tbPaid
			// 
			this.tbPaid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tbPaid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.tbPaid.Location = new System.Drawing.Point(793, 7);
			this.tbPaid.Name = "tbPaid";
			this.tbPaid.Size = new System.Drawing.Size(127, 24);
			this.tbPaid.TabIndex = 115;
			this.toolTip1.SetToolTip(this.tbPaid, "Total Paid Amount");
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(13, 12);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 18);
			this.label5.TabIndex = 114;
			this.label5.Text = "Total";
			// 
			// tbTotal
			// 
			this.tbTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tbTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.tbTotal.Location = new System.Drawing.Point(662, 7);
			this.tbTotal.Name = "tbTotal";
			this.tbTotal.Size = new System.Drawing.Size(125, 24);
			this.tbTotal.TabIndex = 111;
			this.toolTip1.SetToolTip(this.tbTotal, "Total of Invoices");
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this.panelSearch;
			// 
			// bunifuElipse2
			// 
			this.bunifuElipse2.ElipseRadius = 5;
			this.bunifuElipse2.TargetControl = this.dg;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// userIdDataGridViewTextBoxColumn
			// 
			this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
			this.userIdDataGridViewTextBoxColumn.HeaderText = "Id d\'utilisateur";
			this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
			// 
			// shiftIdDataGridViewTextBoxColumn
			// 
			this.shiftIdDataGridViewTextBoxColumn.DataPropertyName = "ShiftId";
			this.shiftIdDataGridViewTextBoxColumn.HeaderText = "Id du poste";
			this.shiftIdDataGridViewTextBoxColumn.Name = "shiftIdDataGridViewTextBoxColumn";
			// 
			// customerIdDataGridViewTextBoxColumn
			// 
			this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
			this.customerIdDataGridViewTextBoxColumn.HeaderText = "Id Client";
			this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
			// 
			// creditDataGridViewCheckBoxColumn
			// 
			this.creditDataGridViewCheckBoxColumn.DataPropertyName = "Credit";
			this.creditDataGridViewCheckBoxColumn.HeaderText = "Crédit";
			this.creditDataGridViewCheckBoxColumn.Name = "creditDataGridViewCheckBoxColumn";
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
			this.paidDataGridViewTextBoxColumn.HeaderText = "Payé";
			this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
			// 
			// thresholdDataGridViewTextBoxColumn
			// 
			this.thresholdDataGridViewTextBoxColumn.DataPropertyName = "Threshold";
			this.thresholdDataGridViewTextBoxColumn.HeaderText = "Threshold";
			this.thresholdDataGridViewTextBoxColumn.Name = "thresholdDataGridViewTextBoxColumn";
			this.thresholdDataGridViewTextBoxColumn.Visible = false;
			// 
			// leftDataGridViewTextBoxColumn
			// 
			this.leftDataGridViewTextBoxColumn.DataPropertyName = "Left";
			this.leftDataGridViewTextBoxColumn.HeaderText = "Left";
			this.leftDataGridViewTextBoxColumn.Name = "leftDataGridViewTextBoxColumn";
			// 
			// UC_Invoices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.panelSearch);
			this.Name = "UC_Invoices";
			this.Size = new System.Drawing.Size(1103, 563);
			this.panelSearch.ResumeLayout(false);
			this.panelSearch.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelSearch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dpEnd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dpStart;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbxDefinedPeriod;
		private System.Windows.Forms.TextBox tbDays;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbClientName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbCashierName;
		private FontAwesome.Sharp.IconButton btnCash;
		private FontAwesome.Sharp.IconButton btnCredit;
		private FontAwesome.Sharp.IconButton btnAll;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cashierDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbTotal;
		private System.Windows.Forms.TextBox tbLeft;
		private System.Windows.Forms.TextBox tbPaid;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
		private System.Windows.Forms.BindingSource invoiceBindingSource;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shiftIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn creditDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn thresholdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn leftDataGridViewTextBoxColumn;
	}
}
