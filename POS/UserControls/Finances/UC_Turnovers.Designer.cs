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
			this.panelListings = new System.Windows.Forms.Panel();
			this.btnMonth = new FontAwesome.Sharp.IconButton();
			this.btnCashier = new FontAwesome.Sharp.IconButton();
			this.btnByProducts = new FontAwesome.Sharp.IconButton();
			this.panelSearch = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.cbxFilter = new System.Windows.Forms.ComboBox();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.panelListings.SuspendLayout();
			this.panelSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			this.SuspendLayout();
			// 
			// panelListings
			// 
			this.panelListings.BackColor = System.Drawing.Color.Transparent;
			this.panelListings.Controls.Add(this.btnMonth);
			this.panelListings.Controls.Add(this.btnCashier);
			this.panelListings.Controls.Add(this.btnByProducts);
			this.panelListings.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelListings.Location = new System.Drawing.Point(0, 83);
			this.panelListings.Name = "panelListings";
			this.panelListings.Size = new System.Drawing.Size(708, 36);
			this.panelListings.TabIndex = 12;
			// 
			// btnMonth
			// 
			this.btnMonth.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMonth.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnMonth.Font = new System.Drawing.Font("Calibri", 15F);
			this.btnMonth.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnMonth.IconColor = System.Drawing.Color.Black;
			this.btnMonth.IconSize = 16;
			this.btnMonth.Location = new System.Drawing.Point(463, 0);
			this.btnMonth.Name = "btnMonth";
			this.btnMonth.Rotation = 0D;
			this.btnMonth.Size = new System.Drawing.Size(241, 36);
			this.btnMonth.TabIndex = 11;
			this.btnMonth.Text = "By Month";
			this.btnMonth.UseVisualStyleBackColor = true;
			this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
			// 
			// btnCashier
			// 
			this.btnCashier.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCashier.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCashier.Font = new System.Drawing.Font("Calibri", 15F);
			this.btnCashier.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnCashier.IconColor = System.Drawing.Color.Black;
			this.btnCashier.IconSize = 16;
			this.btnCashier.Location = new System.Drawing.Point(234, 0);
			this.btnCashier.Name = "btnCashier";
			this.btnCashier.Rotation = 0D;
			this.btnCashier.Size = new System.Drawing.Size(229, 36);
			this.btnCashier.TabIndex = 10;
			this.btnCashier.Text = "By Cashier";
			this.btnCashier.UseVisualStyleBackColor = true;
			this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
			// 
			// btnByProducts
			// 
			this.btnByProducts.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnByProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnByProducts.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnByProducts.Font = new System.Drawing.Font("Calibri", 15F);
			this.btnByProducts.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnByProducts.IconColor = System.Drawing.Color.Black;
			this.btnByProducts.IconSize = 16;
			this.btnByProducts.Location = new System.Drawing.Point(0, 0);
			this.btnByProducts.Name = "btnByProducts";
			this.btnByProducts.Rotation = 0D;
			this.btnByProducts.Size = new System.Drawing.Size(234, 36);
			this.btnByProducts.TabIndex = 9;
			this.btnByProducts.Text = "By Products";
			this.btnByProducts.UseVisualStyleBackColor = true;
			this.btnByProducts.Click += new System.EventHandler(this.btnProducts_Click);
			// 
			// panelSearch
			// 
			this.panelSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panelSearch.BackColor = System.Drawing.Color.Silver;
			this.panelSearch.Controls.Add(this.panelListings);
			this.panelSearch.Controls.Add(this.label6);
			this.panelSearch.Controls.Add(this.textBox2);
			this.panelSearch.Controls.Add(this.label3);
			this.panelSearch.Controls.Add(this.textBox1);
			this.panelSearch.Controls.Add(this.label2);
			this.panelSearch.Controls.Add(this.dateTimePicker2);
			this.panelSearch.Controls.Add(this.label1);
			this.panelSearch.Controls.Add(this.dateTimePicker1);
			this.panelSearch.Controls.Add(this.label4);
			this.panelSearch.Controls.Add(this.cbxFilter);
			this.panelSearch.Controls.Add(this.tbSearch);
			this.panelSearch.Location = new System.Drawing.Point(201, 22);
			this.panelSearch.Name = "panelSearch";
			this.panelSearch.Size = new System.Drawing.Size(708, 119);
			this.panelSearch.TabIndex = 94;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label6.Location = new System.Drawing.Point(426, 43);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 18);
			this.label6.TabIndex = 114;
			this.label6.Text = "Client Name";
			// 
			// textBox2
			// 
			this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.textBox2.Location = new System.Drawing.Point(526, 39);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(157, 24);
			this.textBox2.TabIndex = 113;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label3.Location = new System.Drawing.Point(426, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 18);
			this.label3.TabIndex = 112;
			this.label3.Text = "Cashier Name";
			// 
			// textBox1
			// 
			this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.textBox1.Location = new System.Drawing.Point(526, 11);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(157, 24);
			this.textBox1.TabIndex = 111;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label2.Location = new System.Drawing.Point(24, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 18);
			this.label2.TabIndex = 110;
			this.label2.Text = "End Date";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(99, 44);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(123, 24);
			this.dateTimePicker2.TabIndex = 109;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label1.Location = new System.Drawing.Point(24, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 18);
			this.label1.TabIndex = 108;
			this.label1.Text = "Start Date";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(99, 14);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(123, 24);
			this.dateTimePicker1.TabIndex = 107;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label4.Location = new System.Drawing.Point(258, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 18);
			this.label4.TabIndex = 106;
			this.label4.Text = "Days";
			// 
			// cbxFilter
			// 
			this.cbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbxFilter.FormattingEnabled = true;
			this.cbxFilter.Items.AddRange(new object[] {
            "Today",
            "1 Week",
            "1 Month",
            "3 Months",
            "6 Months",
            "1 Year"});
			this.cbxFilter.Location = new System.Drawing.Point(254, 39);
			this.cbxFilter.Name = "cbxFilter";
			this.cbxFilter.Size = new System.Drawing.Size(157, 26);
			this.cbxFilter.TabIndex = 1;
			this.cbxFilter.Text = "Defined Period";
			// 
			// tbSearch
			// 
			this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.tbSearch.Location = new System.Drawing.Point(301, 11);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(110, 24);
			this.tbSearch.TabIndex = 0;
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
			this.dg.Size = new System.Drawing.Size(1010, 400);
			this.dg.TabIndex = 115;
			// 
			// UC_Turnovers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dg);
			this.Controls.Add(this.panelSearch);
			this.Name = "UC_Turnovers";
			this.Size = new System.Drawing.Size(1103, 563);
			this.panelListings.ResumeLayout(false);
			this.panelSearch.ResumeLayout(false);
			this.panelSearch.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelListings;
		private FontAwesome.Sharp.IconButton btnMonth;
		private FontAwesome.Sharp.IconButton btnCashier;
		private FontAwesome.Sharp.IconButton btnByProducts;
		private System.Windows.Forms.Panel panelSearch;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbxFilter;
		private System.Windows.Forms.TextBox tbSearch;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
	}
}
