using FontAwesome.Sharp;
using POS.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS.Forms
{
	public partial class FormSupplierSettings : Form
	{
		ErrorProvider error = new ErrorProvider();

		public FormSupplierSettings()
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

		private void btnAddCity_Click(object sender, System.EventArgs e)
		{
			if (tbCity.TextLength == 0)
			{
				error.SetError(btnAddCity, "ville invalide");
				return;
			}
			else
				error.SetError(btnAddCity, "");

			if (!Access.IsDuplicate($"SELECT Value FROM Cities WHERE Value = '{tbCity.Text}'"))
			{
				Access.InsertCity(tbCity.Text);
				Manager.Show("ville ajoutée", Notification.Type.Success);
			}
			else
				Manager.Show("Existe déjà", Notification.Type.Error);
		}

		private void tbCity_Click(object sender, System.EventArgs e)
		{
			(sender as TextBox).Clear();
		}

		private void btnAddProvince_Click(object sender, System.EventArgs e)
		{
			if (tbProvince.TextLength == 0)
			{
				error.SetError(btnAddProvince, "Province invalide");
				return;
			}
			else
				error.SetError(btnAddProvince, "");

			if (!Access.IsDuplicate($"SELECT Value FROM Provinces WHERE Value = '{tbProvince.Text}'"))
			{
				Access.InsertProvince(tbProvince.Text);
				Manager.Show("Province Added", Notification.Type.Success);
			}
			else
				Manager.Show("Existe déjà", Notification.Type.Error);
		}
	}
}
