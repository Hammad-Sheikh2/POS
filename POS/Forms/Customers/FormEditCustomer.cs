using FontAwesome.Sharp;
using POS.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS.Forms.Customers
{
	public partial class FormEditCustomer : Form
	{
		ErrorProvider error = new ErrorProvider();
		Customer cus = new Customer();


		public FormEditCustomer()
		{
			InitializeComponent();
			ActivateTheme();
			Populate();
			tbSearch.AutoCompleteCustomSource = Access.GetAllCustomerNamesCollection;
		}

		private void Clear()
		{
			lblId.Text = Access.NextCustomerId.ToString();
			GetAllChildren(this).OfType<ComboBox>().ToList().ForEach(item => item.SelectedIndex = -1);
			GetAllChildren(this).OfType<TextBox>().ToList().ForEach(item => item.Clear());
			tbSearch.AutoCompleteCustomSource = Access.GetAllCustomerNamesCollection;
		}

		private void Populate()
		{
			cbxFilter.Items.Clear();
			cbxFilter.Items.AddRange(Access.GetStringList("SELECT Id FROM Customers", true).ToArray());
			cbxCity.Items.AddRange(Access.GetStringList("SELECT Value FROM Cities").ToArray());
			cbxProvince.Items.AddRange(Access.GetStringList("SELECT Value FROM Provinces").ToArray());
		}

		private void Display()
		{
			lblId.Text = cus.Id.ToString();
			tbName.Text = cus.Name;
			cbxCity.Text = cus.City;
			cbxProvince.Text = cus.Province;
			cbxCategory.Text = cus.Category;
			tbEmail.Text = cus.Email;
			tbContact1.Text = cus.Contact1;
			tbContact2.Text = cus.Contact2;
			tbAirtel.Text = cus.AirtelMoney;
		}

		private void Reload()
		{
			cus.Id = int.Parse(lblId.Text);
			cus.Name = tbName.Text;
			cus.City = cbxCity.Text;
			cus.Province = cbxProvince.Text;
			cus.Email = tbEmail.Text;
			cus.Category = cbxCategory.Text;
			cus.Contact1 = tbContact1.Text;
			cus.Contact2 = tbContact2.Text;
			cus.AirtelMoney = tbAirtel.Text;
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
				error.SetError(tb, "Field can't be empty");
			}
			else
			{ error.SetError(tb, ""); }
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

		private void tbSearch_Click(object sender, EventArgs e)
		{
			(sender as TextBox).Clear();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				Reload();
				Access.UpdateCustomer(cus);
				tbSearch.AutoCompleteCustomSource = Access.GetAllCustomerNamesCollection;
				Manager.Show("Customer updated", Notification.Type.Success);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void tbSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				cus = Access.GetCustomer(tbSearch.Text);
				Display();
			}
		}

		private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			cus = Access.GetCustomer(Convert.ToInt32(cbxFilter.SelectedItem));
			Display();
		}
	}
}
