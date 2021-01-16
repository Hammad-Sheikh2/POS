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

namespace POS.Forms.Customers
{
	public partial class FormCashByCustomer : Form
	{
		private int Id { get; set; }
		public FormCashByCustomer(int id)
		{
			InitializeComponent();
			Id = id;
		}

		private void FormCashByCustomer_Load(object sender, EventArgs e)
		{
			invoiceBindingSource.DataSource = Access.GetInvoicesCashByCustomers(Id);
		}
	}
}
