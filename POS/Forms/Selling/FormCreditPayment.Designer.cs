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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tbTotal = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.invoiceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.leftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.creditInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnPayment = new FontAwesome.Sharp.IconButton();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.creditInvoiceBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tbTotal
			// 
			this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbTotal.Location = new System.Drawing.Point(138, 12);
			this.tbTotal.Name = "tbTotal";
			this.tbTotal.Size = new System.Drawing.Size(430, 29);
			this.tbTotal.TabIndex = 102;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 19);
			this.label1.TabIndex = 101;
			this.label1.Text = "Customer name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(134, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 19);
			this.label2.TabIndex = 103;
			this.label2.Text = "Unpaid Invoices";
			// 
			// dg
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.dateDataGridViewTextBoxColumn,
            this.invoiceNumberDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn,
            this.leftDataGridViewTextBoxColumn});
			this.dg.DataSource = this.creditInvoiceBindingSource;
			this.dg.DoubleBuffered = true;
			this.dg.EnableHeadersVisualStyles = false;
			this.dg.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.dg.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.Location = new System.Drawing.Point(133, 87);
			this.dg.Name = "dg";
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.RowHeadersVisible = false;
			this.dg.Size = new System.Drawing.Size(440, 113);
			this.dg.TabIndex = 104;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			// 
			// invoiceNumberDataGridViewTextBoxColumn
			// 
			this.invoiceNumberDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNumber";
			this.invoiceNumberDataGridViewTextBoxColumn.HeaderText = "Invoice #";
			this.invoiceNumberDataGridViewTextBoxColumn.Name = "invoiceNumberDataGridViewTextBoxColumn";
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
			this.paidDataGridViewTextBoxColumn.HeaderText = "Paid";
			this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
			// 
			// leftDataGridViewTextBoxColumn
			// 
			this.leftDataGridViewTextBoxColumn.DataPropertyName = "Left";
			this.leftDataGridViewTextBoxColumn.HeaderText = "Left";
			this.leftDataGridViewTextBoxColumn.Name = "leftDataGridViewTextBoxColumn";
			// 
			// creditInvoiceBindingSource
			// 
			this.creditInvoiceBindingSource.DataSource = typeof(POS.Classes.Selling.CreditInvoice);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 12F);
			this.label3.Location = new System.Drawing.Point(12, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 19);
			this.label3.TabIndex = 105;
			this.label3.Text = "Pay now";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.textBox1.Location = new System.Drawing.Point(16, 111);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(98, 26);
			this.textBox1.TabIndex = 106;
			// 
			// btnPayment
			// 
			this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPayment.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnPayment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPayment.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnPayment.IconColor = System.Drawing.Color.Black;
			this.btnPayment.IconSize = 16;
			this.btnPayment.Location = new System.Drawing.Point(16, 143);
			this.btnPayment.Name = "btnPayment";
			this.btnPayment.Rotation = 0D;
			this.btnPayment.Size = new System.Drawing.Size(98, 31);
			this.btnPayment.TabIndex = 107;
			this.btnPayment.Text = "Confirm";
			this.btnPayment.UseVisualStyleBackColor = true;
			// 
			// FormCreditPayment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 225);
			this.Controls.Add(this.btnPayment);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbTotal);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(610, 264);
			this.MinimumSize = new System.Drawing.Size(610, 264);
			this.Name = "FormCreditPayment";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Credit Payment";
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.creditInvoiceBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbTotal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn leftDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource creditInvoiceBindingSource;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private FontAwesome.Sharp.IconButton btnPayment;
	}
}