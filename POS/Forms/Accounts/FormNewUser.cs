using POS.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS.Forms.Settings
{
	public partial class FormNewUser : Form
	{
		ErrorProvider error = new ErrorProvider();
		public FormNewUser()
		{
			InitializeComponent();
			ActivateTheme();
		}

		private void ActivateTheme()
		{
			this.BackColor = Properties.Settings.Default.HeaderColor;
			foreach (var textbox in GetAllChildren(this).OfType<TextBox>())
			{
				textbox.BackColor = Properties.Settings.Default.OnHoverColor;
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			}
			foreach (var textbox in GetAllChildren(this).OfType<Label>())
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			foreach (var textbox in GetAllChildren(this).OfType<Panel>())
				textbox.BackColor = Properties.Settings.Default.ForeColor;
			foreach (var textbox in GetAllChildren(this).OfType<Button>())
				textbox.BackColor = Properties.Settings.Default.OnHoverColor;
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

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (tbName.TextLength == 0)
			{
				error.SetError(tbName, "Le nom ne peut pas être vide"); return;
			}
			else error.SetError(tbName, "");
			if (tbUsername.TextLength == 0)
			{
				error.SetError(tbUsername, "Le nom d'utilisateur ne peut pas être vide"); return;
			}
			else error.SetError(tbUsername, "");
			if (cbxRole.SelectedIndex == -1)
			{
				error.SetError(cbxRole, "Le rôle ne peut pas être vide"); return;
			}
			else error.SetError(cbxRole, "");
			if (tbPassword.TextLength == 0)
			{
				error.SetError(tbPassword, "Le mot de passe ne peut pas être vide"); return;
			}
			else error.SetError(tbPassword, "");
			if (tbConfirmPassword.TextLength == 0)
			{
				error.SetError(tbConfirmPassword, "Veuillez confirmer le mot de passe"); return;
			}
			else error.SetError(tbConfirmPassword, "");
			if (tbPassword.Text != tbConfirmPassword.Text)
			{
				error.SetError(tbPassword, "Le mot de passe ne correspond pas");
				error.SetError(tbConfirmPassword, "Le mot de passe ne correspond pas");
				return;
			}
			else
			{
				error.SetError(tbPassword, "");
				error.SetError(tbConfirmPassword, "");
			}
			if (!Access.IsValidUsername(tbUsername.Text))
			{
				error.SetError(tbUsername, "Ce nom d'utilisateur existe déjà"); return;
			}
			else error.SetError(tbUsername, "");
			Access.InsertUser(new User() { Id = Access.NextUserId, Username = tbUsername.Text, Name = tbName.Text, Pass = tbPassword.Text, Role = cbxRole.SelectedItem.ToString() });
			Manager.Show("Utilisateur enregistré", Notification.Type.Success);
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
