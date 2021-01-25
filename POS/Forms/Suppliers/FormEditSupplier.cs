using FontAwesome.Sharp;
using POS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace POS.Forms.Suppliers
{
	public partial class FormEditSupplier : Form
	{
		ErrorProvider error = new ErrorProvider();
		Supplier sup = new Supplier();

		public FormEditSupplier()
		{
			InitializeComponent();
			ActivateTheme();
			cbxFilter.Items.AddRange(Access.GetStringList("SELECT Id FROM Suppliers", true).ToArray());
			cbxCity.Items.AddRange(Access.GetStringList("SELECT Value FROM Cities").ToArray());
			cbxProvince.Items.AddRange(Access.GetStringList("SELECT Value FROM Provinces").ToArray());
			tbSearch.AutoCompleteCustomSource = Access.GetAllSupplierNamesCollection;
		}

		private void Clear()
		{
			lblId.Text = Access.NextSupplierId.ToString();
			GetAllChildren(this).OfType<ComboBox>().ToList().ForEach(item => item.SelectedIndex = -1);
			GetAllChildren(this).OfType<TextBox>().ToList().ForEach(item => item.Clear());
		}

		private void Reload()
		{
			sup.Id = int.Parse(lblId.Text);
			sup.Name = tbName.Text;
			sup.City = cbxCity.Text;
			sup.Province = cbxProvince.Text;
			sup.Email = tbEmail.Text;
			sup.Category = cbxCategory.Text;
			sup.Contact1 = tbContact1.Text;
			sup.Contact2 = tbContact2.Text;
			sup.AirtelMoney = tbAirtel.Text;
			sup.BankAccount = tbBank.Text;
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
			if (tb.TextLength == 0)
			{
				error.SetError(tb, "Can't be empty.");
			}
			else
			{ error.SetError(tb, ""); }
		}

		private void Display()
		{
			lblId.Text = sup.Id.ToString();
			tbName.Text = sup.Name;
			cbxCity.Text = sup.City;
			cbxProvince.Text = sup.Province;
			cbxCategory.Text = sup.Category;
			tbEmail.Text = sup.Email;
			tbContact1.Text = sup.Contact1;
			tbContact2.Text = sup.Contact2;
			tbAirtel.Text = sup.AirtelMoney;
			tbBank.Text = sup.BankAccount;
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
			foreach (var textbox in GetAllChildren(this).OfType<ComboBox>())
			{
				textbox.BackColor = Properties.Settings.Default.OnHoverColor;
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			}
			foreach (var textbox in GetAllChildren(this).OfType<Label>())
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			foreach (var textbox in GetAllChildren(this).OfType<Panel>())
				textbox.BackColor = Properties.Settings.Default.HeaderColor;
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

		private void btnClear_Click(object sender, System.EventArgs e)
		{
			Clear();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				Reload();
				if (Valid())
				{
					Access.UpdateSupplier(sup);
					Manager.Show("Fournisseur mis à jour", Notification.Type.Success);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tbSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				sup = Access.GetSupplier(tbSearch.Text);
				Display();
			}
		}

		private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			sup = Access.GetSupplier(int.Parse(cbxFilter.Text));
			Display();
		}

		private void iconButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private bool Valid()
		{
			if (tbName.TextLength == 0)
			{
				Manager.Show("Nom incorrect", Notification.Type.Warning);
				return false;
			}
			if (cbxCity.SelectedIndex == -1)
			{
				Manager.Show("Ville invalide", Notification.Type.Warning);
				return false;
			}
			if (cbxCategory.SelectedIndex == -1)
			{
				Manager.Show("Catégorie invalide", Notification.Type.Warning);
				return false;
			}
			if (tbContact1.TextLength == 0)
			{
				Manager.Show("Contact invalide", Notification.Type.Warning);
				return false;
			}
			if (tbEmail.TextLength > 0)
			{
				if (new EmailAddressAttribute().IsValid(tbEmail.Text))
				{

				}
				else
				{
					Manager.Show("Email invalide", Notification.Type.Warning);
					return false;
				}
			}
			return true;
		}
	}
}
