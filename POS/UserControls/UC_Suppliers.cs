using Bunifu.Framework.UI;
using FontAwesome.Sharp;
using POS.Classes;
using POS.Forms;
using POS.Forms.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS.UserControls
{
	public partial class UC_Suppliers : UserControl
	{
		#region Variables

		public UC_Suppliers()
		{
			InitializeComponent();
			ActivateTheme();
			Populate();
			supplierBindingSource.DataSource = Access.GetSuppliers();
		}

		#endregion

		#region Methods

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
				textbox.IconColor = Properties.Settings.Default.HeaderColor;
				textbox.ForeColor = Properties.Settings.Default.MenuBarColor;
			}
			foreach (var textbox in GetAllChildren(this).OfType<Panel>())
				textbox.BackColor = Properties.Settings.Default.MenuBarColor;
			foreach (var textbox in GetAllChildren(this).OfType<Label>())
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			foreach (var textbox in GetAllChildren(this).OfType<BunifuCards>())
			{
				textbox.color = Properties.Settings.Default.HeaderColor;
				textbox.BackColor = Properties.Settings.Default.MenuBarColor;
			}
			dg.HeaderBgColor = Properties.Settings.Default.HeaderColor;
			dg.HeaderForeColor = Properties.Settings.Default.ForeColor;
			dg.BackgroundColor = Properties.Settings.Default.MenuBarColor;

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


		#endregion

		#region Events

		private void btnSettings_Click(object sender, EventArgs e)
		{
			FormSupplierSettings f = new FormSupplierSettings();
			f.ShowDialog();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{

		}

		private void tbSearch_Click(object sender, EventArgs e)
		{
			tbSearch.Clear();
		}


		#endregion

		private void Populate()
		{
			cbxFilter.Items.Clear();
			cbxFilter.Items.AddRange(Access.GetStringList("SELECT Id FROM Suppliers", true).ToArray());
			tbSearch.AutoCompleteCustomSource = Access.GetAllSupplierNamesCollection;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			using (FormNewSupplier f = new FormNewSupplier())
			{
				f.ShowDialog();
				Populate();
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			using (FormEditSupplier f = new FormEditSupplier())
			{
				f.ShowDialog();
				Populate();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			using (FormDeleteSupplier f = new FormDeleteSupplier())
			{
				f.ShowDialog();
				Populate();
			}
		}

		private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			supplierBindingSource.DataSource = Access.GetSupplier(int.Parse(cbxFilter.SelectedItem.ToString()));
		}

		private void tbSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				supplierBindingSource.DataSource = Access.GetSupplier(tbSearch.Text);
			}
		}

		private async void btnExportToExcel_Click(object sender, EventArgs e)
		{
			Manager.Show("exportation", Notification.Type.Info);
			await Manager.ExportDataGridAsync(dg);
			Manager.Show("exportation terminée", Notification.Type.Success);
		}
	}
}
