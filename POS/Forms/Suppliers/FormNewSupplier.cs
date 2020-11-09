using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Forms.Suppliers
{
	public partial class FormNewSupplier : Form
	{
		public FormNewSupplier()
		{
			InitializeComponent();
			ActivateTheme();
		}

		private void FormNewSupplier_Load(object sender, EventArgs e)
		{

		}

		private void ActivateTheme()
		{
			this.BackColor = Properties.Settings.Default.HeaderColor;
			foreach (var textbox in GetAllChildren(this).OfType<IconPictureBox>())
			{
				textbox.IconColor = Properties.Settings.Default.MenuBarColor;
				textbox.BackColor = Properties.Settings.Default.MenuBarColor;
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			}
			foreach (var textbox in GetAllChildren(this).OfType<TextBox>())
			{
				textbox.BackColor = Properties.Settings.Default.OnHoverColor;
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			}
			foreach (var textbox in GetAllChildren(this).OfType<ComboBox>())
			{
				textbox.BackColor = Properties.Settings.Default.OnHoverColor;
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			}
			foreach (var textbox in GetAllChildren(this).OfType<Label>())
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			foreach (var textbox in GetAllChildren(this).OfType<Panel>())
				textbox.BackColor = Properties.Settings.Default.HeaderColor;
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
