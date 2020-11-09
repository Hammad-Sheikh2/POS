using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Forms;
using System.Diagnostics;
using POS.Forms.Settings;
using POS.Classes;

namespace POS.UserControls
{
	public partial class UC_Settings : UserControl
	{
		#region Variables

		private Color ForeGround, Background;

		public UC_Settings()
		{
			InitializeComponent();

			UpdateTheme();
		}

		#endregion

		#region Methods

		private void UpdateTheme()
		{
			Background = Properties.Settings.Default.BackgroundColor;
			ForeGround = Properties.Settings.Default.ForeColor;
			this.BackColor = Background;
			foreach (var textbox in GetAllChildren(this).OfType<Label>())
				textbox.ForeColor = ForeGround;
			foreach (var textbox in GetAllChildren(this).OfType<TextBox>())
				textbox.ForeColor = ForeGround;
			foreach (var textbox in GetAllChildren(this).OfType<TextBox>())
				textbox.BackColor = Background;
			foreach (var textbox in GetAllChildren(this).OfType<Button>())
			{
				textbox.BackColor = Properties.Settings.Default.HeaderColor;
				textbox.ForeColor = ForeGround;
			}
		}

		private static IEnumerable<Control> GetAllChildren(Control root)
		{
			var stack = new Stack<Control>();
			stack.Push(root);

			while (stack.Any())
			{
				var next = stack.Pop();
				foreach (Control child in next.Controls)
					stack.Push(child);
				yield return next;
			}
		}

		#endregion

		private void btnChangeTheme_Click(object sender, EventArgs e)
		{
			using (FormChangeTheme f = new FormChangeTheme())
			{
				f.ShowDialog();
				UpdateTheme();
				Dashboard dsh = this.ParentForm as Dashboard;
				dsh.ActivateCurrentTheme();
			}

		}

		private void UC_Settings_Load(object sender, EventArgs e)
		{
			UpdateTheme();
		}

		private void btnManageSoftware_Click(object sender, EventArgs e)
		{
			using (FormSoftwareSettings f = new FormSoftwareSettings())
			{
				if (f.ShowDialog() == DialogResult.OK)
				{
					Dashboard dsh = this.ParentForm as Dashboard;
					dsh.lblSoftwareName.Text = Properties.Settings.Default.CompanyName;
				}
			}
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{

		}

		private void btnFactures_Click(object sender, EventArgs e)
		{

		}

		private void cbxManageUsers_Click(object sender, EventArgs e)
		{

		}

		private void btnNewUser_Click(object sender, EventArgs e)
		{
			using (FormNewUser f = new FormNewUser())
			{
				if (f.ShowDialog() == DialogResult.OK)
					Manager.Show("New User was registered.", Notification.Type.Info);
			}
		}

		private void btnDeleteUser_Click(object sender, EventArgs e)
		{
			FormDeleteUser f = new FormDeleteUser();
			f.ShowDialog();
		}

		private void btnViewAllUsers_Click(object sender, EventArgs e)
		{

		}


	}
}
