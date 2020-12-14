namespace POS.UserControls
{
	partial class UC_StoreToShelves
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
			this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
			this.cbxFilter = new System.Windows.Forms.ComboBox();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblProductId = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.tbQtyInShelves = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tbQuantityInStore = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.tbPurchasingPrice = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.tbSellingPrice = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
			this.label4 = new System.Windows.Forms.Label();
			this.tbMove = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lblLimit = new System.Windows.Forms.Label();
			this.btnMove = new FontAwesome.Sharp.IconButton();
			this.bunifuCards1.SuspendLayout();
			this.bunifuCards2.SuspendLayout();
			this.bunifuCards3.SuspendLayout();
			this.SuspendLayout();
			// 
			// bunifuCards1
			// 
			this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.bunifuCards1.BackColor = System.Drawing.Color.Silver;
			this.bunifuCards1.BorderRadius = 5;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = System.Drawing.Color.Tomato;
			this.bunifuCards1.Controls.Add(this.cbxFilter);
			this.bunifuCards1.Controls.Add(this.tbSearch);
			this.bunifuCards1.Controls.Add(this.label3);
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new System.Drawing.Point(220, 67);
			this.bunifuCards1.Name = "bunifuCards1";
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new System.Drawing.Size(605, 72);
			this.bunifuCards1.TabIndex = 121;
			// 
			// cbxFilter
			// 
			this.cbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cbxFilter.FormattingEnabled = true;
			this.cbxFilter.Location = new System.Drawing.Point(122, 37);
			this.cbxFilter.Name = "cbxFilter";
			this.cbxFilter.Size = new System.Drawing.Size(136, 26);
			this.cbxFilter.TabIndex = 1;
			this.cbxFilter.Text = "Search by Id";
			this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
			// 
			// tbSearch
			// 
			this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbSearch.Location = new System.Drawing.Point(264, 36);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(229, 26);
			this.tbSearch.TabIndex = 0;
			this.tbSearch.Text = "Search by Name";
			this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
			this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(274, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 113;
			this.label3.Text = "Search";
			// 
			// bunifuCards2
			// 
			this.bunifuCards2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.bunifuCards2.BackColor = System.Drawing.Color.Silver;
			this.bunifuCards2.BorderRadius = 5;
			this.bunifuCards2.BottomSahddow = true;
			this.bunifuCards2.color = System.Drawing.Color.Tomato;
			this.bunifuCards2.Controls.Add(this.tbPurchasingPrice);
			this.bunifuCards2.Controls.Add(this.label20);
			this.bunifuCards2.Controls.Add(this.label21);
			this.bunifuCards2.Controls.Add(this.tbSellingPrice);
			this.bunifuCards2.Controls.Add(this.label18);
			this.bunifuCards2.Controls.Add(this.label19);
			this.bunifuCards2.Controls.Add(this.tbQtyInShelves);
			this.bunifuCards2.Controls.Add(this.label6);
			this.bunifuCards2.Controls.Add(this.label7);
			this.bunifuCards2.Controls.Add(this.tbQuantityInStore);
			this.bunifuCards2.Controls.Add(this.label16);
			this.bunifuCards2.Controls.Add(this.label17);
			this.bunifuCards2.Controls.Add(this.tbName);
			this.bunifuCards2.Controls.Add(this.label1);
			this.bunifuCards2.Controls.Add(this.label2);
			this.bunifuCards2.Controls.Add(this.lblProductId);
			this.bunifuCards2.Controls.Add(this.label28);
			this.bunifuCards2.LeftSahddow = false;
			this.bunifuCards2.Location = new System.Drawing.Point(117, 145);
			this.bunifuCards2.Name = "bunifuCards2";
			this.bunifuCards2.RightSahddow = true;
			this.bunifuCards2.ShadowDepth = 20;
			this.bunifuCards2.Size = new System.Drawing.Size(833, 163);
			this.bunifuCards2.TabIndex = 122;
			// 
			// tbName
			// 
			this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbName.Location = new System.Drawing.Point(187, 52);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(234, 26);
			this.tbName.TabIndex = 105;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label1.Location = new System.Drawing.Point(45, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 17);
			this.label1.TabIndex = 106;
			this.label1.Text = "Item Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(173, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(11, 15);
			this.label2.TabIndex = 107;
			this.label2.Text = ":";
			// 
			// lblProductId
			// 
			this.lblProductId.AutoSize = true;
			this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
			this.lblProductId.Location = new System.Drawing.Point(136, 20);
			this.lblProductId.Name = "lblProductId";
			this.lblProductId.Size = new System.Drawing.Size(21, 24);
			this.lblProductId.TabIndex = 104;
			this.lblProductId.Text = "0";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Sitka Small", 14F, System.Drawing.FontStyle.Bold);
			this.label28.Location = new System.Drawing.Point(28, 17);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(102, 28);
			this.label28.TabIndex = 103;
			this.label28.Text = "Item ID#";
			// 
			// tbQtyInShelves
			// 
			this.tbQtyInShelves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbQtyInShelves.Location = new System.Drawing.Point(187, 116);
			this.tbQtyInShelves.Name = "tbQtyInShelves";
			this.tbQtyInShelves.Size = new System.Drawing.Size(186, 26);
			this.tbQtyInShelves.TabIndex = 126;
			this.tbQtyInShelves.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label6.Location = new System.Drawing.Point(43, 122);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(121, 17);
			this.label6.TabIndex = 129;
			this.label6.Text = "Quantity in Shelves";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(173, 122);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(11, 15);
			this.label7.TabIndex = 130;
			this.label7.Text = ":";
			// 
			// tbQuantityInStore
			// 
			this.tbQuantityInStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbQuantityInStore.Location = new System.Drawing.Point(187, 84);
			this.tbQuantityInStore.Name = "tbQuantityInStore";
			this.tbQuantityInStore.Size = new System.Drawing.Size(186, 26);
			this.tbQuantityInStore.TabIndex = 125;
			this.tbQuantityInStore.Text = "0";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label16.Location = new System.Drawing.Point(43, 90);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(107, 17);
			this.label16.TabIndex = 127;
			this.label16.Text = "Quantity in Store";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(173, 90);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(11, 15);
			this.label17.TabIndex = 128;
			this.label17.Text = ":";
			// 
			// tbPurchasingPrice
			// 
			this.tbPurchasingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbPurchasingPrice.Location = new System.Drawing.Point(594, 115);
			this.tbPurchasingPrice.Name = "tbPurchasingPrice";
			this.tbPurchasingPrice.Size = new System.Drawing.Size(186, 26);
			this.tbPurchasingPrice.TabIndex = 136;
			this.tbPurchasingPrice.Text = "0";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label20.Location = new System.Drawing.Point(450, 121);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(108, 17);
			this.label20.TabIndex = 139;
			this.label20.Text = "Purchasing Price";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(580, 121);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(11, 15);
			this.label21.TabIndex = 140;
			this.label21.Text = ":";
			// 
			// tbSellingPrice
			// 
			this.tbSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbSellingPrice.Location = new System.Drawing.Point(594, 83);
			this.tbSellingPrice.Name = "tbSellingPrice";
			this.tbSellingPrice.Size = new System.Drawing.Size(186, 26);
			this.tbSellingPrice.TabIndex = 135;
			this.tbSellingPrice.Text = "0";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label18.Location = new System.Drawing.Point(450, 89);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(81, 17);
			this.label18.TabIndex = 137;
			this.label18.Text = "Selling Price";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(580, 89);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(11, 15);
			this.label19.TabIndex = 138;
			this.label19.Text = ":";
			// 
			// bunifuCards3
			// 
			this.bunifuCards3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.bunifuCards3.BackColor = System.Drawing.Color.Silver;
			this.bunifuCards3.BorderRadius = 5;
			this.bunifuCards3.BottomSahddow = true;
			this.bunifuCards3.color = System.Drawing.Color.Tomato;
			this.bunifuCards3.Controls.Add(this.btnMove);
			this.bunifuCards3.Controls.Add(this.lblLimit);
			this.bunifuCards3.Controls.Add(this.tbMove);
			this.bunifuCards3.Controls.Add(this.label5);
			this.bunifuCards3.Controls.Add(this.label4);
			this.bunifuCards3.LeftSahddow = false;
			this.bunifuCards3.Location = new System.Drawing.Point(117, 314);
			this.bunifuCards3.Name = "bunifuCards3";
			this.bunifuCards3.RightSahddow = true;
			this.bunifuCards3.ShadowDepth = 20;
			this.bunifuCards3.Size = new System.Drawing.Size(833, 178);
			this.bunifuCards3.TabIndex = 122;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(345, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(141, 23);
			this.label4.TabIndex = 113;
			this.label4.Text = "Move to Shelves";
			// 
			// tbMove
			// 
			this.tbMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.tbMove.Location = new System.Drawing.Point(326, 68);
			this.tbMove.Name = "tbMove";
			this.tbMove.Size = new System.Drawing.Size(178, 35);
			this.tbMove.TabIndex = 141;
			this.tbMove.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.label5.Location = new System.Drawing.Point(350, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(111, 17);
			this.label5.TabIndex = 142;
			this.label5.Text = "Quantity to Move";
			// 
			// lblLimit
			// 
			this.lblLimit.AutoSize = true;
			this.lblLimit.Font = new System.Drawing.Font("Times New Roman", 9F);
			this.lblLimit.Location = new System.Drawing.Point(350, 108);
			this.lblLimit.Name = "lblLimit";
			this.lblLimit.Size = new System.Drawing.Size(135, 15);
			this.lblLimit.TabIndex = 144;
			this.lblLimit.Text = "(Must be less than #value)";
			// 
			// btnMove
			// 
			this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMove.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnMove.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnMove.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnMove.IconColor = System.Drawing.Color.Black;
			this.btnMove.IconSize = 16;
			this.btnMove.Location = new System.Drawing.Point(326, 132);
			this.btnMove.Name = "btnMove";
			this.btnMove.Rotation = 0D;
			this.btnMove.Size = new System.Drawing.Size(178, 32);
			this.btnMove.TabIndex = 145;
			this.btnMove.Text = "Move to Shelves";
			this.btnMove.UseVisualStyleBackColor = true;
			this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
			// 
			// UC_StoreToShelves
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bunifuCards3);
			this.Controls.Add(this.bunifuCards2);
			this.Controls.Add(this.bunifuCards1);
			this.Name = "UC_StoreToShelves";
			this.Size = new System.Drawing.Size(1085, 563);
			this.bunifuCards1.ResumeLayout(false);
			this.bunifuCards1.PerformLayout();
			this.bunifuCards2.ResumeLayout(false);
			this.bunifuCards2.PerformLayout();
			this.bunifuCards3.ResumeLayout(false);
			this.bunifuCards3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuCards bunifuCards1;
		private System.Windows.Forms.ComboBox cbxFilter;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Label label3;
		private Bunifu.Framework.UI.BunifuCards bunifuCards2;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblProductId;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox tbQtyInShelves;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbQuantityInStore;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox tbPurchasingPrice;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox tbSellingPrice;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private Bunifu.Framework.UI.BunifuCards bunifuCards3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbMove;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblLimit;
		private FontAwesome.Sharp.IconButton btnMove;
	}
}
