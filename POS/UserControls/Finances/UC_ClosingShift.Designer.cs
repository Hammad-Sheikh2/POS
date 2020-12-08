namespace POS.UserControls.Finances
{
	partial class UC_ClosingShift
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.tbTotal = new System.Windows.Forms.TextBox();
			this.btnReturns = new FontAwesome.Sharp.IconButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.lblCashFund = new System.Windows.Forms.Label();
			this.lblDifference = new System.Windows.Forms.Label();
			this.lblTotalSold = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblTime = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.lblShiftId = new System.Windows.Forms.Label();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cashierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shiftBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).BeginInit();
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
            this.dateDataGridViewTextBoxColumn,
            this.cashierDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
			this.dg.DataSource = this.shiftBindingSource;
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
			this.dg.Location = new System.Drawing.Point(445, 3);
			this.dg.Name = "dg";
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.RowHeadersVisible = false;
			this.dg.Size = new System.Drawing.Size(466, 353);
			this.dg.TabIndex = 7;
			this.dg.Paint += new System.Windows.Forms.PaintEventHandler(this.dg_Paint);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.tbTotal);
			this.panel1.Location = new System.Drawing.Point(445, 362);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 39);
			this.panel1.TabIndex = 119;
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
			this.tbTotal.Location = new System.Drawing.Point(307, 8);
			this.tbTotal.Name = "tbTotal";
			this.tbTotal.Size = new System.Drawing.Size(146, 24);
			this.tbTotal.TabIndex = 111;
			// 
			// btnReturns
			// 
			this.btnReturns.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnReturns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReturns.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnReturns.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReturns.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnReturns.IconColor = System.Drawing.Color.Black;
			this.btnReturns.IconSize = 16;
			this.btnReturns.Location = new System.Drawing.Point(0, 407);
			this.btnReturns.Name = "btnReturns";
			this.btnReturns.Rotation = 0D;
			this.btnReturns.Size = new System.Drawing.Size(914, 31);
			this.btnReturns.TabIndex = 120;
			this.btnReturns.Text = "Close Shift";
			this.btnReturns.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.BackColor = System.Drawing.Color.Silver;
			this.panel2.Controls.Add(this.lblCashFund);
			this.panel2.Controls.Add(this.lblDifference);
			this.panel2.Controls.Add(this.lblTotalSold);
			this.panel2.Controls.Add(this.lblUsername);
			this.panel2.Controls.Add(this.lblTime);
			this.panel2.Controls.Add(this.lblDate);
			this.panel2.Controls.Add(this.lblShiftId);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.label15);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(439, 398);
			this.panel2.TabIndex = 120;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label1.Location = new System.Drawing.Point(42, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 18);
			this.label1.TabIndex = 114;
			this.label1.Text = "Shift ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label2.Location = new System.Drawing.Point(42, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 18);
			this.label2.TabIndex = 115;
			this.label2.Text = "Date";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label3.Location = new System.Drawing.Point(42, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 18);
			this.label3.TabIndex = 116;
			this.label3.Text = "Time";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label4.Location = new System.Drawing.Point(42, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 18);
			this.label4.TabIndex = 117;
			this.label4.Text = "Username";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label6.Location = new System.Drawing.Point(42, 156);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 18);
			this.label6.TabIndex = 118;
			this.label6.Text = "Total Sold";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label7.Location = new System.Drawing.Point(42, 190);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 18);
			this.label7.TabIndex = 119;
			this.label7.Text = "Difference";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label8.Location = new System.Drawing.Point(42, 226);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(71, 18);
			this.label8.TabIndex = 120;
			this.label8.Text = "Cash Fund";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label9.Location = new System.Drawing.Point(119, 226);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(12, 18);
			this.label9.TabIndex = 127;
			this.label9.Text = ":";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label10.Location = new System.Drawing.Point(119, 190);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(12, 18);
			this.label10.TabIndex = 126;
			this.label10.Text = ":";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label11.Location = new System.Drawing.Point(119, 156);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(12, 18);
			this.label11.TabIndex = 125;
			this.label11.Text = ":";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label12.Location = new System.Drawing.Point(119, 123);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(12, 18);
			this.label12.TabIndex = 124;
			this.label12.Text = ":";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label13.Location = new System.Drawing.Point(119, 90);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(12, 18);
			this.label13.TabIndex = 123;
			this.label13.Text = ":";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label14.Location = new System.Drawing.Point(119, 61);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(12, 18);
			this.label14.TabIndex = 122;
			this.label14.Text = ":";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.label15.Location = new System.Drawing.Point(119, 31);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(12, 18);
			this.label15.TabIndex = 121;
			this.label15.Text = ":";
			// 
			// lblCashFund
			// 
			this.lblCashFund.AutoSize = true;
			this.lblCashFund.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.lblCashFund.Location = new System.Drawing.Point(137, 226);
			this.lblCashFund.Name = "lblCashFund";
			this.lblCashFund.Size = new System.Drawing.Size(68, 18);
			this.lblCashFund.TabIndex = 134;
			this.lblCashFund.Text = "------------";
			// 
			// lblDifference
			// 
			this.lblDifference.AutoSize = true;
			this.lblDifference.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.lblDifference.Location = new System.Drawing.Point(137, 190);
			this.lblDifference.Name = "lblDifference";
			this.lblDifference.Size = new System.Drawing.Size(68, 18);
			this.lblDifference.TabIndex = 133;
			this.lblDifference.Text = "------------";
			// 
			// lblTotalSold
			// 
			this.lblTotalSold.AutoSize = true;
			this.lblTotalSold.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.lblTotalSold.Location = new System.Drawing.Point(137, 156);
			this.lblTotalSold.Name = "lblTotalSold";
			this.lblTotalSold.Size = new System.Drawing.Size(68, 18);
			this.lblTotalSold.TabIndex = 132;
			this.lblTotalSold.Text = "------------";
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.lblUsername.Location = new System.Drawing.Point(137, 123);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(68, 18);
			this.lblUsername.TabIndex = 131;
			this.lblUsername.Text = "------------";
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.lblTime.Location = new System.Drawing.Point(137, 90);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(39, 18);
			this.lblTime.TabIndex = 130;
			this.lblTime.Text = "Time";
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.lblDate.Location = new System.Drawing.Point(137, 61);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(37, 18);
			this.lblDate.TabIndex = 129;
			this.lblDate.Text = "Date";
			// 
			// lblShiftId
			// 
			this.lblShiftId.AutoSize = true;
			this.lblShiftId.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.lblShiftId.Location = new System.Drawing.Point(137, 31);
			this.lblShiftId.Name = "lblShiftId";
			this.lblShiftId.Size = new System.Drawing.Size(15, 18);
			this.lblShiftId.TabIndex = 128;
			this.lblShiftId.Text = "0";
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Change";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Quantity";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			// 
			// cashierDataGridViewTextBoxColumn
			// 
			this.cashierDataGridViewTextBoxColumn.DataPropertyName = "Cashier";
			this.cashierDataGridViewTextBoxColumn.HeaderText = "Cashier";
			this.cashierDataGridViewTextBoxColumn.Name = "cashierDataGridViewTextBoxColumn";
			// 
			// valueDataGridViewTextBoxColumn
			// 
			this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
			this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
			this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
			// 
			// shiftBindingSource
			// 
			this.shiftBindingSource.DataSource = typeof(POS.Classes.Finances.Shift);
			// 
			// UC_ClosingShift
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnReturns);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dg);
			this.Name = "UC_ClosingShift";
			this.Size = new System.Drawing.Size(914, 438);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
		private System.Windows.Forms.BindingSource shiftBindingSource;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbTotal;
		private FontAwesome.Sharp.IconButton btnReturns;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cashierDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label lblCashFund;
		private System.Windows.Forms.Label lblDifference;
		private System.Windows.Forms.Label lblTotalSold;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Label lblShiftId;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}
