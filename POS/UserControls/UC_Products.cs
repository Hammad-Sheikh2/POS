using FontAwesome.Sharp;
using POS.Forms;
using POS.Forms.Products;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace POS.UserControls
{
	public partial class UC_Products : UserControl
	{
		public UC_Products()
		{
			InitializeComponent();
			ActivateTheme();
		}
		

		#region Methods

		private void ActivateTheme()
		{
			this.BackColor = Properties.Settings.Default.BackgroundColor;
			foreach (var textbox in GetAllChildren(this).OfType<IconPictureBox>())
			{
				textbox.ForeColor = Properties.Settings.Default.HeaderColor;
				textbox.BackColor = Properties.Settings.Default.MenuBarColor;
			}
			foreach (var textbox in GetAllChildren(this).OfType<IconButton>())
			{
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
				textbox.BackColor = Properties.Settings.Default.HeaderColor;
			}
			foreach (var textbox in GetAllChildren(this).OfType<Panel>())
				textbox.BackColor = Properties.Settings.Default.MenuBarColor;
			foreach (var textbox in GetAllChildren(this).OfType<IconPictureBox>())
				textbox.ForeColor = Properties.Settings.Default.HeaderColor;
			foreach (var textbox in GetAllChildren(this).OfType<Label>())
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			foreach (var textbox in GetAllChildren(this).OfType<ComboBox>())
			{
				textbox.BackColor = Properties.Settings.Default.OnHoverColor;
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			}
			dg.HeaderBgColor = Properties.Settings.Default.HeaderColor;
			dg.HeaderForeColor = Properties.Settings.Default.ForeColor;
			dg.BackgroundColor = Properties.Settings.Default.MenuBarColor;
			panelListings.BackColor = Color.Transparent;
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

		#endregion

		private void btnSettings_Click(object sender, EventArgs e)
		{
			FormProductSettings f = new FormProductSettings();
			f.ShowDialog();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			FormNewProduct f = new FormNewProduct();
			f.ShowDialog();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			FormEditProduct f = new FormEditProduct();
			f.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			FormDeleteProduct f = new FormDeleteProduct();
			f.ShowDialog();
		}
	}
}
