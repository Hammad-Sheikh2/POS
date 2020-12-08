namespace POS.UserControls.Finances
{
	partial class UC_Closing
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
			this.Canva = new System.Windows.Forms.Panel();
			this.panelListings = new System.Windows.Forms.Panel();
			this.btnClosingMonth = new FontAwesome.Sharp.IconButton();
			this.btnClosingDay = new FontAwesome.Sharp.IconButton();
			this.btnClosingShift = new FontAwesome.Sharp.IconButton();
			this.panelListings.SuspendLayout();
			this.SuspendLayout();
			// 
			// Canva
			// 
			this.Canva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.Canva.BackColor = System.Drawing.Color.Transparent;
			this.Canva.Location = new System.Drawing.Point(94, 103);
			this.Canva.Name = "Canva";
			this.Canva.Size = new System.Drawing.Size(914, 438);
			this.Canva.TabIndex = 95;
			// 
			// panelListings
			// 
			this.panelListings.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panelListings.BackColor = System.Drawing.Color.Transparent;
			this.panelListings.Controls.Add(this.btnClosingMonth);
			this.panelListings.Controls.Add(this.btnClosingDay);
			this.panelListings.Controls.Add(this.btnClosingShift);
			this.panelListings.Location = new System.Drawing.Point(94, 65);
			this.panelListings.Name = "panelListings";
			this.panelListings.Size = new System.Drawing.Size(914, 32);
			this.panelListings.TabIndex = 94;
			// 
			// btnClosingMonth
			// 
			this.btnClosingMonth.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnClosingMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClosingMonth.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnClosingMonth.Font = new System.Drawing.Font("Calibri", 15F);
			this.btnClosingMonth.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnClosingMonth.IconColor = System.Drawing.Color.Black;
			this.btnClosingMonth.IconSize = 16;
			this.btnClosingMonth.Location = new System.Drawing.Point(601, 0);
			this.btnClosingMonth.Name = "btnClosingMonth";
			this.btnClosingMonth.Rotation = 0D;
			this.btnClosingMonth.Size = new System.Drawing.Size(310, 32);
			this.btnClosingMonth.TabIndex = 11;
			this.btnClosingMonth.Text = "Closing Month";
			this.btnClosingMonth.UseVisualStyleBackColor = true;
			this.btnClosingMonth.Click += new System.EventHandler(this.btnClosingMonth_Click);
			// 
			// btnClosingDay
			// 
			this.btnClosingDay.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnClosingDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClosingDay.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnClosingDay.Font = new System.Drawing.Font("Calibri", 15F);
			this.btnClosingDay.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnClosingDay.IconColor = System.Drawing.Color.Black;
			this.btnClosingDay.IconSize = 16;
			this.btnClosingDay.Location = new System.Drawing.Point(303, 0);
			this.btnClosingDay.Name = "btnClosingDay";
			this.btnClosingDay.Rotation = 0D;
			this.btnClosingDay.Size = new System.Drawing.Size(298, 32);
			this.btnClosingDay.TabIndex = 10;
			this.btnClosingDay.Text = "Closing Day";
			this.btnClosingDay.UseVisualStyleBackColor = true;
			this.btnClosingDay.Click += new System.EventHandler(this.btnClosingDay_Click);
			// 
			// btnClosingShift
			// 
			this.btnClosingShift.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnClosingShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClosingShift.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnClosingShift.Font = new System.Drawing.Font("Calibri", 15F);
			this.btnClosingShift.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnClosingShift.IconColor = System.Drawing.Color.Black;
			this.btnClosingShift.IconSize = 16;
			this.btnClosingShift.Location = new System.Drawing.Point(0, 0);
			this.btnClosingShift.Name = "btnClosingShift";
			this.btnClosingShift.Rotation = 0D;
			this.btnClosingShift.Size = new System.Drawing.Size(303, 32);
			this.btnClosingShift.TabIndex = 9;
			this.btnClosingShift.Text = "Closing Shift";
			this.btnClosingShift.UseVisualStyleBackColor = true;
			this.btnClosingShift.Click += new System.EventHandler(this.btnClosingShift_Click);
			// 
			// UC_Closing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Canva);
			this.Controls.Add(this.panelListings);
			this.Name = "UC_Closing";
			this.Size = new System.Drawing.Size(1103, 563);
			this.panelListings.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Canva;
		private System.Windows.Forms.Panel panelListings;
		private FontAwesome.Sharp.IconButton btnClosingMonth;
		private FontAwesome.Sharp.IconButton btnClosingDay;
		private FontAwesome.Sharp.IconButton btnClosingShift;
	}
}
