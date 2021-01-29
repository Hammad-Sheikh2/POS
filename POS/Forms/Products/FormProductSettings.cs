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
				error.SetError(btnAddCategory, "Le nom de la catégorie est vide");
				return;
			}
			else
				error.SetError(btnAddCategory, "");

			try
			{
				if (!Access.IsDuplicate($"SELECT Value FROM Categories WHERE Value = '{tbCategory.Text}'"))
				{
					Access.InsertCategory(tbCategory.Text);
					Manager.Show("Catégorie ajoutée", Notification.Type.Success);
				}
				else
					Manager.Show("Existe déjà", Notification.Type.Error);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnAddShelf_Click(object sender, System.EventArgs e)
		{
			if (tbShelf.TextLength == 0)
			{
				error.SetError(btnAddShelf, "Le numéro d'étagère est vide");
				return;
			}
			else
				error.SetError(btnAddShelf, "");

			try
			{
				if (!Access.IsDuplicate($"SELECT Value FROM ShelfNumbers WHERE Value = '{tbShelf.Text}'"))
				{
					Access.InsertShelfNumber(tbShelf.Text);
					Manager.Show("Étagère ajoutée", Notification.Type.Success);
				}
				else
					Manager.Show("Existe déjà", Notification.Type.Error);
			}
			catch (System.Exception ex) { MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); }
		}

		private void btnAddWeight_Click(object sender, System.EventArgs e)
		{
			if (tbWeight.TextLength == 0)
			{
				error.SetError(btnAddWeight, "La valeur de poids est vide");
				return;
			}
			else
				error.SetError(btnAddWeight, "");

			try
			{
				if (!Access.IsDuplicate($"SELECT Value FROM Weights WHERE Value = '{tbWeight.Text}'"))
				{
					Access.InsertWeight(tbWeight.Text);
					Manager.Show("poids ajouté", Notification.Type.Success);
				}
				else
					Manager.Show("Existe déjà", Notification.Type.Error);
			}
			catch (System.Exception ex) { MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); }

		}
	}
}
