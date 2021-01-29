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
			this.label3 = new System.Windows.Forms.Label();
			this.tbChange = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCheckout = new FontAwesome.Sharp.IconButton();
			this.label5 = new System.Windows.Forms.Label();
			this.lblId = new System.Windows.Forms.Label();
			this.btnCancel = new FontAwesome.Sharp.IconButton();
			this.tbCashGiven = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// tbNoOfProducts
			// 
			this.tbNoOfProducts.Enabled = false;
			this.tbNoOfProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbNoOfProducts.Location = new System.Drawing.Point(147, 55);
			this.tbNoOfProducts.Name = "tbNoOfProducts";
			this.tbNoOfProducts.Size = new System.Drawing.Size(134, 29);
			this.tbNoOfProducts.TabIndex = 102;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(17, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 23);
			this.label1.TabIndex = 101;
			this.label1.Text = "No de produits";
			// 
			// tbTotalBill
			// 
			this.tbTotalBill.Enabled = false;
			this.tbTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbTotalBill.Location = new System.Drawing.Point(147, 90);
			this.tbTotalBill.Name = "tbTotalBill";
			this.tbTotalBill.Size = new System.Drawing.Size(134, 29);
			this.tbTotalBill.TabIndex = 104;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 23);
			this.label2.TabIndex = 103;
			this.label2.Text = "Total Facture";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 129);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 23);
			this.label3.TabIndex = 105;
			this.label3.Text = "Montant Remis";
			// 
			// tbChange
			// 
			this.tbChange.Enabled = false;
			this.tbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbChange.Location = new System.Drawing.Point(147, 157);
			this.tbChange.Name = "tbChange";
			this.tbChange.Size = new System.Drawing.Size(134, 29);
			this.tbChange.TabIndex = 108;
			this.tbChange.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(17, 164);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 23);
			this.label4.TabIndex = 107;
			this.label4.Text = "Monnaie";
			// 
			// btnCheckout
			// 
			this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCheckout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCheckout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckout.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
			this.btnCheckout.IconColor = System.Drawing.Color.Black;
			this.btnCheckout.IconSize = 40;
			this.btnCheckout.Location = new System.Drawing.Point(289, 55);
			this.btnCheckout.Name = "btnCheckout";
			this.btnCheckout.Rotation = 0D;
			this.btnCheckout.Size = new System.Drawing.Size(140, 99);
			this.btnCheckout.TabIndex = 109;
			this.btnCheckout.Text = "Payer";
			this.btnCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnCheckout.UseVisualStyleBackColor = true;
			this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(160, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(121, 23);
			this.label5.TabIndex = 110;
			this.label5.Text = "ID de facture#";
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
			this.lblId.Location = new System.Drawing.Point(287, 9);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(20, 23);
			this.lblId.TabIndex = 111;
			this.lblId.Text = "0";
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
			this.btnCancel.Location = new System.Drawing.Point(289, 158);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Rotation = 0D;
			this.btnCancel.Size = new System.Drawing.Size(140, 31);
			this.btnCancel.TabIndex = 125;
			this.btnCancel.Text = "Annuler";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// tbCashGiven
			// 
			this.tbCashGiven.BackColor = System.Drawing.Color.White;
			this.tbCashGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbCashGiven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tbCashGiven.Location = new System.Drawing.Point(147, 125);
			this.tbCashGiven.Name = "tbCashGiven";
			this.tbCashGiven.Size = new System.Drawing.Size(134, 29);
			this.tbCashGiven.TabIndex = 126;
			this.tbCashGiven.Text = "0";
			this.tbCashGiven.TextChanged += new System.EventHandler(this.tbCashGiven_TextChanged);
			// 
			// FormCashPurchase
			// 
			this.AcceptButton = this.btnCheckout;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(461, 195);
			this.Controls.Add(this.tbCashGiven);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnCheckout);
			this.Controls.Add(this.tbChange);
			this.Controls.Add(this.label4);
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
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Achat Espèce";
			this.Load += new System.EventHandler(this.FormCashPurchase_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbChange;
		private System.Windows.Forms.Label label4;
		private FontAwesome.Sharp.IconButton btnCheckout;
		public System.Windows.Forms.TextBox tbNoOfProducts;
		public System.Windows.Forms.TextBox tbTotalBill;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblId;
		private FontAwesome.Sharp.IconButton btnCancel;
		private System.Windows.Forms.TextBox tbCashGiven;
	}
}