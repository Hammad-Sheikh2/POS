using POS.Classes;
using POS.Forms;
using POS.Forms.Settings;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
			foreach (var textbox in GetAllChildren(this).OfType<Panel>())
			{
				textbox.BackColor = Properties.Settings.Default.OnHoverColor;
				textbox.ForeColor = ForeGround;
			}
			flowLayoutPanel1.BackColor = Color.Transparent;
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

		private void SaveSettings(object sender, EventArgs e)
		{
			Properties.Settings.Default.Save();
		}

		private void UC_Settings_Load(object sender, EventArgs e)
		{
			UpdateTheme();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			FormLogin f = new FormLogin();
			this.ParentForm.Hide();
			f.Show();
		}

		private void cbxManageUsers_Click(object sender, EventArgs e)
		{
			if (Login.Role != "Admin")
			{
				Manager.Show("Admins only", Forms.Notification.Type.Error);
				return;
			}
		}

		private void btnNewUser_Click(object sender, EventArgs e)
		{
			if (Login.Role != "Admin")
			{
				Manager.Show("Admins only", Forms.Notification.Type.Error);
				return;
			}
			using (FormNewUser f = new FormNewUser())
			{
				f.ShowDialog();
			}
		}

		private void btnDeleteUser_Click(object sender, EventArgs e)
		{
			if (Login.Role != "Admin")
			{
				Manager.Show("Admins only", Forms.Notification.Type.Error);
				return;
			}
			FormDeleteUser f = new FormDeleteUser();
			f.ShowDialog();
		}

		private void btnCredit_Click(object sender, EventArgs e)
		{
			if (btnCredit.AccessibleDescription == "Collasped")
			{
				panel1.Size = new Size(963, 173);
				btnCredit.AccessibleDescription = "Expanded";
			}
			else
			{
				panel1.Size = new Size(963, 34);
				btnCredit.AccessibleDescription = "Collasped";
			}
		}

		private void btnBankAccounts_Click(object sender, EventArgs e)
		{
			if (btnBankAccounts.AccessibleDescription == "Collasped")
			{
				panel2.Size = new Size(963, 120);
				btnBankAccounts.AccessibleDescription = "Expanded";
			}
			else
			{
				panel2.Size = new Size(963, 34);
				btnBankAccounts.AccessibleDescription = "Collasped";
			}
		}

		private void btnTickets_Click(object sender, EventArgs e)
		{
			if (btnTickets.AccessibleDescription == "Collasped")
			{
				panel3.Size = new Size(963, 84);
				btnTickets.AccessibleDescription = "Expanded";
			}
			else
			{
				panel3.Size = new Size(963, 34);
				btnTickets.AccessibleDescription = "Collasped";
			}
		}

		private void btnViewAllUsers_Click(object sender, EventArgs e)
		{

		}


	}
}
