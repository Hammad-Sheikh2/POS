
namespace POS.Forms.Customers
{
	partial class FormCreditByCustomer
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label31 = new System.Windows.Forms.Label();
			this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
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
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			this.SuspendLayout();
			// 
			// label31
			// 
			this.label31.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label31.AutoSize = true;
			this.label31.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label31.Location = new System.Drawing.Point(269, 5);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(238, 17);
			this.label31.TabIndex = 21;
			this.label31.Text = "Voici les factures de crédit de ce client:";
			// 
			// invoiceBindingSource
			// 
			this.invoiceBindingSource.DataSource = typeof(POS.Classes.Finances.Invoice);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this.dg;
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
			this.dg.Location = new System.Drawing.Point(23, 25);
			this.dg.Name = "dg";
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.RowHeadersVisible = false;
			this.dg.Size = new System.Drawing.Size(772, 446);
			this.dg.TabIndex = 22;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "ID de la facture";
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
			this.customerIdDataGridViewTextBoxColumn.HeaderText = "N ° de client";
			this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
			// 
			// creditDataGridViewCheckBoxColumn
			// 
			this.creditDataGridViewCheckBoxColumn.DataPropertyName = "Credit";
			this.creditDataGridViewCheckBoxColumn.HeaderText = "Credit";
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
			this.paidDataGridViewTextBoxColumn.HeaderText = "payé";
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
			this.leftDataGridViewTextBoxColumn.HeaderText = "montant restant";
			this.leftDataGridViewTextBoxColumn.Name = "leftDataGridViewTextBoxColumn";
			// 
			// FormCreditByCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(818, 483);
			this.Controls.Add(this.label31);
			this.Controls.Add(this.dg);
			this.Name = "FormCreditByCustomer";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "factures de crédit";
			this.Load += new System.EventHandler(this.FormCreditByCustomer_Load);
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.BindingSource invoiceBindingSource;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
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