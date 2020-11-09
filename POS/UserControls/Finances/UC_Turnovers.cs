using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.UserControls.Products;
using FontAwesome.Sharp;
using POS.UserControls.Finances;

namespace POS.UserControls
{
	public partial class UC_Turnovers : UserControl
	{
		public UC_Turnovers()
		{
			InitializeComponent();
			ActivateTheme();
			btnProducts_Click(this, new EventArgs());
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

		private void btnProducts_Click(object sender, EventArgs e)
		{
			Canva.Controls.Clear();
			UC_TurnoverByProducts uc = new UC_TurnoverByProducts();
			uc.Dock = DockStyle.Fill;
			Canva.Controls.Add(uc);
		}

		private void btnCashier_Click(object sender, EventArgs e)
		{
			Canva.Controls.Clear();
			UC_TurnOverByCashier uc = new UC_TurnOverByCashier();
			uc.Dock = DockStyle.Fill;
			Canva.Controls.Add(uc);
		}

		private void btnMonth_Click(object sender, EventArgs e)
		{
			Canva.Controls.Clear();
			UC_TurnoverByMonth uc = new UC_TurnoverByMonth();
			uc.Dock = DockStyle.Fill;
			Canva.Controls.Add(uc);
		}
	}
}
