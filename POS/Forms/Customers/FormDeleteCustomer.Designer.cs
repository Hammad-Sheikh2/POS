namespace POS.Forms.Customers
{
	partial class FormDeleteCustomer
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
			this.cbxFilter = new System.Windows.Forms.ComboBox();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.btnCredit = new FontAwesome.Sharp.IconButton();
			this.SuspendLayout();
			// 
			// cbxFilter
			// 
			this.cbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbxFilter.FormattingEnabled = true;
			this.cbxFilter.Items.AddRange(new object[] {
            "Id",
            "Name",
            "Address",
            "Proprietor",
            "Email",
            "Contact",
            "Fax"});
			this.cbxFilter.Location = new System.Drawing.Point(26, 25);
			this.cbxFilter.Name = "cbxFilter";
			this.cbxFilter.Size = new System.Drawing.Size(229, 26);
			this.cbxFilter.TabIndex = 115;
			this.cbxFilter.Text = "Search by Id";
			// 
			// tbSearch
			// 
			this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbSearch.Location = new System.Drawing.Point(26, 57);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(229, 26);
			this.tbSearch.TabIndex = 114;
			this.tbSearch.Text = "Search by Name";
			// 
			// btnCredit
			// 
			this.btnCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCredit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCredit.Font = new System.Drawing.Font("Calibri", 11F);
			this.btnCredit.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnCredit.IconColor = System.Drawing.Color.Black;
			this.btnCredit.IconSize = 16;
			this.btnCredit.Location = new System.Drawing.Point(84, 97);
			this.btnCredit.Name = "btnCredit";
			this.btnCredit.Rotation = 0D;
			this.btnCredit.Size = new System.Drawing.Size(115, 26);
			this.btnCredit.TabIndex = 116;
			this.btnCredit.Text = "Delete";
			this.btnCredit.UseVisualStyleBackColor = true;
			// 
			// FormDeleteCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(285, 141);
			this.Controls.Add(this.btnCredit);
			this.Controls.Add(this.cbxFilter);
			this.Controls.Add(this.tbSearch);
			this.Name = "FormDeleteCustomer";
			this.Text = "Delete Customer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FontAwesome.Sharp.IconButton btnCredit;
		private System.Windows.Forms.ComboBox cbxFilter;
		private System.Windows.Forms.TextBox tbSearch;
	}
}