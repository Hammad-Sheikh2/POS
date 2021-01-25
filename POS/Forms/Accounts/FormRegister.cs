using Bunifu.Framework.UI;
using FontAwesome.Sharp;
using POS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Forms.Accounts
{
	public partial class FormRegister : Form
	{
		ErrorProvider error = new ErrorProvider();
		public FormRegister()
		{
			InitializeComponent();
			ActivateTheme();
		}

		private void ActivateTheme()
		{
			this.BackColor = Properties.Settings.Default.BackgroundColor;
			foreach (var textbox in GetAllChildren(this).OfType<Label>())
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			foreach (var textbox in GetAllChildren(this).OfType<Panel>())
			{
				textbox.BackColor = Properties.Settings.Default.HeaderColor;
			}
			foreach (var textbox in GetAllChildren(this).OfType<LinkLabel>())
			{
				textbox.LinkColor = Properties.Settings.Default.HeaderColor;
			}
			foreach (var textbox in GetAllChildren(this).OfType<Button>())
			{
				textbox.BackColor = Properties.Settings.Default.OnHoverColor;
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			}
			foreach (var textbox in GetAllChildren(this).OfType<IconButton>())
			{
				textbox.BackColor = Properties.Settings.Default.OnHoverColor;
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			}
			foreach (var textbox in GetAllChildren(this).OfType<BunifuMaterialTextbox>())
			{
				textbox.LineFocusedColor = Properties.Settings.Default.HeaderColor;
				textbox.LineMouseHoverColor = Properties.Settings.Default.HeaderColor;
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
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
		private void pbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://www.facebook.com/gleswills");
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (tbName.Text.Length == 0)
			{
				error.SetError(tbName, "Le nom ne peut pas être vide"); return;
			}
			else error.SetError(tbName, "");
			if (tbUsername.Text.Length == 0)
			{
				error.SetError(tbUsername, "Le nom d'utilisateur ne peut pas être vide"); return;
			}
			else error.SetError(tbUsername, "");
			if (tbPassword.Text.Length == 0)
			{
				error.SetError(tbPassword, "Le mot de passe ne peut pas être vide"); return;
			}
			else error.SetError(tbPassword, "");
			Access.InsertUser(new User() { Id = Access.NextUserId, Username = tbUsername.Text, Name = tbName.Text, Pass = tbPassword.Text, Role = "Admin" });
			Manager.Show("Admin enregistré", Notification.Type.Success);
			FormLogin login = new FormLogin();
			login.Show();
			this.Hide();
		}
	}
}
