
namespace POS.Forms.Selling
{
	partial class FormReturnPurchase
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
			this.lblId = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbTotalBill = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbNoOfProducts = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnReturn = new FontAwesome.Sharp.IconButton();
			this.btnCancel = new FontAwesome.Sharp.IconButton();
			this.SuspendLayout();
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
			this.lblId.Location = new System.Drawing.Point(252, 6);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(20, 23);
			this.lblId.TabIndex = 122;
			this.lblId.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(148, 6);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 23);
			this.label5.TabIndex = 121;
			this.label5.Text = "Invoice ID#";
			// 
			// tbTotalBill
			// 
			this.tbTotalBill.Enabled = false;
			this.tbTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbTotalBill.Location = new System.Drawing.Point(106, 79);
			this.tbTotalBill.Name = "tbTotalBill";
			this.tbTotalBill.Size = new System.Drawing.Size(191, 29);
			this.tbTotalBill.TabIndex = 115;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Italic);
			this.label2.Location = new System.Drawing.Point(22, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 17);
			this.label2.TabIndex = 114;
			this.label2.Text = "Return Price";
			// 
			// tbNoOfProducts
			// 
			this.tbNoOfProducts.Enabled = false;
			this.tbNoOfProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbNoOfProducts.Location = new System.Drawing.Point(106, 44);
			this.tbNoOfProducts.Name = "tbNoOfProducts";
			this.tbNoOfProducts.Size = new System.Drawing.Size(191, 29);
			this.tbNoOfProducts.TabIndex = 113;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Italic);
			this.label1.Location = new System.Drawing.Point(11, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 17);
			this.label1.TabIndex = 112;
			this.label1.Text = "N\" of products";
			// 
			// btnReturn
			// 
			this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReturn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnReturn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnReturn.IconColor = System.Drawing.Color.Black;
			this.btnReturn.IconSize = 16;
			this.btnReturn.Location = new System.Drawing.Point(106, 114);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Rotation = 0D;
			this.btnReturn.Size = new System.Drawing.Size(191, 31);
			this.btnReturn.TabIndex = 123;
			this.btnReturn.Text = "Confirm";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnCancel.IconColor = System.Drawing.Color.Black;
			this.btnCancel.IconSize = 16;
			this.btnCancel.Location = new System.Drawing.Point(106, 151);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Rotation = 0D;
			this.btnCancel.Size = new System.Drawing.Size(191, 31);
			this.btnCancel.TabIndex = 124;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// FormReturnPurchase
			// 
			this.AcceptButton = this.btnReturn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(410, 196);
			this.ControlBox = false;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbTotalBill);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbNoOfProducts);
			this.Controls.Add(this.label1);
			this.Name = "FormReturnPurchase";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Return Invoice";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox tbTotalBill;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox tbNoOfProducts;
		private System.Windows.Forms.Label label1;
		private FontAwesome.Sharp.IconButton btnReturn;
		private FontAwesome.Sharp.IconButton btnCancel;
	}
}