using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS.UserControls.Finances
{
	public partial class UC_Closing : UserControl
	{
		public UC_Closing()
		{
			InitializeComponent();
			ActivateTheme();
			btnClosingShift_Click(this, new EventArgs());
		}

		private void ActivateTheme()
		{
			this.BackColor = Properties.Settings.Default.BackgroundColor;
			foreach (var textbox in GetAllChildren(this).OfType<IconButton>())
			{
				textbox.IconColor = Properties.Settings.Default.ForeColor;
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
				textbox.BackColor = Properties.Settings.Default.HeaderColor;
			}
			foreach (var textbox in GetAllChildren(this).OfType<Panel>())
				textbox.BackColor = Properties.Settings.Default.MenuBarColor;
			foreach (var textbox in GetAllChildren(this).OfType<Label>())
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
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

		private void btnClosingShift_Click(object sender, EventArgs e)
		{
			Canva.Controls.Clear();
			UC_ClosingShift uc = new UC_ClosingShift();
			uc.Dock = DockStyle.Fill;
			Canva.Controls.Add(uc);
		}

		private void btnClosingDay_Click(object sender, EventArgs e)
		{
			Canva.Controls.Clear();
			UC_ClosingDay uc = new UC_ClosingDay();
			uc.Dock = DockStyle.Fill;
			Canva.Controls.Add(uc);
		}

		private void btnClosingMonth_Click(object sender, EventArgs e)
		{
			Canva.Controls.Clear();
			UC_ClosingMonth uc = new UC_ClosingMonth();
			uc.Dock = DockStyle.Fill;
			Canva.Controls.Add(uc);
		}
	}
}
