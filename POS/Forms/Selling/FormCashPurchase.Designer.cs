namespace POS.Forms.Selling
{
	partial class FormCashPurchase
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
			this.tbNoOfProducts = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbTotalBill = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbCashGiven = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbChange = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCredit = new FontAwesome.Sharp.IconButton();
			this.SuspendLayout();
			// 
			// tbNoOfProducts
			// 
			this.tbNoOfProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbNoOfProducts.Location = new System.Drawing.Point(147, 31);
			this.tbNoOfProducts.Name = "tbNoOfProducts";
			this.tbNoOfProducts.Size = new System.Drawing.Size(134, 29);
			this.tbNoOfProducts.TabIndex = 102;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(17, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 23);
			this.label1.TabIndex = 101;
			this.label1.Text = "N\" of products";
			// 
			// tbTotalBill
			// 
			this.tbTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbTotalBill.Location = new System.Drawing.Point(147, 66);
			this.tbTotalBill.Name = "tbTotalBill";
			this.tbTotalBill.Size = new System.Drawing.Size(134, 29);
			this.tbTotalBill.TabIndex = 104;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 23);
			this.label2.TabIndex = 103;
			this.label2.Text = "Total Bill";
			// 
			// tbCashGiven
			// 
			this.tbCashGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbCashGiven.Location = new System.Drawing.Point(147, 101);
			this.tbCashGiven.Name = "tbCashGiven";
			this.tbCashGiven.Size = new System.Drawing.Size(134, 29);
			this.tbCashGiven.TabIndex = 106;
			this.tbCashGiven.Text = "0";
			this.tbCashGiven.TextChanged += new System.EventHandler(this.tbCashGiven_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 23);
			this.label3.TabIndex = 105;
			this.label3.Text = "Cash Given";
			// 
			// tbChange
			// 
			this.tbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbChange.Location = new System.Drawing.Point(147, 136);
			this.tbChange.Name = "tbChange";
			this.tbChange.Size = new System.Drawing.Size(134, 29);
			this.tbChange.TabIndex = 108;
			this.tbChange.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(17, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 23);
			this.label4.TabIndex = 107;
			this.label4.Text = "Change";
			// 
			// btnCredit
			// 
			this.btnCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCredit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCredit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCredit.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnCredit.IconColor = System.Drawing.Color.Black;
			this.btnCredit.IconSize = 16;
			this.btnCredit.Location = new System.Drawing.Point(309, 57);
			this.btnCredit.Name = "btnCredit";
			this.btnCredit.Rotation = 0D;
			this.btnCredit.Size = new System.Drawing.Size(140, 71);
			this.btnCredit.TabIndex = 109;
			this.btnCredit.Text = "Confirm";
			this.btnCredit.UseVisualStyleBackColor = true;
			// 
			// FormCashPurchase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 195);
			this.Controls.Add(this.btnCredit);
			this.Controls.Add(this.tbChange);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbCashGiven);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbTotalBill);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbNoOfProducts);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(477, 234);
			this.MinimumSize = new System.Drawing.Size(477, 234);
			this.Name = "FormCashPurchase";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cash Purchase";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbCashGiven;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbChange;
		private System.Windows.Forms.Label label4;
		private FontAwesome.Sharp.IconButton btnCredit;
		public System.Windows.Forms.TextBox tbNoOfProducts;
		public System.Windows.Forms.TextBox tbTotalBill;
	}
}