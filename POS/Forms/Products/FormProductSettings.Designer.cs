namespace POS.Forms
{
	partial class FormProductSettings
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
			this.btnAddCategory = new FontAwesome.Sharp.IconPictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tbCategory = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.tbWeight = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.tbShelf = new System.Windows.Forms.TextBox();
			this.btnAddWeight = new FontAwesome.Sharp.IconPictureBox();
			this.btnAddShelf = new FontAwesome.Sharp.IconPictureBox();
			((System.ComponentModel.ISupportInitialize)(this.btnAddCategory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAddWeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAddShelf)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAddCategory
			// 
			this.btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddCategory.BackColor = System.Drawing.Color.Transparent;
			this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddCategory.ForeColor = System.Drawing.Color.Gray;
			this.btnAddCategory.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
			this.btnAddCategory.IconColor = System.Drawing.Color.Gray;
			this.btnAddCategory.IconSize = 26;
			this.btnAddCategory.Location = new System.Drawing.Point(275, 36);
			this.btnAddCategory.Name = "btnAddCategory";
			this.btnAddCategory.Size = new System.Drawing.Size(26, 27);
			this.btnAddCategory.TabIndex = 106;
			this.btnAddCategory.TabStop = false;
			this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label1.Location = new System.Drawing.Point(43, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 19);
			this.label1.TabIndex = 105;
			this.label1.Text = "Category";
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel2.BackColor = System.Drawing.Color.Gray;
			this.panel2.Location = new System.Drawing.Point(34, 81);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(250, 1);
			this.panel2.TabIndex = 104;
			// 
			// tbCategory
			// 
			this.tbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbCategory.Location = new System.Drawing.Point(46, 36);
			this.tbCategory.Name = "tbCategory";
			this.tbCategory.Size = new System.Drawing.Size(226, 29);
			this.tbCategory.TabIndex = 103;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label2.Location = new System.Drawing.Point(43, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 19);
			this.label2.TabIndex = 109;
			this.label2.Text = "Weight/Dosage";
			// 
			// panel3
			// 
			this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel3.BackColor = System.Drawing.Color.Gray;
			this.panel3.Location = new System.Drawing.Point(34, 160);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(250, 1);
			this.panel3.TabIndex = 108;
			// 
			// tbWeight
			// 
			this.tbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbWeight.Location = new System.Drawing.Point(46, 115);
			this.tbWeight.Name = "tbWeight";
			this.tbWeight.Size = new System.Drawing.Size(226, 29);
			this.tbWeight.TabIndex = 107;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label3.Location = new System.Drawing.Point(43, 171);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 19);
			this.label3.TabIndex = 112;
			this.label3.Text = "Shelf Number";
			// 
			// panel4
			// 
			this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel4.BackColor = System.Drawing.Color.Gray;
			this.panel4.Location = new System.Drawing.Point(34, 240);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(250, 1);
			this.panel4.TabIndex = 111;
			// 
			// tbShelf
			// 
			this.tbShelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbShelf.Location = new System.Drawing.Point(46, 195);
			this.tbShelf.Name = "tbShelf";
			this.tbShelf.Size = new System.Drawing.Size(226, 29);
			this.tbShelf.TabIndex = 110;
			// 
			// btnAddWeight
			// 
			this.btnAddWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddWeight.BackColor = System.Drawing.Color.Transparent;
			this.btnAddWeight.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddWeight.ForeColor = System.Drawing.Color.Gray;
			this.btnAddWeight.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
			this.btnAddWeight.IconColor = System.Drawing.Color.Gray;
			this.btnAddWeight.IconSize = 26;
			this.btnAddWeight.Location = new System.Drawing.Point(275, 115);
			this.btnAddWeight.Name = "btnAddWeight";
			this.btnAddWeight.Size = new System.Drawing.Size(26, 27);
			this.btnAddWeight.TabIndex = 113;
			this.btnAddWeight.TabStop = false;
			this.btnAddWeight.Click += new System.EventHandler(this.btnAddWeight_Click);
			// 
			// btnAddShelf
			// 
			this.btnAddShelf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddShelf.BackColor = System.Drawing.Color.Transparent;
			this.btnAddShelf.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddShelf.ForeColor = System.Drawing.Color.Gray;
			this.btnAddShelf.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
			this.btnAddShelf.IconColor = System.Drawing.Color.Gray;
			this.btnAddShelf.IconSize = 26;
			this.btnAddShelf.Location = new System.Drawing.Point(275, 195);
			this.btnAddShelf.Name = "btnAddShelf";
			this.btnAddShelf.Size = new System.Drawing.Size(26, 27);
			this.btnAddShelf.TabIndex = 114;
			this.btnAddShelf.TabStop = false;
			this.btnAddShelf.Click += new System.EventHandler(this.btnAddShelf_Click);
			// 
			// FormProductSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 263);
			this.Controls.Add(this.btnAddShelf);
			this.Controls.Add(this.btnAddWeight);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.tbShelf);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.tbWeight);
			this.Controls.Add(this.btnAddCategory);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.tbCategory);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormProductSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Product Settings";
			((System.ComponentModel.ISupportInitialize)(this.btnAddCategory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAddWeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAddShelf)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private FontAwesome.Sharp.IconPictureBox btnAddCategory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox tbCategory;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox tbWeight;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox tbShelf;
		private FontAwesome.Sharp.IconPictureBox btnAddWeight;
		private FontAwesome.Sharp.IconPictureBox btnAddShelf;
	}
}