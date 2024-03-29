﻿using FontAwesome.Sharp;
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
			foreach (var textbox in GetAllChildren(this).OfType<RadioButton>())
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			foreach (var textbox in GetAllChildren(this).OfType<Label>())
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			btnReceiveCreditPmt.ForeColor = Properties.Settings.Default.ForeColor;
			btnReceiveCreditPmt.LinkColor = Properties.Settings.Default.ForeColor;
			dg.HeaderBgColor = Properties.Settings.Default.HeaderColor;
			dg.HeaderForeColor = Properties.Settings.Default.ForeColor;
			dg.BackgroundColor = Properties.Settings.Default.MenuBarColor;
			tbTotal.BackColor = Properties.Settings.Default.HeaderColor;
			tbTotal.ForeColor = Properties.Settings.Default.ForeColor;
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

		private void PopulateComboboxes()
		{
			try
			{
				cbxCustomers.AutoCompleteCustomSource = Access.GetAllCustomerNamesCollection;
				cbxCustomers.Items.AddRange(Access.GetStringList("SELECT Name FROM Customers").ToArray());
				cbxProductNames.AutoCompleteCustomSource = Access.GetAllProductNamesCollection;
				cbxProductNames.Items.AddRange(Access.GetStringList("SELECT ProductName FROM Products;").ToArray());
				lblCashier.Text = Login.Name.ToUpper();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				if (f.ShowDialog() == DialogResult.OK)
				{
					btnClear_Click(this, e);
				}
			}
		}

		private void btnCredit_Click(object sender, EventArgs e)
		{
			Customer cus = Access.GetCustomer(cbxCustomers.Text);
			Cart[] arr = cartBindingSource.List.OfType<Cart>().ToArray();
			if (arr.Length == 0)
			{
				Manager.Show("panier vide", Forms.Notification.Type.Warning);
				return;
			}

			if (rbPayment.Checked)
			{
				using (FormCreditPayment f = new FormCreditPayment(cus, arr))
				{
					f.tbTotalBill.Text = tbTotal.Text;
					if (f.ShowDialog() == DialogResult.OK)
					{
						btnClear_Click(sender, e);
					}
				}
			}
			else
			{
				if (arr.Length == 0)
				{
					Manager.Show("panier vide", Forms.Notification.Type.Warning);
					return;
				}
				foreach (Cart item in arr)
				{
					item.Quantity *= -1;
				}
				using (FormReturnPurchase f = new FormReturnPurchase(cus, arr))
				{
					f.tbTotalBill.Text = (double.Parse(tbTotal.Text) * -1).ToString();
					f.tbNoOfProducts.Text = dg.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["quantityDataGridViewTextBoxColumn"].Value)).ToString();
					f.ShowDialog();
				}
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
			try
			{
				Product pr = Access.GetProduct(cbxProductNames.Text);
				if (pr == null)
					return;
				if (pr.QuantityInShelves <= 0 && rbPayment.Checked)
				{
					Manager.Show("En rupture de stock", Forms.Notification.Type.Info);
					return;
				}
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
				dg.ClearSelection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			cartBindingSource.Clear();
			rbPayment.Checked = true;
			cbxCustomers.SelectedIndex = -1;
			cbxCustomers.Text = "Comptant";
			cbxProductNames.Text = "";
			btnReceiveCreditPmt.LinkColor = Properties.Settings.Default.ForeColor;

		}

		private void cbxProductNames_Click(object sender, EventArgs e)
		{
			(sender as ComboBox).Text = "";
		}

		private void InvoiceType_CheckChanged(object sender, EventArgs e)
		{
			if (rbReturn.Checked)
			{
				btnCash.Visible = false;
				btnCredit.Text = "confirmer";
			}
			else
			{
				btnCash.Visible = true;
				btnCredit.Text = "Crédit";
			}
		}

		private void dg_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			Cart pr = cartBindingSource.List.Cast<Cart>().ToList().ElementAt(e.RowIndex);
			if (Access.GetProduct(pr.ProductId).QuantityInShelves <= 0)
			{
				Manager.Show("Out of stock", Forms.Notification.Type.Info);
				e.Cancel = true;
			}
		}

		private void dg_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			Cart cr = cartBindingSource.List.Cast<Cart>().ToList().ElementAt(e.RowIndex);
			Product pr = Access.GetProduct(cr.ProductId);
			if (pr.QuantityInShelves < cr.Quantity)
			{
				Manager.Show("quantité invalide", Forms.Notification.Type.Info);
				cr.Quantity = pr.QuantityInShelves;
			}
		}

		private void btnReceiveCreditPmt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Customer cus = Access.GetCustomer(cbxCustomers.Text);
			using (FormCreditPayment f = new FormCreditPayment(cus))
			{
				f.ShowDialog();
			}
		}
	}
}
