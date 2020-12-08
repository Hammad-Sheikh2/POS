using POS.Classes;
using System;
using System.Windows.Forms;

namespace POS.Forms.Settings
{
	public partial class FormDeleteUser : Form
	{
		public FormDeleteUser()
		{
			InitializeComponent();
			this.BackColor = Properties.Settings.Default.HeaderColor;
			cbxThemes.BackColor = Properties.Settings.Default.OnHoverColor;
			cbxThemes.ForeColor = Properties.Settings.Default.ForeColor;
			label5.ForeColor = Properties.Settings.Default.ForeColor;
			btnOk.BackColor = Properties.Settings.Default.OnHoverColor;
			btnOk.ForeColor = Properties.Settings.Default.ForeColor;
			btnCancel.BackColor = Properties.Settings.Default.OnHoverColor;
			btnCancel.ForeColor = Properties.Settings.Default.ForeColor;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Manager.Show("User was removed.", Notification.Type.Warning);
		}
	}
}
