using FontAwesome.Sharp;
using POS.Classes;
using POS.Classes.Finances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS.Forms.Selling
{
	public partial class FormCashPurchase : Form
	{
		public Customer customer { get; set; }
		public Cart[] cart { get; set; }
		Invoice invoice = new Invoice();

		public FormCashPurchase()
		{
			InitializeComponent();
			ActivateTheme();
		}

		public FormCashPurchase(Customer cus, Cart[] arr)
		{
			InitializeComponent();
			ActivateTheme();
			customer = cus;
			cart = arr;
			Populate();
		}

		private void Populate()
		{
			lblId.Text = Access.NextInvoiceId.ToString();
		}

		private void Reload()
		{
			invoice.Id = int.Parse(lblId.Text);
			invoice.Total = double.Parse(tbTotalBill.Text);
			invoice.Paid = double.Parse(tbCashGiven.Text);
			invoice.CustomerId = customer.Id;
			invoice.UserId = Login.Id;
			invoice.Credit = false;
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

		private void tbCashGiven_TextChanged(object sender, EventArgs e)
		{
			try
			{
				tbChange.Text = (double.Parse(tbTotalBill.Text) - double.Parse(tbCashGiven.Text)).ToString();
			}
			catch (Exception)
			{
				tbChange.Text = "0";
			}
		}

		private void btnCheckout_Click(object sender, EventArgs e)
		{
			try
			{
				Reload();
				Access.InsertInvoice(invoice, cart);
				Manager.Show("Ivoice created", Notification.Type.Success);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
