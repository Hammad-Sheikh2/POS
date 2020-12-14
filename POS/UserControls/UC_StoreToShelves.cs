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
using Bunifu.Framework.UI;
using POS.Classes.Products;
using POS.Classes;

namespace POS.UserControls
{
	public partial class UC_StoreToShelves : UserControl
	{
		Product product;

		public UC_StoreToShelves()
		{
			InitializeComponent();
			ActivateTheme();
			Populate();
		}

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
		}

		private void Populate()
		{
			cbxFilter.Items.Clear();
			tbSearch.AutoCompleteCustomSource = Access.GetAllProductNamesCollection;
			cbxFilter.Items.AddRange(Access.GetStringList("SELECT Id FROM Products;", true).ToArray());
		}

		private void Display()
		{
			lblProductId.Text = product.Id.ToString();
			tbName.Text = product.Name;
			tbQuantityInStore.Text = product.QuantityInStore.ToString();
			tbQtyInShelves.Text = product.QuantityInShelves.ToString();
			tbPurchasingPrice.Text = product.PurchasePrice.ToString();
			tbSellingPrice.Text = product.SellingPrice.ToString();
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

		private void tbSearch_Click(object sender, EventArgs e)
		{
			(sender as TextBox).Clear();
		}

		private void tbSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				product = Access.GetProduct(tbSearch.Text);
				Display();
			}
		}

		private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			product = Access.GetProduct(int.Parse(cbxFilter.SelectedItem.ToString()));
			Display();
		}

		private void btnMove_Click(object sender, EventArgs e)
		{
			if (product != null)
			{
				if (double.TryParse(tbMove.Text, out double move))
				{
					if (double.TryParse(tbQuantityInStore.Text, out double inStore))
					{
						if (move <= inStore)
						{
							if (inStore <= 0)
							{
								Manager.Show("Store empty", Forms.Notification.Type.Error);
								return;
							}
							Access.ExecuteCommand($"UPDATE Products SET QuantityInStore = QuantityInStore - {move}, QuantityInShelves = QuantityInShelves + {move} WHERE Id = {product.Id}");
							product = Access.GetProduct(product.Id);
							Display();
							Manager.Show("Moved", Forms.Notification.Type.Success);
							lblLimit.ForeColor = Properties.Settings.Default.ForeColor;
						}
						else
						{
							lblLimit.Text = $"(Must be less than {inStore})";
							lblLimit.ForeColor = Color.DarkRed;
						}
					}
					else Manager.Show("Invalid in-Store Qty", Forms.Notification.Type.Error);
				}
				else Manager.Show("Invalid Quantity", Forms.Notification.Type.Error);
			}
			else Manager.Show("No product selected", Forms.Notification.Type.Error);
		}
	}
}
