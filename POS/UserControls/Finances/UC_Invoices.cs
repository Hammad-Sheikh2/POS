using FontAwesome.Sharp;
using POS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POS.UserControls.Finances
{
	public enum InvoiceFilter
	{
		ALL, CREDIT, CASH
	}

	public enum DefinedPeriod
	{
		TODAY,
		ONE_WEEK,
		ONE_MONTH,
		THREE_MONTH,
		SIX_MONTH,
		ONE_YEAR
	}

	public partial class UC_Invoices : UserControl
	{
		ErrorProvider error = new ErrorProvider();
		InvoiceFilter filter = InvoiceFilter.ALL;
		DefinedPeriod period;

		public UC_Invoices()
		{
			InitializeComponent();
			ActivateTheme();
			PopulateTextBoxes();
		}

		private void PopulateTextBoxes()
		{
			tbClientName.AutoCompleteCustomSource = Access.GetAllCustomerNamesCollection;
			tbCashierName.AutoCompleteCustomSource = Access.GetAllUserNamesCollection;
		}

		private void PopulateInvoices()
		{
			switch (filter)
			{
				case InvoiceFilter.ALL:
					if (tbClientName.TextLength != 0 && tbCashierName.TextLength != 0)
					{
						int customerId = Access.GetCustomer(tbClientName.Text).Id;
						int cashierId = Access.GetUser(tbCashierName.Text).Id;
						invoiceBindingSource.DataSource = Access.GetInvoices(customerId, cashierId, dpStart.Value, dpEnd.Value);
					}
					else if (tbClientName.TextLength != 0)
					{
						int customerId = Access.GetCustomer(tbClientName.Text).Id;
						invoiceBindingSource.DataSource = Access.GetInvoicesByCustomers(customerId, dpStart.Value, dpEnd.Value);
					}
					else if (tbCashierName.TextLength != 0)
					{
						int cashierId = Access.GetUser(tbCashierName.Text).Id;
						invoiceBindingSource.DataSource = Access.GetInvoicesByUser(cashierId, dpStart.Value, dpEnd.Value);
					}
					else if (tbCashierName.TextLength == 0 && tbClientName.TextLength == 0)
					{
						invoiceBindingSource.DataSource = Access.GetInvoices(dpStart.Value, dpEnd.Value);
					}
					break;
				case InvoiceFilter.CREDIT:
					if (tbClientName.TextLength != 0 && tbCashierName.TextLength != 0)
					{
						int customerId = Access.GetCustomer(tbClientName.Text).Id;
						int cashierId = Access.GetUser(tbCashierName.Text).Id;
						invoiceBindingSource.DataSource = Access.GetInvoicesCredit(customerId, cashierId, dpStart.Value, dpEnd.Value);
					}
					else if (tbClientName.TextLength != 0)
					{
						int customerId = Access.GetCustomer(tbClientName.Text).Id;
						invoiceBindingSource.DataSource = Access.GetInvoicesCreditByCustomers(customerId, dpStart.Value, dpEnd.Value);
					}
					else if (tbCashierName.TextLength != 0)
					{
						int cashierId = Access.GetUser(tbCashierName.Text).Id;
						invoiceBindingSource.DataSource = Access.GetInvoicesCreditByUser(cashierId, dpStart.Value, dpEnd.Value);
					}
					else if (tbCashierName.TextLength == 0 && tbClientName.TextLength == 0)
					{
						invoiceBindingSource.DataSource = Access.GetInvoicesCredit(dpStart.Value, dpEnd.Value);
					}
					break;
				case InvoiceFilter.CASH:
					if (tbClientName.TextLength != 0 && tbCashierName.TextLength != 0)
					{
						int customerId = Access.GetCustomer(tbClientName.Text).Id;
						int cashierId = Access.GetUser(tbCashierName.Text).Id;
						invoiceBindingSource.DataSource = Access.GetInvoicesCash(customerId, cashierId, dpStart.Value, dpEnd.Value);
					}
					else if (tbClientName.TextLength != 0)
					{
						int customerId = Access.GetCustomer(tbClientName.Text).Id;
						invoiceBindingSource.DataSource = Access.GetInvoicesCashByCustomers(customerId, dpStart.Value, dpEnd.Value);
					}
					else if (tbCashierName.TextLength != 0)
					{
						int cashierId = Access.GetUser(tbCashierName.Text).Id;
						invoiceBindingSource.DataSource = Access.GetInvoicesCashByUser(cashierId, dpStart.Value, dpEnd.Value);
					}
					else if (tbCashierName.TextLength == 0 && tbClientName.TextLength == 0)
					{
						invoiceBindingSource.DataSource = Access.GetInvoicesCash(dpStart.Value, dpEnd.Value);
					}
					break;
				default:
					break;
			}
		}

		private void HandleDefinedPeriod()
		{
			switch (period)
			{
				case DefinedPeriod.TODAY:
					dpStart.Value = DateTime.Now;
					dpEnd.Value = DateTime.Now;
					break;
				case DefinedPeriod.ONE_WEEK:
					dpEnd.Value = DateTime.Now;
					dpStart.Value = DateTime.Now.AddDays(-7);
					break;
				case DefinedPeriod.ONE_MONTH:
					dpEnd.Value = DateTime.Now;
					dpStart.Value = DateTime.Now.AddDays(-30);
					break;
				case DefinedPeriod.THREE_MONTH:
					dpEnd.Value = DateTime.Now;
					dpStart.Value = DateTime.Now.AddDays(-90);
					break;
				case DefinedPeriod.SIX_MONTH:
					dpEnd.Value = DateTime.Now;
					dpStart.Value = DateTime.Now.AddDays(-180);
					break;
				case DefinedPeriod.ONE_YEAR:
					dpEnd.Value = DateTime.Now;
					dpStart.Value = DateTime.Now.AddDays(-364);
					break;
				default:
					break;
			}
			tbDays.Text = ((int)(dpEnd.Value - dpStart.Value).TotalDays).ToString();
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

		private void ValidateDateInterval(object sender, EventArgs e)
		{
			if (dpStart.Value > dpEnd.Value)
			{
				error.SetError(dpEnd, "End date must be greater than start date");
			}
			else
			{
				tbDays.Text = ((int)(dpEnd.Value - dpStart.Value).TotalDays).ToString();
				error.SetError(dpEnd, "");
			}
		}

		private void dg_Paint(object sender, PaintEventArgs e)
		{
			tbTotal.Text = dg.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["totalDataGridViewTextBoxColumn"].Value)).ToString();
			tbPaid.Text = dg.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["paidDataGridViewTextBoxColumn"].Value)).ToString();
			tbLeft.Text = dg.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["leftDataGridViewTextBoxColumn"].Value)).ToString();
		}

		private void btnAll_Click(object sender, EventArgs e)
		{
			filter = InvoiceFilter.ALL;
			PopulateInvoices();
		}

		private void btnCredit_Click(object sender, EventArgs e)
		{
			filter = InvoiceFilter.CREDIT;
			PopulateInvoices();
		}

		private void btnCash_Click(object sender, EventArgs e)
		{
			filter = InvoiceFilter.CASH;
			PopulateInvoices();
		}

		private void cbxDefinedPeriod_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cbxDefinedPeriod.SelectedIndex)
			{
				case 0: // Today
					period = DefinedPeriod.TODAY;
					HandleDefinedPeriod();
					break;
				case 1: // One week
					period = DefinedPeriod.ONE_WEEK;
					HandleDefinedPeriod();
					break;
				case 2: // One month
					period = DefinedPeriod.ONE_MONTH;
					HandleDefinedPeriod();
					break;
				case 3: // Three months
					period = DefinedPeriod.THREE_MONTH;
					HandleDefinedPeriod();
					break;
				case 4: // 6 Months
					period = DefinedPeriod.SIX_MONTH;
					HandleDefinedPeriod();
					break;
				case 5: // 1 year
					period = DefinedPeriod.ONE_YEAR;
					HandleDefinedPeriod();
					break;
				default:
					break;
			}
		}

		private void panelSearch_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
