namespace POS.Reporting
{
	partial class FormInvioceReport
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
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.btnPrint = new FontAwesome.Sharp.IconButton();
			this.bindingInvoice = new System.Windows.Forms.BindingSource(this.components);
			this.bindingCart = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.bindingInvoice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingCart)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS.Reporting.InvoiceReport.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(12, 12);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(367, 409);
			this.reportViewer1.TabIndex = 0;
			// 
			// btnPrint
			// 
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnPrint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
			this.btnPrint.IconColor = System.Drawing.Color.Black;
			this.btnPrint.IconSize = 1;
			this.btnPrint.Location = new System.Drawing.Point(12, 427);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Rotation = 0D;
			this.btnPrint.Size = new System.Drawing.Size(367, 30);
			this.btnPrint.TabIndex = 110;
			this.btnPrint.Text = "Print";
			this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// bindingInvoice
			// 
			this.bindingInvoice.DataSource = typeof(POS.Classes.Finances.Invoice);
			// 
			// bindingCart
			// 
			this.bindingCart.DataSource = typeof(POS.Classes.Cart);
			// 
			// FormInvioceReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 469);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.reportViewer1);
			this.Name = "FormInvioceReport";
			this.Text = "Invoice Report";
			this.Load += new System.EventHandler(this.FormInvioceReport_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingInvoice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingCart)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private FontAwesome.Sharp.IconButton btnPrint;
		private System.Windows.Forms.BindingSource bindingInvoice;
		private System.Windows.Forms.BindingSource bindingCart;
	}
}