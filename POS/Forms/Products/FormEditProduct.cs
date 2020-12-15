using FontAwesome.Sharp;
using POS.Classes;
using POS.Classes.Products;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace POS.Forms.Products
{
	public partial class FormEditProduct : Form
	{
		ErrorProvider error = new ErrorProvider();
		Product product = new Product();

		public FormEditProduct()
		{
			InitializeComponent();
			ActivateTheme();
			tbSearch.AutoCompleteCustomSource = Access.GetAllProductNamesCollection;
			cbxFilter.Items.AddRange(Access.GetStringList("SELECT Id FROM Products;", true).ToArray());
			cbxCategory.Items.AddRange(Access.GetStringList("SELECT Value FROM Categories").ToArray());
			cbxShelf.Items.AddRange(Access.GetStringList("SELECT Value FROM ShelfNumbers").ToArray());
			cbxSupplier.Items.AddRange(Access.GetStringList("SELECT Name FROM Suppliers").ToArray());
			cbxWeight.Items.AddRange(Access.GetDoublesStringList("SELECT Value FROM Weights").ToArray());
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
			Canva.BackColor = Color.Transparent;
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

		private void tbSearch_Click(object sender, System.EventArgs e)
		{
			(sender as TextBox).Clear();
		}

		private void ValidateCombobox(object sender, EventArgs e)
		{
			ComboBox cb = sender as ComboBox;
			if (cb.SelectedIndex == -1)
				error.SetError(cb, "Please select an option");
			else
				error.SetError(cb, "");
		}

		private void ValidateInput(object sender, EventArgs e)
		{
			TextBox tb = sender as TextBox;
			if (!double.TryParse(tb.Text, out _))
			{
				error.SetError(tb, "Not a valid number");
			}
			else
			{ error.SetError(tb, ""); }
		}

		private void Display()
		{
			lblProductId.Text = product.Id.ToString();
			tbName.Text = product.Name;
			cbxShape.Text = product.Shape;
			cbxWeight.Text = product.Weight.ToString();
			tbQuantityInStore.Text = product.QuantityInStore.ToString();
			tbQtyInShelves.Text = product.QuantityInShelves.ToString();
			tbQtyInBox.Text = product.QuantityInBox.ToString();
			tbQtyMaxInShelve.Text = product.QuantityMaxInShelve.ToString();
			tbUnitPrice.Text = product.UnitPrice.ToString();
			tbPurchasingPrice.Text = product.PurchasePrice.ToString();
			tbSellingPrice.Text = product.SellingPrice.ToString();
			cbxShelf.Text = product.ShelfCode;
			tbAlertThreshold.Text = product.AlertThreshold.ToString();
			dpExpire.Value = product.ExpiryDate;
			cbxSupplier.Text = product.SupplierName;
			cbxStore.SelectedIndex = product.Store ? 0 : 1;
			lblModified.Text = product.DateModified.ToShortDateString();
			lblCreated.Text = product.DateCreated.ToShortDateString();
			lblCreatedBy.Text = product.CreatedBy;
		}

		private void Reload()
		{
			product.Id = int.Parse(lblProductId.Text);
			product.Name = tbName.Text;
			product.Shape = cbxShape.Text;
			product.Weight = double.Parse(cbxWeight.Text);
			product.QuantityInStore = double.Parse(tbQuantityInStore.Text);
			product.QuantityInShelves = double.Parse(tbQtyInShelves.Text);
			product.QuantityInBox = double.Parse(tbQtyInBox.Text);
			product.QuantityMaxInShelve = double.Parse(tbQtyMaxInShelve.Text);
			product.UnitPrice = double.Parse(tbUnitPrice.Text);
			product.PurchasePrice = double.Parse(tbPurchasingPrice.Text);
			product.SellingPrice = double.Parse(tbSellingPrice.Text);
			product.ShelfCode = cbxShelf.Text;
			product.AlertThreshold = double.Parse(tbAlertThreshold.Text);
			product.CreatedBy = Login.Name;
			product.ExpiryDate = dpExpire.Value;
			product.SupplierName = cbxSupplier.Text;
			product.Store = cbxStore.SelectedIndex == 0 ? true : false;
		}

		private void tbSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				product = Access.GetProduct(tbSearch.Text);
				Display();
			}
		}

		private void cbxFilter_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				if (int.TryParse(cbxFilter.Text, out int index))
				{
					product = Access.GetProduct(index);
					Display();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnPayment_Click(object sender, EventArgs e)
		{
			try
			{
				Reload();
				Access.UpdateProduct(product);
				Manager.Show("Product Updated", Notification.Type.Success);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
