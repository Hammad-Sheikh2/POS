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
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.iconButton4 = new FontAwesome.Sharp.IconButton();
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
			this.tbDownPayment = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbDiscount = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.cbxCategory = new System.Windows.Forms.ComboBox();
			this.cbxProvince = new System.Windows.Forms.ComboBox();
			this.cbxCity = new System.Windows.Forms.ComboBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
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
			this.label33 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label34 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
			this.btnClear = new FontAwesome.Sharp.IconButton();
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
			this.cbxFilter.Text = "Search by Id";
			this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(194, 3);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Search";
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
			this.tbSearch.Text = "Search by Name";
			this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
			this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
			this.tbSearch.Validated += new System.EventHandler(this.ValidateInput);
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.iconButton1);
			this.panel1.Controls.Add(this.iconButton4);
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
			this.panel1.Controls.Add(this.tbDownPayment);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.tbDiscount);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.cbxCategory);
			this.panel1.Controls.Add(this.cbxProvince);
			this.panel1.Controls.Add(this.cbxCity);
			this.panel1.Controls.Add(this.label21);
			this.panel1.Controls.Add(this.label22);
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
			this.panel1.Controls.Add(this.label33);
			this.panel1.Controls.Add(this.tbName);
			this.panel1.Controls.Add(this.label34);
			this.panel1.Controls.Add(this.label35);
			this.panel1.Controls.Add(this.label36);
			this.panel1.Controls.Add(this.label37);
			this.panel1.Location = new System.Drawing.Point(11, 79);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(837, 251);
			this.panel1.TabIndex = 119;
			// 
			// iconButton1
			// 
			this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.iconButton1.Font = new System.Drawing.Font("Calibri", 11F);
			this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
			this.iconButton1.IconColor = System.Drawing.Color.Black;
			this.iconButton1.IconSize = 16;
			this.iconButton1.Location = new System.Drawing.Point(114, 203);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Rotation = 0D;
			this.iconButton1.Size = new System.Drawing.Size(78, 26);
			this.iconButton1.TabIndex = 12;
			this.iconButton1.Text = "Cash";
			this.iconButton1.UseVisualStyleBackColor = true;
			// 
			// iconButton4
			// 
			this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.iconButton4.Font = new System.Drawing.Font("Calibri", 11F);
			this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
			this.iconButton4.IconColor = System.Drawing.Color.Black;
			this.iconButton4.IconSize = 16;
			this.iconButton4.Location = new System.Drawing.Point(30, 203);
			this.iconButton4.Name = "iconButton4";
			this.iconButton4.Rotation = 0D;
			this.iconButton4.Size = new System.Drawing.Size(78, 26);
			this.iconButton4.TabIndex = 11;
			this.iconButton4.Text = "Credit";
			this.iconButton4.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(83, 182);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(59, 18);
			this.label12.TabIndex = 106;
			this.label12.Text = "Invoices";
			// 
			// btnCancel
			// 
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCancel.Font = new System.Drawing.Font("Calibri", 11F);
			this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnCancel.IconColor = System.Drawing.Color.Black;
			this.btnCancel.IconSize = 16;
			this.btnCancel.Location = new System.Drawing.Point(362, 222);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Rotation = 0D;
			this.btnCancel.Size = new System.Drawing.Size(115, 26);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnUpdate.Font = new System.Drawing.Font("Calibri", 11F);
			this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnUpdate.IconColor = System.Drawing.Color.Black;
			this.btnUpdate.IconSize = 16;
			this.btnUpdate.Location = new System.Drawing.Point(241, 222);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Rotation = 0D;
			this.btnUpdate.Size = new System.Drawing.Size(115, 26);
			this.btnUpdate.TabIndex = 8;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// tbAirtel
			// 
			this.tbAirtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbAirtel.Location = new System.Drawing.Point(651, 174);
			this.tbAirtel.Name = "tbAirtel";
			this.tbAirtel.Size = new System.Drawing.Size(148, 26);
			this.tbAirtel.TabIndex = 7;
			this.tbAirtel.Validated += new System.EventHandler(this.ValidateInput);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(638, 181);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(11, 15);
			this.label1.TabIndex = 105;
			this.label1.Text = ":";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label10.Location = new System.Drawing.Point(552, 181);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(86, 17);
			this.label10.TabIndex = 104;
			this.label10.Text = "Airtel Money";
			// 
			// tbTotalLeft
			// 
			this.tbTotalLeft.Enabled = false;
			this.tbTotalLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbTotalLeft.Location = new System.Drawing.Point(651, 142);
			this.tbTotalLeft.Name = "tbTotalLeft";
			this.tbTotalLeft.Size = new System.Drawing.Size(148, 26);
			this.tbTotalLeft.TabIndex = 10;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(638, 149);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(11, 15);
			this.label8.TabIndex = 102;
			this.label8.Text = ":";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label9.Location = new System.Drawing.Point(552, 149);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 17);
			this.label9.TabIndex = 101;
			this.label9.Text = "Total Left";
			// 
			// tbTotalPaid
			// 
			this.tbTotalPaid.Enabled = false;
			this.tbTotalPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbTotalPaid.Location = new System.Drawing.Point(651, 109);
			this.tbTotalPaid.Name = "tbTotalPaid";
			this.tbTotalPaid.Size = new System.Drawing.Size(148, 26);
			this.tbTotalPaid.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(638, 114);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(11, 15);
			this.label6.TabIndex = 99;
			this.label6.Text = ":";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label7.Location = new System.Drawing.Point(552, 114);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 17);
			this.label7.TabIndex = 98;
			this.label7.Text = "Total Paid";
			// 
			// tbDownPayment
			// 
			this.tbDownPayment.Enabled = false;
			this.tbDownPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbDownPayment.Location = new System.Drawing.Point(651, 76);
			this.tbDownPayment.Name = "tbDownPayment";
			this.tbDownPayment.Size = new System.Drawing.Size(148, 26);
			this.tbDownPayment.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(638, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(11, 15);
			this.label3.TabIndex = 96;
			this.label3.Text = ":";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 9F);
			this.label4.Location = new System.Drawing.Point(552, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 15);
			this.label4.TabIndex = 95;
			this.label4.Text = "Down Payment";
			// 
			// tbDiscount
			// 
			this.tbDiscount.Enabled = false;
			this.tbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbDiscount.Location = new System.Drawing.Point(651, 43);
			this.tbDiscount.Name = "tbDiscount";
			this.tbDiscount.Size = new System.Drawing.Size(148, 26);
			this.tbDiscount.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(638, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(11, 15);
			this.label2.TabIndex = 93;
			this.label2.Text = ":";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label11.Location = new System.Drawing.Point(552, 50);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 17);
			this.label11.TabIndex = 92;
			this.label11.Text = "Discount";
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
			this.cbxCategory.Text = "Select";
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
			this.cbxProvince.Text = "Select";
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
			this.cbxCity.Text = "Select";
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
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label22.Location = new System.Drawing.Point(17, 149);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(62, 17);
			this.label22.TabIndex = 86;
			this.label22.Text = "Category";
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
			this.label24.Location = new System.Drawing.Point(351, 9);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(104, 19);
			this.label24.TabIndex = 45;
			this.label24.Text = "Customer ID#";
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
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label33.Location = new System.Drawing.Point(17, 117);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(60, 17);
			this.label33.TabIndex = 10;
			this.label33.Text = "Province";
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
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label34.Location = new System.Drawing.Point(16, 50);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(44, 17);
			this.label34.TabIndex = 2;
			this.label34.Text = "Name";
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
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label37.Location = new System.Drawing.Point(17, 84);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(32, 17);
			this.label37.TabIndex = 5;
			this.label37.Text = "City";
			// 
			// btnClear
			// 
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnClear.Font = new System.Drawing.Font("Calibri", 11F);
			this.btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnClear.IconColor = System.Drawing.Color.Black;
			this.btnClear.IconSize = 16;
			this.btnClear.Location = new System.Drawing.Point(483, 222);
			this.btnClear.Name = "btnClear";
			this.btnClear.Rotation = 0D;
			this.btnClear.Size = new System.Drawing.Size(115, 26);
			this.btnClear.TabIndex = 10;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// FormEditCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(859, 344);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelSearch);
			this.Name = "FormEditCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit Customer";
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
		private System.Windows.Forms.TextBox tbDownPayment;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbDiscount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cbxCategory;
		private System.Windows.Forms.ComboBox cbxProvince;
		private System.Windows.Forms.ComboBox cbxCity;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
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
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label12;
		private FontAwesome.Sharp.IconButton iconButton1;
		private FontAwesome.Sharp.IconButton iconButton4;
		private FontAwesome.Sharp.IconButton btnCancel;
		private FontAwesome.Sharp.IconButton btnUpdate;
		private FontAwesome.Sharp.IconButton btnClear;
	}
}