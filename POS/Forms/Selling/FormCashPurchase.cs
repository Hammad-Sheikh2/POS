using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Forms.Selling
{
	public partial class FormCashPurchase : Form
	{
		public FormCashPurchase()
		{
			InitializeComponent();
		}

		private void tbCashGiven_TextChanged(object sender, EventArgs e)
		{
			try
			{
				tbChange.Text = (double.Parse(tbTotalBill.Text) - double.Parse(tbCashGiven.Text)).ToString();
			}
			catch (Exception)
			{
				tbChange.Text = "0";
			}
		}
	}
}
