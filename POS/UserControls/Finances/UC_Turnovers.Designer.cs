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
			this.panelListings = new System.Windows.Forms.Panel();
			this.Canva = new System.Windows.Forms.Panel();
			this.btnProducts = new FontAwesome.Sharp.IconButton();
			this.btnCashier = new FontAwesome.Sharp.IconButton();
			this.btnMonth = new FontAwesome.Sharp.IconButton();
			this.panelListings.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelListings
			// 
			this.panelListings.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panelListings.BackColor = System.Drawing.Color.Transparent;
			this.panelListings.Controls.Add(this.btnMonth);
			this.panelListings.Controls.Add(this.btnCashier);
			this.panelListings.Controls.Add(this.btnProducts);
			this.panelListings.Location = new System.Drawing.Point(321, 29);
			this.panelListings.Name = "panelListings";
			this.panelListings.Size = new System.Drawing.Size(453, 76);
			this.panelListings.TabIndex = 12;
			// 
			// Canva
			// 
			this.Canva.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Canva.BackColor = System.Drawing.Color.Transparent;
			this.Canva.Location = new System.Drawing.Point(97, 111);
			this.Canva.Name = "Canva";
			this.Canva.Size = new System.Drawing.Size(914, 438);
			this.Canva.TabIndex = 93;
			// 
			// btnProducts
			// 
			this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProducts.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnProducts.Font = new System.Drawing.Font("Calibri", 15F);
			this.btnProducts.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnProducts.IconColor = System.Drawing.Color.Black;
			this.btnProducts.IconSize = 16;
			this.btnProducts.Location = new System.Drawing.Point(10, 3);
			this.btnProducts.Name = "btnProducts";
			this.btnProducts.Rotation = 0D;
			this.btnProducts.Size = new System.Drawing.Size(140, 70);
			this.btnProducts.TabIndex = 9;
			this.btnProducts.Text = "By Products";
			this.btnProducts.UseVisualStyleBackColor = true;
			this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
			// 
			// btnCashier
			// 
			this.btnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCashier.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCashier.Font = new System.Drawing.Font("Calibri", 15F);
			this.btnCashier.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnCashier.IconColor = System.Drawing.Color.Black;
			this.btnCashier.IconSize = 16;
			this.btnCashier.Location = new System.Drawing.Point(156, 3);
			this.btnCashier.Name = "btnCashier";
			this.btnCashier.Rotation = 0D;
			this.btnCashier.Size = new System.Drawing.Size(135, 70);
			this.btnCashier.TabIndex = 10;
			this.btnCashier.Text = "By Cashier";
			this.btnCashier.UseVisualStyleBackColor = true;
			this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
			// 
			// btnMonth
			// 
			this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMonth.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnMonth.Font = new System.Drawing.Font("Calibri", 15F);
			this.btnMonth.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnMonth.IconColor = System.Drawing.Color.Black;
			this.btnMonth.IconSize = 16;
			this.btnMonth.Location = new System.Drawing.Point(297, 3);
			this.btnMonth.Name = "btnMonth";
			this.btnMonth.Rotation = 0D;
			this.btnMonth.Size = new System.Drawing.Size(147, 70);
			this.btnMonth.TabIndex = 11;
			this.btnMonth.Text = "By Month";
			this.btnMonth.UseVisualStyleBackColor = true;
			this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
			// 
			// UC_Turnovers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Canva);
			this.Controls.Add(this.panelListings);
			this.Name = "UC_Turnovers";
			this.Size = new System.Drawing.Size(1103, 563);
			this.panelListings.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelListings;
		private System.Windows.Forms.Panel Canva;
		private FontAwesome.Sharp.IconButton btnMonth;
		private FontAwesome.Sharp.IconButton btnCashier;
		private FontAwesome.Sharp.IconButton btnProducts;
	}
}
