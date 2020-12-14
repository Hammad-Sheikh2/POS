using FontAwesome.Sharp;
using POS.Classes;
using POS.Classes.Finances;
using POS.UserControls.Finances;
using POS.UserControls.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS.UserControls
{
	internal enum TurnOverFilter
	{
		ByProducts, ByCashier, ByMonth
	}

	public partial class UC_Turnovers : UserControl
	{
		ErrorProvider error = new ErrorProvider();
		TurnOverFilter filter = TurnOverFilter.ByProducts;
		DefinedPeriod period;

		public UC_Turnovers()
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

		private void PopulateInvoices()
		{
			switch (filter)
			{
				case TurnOverFilter.ByProducts:

					dg.DataSource = turnOverProductsBindingSource;
					if (tbClientName.TextLength != 0 && tbCashierName.TextLength != 0)
					{
						int customerId = Access.GetCustomer(tbClientName.Text).Id;
						int cashierId = Access.GetUser(tbCashierName.Text).Id;
						turnOverProductsBindingSource.DataSource = TurnOverProducts.GetTurnOverProducts(Access.GetCarts(Access.GetInvoices(customerId, cashierId, dpStart.Value, dpEnd.Value)).ToArray());
					}
					else if (tbClientName.TextLength != 0)
					{
						int customerId = Access.GetCustomer(tbClientName.Text).Id;
						turnOverProductsBindingSource.DataSource = TurnOverProducts.GetTurnOverProducts(Access.GetCarts(Access.GetInvoicesByCustomers(customerId, dpStart.Value, dpEnd.Value)).ToArray());
					}
					else if (tbCashierName.TextLength != 0)
					{
						int cashierId = Access.GetUser(tbCashierName.Text).Id;
						turnOverProductsBindingSource.DataSource = TurnOverProducts.GetTurnOverProducts(Access.GetCarts(Access.GetInvoicesByUser(cashierId, dpStart.Value, dpEnd.Value)).ToArray());
					}
					else if (tbCashierName.TextLength == 0 && tbClientName.TextLength == 0)
					{
						turnOverProductsBindingSource.DataSource = TurnOverProducts.GetTurnOverProducts(Access.GetCarts(Access.GetInvoices(dpStart.Value, dpEnd.Value)).ToArray());
					}
					break;
				case TurnOverFilter.ByCashier:
					dg.DataSource = turnOverCashierBindingSource;
					if (tbClientName.TextLength != 0 && tbCashierName.TextLength != 0)
					{
						int customerId = Access.GetCustomer(tbClientName.Text).Id;
						int cashierId = Access.GetUser(tbCashierName.Text).Id;
						turnOverCashierBindingSource.DataSource = TurnOverCashier.GetTurnOverCashiers(Access.GetInvoices(customerId, cashierId, dpStart.Value, dpEnd.Value));
					}
					else if (tbClientName.TextLength != 0)
					{
						int customerId = Access.GetCustomer(tbClientName.Text).Id;
						turnOverCashierBindingSource.DataSource = TurnOverCashier.GetTurnOverCashiers(Access.GetInvoicesByCustomers(customerId, dpStart.Value, dpEnd.Value));
					}
					else if (tbCashierName.TextLength != 0)
					{
						int cashierId = Access.GetUser(tbCashierName.Text).Id;
						turnOverCashierBindingSource.DataSource = TurnOverCashier.GetTurnOverCashiers(Access.GetInvoicesByUser(cashierId, dpStart.Value, dpEnd.Value));
					}
					else if (tbCashierName.TextLength == 0 && tbClientName.TextLength == 0)
					{
						turnOverCashierBindingSource.DataSource = TurnOverCashier.GetTurnOverCashiers(Access.GetInvoices(dpStart.Value, dpEnd.Value));
					}
					break;
				case TurnOverFilter.ByMonth:
					dg.DataSource = turnOverMonthBindingSource;
					if (tbClientName.TextLength != 0 && tbCashierName.TextLength != 0)
					{
						int customerId = Access.GetCustomer(tbClientName.Text).Id;
						int cashierId = Access.GetUser(tbCashierName.Text).Id;
						turnOverMonthBindingSource.DataSource = TurnOverMonth.GetTurnOverMonth(Access.GetInvoices(customerId, cashierId, dpStart.Value, dpEnd.Value));
					}
					else if (tbClientName.TextLength != 0)
					{
						int customerId = Access.GetCustomer(tbClientName.Text).Id;
						turnOverMonthBindingSource.DataSource = TurnOverMonth.GetTurnOverMonth(Access.GetInvoicesByCustomers(customerId, dpStart.Value, dpEnd.Value));
					}
					else if (tbCashierName.TextLength != 0)
					{
						int cashierId = Access.GetUser(tbCashierName.Text).Id;
						turnOverMonthBindingSource.DataSource = TurnOverMonth.GetTurnOverMonth(Access.GetInvoicesByUser(cashierId, dpStart.Value, dpEnd.Value));
					}
					else if (tbCashierName.TextLength == 0 && tbClientName.TextLength == 0)
					{
						turnOverMonthBindingSource.DataSource = TurnOverMonth.GetTurnOverMonth(Access.GetInvoices(dpStart.Value, dpEnd.Value));
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

		private void btnProducts_Click(object sender, EventArgs e)
		{
			//Canva.Controls.Clear();

			UC_TurnoverByProducts uc = new UC_TurnoverByProducts();
			uc.Dock = DockStyle.Fill;
			//Canva.Controls.Add(uc);
		}

		private void btnCashier_Click(object sender, EventArgs e)
		{
			//Canva.Controls.Clear();
			UC_TurnOverByCashier uc = new UC_TurnOverByCashier();
			uc.Dock = DockStyle.Fill;
			//Canva.Controls.Add(uc);
		}

		private void btnMonth_Click(object sender, EventArgs e)
		{
			//Canva.Controls.Clear();
			UC_TurnoverByMonth uc = new UC_TurnoverByMonth();
			uc.Dock = DockStyle.Fill;
			//Canva.Controls.Add(uc);
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

		private void btnByProducts_Click(object sender, EventArgs e)
		{
			filter = TurnOverFilter.ByProducts;
			PopulateInvoices();
			if (dg.DataSource == turnOverProductsBindingSource)
			{

			}
		}

		private void dg_Paint(object sender, PaintEventArgs e)
		{
			switch (filter)
			{
				case TurnOverFilter.ByProducts:
					tbTotalQty.Text = dg.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["Quantity"].Value)).ToString();
					tbTotalBuy.Text = dg.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["BuyingPrice"].Value)).ToString();
					tbTotalSell.Text = dg.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["SellingPrice"].Value)).ToString();
					tbTotalMargin.Text = dg.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["Margin"].Value)).ToString();
					break;
				case TurnOverFilter.ByCashier:
					tbTotalMargin.Text = dg.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["Turnover"].Value)).ToString();
					break;
				case TurnOverFilter.ByMonth:
					break;
				default:
					break;
			}

		}

		private void btnByCashier_Click(object sender, EventArgs e)
		{
			filter = TurnOverFilter.ByCashier;
			PopulateInvoices();
		}

		private void btnByMonth_Click(object sender, EventArgs e)
		{
			filter = TurnOverFilter.ByMonth;
			PopulateInvoices();
		}
	}
}
