using Bunifu.Framework.UI;
using FontAwesome.Sharp;
using POS.Classes;
using POS.UserControls.Finances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS.UserControls
{
	public partial class UC_FinanceDashboard : UserControl
	{
		ErrorProvider error = new ErrorProvider();
		DefinedPeriod period;

		public UC_FinanceDashboard()
		{
			InitializeComponent();
			ActivateTheme();
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
			foreach (var textbox in GetAllChildren(this).OfType<BunifuCards>())
			{
				textbox.color = Properties.Settings.Default.HeaderColor;
				textbox.BackColor = Properties.Settings.Default.MenuBarColor;
			}
			foreach (var textbox in GetAllChildren(this).OfType<TextBox>())
			{
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
				textbox.BackColor = Properties.Settings.Default.OnHoverColor;
			}
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

		private void cbxDefinedPeriod_SelectedIndexChanged(object sender, System.EventArgs e)
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

		private void btnFetch_Click(object sender, EventArgs e)
		{
			tbTurnover.Value = Convert.ToDecimal(Access.GetTotalTurnOver(dpStart.Value, dpEnd.Value));
			tbBuyPrice.Value = Convert.ToDecimal(Access.GetTotalBuyPrice(dpStart.Value, dpEnd.Value));
			tbSellingPrice.Value = Convert.ToDecimal(Access.GetTotalSellPrice(dpStart.Value, dpEnd.Value));
			tbCreditPmts.Value = Convert.ToDecimal(Access.GetCreditPayments(dpStart.Value, dpEnd.Value));
			tbCashPmts.Value = Convert.ToDecimal(Access.GetCashPayments(dpStart.Value, dpEnd.Value));
			tbUnpaidInvoicesValue.Value = Convert.ToDecimal(Access.GetUnpaidPayments(dpStart.Value, dpEnd.Value));
			tbAvgSale.Text = Math.Round(Access.GetAverageSale(dpStart.Value, dpEnd.Value), 2).ToString();
			tbInStoreProductPrice.Text = Access.GetInStoreProductsPrice().ToString();
			tbInShelvesProductPrice.Text = Access.GetInShelvesProductsPrice().ToString();
			tbProductsShelvesQty.Text = Access.GetInShelvesProductsQuantity().ToString();
			tbProductsStoreQty.Text = Access.GetInStoreProductsQuantity().ToString();
			tbPriceOfProductsExpired.Text = Access.GetExpiredProductsPurchasePrice().ToString();
			tbProductsExpiredCount.Text = Access.GetExpiredProductsCount().ToString();
			tbQuantityExpired.Text = Access.GetExpiredProductsQuantity().ToString();
			tbProductsDormantCount.Text = Access.GetDormantProductsCount(dpStart.Value, dpEnd.Value).ToString();
			tbProductsReturnedCount.Text = Access.GetReturnedProductsCount(dpStart.Value, dpEnd.Value).ToString();
		}
	}
}
