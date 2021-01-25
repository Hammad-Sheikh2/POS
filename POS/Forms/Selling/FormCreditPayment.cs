using FontAwesome.Sharp;
using POS.Classes;
using POS.Classes.Finances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS.Forms.Selling
{
	public partial class FormCreditPayment : Form
	{
		public Customer customer { get; set; }
		public Cart[] cart { get; set; }
		Invoice invoice = new Invoice();
		private bool IsNew = true;

		public FormCreditPayment()
		{
			InitializeComponent();
			ActivateTheme();
		}

		public FormCreditPayment(Customer cus, Cart[] arr)
		{
			InitializeComponent();
			ActivateTheme();
			customer = cus;
			cart = arr;
			cbxCustomers.AutoCompleteCustomSource = Access.GetAllCustomerNamesCollection;
			cbxCustomers.Items.AddRange(Access.GetStringList("SELECT Name FROM Customers").ToArray());
			Populate();
		}

		private void Populate()
		{
			lblId.Text = Access.NextInvoiceId.ToString();
			invoiceBindingSource.DataSource = Access.GetInvoicesByCustomersUnpaid(customer.Id);
			cbxInvoices.Items.Clear();
			cbxInvoices.Items.AddRange(Access.GetStringList($"SELECT Id FROM Invoices WHERE CustomerId = {customer.Id} AND Total > Paid", true).ToArray());
			cbxCustomers.Text = customer.Name;
		}

		private void Display()
		{
			lblId.Text = invoice.Id.ToString();
			cbxCustomers.Text = Access.GetCustomer(invoice.CustomerId).Name;
			tbTotalBill.Text = invoice.Total.ToString();
			tbCashGiven.Text = invoice.Paid.ToString();
		}

		private void Reload()
		{
			invoice.Id = int.Parse(lblId.Text);
			invoice.Total = double.Parse(tbTotalBill.Text);
			invoice.Paid = double.Parse(tbCashGiven.Text);
			invoice.CustomerId = customer.Id;
			invoice.UserId = Login.Id;
			invoice.Credit = true;
			invoice.InvoiceDate = DateTime.Now;
			invoice.ShiftId = Access.GetShift().Id;
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
			cbxInvoices.BackColor = Properties.Settings.Default.OnHoverColor;
			cbxInvoices.ForeColor = Properties.Settings.Default.ForeColor;
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

		private void btnSaveInvoice_Click(object sender, EventArgs e)
		{

			try
			{
				Reload();
				if (IsNew)
				{
					Access.InsertInvoice(invoice, cart);
					Manager.Show("Invoice created", Notification.Type.Success);
				}
				else
				{
					Access.UpdateInvoice(invoice);
					Manager.Show("Invoice updated", Notification.Type.Success);
				}
				Populate();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
		{
			customer = Access.GetCustomer(cbxCustomers.SelectedItem.ToString());
			invoiceBindingSource.DataSource = Access.GetInvoicesByCustomersUnpaid(customer.Id);
		}

		private void cbxInvoices_SelectedIndexChanged(object sender, EventArgs e)
		{
			invoice = Access.GetInvoice(int.Parse(cbxInvoices.SelectedItem.ToString()));
			Display();
			IsNew = false;
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			invoice = Access.GetInvoice(int.Parse(cbxInvoices.SelectedItem.ToString()));
			Display();
			IsNew = false;
		}
	}
}
