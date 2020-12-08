using Bunifu.Framework.UI;
using FontAwesome.Sharp;
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
			Dashboard dsh = new Dashboard();
			dsh.Show();
			this.Hide();
			//if (tbUsername.Text == Properties.Settings.Default.LoginUsername && tbPassword.Text == Properties.Settings.Default.LoginPassword)
			//{
			//	Dashboard dsh = new Dashboard();
			//	dsh.Show();
			//	this.Hide();
			//}
			//else
			//{
			//	Manager.Show("Invalid Credentials", Notification.Type.Warning);
			//}
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
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
