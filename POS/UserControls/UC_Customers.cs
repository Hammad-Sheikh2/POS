using Bunifu.Framework.UI;
using FontAwesome.Sharp;
using POS.Classes;
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
			Populate();
			customerBindingSource.DataSource = Access.GetCustomers();
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
			foreach (var textbox in GetAllChildren(this).OfType<Label>())
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			foreach (var textbox in GetAllChildren(this).OfType<BunifuCards>())
			{
				textbox.color = Properties.Settings.Default.HeaderColor;
				textbox.BackColor = Properties.Settings.Default.MenuBarColor;
			}
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

		private void Populate()
		{
			cbxFilter.Items.Clear();
			cbxFilter.Items.AddRange(Access.GetStringList("SELECT Id FROM Customers", true).ToArray());
			tbSearch.AutoCompleteCustomSource = Access.GetAllCustomerNamesCollection;
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
			using (FormEditCustomer f = new FormEditCustomer())
			{
				f.ShowDialog();
				Populate();
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			using (FormNewCustomer f = new FormNewCustomer())
			{
				f.ShowDialog();
				Populate();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

			using (FormDeleteCustomer f = new FormDeleteCustomer())
			{
				f.ShowDialog();
				Populate();
			}
		}

		private void tbSearch_Click(object sender, EventArgs e)
		{
			(sender as TextBox).Clear();
		}

		private void tbSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				customerBindingSource.DataSource = Access.GetCustomer(tbSearch.Text);
			}
		}

		private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			customerBindingSource.DataSource = Access.GetCustomer(Convert.ToInt32(cbxFilter.SelectedItem));
		}
	}
}
