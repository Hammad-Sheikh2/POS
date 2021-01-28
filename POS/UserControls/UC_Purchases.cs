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
			purchaseBindingSource.DataSource = await Access.GetPurchasesAsync();
		}

		private async void btnSave_Click(object sender, EventArgs e)
		{
			if (ValidatePurchase())
			{
				if (MessageBox.Show("Vous êtes sur le point d'enregistrer un nouvel achat. Le stock du produit sélectionné sera mis à jour. Êtes-vous sûr?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						pur.PurchaseDate = dp.Value;
						pur.SupplierName = cbxSuppliers.Text;
						pur.Quantity = double.Parse(tbQty.Value.ToString());
						pur.TotalPaid = double.Parse(tbTotalPrice.Text);
						pur.ProductName = cbxProducts.Text;
						await Access.InsertPurchaseAsync(pur);
						Manager.Show("Achat enregistré", Forms.Notification.Type.Success);
						Product product = Access.GetProduct(cbxProducts.Text);
						if (product.Store)
						{
							product.QuantityInStore += pur.Quantity;
						}
						else
						{
							product.QuantityInShelves += pur.Quantity;
						}
						await Access.UpdateProductAsync(product);
						Manager.Show("stock mis à jour", Forms.Notification.Type.Info);
						UC_Purchases_Load(this, e);
						btnClear_Click(this, e);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
						Manager.Show("achat raté", Forms.Notification.Type.Error);
					}
				}
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			pur = new Purchase() { Id = Access.NextPurchaseId };
			panelDetails.Controls.OfType<ComboBox>().ToList().ForEach(item => item.SelectedIndex = -1);
			panelDetails.Controls.OfType<TextBox>().ToList().ForEach(item => item.Clear());
			cbxProducts.Text = "Sélectionner";
			cbxSuppliers.Text = "Sélectionner";
			tbQty.Value = 0;
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

		private void cbxProducts_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxProducts.SelectedIndex != -1)
			{
				Product pro = Access.GetProduct(cbxProducts.Text);
				tbPurchasePrice.Text = pro.PurchasePrice.ToString();
				pur.PurchasePrice = pro.PurchasePrice;
				tbTotalPrice.Text = (Convert.ToDouble(tbQty.Value) * pro.PurchasePrice).ToString();
			}
		}

		private void tbQty_Leave(object sender, EventArgs e)
		{
			try
			{
				tbTotalPrice.Text = (Convert.ToDouble(tbQty.Value) * double.Parse(tbPurchasePrice.Text)).ToString();
			}
			catch (Exception)
			{
				tbTotalPrice.Text = "0";
			}
		}

		private bool ValidatePurchase()
		{
			if (cbxSuppliers.SelectedIndex == -1)
			{
				Manager.Show("fournisseur invalide", Forms.Notification.Type.Warning);
				return false;
			}
			if (cbxProducts.SelectedIndex == -1)
			{
				Manager.Show("produit invalide", Forms.Notification.Type.Warning);
				return false;
			}
			if (tbQty.Value == 0)
			{
				Manager.Show("quantité invalide", Forms.Notification.Type.Warning);
				return false;
			}
			return true;
		}
	}
}
