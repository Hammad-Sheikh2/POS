using FontAwesome.Sharp;
using POS.Forms;
using POS.Forms.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS.UserControls
{
	public partial class UC_Customers : UserControl
	{
		public UC_Customers()
		{
			InitializeComponent();
			ActivateTheme();
		}

		private void ActivateTheme()
		{
			this.BackColor = Properties.Settings.Default.BackgroundColor;
			foreach (var textbox in GetAllChildren(this).OfType<IconPictureBox>())
			{
				textbox.ForeColor = Properties.Settings.Default.HeaderColor;
				textbox.BackColor = Properties.Settings.Default.MenuBarColor;
			}
			foreach (var textbox in GetAllChildren(this).OfType<IconButton>())
			{
				textbox.IconColor = Properties.Settings.Default.HeaderColor;
				textbox.ForeColor = Properties.Settings.Default.MenuBarColor;
			}
			foreach (var textbox in GetAllChildren(this).OfType<Panel>())
				textbox.BackColor = Properties.Settings.Default.MenuBarColor;
			foreach (var textbox in GetAllChildren(this).OfType<IconPictureBox>())
				textbox.ForeColor = Properties.Settings.Default.HeaderColor;
			foreach (var textbox in GetAllChildren(this).OfType<Label>())
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			dg.HeaderBgColor = Properties.Settings.Default.HeaderColor;
			dg.HeaderForeColor = Properties.Settings.Default.ForeColor;
			dg.BackgroundColor = Properties.Settings.Default.MenuBarColor;

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

		private void btnSettings_Click(object sender, EventArgs e)
		{
			FormSupplierSettings f = new FormSupplierSettings();
			f.ShowDialog();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{

		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			FormEditCustomer f = new FormEditCustomer();
			f.ShowDialog();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			FormNewCustomer f = new FormNewCustomer();
			f.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			FormDeleteCustomer f = new FormDeleteCustomer();
			f.ShowDialog();
		}
	}
}
