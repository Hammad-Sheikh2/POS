using FontAwesome.Sharp;
using POS.Classes;
using POS.Classes.Products;
using POS.Forms.Selling;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POS.UserControls
{
	public partial class UC_SellingWindow : UserControl
	{
		public UC_SellingWindow()
		{
			InitializeComponent();
			ActivateTheme();
			PopulateComboboxes();
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
			dg.HeaderBgColor = Properties.Settings.Default.HeaderColor;
			dg.HeaderForeColor = Properties.Settings.Default.ForeColor;
			dg.BackgroundColor = Properties.Settings.Default.MenuBarColor;
			tbTotal.BackColor = Properties.Settings.Default.HeaderColor;
			tbTotal.ForeColor = Properties.Settings.Default.ForeColor;
		}

		private void PopulateComboboxes()
		{
			cbxCustomers.AutoCompleteCustomSource = Access.GetAllCustomerNamesCollection;
			cbxCustomers.Items.AddRange(Access.GetStringList("SELECT Name FROM Customers").ToArray());
			cbxProductNames.AutoCompleteCustomSource = Access.GetAllProductNamesCollection;
			cbxProductNames.Items.AddRange(Access.GetStringList("SELECT ProductName FROM Products;").ToArray());
			lblCashier.Text = Login.Name;
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

		private void dg_Paint(object sender, PaintEventArgs e)
		{
			tbTotal.Text = dg.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["totalDataGridViewTextBoxColumn"].Value)).ToString();
		}

		private void btnCash_Click(object sender, EventArgs e)
		{
			Customer cus = Access.GetCustomer(cbxCustomers.Text);
			Cart[] arr = cartBindingSource.List.OfType<Cart>().ToArray();
			using (FormCashPurchase f = new FormCashPurchase(cus, arr))
			{
				f.tbTotalBill.Text = tbTotal.Text;
				f.tbNoOfProducts.Text = dg.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["quantityDataGridViewTextBoxColumn"].Value)).ToString();
				f.ShowDialog();
			}
		}

		private void btnCredit_Click(object sender, EventArgs e)
		{
			Customer cus = Access.GetCustomer(cbxCustomers.Text);
			Cart[] arr = cartBindingSource.List.OfType<Cart>().ToArray();
			using (FormCreditPayment f = new FormCreditPayment(cus, arr))
			{
				f.tbTotalBill.Text = tbTotal.Text;
				f.ShowDialog();
			}
		}

		private void cbxProductNames_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				//cbxProductNames_SelectedIndexChanged(sender, e);
			}
		}

		private void cbxProductNames_SelectedIndexChanged(object sender, EventArgs e)
		{
			foreach (Cart item in cartBindingSource.List)
			{
				if (item.ProductName == cbxProductNames.Text)
				{
					item.Quantity++;
					cartBindingSource.ResetBindings(false);
					return;
				}
			}
			cartBindingSource.List.Add(Access.GetCart(Access.GetProduct(cbxProductNames.Text)));
		}
	}
}
