using Bunifu.Framework.UI;
using FontAwesome.Sharp;
using POS.Classes;
using POS.Forms;
using POS.Forms.Products;
using POS.UserControls.Finances;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace POS.UserControls
{
	public enum ProductFilter
	{
		All, InStore, InShelves, Returned, Dormant, Expired, OutOfStock, InStock
	}

	public partial class UC_Products : UserControl
	{
		ErrorProvider error = new ErrorProvider();
		DefinedPeriod period;

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
			foreach (var textbox in GetAllChildren(this).OfType<CheckBox>())
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
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
			foreach (var textbox in GetAllChildren(this).OfType<BunifuCards>())
			{
				textbox.color = Properties.Settings.Default.HeaderColor;
				textbox.BackColor = Properties.Settings.Default.MenuBarColor;
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

		private void btnExportToExcel_Click(object sender, EventArgs e)
		{
			Manager.ExportDataGrid(dg);
			Manager.Show("Export complete", Notification.Type.Error);
		}

		private void dg_Paint(object sender, PaintEventArgs e)
		{
			foreach (DataGridViewRow row in dg.Rows)
			{
				foreach (DataGridViewCell cell in row.Cells)
				{

				}
			}
		}

		private void btnAll_Click(object sender, EventArgs e)
		{
			productBindingSource.DataSource = Access.GetProducts(ProductFilter.All);
		}

		private void btnInStore_Click(object sender, EventArgs e)
		{
			productBindingSource.DataSource = Access.GetProducts(ProductFilter.InStore);
		}

		private void btnInShelves_Click(object sender, EventArgs e)
		{
			productBindingSource.DataSource = Access.GetProducts(ProductFilter.InShelves);
		}

		private void btnReturned_Click(object sender, EventArgs e)
		{
			if (!cbFilter.Checked)
			{
				productBindingSource.DataSource = Access.GetProducts(ProductFilter.Returned);
			}
			else productBindingSource.DataSource = Access.GetProducts(ProductFilter.Returned, dpStart.Value, dpEnd.Value);
		}

		private void btnDormant_Click(object sender, EventArgs e)
		{
			if (!cbFilter.Checked)
			{
				productBindingSource.DataSource = Access.GetProducts(ProductFilter.Dormant);
			}
			else productBindingSource.DataSource = Access.GetProducts(ProductFilter.Dormant, dpStart.Value, dpEnd.Value);
		}

		private void btnExpired_Click(object sender, EventArgs e)
		{
			productBindingSource.DataSource = Access.GetProducts(ProductFilter.Expired);
		}

		private void btnOutOfStock_Click(object sender, EventArgs e)
		{
			productBindingSource.DataSource = Access.GetProducts(ProductFilter.OutOfStock);
		}

		private void btnInStock_Click(object sender, EventArgs e)
		{
			productBindingSource.DataSource = Access.GetProducts(ProductFilter.InStock);
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
	}
}
