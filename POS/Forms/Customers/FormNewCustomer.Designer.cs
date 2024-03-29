﻿namespace POS.Forms.Customers
{
	partial class FormNewCustomer
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClear = new FontAwesome.Sharp.IconButton();
			this.cbxCategory = new System.Windows.Forms.ComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.cbxProvince = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxCity = new System.Windows.Forms.ComboBox();
			this.tbAirtel = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.tbContact2 = new System.Windows.Forms.TextBox();
			this.tbContact1 = new System.Windows.Forms.TextBox();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.btnCredit = new FontAwesome.Sharp.IconButton();
			this.lblId = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.cbxCategory);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.label20);
			this.panel1.Controls.Add(this.cbxProvince);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.cbxCity);
			this.panel1.Controls.Add(this.tbAirtel);
			this.panel1.Controls.Add(this.label18);
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.tbContact2);
			this.panel1.Controls.Add(this.tbContact1);
			this.panel1.Controls.Add(this.tbEmail);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.tbName);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.iconButton1);
			this.panel1.Controls.Add(this.btnCredit);
			this.panel1.Controls.Add(this.lblId);
			this.panel1.Controls.Add(this.label24);
			this.panel1.Controls.Add(this.label25);
			this.panel1.Location = new System.Drawing.Point(23, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(837, 228);
			this.panel1.TabIndex = 0;
			// 
			// btnClear
			// 
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnClear.Font = new System.Drawing.Font("Calibri", 11F);
			this.btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnClear.IconColor = System.Drawing.Color.Black;
			this.btnClear.IconSize = 16;
			this.btnClear.Location = new System.Drawing.Point(487, 194);
			this.btnClear.Name = "btnClear";
			this.btnClear.Rotation = 0D;
			this.btnClear.Size = new System.Drawing.Size(115, 26);
			this.btnClear.TabIndex = 10;
			this.btnClear.Text = "Effacer";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// cbxCategory
			// 
			this.cbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbxCategory.FormattingEnabled = true;
			this.cbxCategory.Items.AddRange(new object[] {
            "Entreprise",
            "Individuel",
            "Entreprise Employee"});
			this.cbxCategory.Location = new System.Drawing.Point(165, 145);
			this.cbxCategory.Name = "cbxCategory";
			this.cbxCategory.Size = new System.Drawing.Size(226, 26);
			this.cbxCategory.TabIndex = 3;
			this.cbxCategory.Text = "Sélectionner";
			this.cbxCategory.Validated += new System.EventHandler(this.ValidateCombobox);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(153, 153);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(11, 15);
			this.label17.TabIndex = 126;
			this.label17.Text = ":";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label20.Location = new System.Drawing.Point(67, 153);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(65, 17);
			this.label20.TabIndex = 125;
			this.label20.Text = "Catégorie";
			// 
			// cbxProvince
			// 
			this.cbxProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbxProvince.FormattingEnabled = true;
			this.cbxProvince.Location = new System.Drawing.Point(166, 114);
			this.cbxProvince.Name = "cbxProvince";
			this.cbxProvince.Size = new System.Drawing.Size(226, 26);
			this.cbxProvince.TabIndex = 2;
			this.cbxProvince.Text = "Sélectionner";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(154, 122);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(11, 15);
			this.label5.TabIndex = 121;
			this.label5.Text = ":";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label6.Location = new System.Drawing.Point(68, 122);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 17);
			this.label6.TabIndex = 120;
			this.label6.Text = "Province";
			// 
			// cbxCity
			// 
			this.cbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbxCity.FormattingEnabled = true;
			this.cbxCity.Location = new System.Drawing.Point(165, 82);
			this.cbxCity.Name = "cbxCity";
			this.cbxCity.Size = new System.Drawing.Size(226, 26);
			this.cbxCity.TabIndex = 1;
			this.cbxCity.Text = "Sélectionner";
			this.cbxCity.Validated += new System.EventHandler(this.ValidateCombobox);
			// 
			// tbAirtel
			// 
			this.tbAirtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbAirtel.Location = new System.Drawing.Point(556, 146);
			this.tbAirtel.Name = "tbAirtel";
			this.tbAirtel.Size = new System.Drawing.Size(215, 26);
			this.tbAirtel.TabIndex = 7;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(543, 153);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(11, 15);
			this.label18.TabIndex = 119;
			this.label18.Text = ":";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label19.Location = new System.Drawing.Point(457, 153);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(86, 17);
			this.label19.TabIndex = 118;
			this.label19.Text = "Airtel Money";
			// 
			// tbContact2
			// 
			this.tbContact2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbContact2.Location = new System.Drawing.Point(556, 113);
			this.tbContact2.Name = "tbContact2";
			this.tbContact2.Size = new System.Drawing.Size(215, 26);
			this.tbContact2.TabIndex = 6;
			// 
			// tbContact1
			// 
			this.tbContact1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbContact1.Location = new System.Drawing.Point(556, 81);
			this.tbContact1.Name = "tbContact1";
			this.tbContact1.Size = new System.Drawing.Size(215, 26);
			this.tbContact1.TabIndex = 5;
			this.tbContact1.Validated += new System.EventHandler(this.ValidateInput);
			// 
			// tbEmail
			// 
			this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbEmail.Location = new System.Drawing.Point(556, 49);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(215, 26);
			this.tbEmail.TabIndex = 4;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(543, 120);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(11, 15);
			this.label12.TabIndex = 114;
			this.label12.Text = ":";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label13.Location = new System.Drawing.Point(457, 120);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(65, 17);
			this.label13.TabIndex = 112;
			this.label13.Text = "Contact 2";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(543, 87);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(11, 15);
			this.label10.TabIndex = 117;
			this.label10.Text = ":";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label11.Location = new System.Drawing.Point(457, 87);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(65, 17);
			this.label11.TabIndex = 116;
			this.label11.Text = "Contact 1";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(543, 57);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(11, 15);
			this.label8.TabIndex = 115;
			this.label8.Text = ":";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label9.Location = new System.Drawing.Point(457, 57);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 17);
			this.label9.TabIndex = 113;
			this.label9.Text = "Email";
			// 
			// tbName
			// 
			this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbName.Location = new System.Drawing.Point(166, 50);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(226, 26);
			this.tbName.TabIndex = 0;
			this.tbName.Validated += new System.EventHandler(this.ValidateInput);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label1.Location = new System.Drawing.Point(66, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 17);
			this.label1.TabIndex = 102;
			this.label1.Text = "Nom";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(153, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(11, 15);
			this.label3.TabIndex = 110;
			this.label3.Text = ":";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(152, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(11, 15);
			this.label2.TabIndex = 105;
			this.label2.Text = ":";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label4.Location = new System.Drawing.Point(67, 90);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 17);
			this.label4.TabIndex = 108;
			this.label4.Text = "Ville";
			// 
			// iconButton1
			// 
			this.iconButton1.DialogResult = System.Windows.Forms.DialogResult.Abort;
			this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.iconButton1.Font = new System.Drawing.Font("Calibri", 11F);
			this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
			this.iconButton1.IconColor = System.Drawing.Color.Black;
			this.iconButton1.IconSize = 16;
			this.iconButton1.Location = new System.Drawing.Point(366, 194);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Rotation = 0D;
			this.iconButton1.Size = new System.Drawing.Size(115, 26);
			this.iconButton1.TabIndex = 9;
			this.iconButton1.Text = "Annuler";
			this.iconButton1.UseVisualStyleBackColor = true;
			this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
			// 
			// btnCredit
			// 
			this.btnCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCredit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCredit.Font = new System.Drawing.Font("Calibri", 11F);
			this.btnCredit.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnCredit.IconColor = System.Drawing.Color.Black;
			this.btnCredit.IconSize = 16;
			this.btnCredit.Location = new System.Drawing.Point(245, 194);
			this.btnCredit.Name = "btnCredit";
			this.btnCredit.Rotation = 0D;
			this.btnCredit.Size = new System.Drawing.Size(115, 26);
			this.btnCredit.TabIndex = 8;
			this.btnCredit.Text = "sauvegarder";
			this.btnCredit.UseVisualStyleBackColor = true;
			this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
			this.lblId.Location = new System.Drawing.Point(461, 9);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(17, 19);
			this.lblId.TabIndex = 46;
			this.lblId.Text = "0";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
			this.label24.Location = new System.Drawing.Point(350, 9);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(99, 19);
			this.label24.TabIndex = 45;
			this.label24.Text = "N ° de client#";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.Location = new System.Drawing.Point(119, 352);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(11, 15);
			this.label25.TabIndex = 20;
			this.label25.Text = ":";
			// 
			// FormNewCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.iconButton1;
			this.ClientSize = new System.Drawing.Size(886, 252);
			this.Controls.Add(this.panel1);
			this.MaximumSize = new System.Drawing.Size(902, 291);
			this.MinimumSize = new System.Drawing.Size(902, 291);
			this.Name = "FormNewCustomer";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nouveau client";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private FontAwesome.Sharp.IconButton iconButton1;
		private FontAwesome.Sharp.IconButton btnCredit;
		private System.Windows.Forms.ComboBox cbxCategory;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.ComboBox cbxProvince;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbxCity;
		private System.Windows.Forms.TextBox tbAirtel;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox tbContact2;
		private System.Windows.Forms.TextBox tbContact1;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private FontAwesome.Sharp.IconButton btnClear;
	}
}