namespace POS.UserControls
{
	partial class UC_Settings
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Settings));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnChangeTheme = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cbxManageUsers = new System.Windows.Forms.ToolStripDropDownButton();
			this.btnNewUser = new System.Windows.Forms.ToolStripMenuItem();
			this.btnDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
			this.btnViewAllUsers = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnManageSoftware = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnFactures = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.btnLogout = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangeTheme,
            this.toolStripSeparator1,
            this.cbxManageUsers,
            this.toolStripSeparator2,
            this.btnManageSoftware,
            this.toolStripSeparator3,
            this.btnFactures,
            this.toolStripSeparator4,
            this.btnLogout,
            this.toolStripSeparator5});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1085, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnChangeTheme
			// 
			this.btnChangeTheme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnChangeTheme.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeTheme.Image")));
			this.btnChangeTheme.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnChangeTheme.Name = "btnChangeTheme";
			this.btnChangeTheme.Size = new System.Drawing.Size(91, 22);
			this.btnChangeTheme.Text = "Change Theme";
			this.btnChangeTheme.Click += new System.EventHandler(this.btnChangeTheme_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// cbxManageUsers
			// 
			this.cbxManageUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.cbxManageUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewUser,
            this.btnDeleteUser,
            this.btnViewAllUsers});
			this.cbxManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("cbxManageUsers.Image")));
			this.cbxManageUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cbxManageUsers.Name = "cbxManageUsers";
			this.cbxManageUsers.Size = new System.Drawing.Size(94, 22);
			this.cbxManageUsers.Text = "Manage Users";
			this.cbxManageUsers.Click += new System.EventHandler(this.cbxManageUsers_Click);
			// 
			// btnNewUser
			// 
			this.btnNewUser.Name = "btnNewUser";
			this.btnNewUser.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
			this.btnNewUser.Size = new System.Drawing.Size(185, 22);
			this.btnNewUser.Text = "New User";
			this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
			// 
			// btnDeleteUser
			// 
			this.btnDeleteUser.Name = "btnDeleteUser";
			this.btnDeleteUser.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Delete)));
			this.btnDeleteUser.Size = new System.Drawing.Size(185, 22);
			this.btnDeleteUser.Text = "Delete User";
			this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
			// 
			// btnViewAllUsers
			// 
			this.btnViewAllUsers.Name = "btnViewAllUsers";
			this.btnViewAllUsers.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
			this.btnViewAllUsers.Size = new System.Drawing.Size(185, 22);
			this.btnViewAllUsers.Text = "View All Users";
			this.btnViewAllUsers.Click += new System.EventHandler(this.btnViewAllUsers_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// btnManageSoftware
			// 
			this.btnManageSoftware.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnManageSoftware.Image = ((System.Drawing.Image)(resources.GetObject("btnManageSoftware.Image")));
			this.btnManageSoftware.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnManageSoftware.Name = "btnManageSoftware";
			this.btnManageSoftware.Size = new System.Drawing.Size(103, 22);
			this.btnManageSoftware.Text = "Manage Software";
			this.btnManageSoftware.Click += new System.EventHandler(this.btnManageSoftware_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// btnFactures
			// 
			this.btnFactures.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnFactures.Image = ((System.Drawing.Image)(resources.GetObject("btnFactures.Image")));
			this.btnFactures.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnFactures.Name = "btnFactures";
			this.btnFactures.Size = new System.Drawing.Size(55, 22);
			this.btnFactures.Text = "Factures";
			this.btnFactures.Click += new System.EventHandler(this.btnFactures_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// btnLogout
			// 
			this.btnLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
			this.btnLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(49, 22);
			this.btnLogout.Text = "Logout";
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// UC_Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Controls.Add(this.toolStrip1);
			this.Name = "UC_Settings";
			this.Size = new System.Drawing.Size(1085, 563);
			this.Load += new System.EventHandler(this.UC_Settings_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnChangeTheme;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripDropDownButton cbxManageUsers;
		private System.Windows.Forms.ToolStripMenuItem btnNewUser;
		private System.Windows.Forms.ToolStripMenuItem btnDeleteUser;
		private System.Windows.Forms.ToolStripMenuItem btnViewAllUsers;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnManageSoftware;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btnFactures;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton btnLogout;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
	}
}
