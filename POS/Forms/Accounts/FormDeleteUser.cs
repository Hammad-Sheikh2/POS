using POS.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace POS.Forms.Settings
{
	public partial class FormDeleteUser : Form
	{
		User usr = new User();
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

		private async void btnOk_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show($"Voulez-vous vraiment supprimer l'utilisateur {cbxThemes.Text} de la base de données?", ProductName, MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				usr = Access.GetUser(cbxThemes.Text);
				await Access.DeleteUser(usr);
				Manager.Show("Utilisateur supprimé", Notification.Type.Warning);
			}
		}

		private async void FormDeleteUser_Load(object sender, EventArgs e)
		{
			cbxThemes.Items.Clear();
			List<string> li = await Access.GetStringListAsync("Select Name FROM Users", false);
			cbxThemes.Items.AddRange(li.ToArray());
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
