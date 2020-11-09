namespace POS.Forms
{
	partial class FormLogin
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
			this.label15 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbRegistrationNumber = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label15.Location = new System.Drawing.Point(34, 160);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(70, 19);
			this.label15.TabIndex = 124;
			this.label15.Text = "Username";
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel1.BackColor = System.Drawing.Color.Gray;
			this.panel1.Location = new System.Drawing.Point(26, 387);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(250, 1);
			this.panel1.TabIndex = 123;
			// 
			// tbName
			// 
			this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbName.Location = new System.Drawing.Point(37, 184);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(226, 29);
			this.tbName.TabIndex = 122;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label1.Location = new System.Drawing.Point(35, 220);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 19);
			this.label1.TabIndex = 126;
			this.label1.Text = "Password";
			// 
			// tbRegistrationNumber
			// 
			this.tbRegistrationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbRegistrationNumber.Location = new System.Drawing.Point(38, 244);
			this.tbRegistrationNumber.Name = "tbRegistrationNumber";
			this.tbRegistrationNumber.Size = new System.Drawing.Size(226, 29);
			this.tbRegistrationNumber.TabIndex = 125;
			this.tbRegistrationNumber.UseSystemPasswordChar = true;
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOk.Location = new System.Drawing.Point(38, 341);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(226, 31);
			this.btnOk.TabIndex = 127;
			this.btnOk.Text = "Register";
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(37, 304);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(227, 31);
			this.button1.TabIndex = 128;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pbLogo
			// 
			this.pbLogo.BackColor = System.Drawing.Color.Transparent;
			this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbLogo.Image = global::POS.Properties.Resources.Daco_4579002;
			this.pbLogo.Location = new System.Drawing.Point(77, 13);
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.Size = new System.Drawing.Size(146, 111);
			this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbLogo.TabIndex = 129;
			this.pbLogo.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel2.BackColor = System.Drawing.Color.Gray;
			this.panel2.Location = new System.Drawing.Point(26, 149);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(250, 1);
			this.panel2.TabIndex = 124;
			// 
			// panel3
			// 
			this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel3.BackColor = System.Drawing.Color.Gray;
			this.panel3.Location = new System.Drawing.Point(26, 288);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(250, 1);
			this.panel3.TabIndex = 124;
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(310, 446);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pbLogo);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbRegistrationNumber);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tbName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbRegistrationNumber;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pbLogo;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
	}
}