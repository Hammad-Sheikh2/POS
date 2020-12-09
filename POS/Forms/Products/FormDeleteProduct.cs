using FontAwesome.Sharp;
using POS.Classes;
using POS.Classes.Products;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS.Forms.Products
{
	public partial class FormDeleteProduct : Form
	{
		ErrorProvider error = new ErrorProvider();
		Product product;

		public FormDeleteProduct()
		{
			InitializeComponent();
			ActivateTheme();
			Reload();
		}

		private void Reload()
		{
			cbxFilter.Items.Clear();
			tbSearch.AutoCompleteCustomSource = Access.GetAllProductNamesCollection;
			Access.GetStringList("SELECT Id FROM Products;", true).ForEach(item => cbxFilter.Items.Add(item));
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
			foreach (var textbox in GetAllChildren(this).OfType<Label>())
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			foreach (var textbox in GetAllChildren(this).OfType<Panel>())
				textbox.BackColor = Properties.Settings.Default.ForeColor;
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

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			if (product == null)
			{
				error.SetError(btnDelete, "No product selected");
			}
			else
			{
				if (MessageBox.Show($"Do you want to delete {product.Name}?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Access.DeleteProduct(product);
					Manager.Show("Product Deleted", Notification.Type.Info);
					Reload();
				}
			}
		}

		private void cbxFilter_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (int.TryParse(cbxFilter.Text, out int index))
			{
				product = Access.GetProduct(index);
			}
			else
				Manager.Show("Invalid ID", Notification.Type.Warning);
		}

		private void tbSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				product = Access.GetProduct(tbSearch.Text);
			}
		}
	}
}
