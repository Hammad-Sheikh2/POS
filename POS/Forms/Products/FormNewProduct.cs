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
	public partial class FormNewProduct : Form
	{
		private ErrorProvider error = new ErrorProvider();
		private Product product = new Product();

		public FormNewProduct()
		{
			InitializeComponent();
			ActivateTheme();
			Clear();
			Access.GetStringList("SELECT Value FROM Categories").ForEach(item => cbxCategory.Items.Add(item));
			Access.GetStringList("SELECT Value FROM ShelfNumbers").ForEach(item => cbxShelf.Items.Add(item));
			Access.GetDoublesStringList("SELECT Value FROM Weights").ForEach(item => cbxWeight.Items.Add(item));
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

		private void Clear()
		{
			lblProductId.Text = Access.NextProductId.ToString();
			GetAllChildren(this).OfType<TextBox>().ToList().ForEach(tb => tb.Text = "0");
			tbName.Clear();
			GetAllChildren(this).OfType<ComboBox>().ToList().ForEach(tb => tb.SelectedIndex = -1);
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
			//Canva.BackColor = Properties.Settings.Default.HeaderColor;
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

		private void btnRegister_Click(object sender, EventArgs e)
		{
			Reload();
			Access.InsertProduct(product);
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}
	}
}
