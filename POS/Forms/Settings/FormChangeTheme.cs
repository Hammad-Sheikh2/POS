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
	public partial class FormChangeTheme : Form
	{
		public FormChangeTheme()
		{
			InitializeComponent();
			this.BackColor = Properties.Settings.Default.HeaderColor;
			cbxThemes.BackColor = Properties.Settings.Default.OnHoverColor;
			cbxThemes.ForeColor = Properties.Settings.Default.ForeColor;
			label5.ForeColor = Properties.Settings.Default.ForeColor;
			btnOk.BackColor = Properties.Settings.Default.OnHoverColor;
			btnOk.ForeColor = Properties.Settings.Default.ForeColor;
			btnCancel.BackColor = Properties.Settings.Default.OnHoverColor;
			btnCancel.ForeColor = Properties.Settings.Default.ForeColor;
		}

		private void cbxThemes_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cbxThemes.SelectedIndex)
			{
				case 0:
					Theme.ApplyTheme(Theme.Themes.DarkGreen);
					break;
				case 1:
					Theme.ApplyTheme(Theme.Themes.DarkBlue);

					break;
				case 2:
					Theme.ApplyTheme(Theme.Themes.DarkCyan);

					break;
				case 3:
					Theme.ApplyTheme(Theme.Themes.DarkGray);

					break;
				case 4:
					Theme.ApplyTheme(Theme.Themes.DarkPurple);

					break;
				case 5:
					Theme.ApplyTheme(Theme.Themes.DarkRed);

					break;
				case 6:
					Theme.ApplyTheme(Theme.Themes.LightBlue);

					break;
				case 7:
					Theme.ApplyTheme(Theme.Themes.LightCyan);

					break;
				case 8:
					Theme.ApplyTheme(Theme.Themes.LightGray);

					break;
				case 9:
					Theme.ApplyTheme(Theme.Themes.LightPurple);

					break;
				case 10:
					Theme.ApplyTheme(Theme.Themes.LightRed);

					break;
				default:
					break;
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Manager.Show("Theme Changed", Notification.Type.Success);
		}
	}
}
