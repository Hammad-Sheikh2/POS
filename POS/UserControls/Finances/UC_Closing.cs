using Bunifu.Framework.UI;
using FontAwesome.Sharp;
using POS.Classes;
using POS.Classes.Finances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS.UserControls.Finances
{
	public partial class UC_Closing : UserControl
	{
		Shift shift = new Shift();
		DayClosing dayClosing = new DayClosing();

		public UC_Closing()
		{
			InitializeComponent();
			ActivateTheme();
			if (Login.Role == "Cashier")
			{
				tabControl1.TabPages.Remove(tabPage2);
				tabControl1.TabPages.Remove(tabPage3);
			}
			else if (Login.Role == "Supervisor")
			{
				tabControl1.TabPages.Remove(tabPage3);
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
			foreach (var item in GetAllChildren(this).OfType<BunifuCards>())
			{
				item.color = Properties.Settings.Default.HeaderColor;
				item.BackColor = Properties.Settings.Default.OnHoverColor;
			}
			foreach (var item in GetAllChildren(this).OfType<BunifuCustomDataGrid>())
			{
				item.BackColor = Properties.Settings.Default.OnHoverColor;
				item.HeaderBgColor = Properties.Settings.Default.HeaderColor;
				item.HeaderForeColor = Properties.Settings.Default.ForeColor;
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

		private async void UC_Closing_Load(object sender, EventArgs e)
		{
			closingShiftBindingSource.DataSource = await Access.GetClosingShiftsAsync();
			shiftBindingSource.DataSource = await Access.GetShiftsAsync(dpDayClosing.Value);
			dayClosingBindingSource.DataSource = await Access.GetDayClosingsAsync(dpClosingMonth.Value);
			ReloadShift();
			DisplayShift();
			ReloadDay();
			DisplayDay();
			DisplayMonth();
		}

		private void ReloadShift()
		{
			shift.Id = Access.GetShift().Id;
			shift.QuantitySold = closingShiftBindingSource.List.Cast<ClosingShift>().Sum(item => item.Quantity);
			shift.TotalAmount = closingShiftBindingSource.List.Cast<ClosingShift>().Sum(item => item.Total);
			shift.PaidAmount = closingShiftBindingSource.List.Cast<ClosingShift>().Sum(item => item.Paid);
			shift.CreditInvoices = closingShiftBindingSource.List.Cast<ClosingShift>().Sum(item => item.Credit ? 1 : 0);
			shift.CashInvoices = closingShiftBindingSource.List.Cast<ClosingShift>().Sum(item => item.Credit ? 0 : 1);
			shift.ClosedOn = DateTime.Now;
			shift.Explanation = tbExplanation.Text;
		}

		private void DisplayShift()
		{
			tbShiftId.Value = shift.Id;
			tbQuantity.Value = Convert.ToDecimal(shift.QuantitySold);
			tbTotal.Value = Convert.ToDecimal(shift.TotalAmount);
			tbPaid.Value = Convert.ToDecimal(shift.PaidAmount);
			tbCredit.Value = Convert.ToDecimal(shift.CreditInvoices);
			tbCash.Value = Convert.ToDecimal(shift.CashInvoices);
			tbExplanation.Text = shift.Explanation;
		}

		private void ReloadDay()
		{
			//dayClosing.DayId =
			dayClosing.ClosingDate = dpDayClosing.Value;
			dayClosing.TotalAmount = shiftBindingSource.List.Cast<Shift>().Sum(item => item.TotalAmount);
			dayClosing.PaidAmount = shiftBindingSource.List.Cast<Shift>().Sum(item => item.PaidAmount);
		}

		private void DisplayDay()
		{
			//dpDayClosing.Value = dayClosing.ClosingDate;
			tbTotalAmountDaily.Value = Convert.ToDecimal(dayClosing.TotalAmount);
			tbPaidAmountDaily.Value = Convert.ToDecimal(dayClosing.PaidAmount);

		}

		private void DisplayMonth()
		{
			tbTotalMonthly.Value = Convert.ToDecimal(dayClosingBindingSource.List.Cast<DayClosing>().Sum(item => item.TotalAmount));
			tbPaidMonthly.Value = Convert.ToDecimal(dayClosingBindingSource.List.Cast<DayClosing>().Sum(item => item.PaidAmount));
		}

		private async void btnCloseShift_Click(object sender, EventArgs e)
		{
			try
			{
				ReloadShift();
				await Access.InsertShiftAsync(shift);
				Manager.Show("Poste bouclé", Forms.Notification.Type.Success);
				int id = await Access.StartNewShift();
				Manager.Show("nouveau poste", Forms.Notification.Type.Success);
				Manager.Show($"poste Id: {id}", Forms.Notification.Type.Info);
				UC_Closing_Load(this, e);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private async void dpDayClosing_ValueChanged(object sender, EventArgs e)
		{
			shiftBindingSource.DataSource = await Access.GetShiftsAsync(dpDayClosing.Value);
			ReloadDay();
			DisplayDay();
		}

		private async void btnCloseDay_Click(object sender, EventArgs e)
		{
			try
			{
				ReloadDay();
				await Access.InsertDayClosingAsync(dayClosing);
				Manager.Show("Journée cloturée", Forms.Notification.Type.Success);
				UC_Closing_Load(this, e);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void dpClosingMonth_ValueChanged(object sender, EventArgs e)
		{
			//dayClosingBindingSource.DataSource = await Access.GetDayClosingsAsync(dpClosingMonth.Value);
			UC_Closing_Load(this, e);
		}
	}
}
