using Bunifu.Framework.UI;
using FontAwesome.Sharp;
using POS.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace POS.Forms
{
	public partial class FormLogin : Form
	{
		public FormLogin()
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

		private void button1_Click(object sender, EventArgs e)
		{
			User user = Access.GetUserByUsername(tbUsername.Text);
			if (user != null && tbPassword.Text == user.Pass)
			{
				Login.Id = user.Id;
				Login.Name = user.Name;
				Login.Username = user.Username;
				Login.Password = user.Pass;
				Login.Role = user.Role;
				Manager.Show($"Role: {Login.Role}", Notification.Type.Info);
				Dashboard dsh = new Dashboard();
				dsh.Show();
				this.Hide();
			}
			else Manager.Show("Invalid credentials", Notification.Type.Error);
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.Save();
			Application.Exit();
		}

		private void tbPassword_Enter(object sender, EventArgs e)
		{
			tbPassword.isPassword = true;
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://www.linkedin.com/in/usama-aziz-01/");
		}


	}
}
