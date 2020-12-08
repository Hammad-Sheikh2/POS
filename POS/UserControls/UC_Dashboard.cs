using System;
using System.Windows.Forms;

namespace POS.UserControls
{
	public partial class UC_Dashboard : UserControl
	{
		public UC_Dashboard()
		{
			InitializeComponent();
			this.BackColor = Properties.Settings.Default.BackgroundColor;
		}

		private void UC_Dashboard_Load(object sender, EventArgs e)
		{

		}
	}
}
