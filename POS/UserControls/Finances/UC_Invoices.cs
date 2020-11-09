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

namespace POS.UserControls.Finances
{
	public partial class UC_Invoices : UserControl
	{
		public UC_Invoices()
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
			tbPaid.Text = dg.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["paidDataGridViewTextBoxColumn"].Value)).ToString();
			tbLeft.Text = dg.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["leftDataGridViewTextBoxColumn"].Value)).ToString();
		}
	}
}
