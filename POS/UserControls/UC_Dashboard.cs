using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
