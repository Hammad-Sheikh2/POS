using FontAwesome.Sharp;
using POS.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS.Forms.Suppliers
{
	public partial class FormDeleteSupplier : Form
	{
		ErrorProvider error = new ErrorProvider();
		Supplier sup;

		public FormDeleteSupplier()
		{
			InitializeComponent();
			ActivateTheme();
			Populate();
		}

		private void Populate()
		{
			try
			{
				cbxFilter.Items.Clear();
				cbxFilter.Items.AddRange(Access.GetStringList("SELECT Id FROM Suppliers", true).ToArray());
				tbSearch.AutoCompleteCustomSource = Access.GetAllSupplierNamesCollection;
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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
			if (sup == null)
			{
				error.SetError(btnDelete, "Aucun Fournisseur sélectionné");
			}
			else
			{
				error.SetError(btnDelete, "");
				if (MessageBox.Show($"Voulez-vous supprimer {sup.Name}?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Access.DeleteSupplier(sup);
					Manager.Show("Fournisseur supprimé", Notification.Type.Info);
					this.Close();
					Populate();
				}
			}
		}

		private void tbSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				sup = Access.GetSupplier(tbSearch.Text);
			}
		}

		private void cbxFilter_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			sup = Access.GetSupplier(int.Parse(cbxFilter.Text));
		}
	}
}
