
namespace POS.Forms.Accounts
{
	partial class FormRegister
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.pbClose = new FontAwesome.Sharp.IconPictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.tbPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.btnLogin = new FontAwesome.Sharp.IconButton();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.lblSoftwareName = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.tbName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(85)))), ((int)(((byte)(136)))));
			this.panel2.Controls.Add(this.pbClose);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(436, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(49, 310);
			this.panel2.TabIndex = 164;
			// 
			// pbClose
			// 
			this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pbClose.BackColor = System.Drawing.Color.Transparent;
			this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbClose.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.pbClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
			this.pbClose.IconColor = System.Drawing.Color.WhiteSmoke;
			this.pbClose.IconSize = 24;
			this.pbClose.Location = new System.Drawing.Point(22, 3);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(24, 24);
			this.pbClose.TabIndex = 138;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(85)))), ((int)(((byte)(136)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(49, 310);
			this.panel1.TabIndex = 163;
			// 
			// tbUsername
			// 
			this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.tbUsername.ForeColor = System.Drawing.Color.Black;
			this.tbUsername.HintForeColor = System.Drawing.Color.Gray;
			this.tbUsername.HintText = "Username";
			this.tbUsername.isPassword = false;
			this.tbUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(85)))), ((int)(((byte)(136)))));
			this.tbUsername.LineIdleColor = System.Drawing.Color.Gray;
			this.tbUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(85)))), ((int)(((byte)(136)))));
			this.tbUsername.LineThickness = 3;
			this.tbUsername.Location = new System.Drawing.Point(100, 158);
			this.tbUsername.Margin = new System.Windows.Forms.Padding(4);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.Size = new System.Drawing.Size(293, 35);
			this.tbUsername.TabIndex = 1;
			this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// bunifuElipse2
			// 
			this.bunifuElipse2.ElipseRadius = 13;
			this.bunifuElipse2.TargetControl = this;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Sitka Small", 8F);
			this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(85)))), ((int)(((byte)(136)))));
			this.linkLabel1.Location = new System.Drawing.Point(172, 283);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(146, 16);
			this.linkLabel1.TabIndex = 4;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "contacter le développeur";
			this.toolTip1.SetToolTip(this.linkLabel1, "Having problems? Contact System Developer..\r\nPlease feel free to contact me at an" +
        "y platform:\r\n- Whatsapp: (+92) 309 2193796\r\nOr, Email me at:\r\n- usamaaziz999@gma" +
        "il.com\r\n\r\n");
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// tbPassword
			// 
			this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.tbPassword.ForeColor = System.Drawing.Color.Black;
			this.tbPassword.HintForeColor = System.Drawing.Color.Gray;
			this.tbPassword.HintText = "Password";
			this.tbPassword.isPassword = true;
			this.tbPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(85)))), ((int)(((byte)(136)))));
			this.tbPassword.LineIdleColor = System.Drawing.Color.Gray;
			this.tbPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(85)))), ((int)(((byte)(136)))));
			this.tbPassword.LineThickness = 3;
			this.tbPassword.Location = new System.Drawing.Point(100, 198);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(293, 31);
			this.tbPassword.TabIndex = 2;
			this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(85)))), ((int)(((byte)(136)))));
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnLogin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnLogin.IconSize = 30;
			this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLogin.Location = new System.Drawing.Point(100, 236);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnLogin.Rotation = 0D;
			this.btnLogin.Size = new System.Drawing.Size(293, 35);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "Register Administrator";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// bunifuDragControl3
			// 
			this.bunifuDragControl3.Fixed = true;
			this.bunifuDragControl3.Horizontal = true;
			this.bunifuDragControl3.TargetControl = this.panel1;
			this.bunifuDragControl3.Vertical = true;
			// 
			// bunifuDragControl2
			// 
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.panel2;
			this.bunifuDragControl2.Vertical = true;
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = null;
			this.bunifuDragControl1.Vertical = true;
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoEllipsis = true;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Sitka Small", 14.25F);
			this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(141, 69);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(206, 34);
			this.bunifuCustomLabel1.TabIndex = 167;
			this.bunifuCustomLabel1.Text = "System de gestion";
			this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSoftwareName
			// 
			this.lblSoftwareName.AutoEllipsis = true;
			this.lblSoftwareName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::POS.Properties.Settings.Default, "CompanyName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lblSoftwareName.Font = new System.Drawing.Font("Sitka Small", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSoftwareName.ForeColor = System.Drawing.Color.Black;
			this.lblSoftwareName.Location = new System.Drawing.Point(100, 34);
			this.lblSoftwareName.Name = "lblSoftwareName";
			this.lblSoftwareName.Size = new System.Drawing.Size(293, 34);
			this.lblSoftwareName.TabIndex = 166;
			this.lblSoftwareName.Text = global::POS.Properties.Settings.Default.CompanyName;
			this.lblSoftwareName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbName
			// 
			this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.tbName.ForeColor = System.Drawing.Color.Black;
			this.tbName.HintForeColor = System.Drawing.Color.Gray;
			this.tbName.HintText = "Name";
			this.tbName.isPassword = false;
			this.tbName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(85)))), ((int)(((byte)(136)))));
			this.tbName.LineIdleColor = System.Drawing.Color.Gray;
			this.tbName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(85)))), ((int)(((byte)(136)))));
			this.tbName.LineThickness = 3;
			this.tbName.Location = new System.Drawing.Point(100, 115);
			this.tbName.Margin = new System.Windows.Forms.Padding(4);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(293, 35);
			this.tbName.TabIndex = 0;
			this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// FormRegister
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 310);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tbUsername);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Controls.Add(this.lblSoftwareName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormRegister";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormRegister";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private FontAwesome.Sharp.IconPictureBox pbClose;
		private System.Windows.Forms.Panel panel1;
		private Bunifu.Framework.UI.BunifuMaterialTextbox tbUsername;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.ToolTip toolTip1;
		private Bunifu.Framework.UI.BunifuMaterialTextbox tbPassword;
		private FontAwesome.Sharp.IconButton btnLogin;
		public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
		public Bunifu.Framework.UI.BunifuCustomLabel lblSoftwareName;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private Bunifu.Framework.UI.BunifuMaterialTextbox tbName;
	}
}