using FontAwesome.Sharp;
using POS.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS.Forms.Customers
{
	public partial class FormDeleteCustomer : Form
	{
		ErrorProvider error = new ErrorProvider();
		Customer cus;

		public FormDeleteCustomer()
		{
			InitializeComponent();
			ActivateTheme();
			Populate();
		}

		private void Populate()
		{
			cbxFilter.Items.Clear();
			cbxFilter.Items.AddRange(Access.GetStringList("SELECT Id FROM Customers", true).ToArray());
			tbSearch.AutoCompleteCustomSource = Access.GetAllCustomerNamesCollection;
		}

		private void ActivateTheme()
		{
			this.BackColor = Properties.Settings.Default.HeaderColor;
			foreach (var textbox in GetAllChildren(this).OfType<IconPictureBox>())
			{
				textbox.IconColor = Properties.Settings.Default.MenuBarColor;
				textbox.BackColor = Properties.Settings.Default.MenuBarColor;
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			}
			foreach (var textbox in GetAllChildren(this).OfType<TextBox>())
			{
				textbox.BackColor = Properties.Settings.Default.OnHoverColor;
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			}
			foreach (var textbox in GetAllChildren(this).OfType<Label>())
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			foreach (var textbox in GetAllChildren(this).OfType<Panel>())
				textbox.BackColor = Properties.Settings.Default.ForeColor;
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
		private void btnCredit_Click(object sender, System.EventArgs e)
		{
			if (cus == null)
			{
				error.SetError(btnDelete, "No customer selected");
			}
			else
			{
				error.SetError(btnDelete, "");
				if (MessageBox.Show($"Do you want to delete {cus.Name}?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						Access.DeleteCustomer(cus);
						Manager.Show("Customer Deleted", Notification.Type.Info);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					Populate();
				}
			}
		}

		private void tbSearch_Click(object sender, System.EventArgs e)
		{
			(sender as TextBox).Clear();
		}

		private void tbSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				cus = Access.GetCustomer(tbSearch.Text);
			}
		}

		private void cbxFilter_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cus = Access.GetCustomer(Convert.ToInt32(cbxFilter.SelectedItem));
		}
	}
}
