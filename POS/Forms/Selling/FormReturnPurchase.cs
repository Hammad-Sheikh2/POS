using FontAwesome.Sharp;
using POS.Classes;
using POS.Classes.Finances;
using POS.Classes.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Forms.Selling
{
	public partial class FormReturnPurchase : Form
	{
		public Customer customer { get; set; }
		public Cart[] cart { get; set; }

		Invoice invoice = new Invoice();

		public FormReturnPurchase(Customer cus, Cart[] arr)
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
			invoice.Paid = double.Parse(tbTotalBill.Text);
			invoice.CustomerId = customer.Id;
			invoice.UserId = Login.Id;
			invoice.Credit = false;
			invoice.InvoiceDate = DateTime.Now;
			invoice.ShiftId = Access.GetShift().Id;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private async void btnReturn_Click(object sender, EventArgs e)
		{
			try
			{
				Reload();
				Access.InsertInvoice(invoice, cart);
				Manager.Show("Facture créée", Notification.Type.Success);
				Manager.Show("stock mis à jour", Notification.Type.Info);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Manager.Show("La transaction échoué", Notification.Type.Error);
			}
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
	}
}
