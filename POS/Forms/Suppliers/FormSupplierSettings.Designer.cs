namespace POS.Forms
{
	partial class FormSupplierSettings
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
			this.components = new System.ComponentModel.Container();
			this.tbCity = new System.Windows.Forms.TextBox();
			this.tbProvince = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label15 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAddCity = new FontAwesome.Sharp.IconPictureBox();
			this.btnAddProvince = new FontAwesome.Sharp.IconPictureBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.btnAddCity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAddProvince)).BeginInit();
			this.SuspendLayout();
			// 
			// tbCity
			// 
			this.tbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbCity.Location = new System.Drawing.Point(43, 43);
			this.tbCity.Name = "tbCity";
			this.tbCity.Size = new System.Drawing.Size(226, 29);
			this.tbCity.TabIndex = 0;
			this.tbCity.Click += new System.EventHandler(this.tbCity_Click);
			// 
			// tbProvince
			// 
			this.tbProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbProvince.Location = new System.Drawing.Point(43, 127);
			this.tbProvince.Name = "tbProvince";
			this.tbProvince.Size = new System.Drawing.Size(226, 29);
			this.tbProvince.TabIndex = 1;
			this.tbProvince.Click += new System.EventHandler(this.tbCity_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel1.BackColor = System.Drawing.Color.Gray;
			this.panel1.Location = new System.Drawing.Point(31, 88);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(250, 1);
			this.panel1.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel2.BackColor = System.Drawing.Color.Gray;
			this.panel2.Location = new System.Drawing.Point(31, 174);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(250, 1);
			this.panel2.TabIndex = 5;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label15.Location = new System.Drawing.Point(40, 19);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(34, 19);
			this.label15.TabIndex = 46;
			this.label15.Text = "City";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label1.Location = new System.Drawing.Point(40, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 19);
			this.label1.TabIndex = 47;
			this.label1.Text = "Province";
			// 
			// btnAddCity
			// 
			this.btnAddCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddCity.BackColor = System.Drawing.Color.Transparent;
			this.btnAddCity.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddCity.ForeColor = System.Drawing.Color.Gray;
			this.btnAddCity.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
			this.btnAddCity.IconColor = System.Drawing.Color.Gray;
			this.btnAddCity.IconSize = 26;
			this.btnAddCity.Location = new System.Drawing.Point(272, 45);
			this.btnAddCity.Name = "btnAddCity";
			this.btnAddCity.Size = new System.Drawing.Size(26, 27);
			this.btnAddCity.TabIndex = 98;
			this.btnAddCity.TabStop = false;
			this.toolTip1.SetToolTip(this.btnAddCity, "Add City");
			this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
			// 
			// btnAddProvince
			// 
			this.btnAddProvince.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddProvince.BackColor = System.Drawing.Color.Transparent;
			this.btnAddProvince.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddProvince.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnAddProvince.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
			this.btnAddProvince.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
			this.btnAddProvince.IconSize = 26;
			this.btnAddProvince.Location = new System.Drawing.Point(272, 130);
			this.btnAddProvince.Name = "btnAddProvince";
			this.btnAddProvince.Size = new System.Drawing.Size(26, 27);
			this.btnAddProvince.TabIndex = 99;
			this.btnAddProvince.TabStop = false;
			this.toolTip1.SetToolTip(this.btnAddProvince, "Add Province");
			this.btnAddProvince.Click += new System.EventHandler(this.btnAddProvince_Click);
			// 
			// FormSupplierSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(326, 199);
			this.Controls.Add(this.btnAddProvince);
			this.Controls.Add(this.btnAddCity);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tbProvince);
			this.Controls.Add(this.tbCity);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormSupplierSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Supplier Settings";
			((System.ComponentModel.ISupportInitialize)(this.btnAddCity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAddProvince)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbCity;
		private System.Windows.Forms.TextBox tbProvince;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label1;
		private FontAwesome.Sharp.IconPictureBox btnAddCity;
		private FontAwesome.Sharp.IconPictureBox btnAddProvince;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}