namespace POS.UserControls
{
	partial class UC_Turnovers
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
			this.panelSearch = new System.Windows.Forms.Panel();
			this.btnByMonth = new FontAwesome.Sharp.IconButton();
			this.btnByCashier = new FontAwesome.Sharp.IconButton();
			this.btnByProducts = new FontAwesome.Sharp.IconButton();
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
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbTotalMargin = new System.Windows.Forms.TextBox();
			this.tbTotalSell = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbTotalBuy = new System.Windows.Forms.TextBox();
			this.tbTotalQty = new System.Windows.Forms.TextBox();
			this.turnOverCashierBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.turnOverProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.turnOverMonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panelSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.turnOverCashierBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.turnOverProductsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.turnOverMonthBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panelSearch
			// 
			this.panelSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panelSearch.BackColor = System.Drawing.Color.Silver;
			this.panelSearch.Controls.Add(this.btnByMonth);
			this.panelSearch.Controls.Add(this.btnByCashier);
			this.panelSearch.Controls.Add(this.btnByProducts);
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
			this.panelSearch.Location = new System.Drawing.Point(201, 22);
			this.panelSearch.Name = "panelSearch";
			this.panelSearch.Size = new System.Drawing.Size(708, 119);
			this.panelSearch.TabIndex = 94;
			// 
			// btnByMonth
			// 
			this.btnByMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnByMonth.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnByMonth.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnByMonth.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnByMonth.IconColor = System.Drawing.Color.Black;
			this.btnByMonth.IconSize = 16;
			this.btnByMonth.Location = new System.Drawing.Point(436, 81);
			this.btnByMonth.Name = "btnByMonth";
			this.btnByMonth.Rotation = 0D;
			this.btnByMonth.Size = new System.Drawing.Size(140, 32);
			this.btnByMonth.TabIndex = 128;
			this.btnByMonth.Text = "By Month";
			this.btnByMonth.UseVisualStyleBackColor = true;
			this.btnByMonth.Click += new System.EventHandler(this.btnByMonth_Click);
			// 
			// btnByCashier
			// 
			this.btnByCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnByCashier.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnByCashier.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnByCashier.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnByCashier.IconColor = System.Drawing.Color.Black;
			this.btnByCashier.IconSize = 16;
			this.btnByCashier.Location = new System.Drawing.Point(290, 81);
			this.btnByCashier.Name = "btnByCashier";
			this.btnByCashier.Rotation = 0D;
			this.btnByCashier.Size = new System.Drawing.Size(140, 32);
			this.btnByCashier.TabIndex = 127;
			this.btnByCashier.Text = "By Cashier";
			this.btnByCashier.UseVisualStyleBackColor = true;
			this.btnByCashier.Click += new System.EventHandler(this.btnByCashier_Click);
			// 
			// btnByProducts
			// 
			this.btnByProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnByProducts.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnByProducts.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnByProducts.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnByProducts.IconColor = System.Drawing.Color.Black;
			this.btnByProducts.IconSize = 16;
			this.btnByProducts.Location = new System.Drawing.Point(144, 81);
			this.btnByProducts.Name = "btnByProducts";
			this.btnByProducts.Rotation = 0D;
			this.btnByProducts.Size = new System.Drawing.Size(140, 32);
			this.btnByProducts.TabIndex = 126;
			this.btnByProducts.Text = "By Products";
			this.btnByProducts.UseVisualStyleBackColor = true;
			this.btnByProducts.Click += new System.EventHandler(this.btnByProducts_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label6.Location = new System.Drawing.Point(448, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 18);
			this.label6.TabIndex = 125;
			this.label6.Text = "Client Name";
			// 
			// tbClientName
			// 
			this.tbClientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tbClientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.tbClientName.Location = new System.Drawing.Point(539, 44);
			this.tbClientName.Name = "tbClientName";
			this.tbClientName.Size = new System.Drawing.Size(104, 24);
			this.tbClientName.TabIndex = 124;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label3.Location = new System.Drawing.Point(439, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 18);
			this.label3.TabIndex = 123;
			this.label3.Text = "Cashier Name";
			// 
			// tbCashierName
			// 
			this.tbCashierName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tbCashierName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbCashierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.tbCashierName.Location = new System.Drawing.Point(539, 16);
			this.tbCashierName.Name = "tbCashierName";
			this.tbCashierName.Size = new System.Drawing.Size(104, 24);
			this.tbCashierName.TabIndex = 122;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label2.Location = new System.Drawing.Point(81, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 18);
			this.label2.TabIndex = 121;
			this.label2.Text = "End Date";
			// 
			// dpEnd
			// 
			this.dpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.dpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dpEnd.Location = new System.Drawing.Point(156, 49);
			this.dpEnd.Name = "dpEnd";
			this.dpEnd.Size = new System.Drawing.Size(123, 24);
			this.dpEnd.TabIndex = 120;
			this.dpEnd.ValueChanged += new System.EventHandler(this.ValidateDateInterval);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label1.Location = new System.Drawing.Point(81, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 18);
			this.label1.TabIndex = 119;
			this.label1.Text = "Start Date";
			// 
			// dpStart
			// 
			this.dpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.dpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dpStart.Location = new System.Drawing.Point(156, 19);
			this.dpStart.Name = "dpStart";
			this.dpStart.Size = new System.Drawing.Size(123, 24);
			this.dpStart.TabIndex = 118;
			this.dpStart.ValueChanged += new System.EventHandler(this.ValidateDateInterval);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label4.Location = new System.Drawing.Point(315, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 18);
			this.label4.TabIndex = 117;
			this.label4.Text = "Days";
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
			this.cbxDefinedPeriod.Location = new System.Drawing.Point(308, 49);
			this.cbxDefinedPeriod.Name = "cbxDefinedPeriod";
			this.cbxDefinedPeriod.Size = new System.Drawing.Size(122, 26);
			this.cbxDefinedPeriod.TabIndex = 116;
			this.cbxDefinedPeriod.Text = "Defined Period";
			this.cbxDefinedPeriod.SelectedIndexChanged += new System.EventHandler(this.cbxDefinedPeriod_SelectedIndexChanged);
			// 
			// tbDays
			// 
			this.tbDays.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tbDays.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbDays.Enabled = false;
			this.tbDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.tbDays.Location = new System.Drawing.Point(355, 21);
			this.tbDays.Name = "tbDays";
			this.tbDays.Size = new System.Drawing.Size(75, 24);
			this.tbDays.TabIndex = 115;
			this.tbDays.Text = "0";
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
			// dg
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
			this.dg.Location = new System.Drawing.Point(39, 147);
			this.dg.Name = "dg";
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.RowHeadersVisible = false;
			this.dg.Size = new System.Drawing.Size(1010, 364);
			this.dg.TabIndex = 115;
			this.dg.Paint += new System.Windows.Forms.PaintEventHandler(this.dg_Paint);
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.tbTotalQty);
			this.panel1.Controls.Add(this.tbTotalMargin);
			this.panel1.Controls.Add(this.tbTotalSell);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.tbTotalBuy);
			this.panel1.Location = new System.Drawing.Point(39, 517);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1010, 39);
			this.panel1.TabIndex = 119;
			// 
			// tbTotalMargin
			// 
			this.tbTotalMargin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tbTotalMargin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbTotalMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.tbTotalMargin.Location = new System.Drawing.Point(892, 8);
			this.tbTotalMargin.Name = "tbTotalMargin";
			this.tbTotalMargin.Size = new System.Drawing.Size(107, 24);
			this.tbTotalMargin.TabIndex = 116;
			// 
			// tbTotalSell
			// 
			this.tbTotalSell.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tbTotalSell.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbTotalSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.tbTotalSell.Location = new System.Drawing.Point(760, 8);
			this.tbTotalSell.Name = "tbTotalSell";
			this.tbTotalSell.Size = new System.Drawing.Size(127, 24);
			this.tbTotalSell.TabIndex = 115;
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
			// tbTotalBuy
			// 
			this.tbTotalBuy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tbTotalBuy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbTotalBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.tbTotalBuy.Location = new System.Drawing.Point(629, 8);
			this.tbTotalBuy.Name = "tbTotalBuy";
			this.tbTotalBuy.Size = new System.Drawing.Size(125, 24);
			this.tbTotalBuy.TabIndex = 111;
			// 
			// tbTotalQty
			// 
			this.tbTotalQty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tbTotalQty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.tbTotalQty.Location = new System.Drawing.Point(498, 8);
			this.tbTotalQty.Name = "tbTotalQty";
			this.tbTotalQty.Size = new System.Drawing.Size(125, 24);
			this.tbTotalQty.TabIndex = 117;
			// 
			// turnOverCashierBindingSource
			// 
			this.turnOverCashierBindingSource.DataSource = typeof(POS.Classes.Finances.TurnOverCashier);
			// 
			// turnOverProductsBindingSource
			// 
			this.turnOverProductsBindingSource.DataSource = typeof(POS.Classes.Finances.TurnOverProducts);
			// 
			// turnOverMonthBindingSource
			// 
			this.turnOverMonthBindingSource.DataSource = typeof(POS.Classes.Finances.TurnOverMonth);
			// 
			// UC_Turnovers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.panelSearch);
			this.Name = "UC_Turnovers";
			this.Size = new System.Drawing.Size(1103, 563);
			this.panelSearch.ResumeLayout(false);
			this.panelSearch.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.turnOverCashierBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.turnOverProductsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.turnOverMonthBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelSearch;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbClientName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbCashierName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dpEnd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dpStart;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbxDefinedPeriod;
		private System.Windows.Forms.TextBox tbDays;
		private FontAwesome.Sharp.IconButton btnByMonth;
		private FontAwesome.Sharp.IconButton btnByCashier;
		private FontAwesome.Sharp.IconButton btnByProducts;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox tbTotalMargin;
		private System.Windows.Forms.TextBox tbTotalSell;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbTotalBuy;
		private System.Windows.Forms.TextBox tbTotalQty;
		private System.Windows.Forms.BindingSource turnOverProductsBindingSource;
		private System.Windows.Forms.BindingSource turnOverCashierBindingSource;
		private System.Windows.Forms.BindingSource turnOverMonthBindingSource;
	}
}
