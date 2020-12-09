using FontAwesome.Sharp;
using POS.Classes;
using POS.Classes.Products;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS.Forms
{
	public partial class FormProductSettings : Form
	{
		ErrorProvider error = new ErrorProvider();
		public FormProductSettings()
		{
			InitializeComponent();
			ActivateTheme();
		}

		private void ActivateTheme()
		{
			this.BackColor = Properties.Settings.Default.HeaderColor;
			foreach (var textbox in GetAllChildren(this).OfType<IconPictureBox>())
			{
				textbox.IconColor = Properties.Settings.Default.MenuBarColor;
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

		private void btnAddCategory_Click(object sender, System.EventArgs e)
		{
			if (tbCategory.TextLength == 0)
			{
				error.SetError(btnAddCategory, "Category name is empty");
				return;
			}
			else
				error.SetError(btnAddCategory, "");

			if (!Access.IsDuplicate($"SELECT Value FROM Categories WHERE Value = '{tbCategory.Text}'"))
			{
				Access.InsertCategory(tbCategory.Text);
				Manager.Show("Category Added", Notification.Type.Success);
			}
			else
				Manager.Show("Already Exists", Notification.Type.Error);
		}

		private void btnAddShelf_Click(object sender, System.EventArgs e)
		{
			if (tbShelf.TextLength == 0)
			{
				error.SetError(btnAddShelf, "Shelf number is empty");
				return;
			}
			else
				error.SetError(btnAddShelf, "");

			if (!Access.IsDuplicate($"SELECT Value FROM ShelfNumbers WHERE Value = '{tbShelf.Text}'"))
			{
				Access.InsertShelfNumber(tbShelf.Text);
				Manager.Show("Shelf Added", Notification.Type.Success);
			}
			else
				Manager.Show("Already Exists", Notification.Type.Error);
		}

		private void btnAddWeight_Click(object sender, System.EventArgs e)
		{
			if (tbWeight.TextLength == 0)
			{
				error.SetError(btnAddWeight, "Weight value is empty");
				return;
			}
			else
				error.SetError(btnAddWeight, "");

			if (double.TryParse(tbWeight.Text, out double value))
			{
				if (!Access.IsDuplicate($"SELECT Value FROM Weights WHERE Value = {value}"))
				{
					Access.InsertWeight(value);
					Manager.Show("Weight Added", Notification.Type.Success);
				}
				else
					Manager.Show("Already Exists", Notification.Type.Error);
			}
			else
				Manager.Show("Invalid number", Notification.Type.Error);
		}
	}
}
