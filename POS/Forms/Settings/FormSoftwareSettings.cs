using POS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Forms
{
	public partial class FormSoftwareSettings : Form
	{
		public FormSoftwareSettings()
		{
			InitializeComponent();
			ActivateTheme();
			LoadDetails();
		}

		private void LoadDetails()
		{
			Dashboard dsh = new Dashboard();
			pbLogo.Image = dsh.pbLogo.Image;
			tbName.Text = Properties.Settings.Default.CompanyName;
			tbManagerName.Text = Properties.Settings.Default.ManagerName;
			tbRegistrationNumber.Text = Properties.Settings.Default.RegisterationNumber;
			tbVAT.Text = Properties.Settings.Default.VAT.ToString();
			dsh.Dispose();
		}

		private void ActivateTheme()
		{
			this.BackColor = Properties.Settings.Default.HeaderColor;
			foreach (var textbox in GetAllChildren(this).OfType<TextBox>())
			{
				textbox.BackColor = Properties.Settings.Default.OnHoverColor;
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			}
			foreach (var textbox in GetAllChildren(this).OfType<Label>())
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
			foreach (var textbox in GetAllChildren(this).OfType<Panel>())
				textbox.BackColor = Properties.Settings.Default.ForeColor;
			foreach (var textbox in GetAllChildren(this).OfType<Button>())
				textbox.BackColor = Properties.Settings.Default.OnHoverColor;
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

		private void btnOk_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.CompanyName = tbName.Text;
			Properties.Settings.Default.ManagerName = tbManagerName.Text;
			Properties.Settings.Default.RegisterationNumber = tbRegistrationNumber.Text;
			Properties.Settings.Default.VAT = Convert.ToDouble(tbVAT.Text);
			Properties.Settings.Default.Save();
			Manager.Show("Changes saved.", Notification.Type.Success);
		}
	}
}
