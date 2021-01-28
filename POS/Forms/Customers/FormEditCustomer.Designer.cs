namespace POS.Forms.Customers
{
	partial class FormEditCustomer
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
			this.panelSearch = new System.Windows.Forms.Panel();
			this.cbxFilter = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label20 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.btnClear = new FontAwesome.Sharp.IconButton();
			this.btnCash = new FontAwesome.Sharp.IconButton();
			this.btnCredit = new FontAwesome.Sharp.IconButton();
			this.label12 = new System.Windows.Forms.Label();
			this.btnCancel = new FontAwesome.Sharp.IconButton();
			this.btnUpdate = new FontAwesome.Sharp.IconButton();
			this.tbAirtel = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.tbTotalLeft = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tbTotalPaid = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cbxCategory = new System.Windows.Forms.ComboBox();
			this.cbxProvince = new System.Windows.Forms.ComboBox();
			this.cbxCity = new System.Windows.Forms.ComboBox();
			this.label21 = new System.Windows.Forms.Label();
			this.lblId = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.tbContact2 = new System.Windows.Forms.TextBox();
			this.tbContact1 = new System.Windows.Forms.TextBox();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label35 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.panelSearch.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelSearch
			// 
			this.panelSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panelSearch.BackColor = System.Drawing.Color.Silver;
			this.panelSearch.Controls.Add(this.cbxFilter);
			this.panelSearch.Controls.Add(this.label5);
			this.panelSearch.Controls.Add(this.tbSearch);
			this.panelSearch.Location = new System.Drawing.Point(214, 12);
			this.panelSearch.Name = "panelSearch";
			this.panelSearch.Size = new System.Drawing.Size(443, 60);
			this.panelSearch.TabIndex = 0;
			// 
			// cbxFilter
			// 
			this.cbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbxFilter.FormattingEnabled = true;
			this.cbxFilter.Location = new System.Drawing.Point(55, 31);
			this.cbxFilter.Name = "cbxFilter";
			this.cbxFilter.Size = new System.Drawing.Size(165, 26);
			this.cbxFilter.TabIndex = 0;
			this.cbxFilter.Text = "Recherche par ld";
			this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(185, 4);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Chercher";
			// 
			// tbSearch
			// 
			this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbSearch.Location = new System.Drawing.Point(226, 30);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(169, 26);
			this.tbSearch.TabIndex = 1;
			this.tbSearch.Text = "Recherche par nom";
			this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
			this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
			this.tbSearch.Validated += new System.EventHandler(this.ValidateInput);
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.label20);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.btnCash);
			this.panel1.Controls.Add(this.btnCredit);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnUpdate);
			this.panel1.Controls.Add(this.tbAirtel);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.tbTotalLeft);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.tbTotalPaid);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.cbxCategory);
			this.panel1.Controls.Add(this.cbxProvince);
			this.panel1.Controls.Add(this.cbxCity);
			this.panel1.Controls.Add(this.label21);
			this.panel1.Controls.Add(this.lblId);
			this.panel1.Controls.Add(this.label24);
			this.panel1.Controls.Add(this.tbContact2);
			this.panel1.Controls.Add(this.tbContact1);
			this.panel1.Controls.Add(this.tbEmail);
			this.panel1.Controls.Add(this.label25);
			this.panel1.Controls.Add(this.label26);
			this.panel1.Controls.Add(this.label27);
			this.panel1.Controls.Add(this.label28);
			this.panel1.Controls.Add(this.label29);
			this.panel1.Controls.Add(this.label30);
			this.panel1.Controls.Add(this.label31);
			this.panel1.Controls.Add(this.label32);
			this.panel1.Controls.Add(this.tbName);
			this.panel1.Controls.Add(this.label35);
			this.panel1.Controls.Add(this.label36);
			this.panel1.Location = new System.Drawing.Point(11, 79);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(837, 251);
			this.panel1.TabIndex = 119;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label20.Location = new System.Drawing.Point(16, 148);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(65, 17);
			this.label20.TabIndex = 128;
			this.label20.Text = "Catégorie";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label14.Location = new System.Drawing.Point(17, 117);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(60, 17);
			this.label14.TabIndex = 127;
			this.label14.Text = "Province";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label15.Location = new System.Drawing.Point(16, 82);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(34, 17);
			this.label15.TabIndex = 126;
			this.label15.Text = "Ville";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label13.Location = new System.Drawing.Point(17, 49);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(37, 17);
			this.label13.TabIndex = 107;
			this.label13.Text = "Nom";
			// 
			// btnClear
			// 
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnClear.Font = new System.Drawing.Font("Calibri", 11F);
			this.btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnClear.IconColor = System.Drawing.Color.Black;
			this.btnClear.IconSize = 16;
			this.btnClear.Location = new System.Drawing.Point(505, 222);
			this.btnClear.Name = "btnClear";
			this.btnClear.Rotation = 0D;
			this.btnClear.Size = new System.Drawing.Size(115, 26);
			this.btnClear.TabIndex = 10;
			this.btnClear.Text = "Effacer";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnCash
			// 
			this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCash.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCash.Font = new System.Drawing.Font("Calibri", 11F);
			this.btnCash.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnCash.IconColor = System.Drawing.Color.Black;
			this.btnCash.IconSize = 16;
			this.btnCash.Location = new System.Drawing.Point(114, 203);
			this.btnCash.Name = "btnCash";
			this.btnCash.Rotation = 0D;
			this.btnCash.Size = new System.Drawing.Size(90, 26);
			this.btnCash.TabIndex = 12;
			this.btnCash.Text = "En espèces";
			this.btnCash.UseVisualStyleBackColor = true;
			this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
			// 
			// btnCredit
			// 
			this.btnCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCredit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCredit.Font = new System.Drawing.Font("Calibri", 11F);
			this.btnCredit.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnCredit.IconColor = System.Drawing.Color.Black;
			this.btnCredit.IconSize = 16;
			this.btnCredit.Location = new System.Drawing.Point(30, 203);
			this.btnCredit.Name = "btnCredit";
			this.btnCredit.Rotation = 0D;
			this.btnCredit.Size = new System.Drawing.Size(78, 26);
			this.btnCredit.TabIndex = 11;
			this.btnCredit.Text = "Crédit";
			this.btnCredit.UseVisualStyleBackColor = true;
			this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(83, 182);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(60, 18);
			this.label12.TabIndex = 106;
			this.label12.Text = "Factures";
			// 
			// btnCancel
			// 
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCancel.Font = new System.Drawing.Font("Calibri", 11F);
			this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnCancel.IconColor = System.Drawing.Color.Black;
			this.btnCancel.IconSize = 16;
			this.btnCancel.Location = new System.Drawing.Point(384, 222);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Rotation = 0D;
			this.btnCancel.Size = new System.Drawing.Size(115, 26);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Annuler";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnUpdate.Font = new System.Drawing.Font("Calibri", 11F);
			this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnUpdate.IconColor = System.Drawing.Color.Black;
			this.btnUpdate.IconSize = 16;
			this.btnUpdate.Location = new System.Drawing.Point(263, 222);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Rotation = 0D;
			this.btnUpdate.Size = new System.Drawing.Size(115, 26);
			this.btnUpdate.TabIndex = 8;
			this.btnUpdate.Text = "Mise à jour";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// tbAirtel
			// 
			this.tbAirtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbAirtel.Location = new System.Drawing.Point(651, 140);
			this.tbAirtel.Name = "tbAirtel";
			this.tbAirtel.Size = new System.Drawing.Size(148, 26);
			this.tbAirtel.TabIndex = 7;
			this.tbAirtel.Validated += new System.EventHandler(this.ValidateInput);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(638, 147);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(11, 15);
			this.label1.TabIndex = 105;
			this.label1.Text = ":";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label10.Location = new System.Drawing.Point(552, 147);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(86, 17);
			this.label10.TabIndex = 104;
			this.label10.Text = "Airtel Money";
			// 
			// tbTotalLeft
			// 
			this.tbTotalLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbTotalLeft.Location = new System.Drawing.Point(651, 108);
			this.tbTotalLeft.Name = "tbTotalLeft";
			this.tbTotalLeft.ReadOnly = true;
			this.tbTotalLeft.Size = new System.Drawing.Size(148, 26);
			this.tbTotalLeft.TabIndex = 10;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(638, 115);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(11, 15);
			this.label8.TabIndex = 102;
			this.label8.Text = ":";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label9.Location = new System.Drawing.Point(552, 115);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 17);
			this.label9.TabIndex = 101;
			this.label9.Text = "Total restant";
			// 
			// tbTotalPaid
			// 
			this.tbTotalPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbTotalPaid.Location = new System.Drawing.Point(651, 75);
			this.tbTotalPaid.Name = "tbTotalPaid";
			this.tbTotalPaid.ReadOnly = true;
			this.tbTotalPaid.Size = new System.Drawing.Size(148, 26);
			this.tbTotalPaid.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(638, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(11, 15);
			this.label6.TabIndex = 99;
			this.label6.Text = ":";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label7.Location = new System.Drawing.Point(552, 80);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 17);
			this.label7.TabIndex = 98;
			this.label7.Text = "Total payé";
			// 
			// cbxCategory
			// 
			this.cbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbxCategory.FormattingEnabled = true;
			this.cbxCategory.Items.AddRange(new object[] {
            "Company",
            "Individual",
            "Company Employee"});
			this.cbxCategory.Location = new System.Drawing.Point(116, 144);
			this.cbxCategory.Name = "cbxCategory";
			this.cbxCategory.Size = new System.Drawing.Size(172, 26);
			this.cbxCategory.TabIndex = 3;
			this.cbxCategory.Text = "Sélectionner";
			this.cbxCategory.Validated += new System.EventHandler(this.ValidateCombobox);
			// 
			// cbxProvince
			// 
			this.cbxProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbxProvince.FormattingEnabled = true;
			this.cbxProvince.Location = new System.Drawing.Point(116, 110);
			this.cbxProvince.Name = "cbxProvince";
			this.cbxProvince.Size = new System.Drawing.Size(172, 26);
			this.cbxProvince.TabIndex = 2;
			this.cbxProvince.Text = "Sélectionner";
			this.cbxProvince.Validated += new System.EventHandler(this.ValidateCombobox);
			// 
			// cbxCity
			// 
			this.cbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbxCity.FormattingEnabled = true;
			this.cbxCity.Location = new System.Drawing.Point(115, 76);
			this.cbxCity.Name = "cbxCity";
			this.cbxCity.Size = new System.Drawing.Size(172, 26);
			this.cbxCity.TabIndex = 1;
			this.cbxCity.Text = "Sélectionner";
			this.cbxCity.Validated += new System.EventHandler(this.ValidateCombobox);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(103, 149);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(11, 15);
			this.label21.TabIndex = 87;
			this.label21.Text = ":";
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
			this.label24.Location = new System.Drawing.Point(344, 9);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(111, 19);
			this.label24.TabIndex = 45;
			this.label24.Text = "Numéro client#";
			// 
			// tbContact2
			// 
			this.tbContact2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbContact2.Location = new System.Drawing.Point(392, 142);
			this.tbContact2.Name = "tbContact2";
			this.tbContact2.Size = new System.Drawing.Size(148, 26);
			this.tbContact2.TabIndex = 6;
			this.tbContact2.Validated += new System.EventHandler(this.ValidateInput);
			// 
			// tbContact1
			// 
			this.tbContact1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbContact1.Location = new System.Drawing.Point(392, 110);
			this.tbContact1.Name = "tbContact1";
			this.tbContact1.Size = new System.Drawing.Size(148, 26);
			this.tbContact1.TabIndex = 5;
			this.tbContact1.Validated += new System.EventHandler(this.ValidateInput);
			// 
			// tbEmail
			// 
			this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbEmail.Location = new System.Drawing.Point(392, 75);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(148, 26);
			this.tbEmail.TabIndex = 4;
			this.tbEmail.Validated += new System.EventHandler(this.ValidateInput);
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
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(379, 149);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(11, 15);
			this.label26.TabIndex = 14;
			this.label26.Text = ":";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label27.Location = new System.Drawing.Point(293, 149);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(65, 17);
			this.label27.TabIndex = 13;
			this.label27.Text = "Contact 2";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.Location = new System.Drawing.Point(379, 116);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(11, 15);
			this.label28.TabIndex = 17;
			this.label28.Text = ":";
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label29.Location = new System.Drawing.Point(293, 116);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(65, 17);
			this.label29.TabIndex = 16;
			this.label29.Text = "Contact 1";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label30.Location = new System.Drawing.Point(379, 83);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(11, 15);
			this.label30.TabIndex = 14;
			this.label30.Text = ":";
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label31.Location = new System.Drawing.Point(293, 83);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(41, 17);
			this.label31.TabIndex = 13;
			this.label31.Text = "Email";
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label32.Location = new System.Drawing.Point(103, 117);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(11, 15);
			this.label32.TabIndex = 11;
			this.label32.Text = ":";
			// 
			// tbName
			// 
			this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbName.Location = new System.Drawing.Point(116, 44);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(424, 26);
			this.tbName.TabIndex = 0;
			this.tbName.Validated += new System.EventHandler(this.ValidateInput);
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label35.Location = new System.Drawing.Point(103, 84);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(11, 15);
			this.label35.TabIndex = 6;
			this.label35.Text = ":";
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label36.Location = new System.Drawing.Point(102, 50);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(11, 15);
			this.label36.TabIndex = 3;
			this.label36.Text = ":";
			// 
			// FormEditCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(859, 344);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelSearch);
			this.Name = "FormEditCustomer";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modifier le client";
			this.Validated += new System.EventHandler(this.ValidateCombobox);
			this.panelSearch.ResumeLayout(false);
			this.panelSearch.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelSearch;
		private System.Windows.Forms.ComboBox cbxFilter;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox tbAirtel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox tbTotalLeft;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbTotalPaid;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbxCategory;
		private System.Windows.Forms.ComboBox cbxProvince;
		private System.Windows.Forms.ComboBox cbxCity;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox tbContact2;
		private System.Windows.Forms.TextBox tbContact1;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label12;
		private FontAwesome.Sharp.IconButton btnCash;
		private FontAwesome.Sharp.IconButton btnCredit;
		private FontAwesome.Sharp.IconButton btnCancel;
		private FontAwesome.Sharp.IconButton btnUpdate;
		private FontAwesome.Sharp.IconButton btnClear;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
	}
}