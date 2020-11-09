using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using POS.Forms.Selling;

namespace POS.UserControls
{
	public partial class UC_SellingWindow : UserControl
	{
		public UC_SellingWindow()
		{
			InitializeComponent();
			ActivateTheme();
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
			//double your_variable = dg.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["Column4"].Value));
			tbTotal.Text = dg.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["totalDataGridViewTextBoxColumn"].Value)).ToString();
		}

		private void btnCash_Click(object sender, EventArgs e)
		{
			using (FormCashPurchase f = new FormCashPurchase())
			{
				f.tbTotalBill.Text = tbTotal.Text;
				f.tbNoOfProducts.Text = dg.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["quantityDataGridViewTextBoxColumn"].Value)).ToString();
				f.ShowDialog();
			}
		}

		private void btnCredit_Click(object sender, EventArgs e)
		{
			using (FormCreditPayment f = new FormCreditPayment())
			{
				f.ShowDialog();
			}
		}
	}
}
