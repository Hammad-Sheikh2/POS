using FontAwesome.Sharp;
using POS.Classes;
using POS.Classes.Products;
using POS.Forms.Products;
using POS.Forms.Suppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.UserControls
{
	public partial class UC_Purchases : UserControl
	{
		Purchase pur;
		public UC_Purchases()
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
				textbox.IconColor = Properties.Settings.Default.HeaderColor;
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
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


		#endregion

		private async void UC_Purchases_Load(object sender, EventArgs e)
		{
			cbxSuppliers.Items.Clear();
			List<string> li = await Access.GetStringListAsync("SELECT Name FROM Suppliers", false);
			cbxSuppliers.Items.AddRange(li.ToArray());
			cbxProducts.Items.Clear();
			li = await Access.GetStringListAsync("SELECT ProductName FROM Products", false);
			cbxProducts.Items.AddRange(li.ToArray());
			pur = new Purchase() { Id = Access.NextPurchaseId };
			purchaseBindingSource1.DataSource = pur;
			purchaseBindingSource.DataSource = await Access.GetPurchasesAsync();
		}

		private async void btnSave_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("You are about to register a new purchase. Purchase price and stock of selected product will be updated. Are you sure?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					await Access.InsertPurchaseAsync(pur);
					Manager.Show("Purchase Registered", Forms.Notification.Type.Success);
					Product product = Access.GetProduct(cbxProducts.Text);
					if (product.Store)
					{
						product.QuantityInStore += pur.Quantity;
					}
					else
					{
						product.QuantityInShelves += pur.Quantity;
					}
					product.PurchasePrice = pur.PurchasePrice;
					await Access.UpdateProductAsync(product);
					Manager.Show("Stock Updated", Forms.Notification.Type.Info);
					UC_Purchases_Load(this, e);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
					Manager.Show("Purchase Failed", Forms.Notification.Type.Error);
				}
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			this.Controls.OfType<TextBox>().ToList().ForEach(item => item.Clear());
			this.Controls.OfType<NumericUpDown>().ToList().ForEach(item => item.Value = 0);
			this.Controls.OfType<ComboBox>().ToList().ForEach(item => item.SelectedIndex = -1);
			Manager.Show("Cleared", Forms.Notification.Type.Info);
		}

		private async void btnExportToExcel_Click(object sender, EventArgs e)
		{
			Manager.Show("Starting Export", Forms.Notification.Type.Info);
			await Manager.ExportDataGridAsync(dg);
			Manager.Show("Export Complete", Forms.Notification.Type.Success);

		}

		private void btnNewSupplier_Click(object sender, EventArgs e)
		{
			using (FormNewSupplier f = new FormNewSupplier())
			{
				f.ShowDialog();
				UC_Purchases_Load(this, e);
			}
		}

		private void btnNewProduct_Click(object sender, EventArgs e)
		{
			using (FormNewProduct f = new FormNewProduct())
			{
				f.ShowDialog();
				UC_Purchases_Load(this, e);
			}
		}
	}
}
