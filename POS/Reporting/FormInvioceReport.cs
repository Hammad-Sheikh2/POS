using Microsoft.Reporting.WinForms;
using POS.Classes;
using POS.Classes.Finances;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Reporting
{
	public partial class FormInvioceReport : Form
	{
		public Invoice inv { get; set; }
		public Cart[] cart { get; set; }

		public FormInvioceReport(Invoice invoice, Cart[] crt)
		{
			InitializeComponent();
			inv = invoice;
			cart = crt;
		}

		private void FormInvioceReport_Load(object sender, EventArgs e)
		{
			bindingInvoice.DataSource = inv;
			bindingCart.DataSource = cart;
			ReportDataSource ds1 = new ReportDataSource("InvoiceDetailsDataset", bindingInvoice);
			ReportDataSource ds2 = new ReportDataSource("InvoiceCartDataset", bindingCart);

			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(ds1);
			reportViewer1.LocalReport.DataSources.Add(ds2);
			this.reportViewer1.RefreshReport();
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			bindingInvoice.DataSource = inv;
			ReportDataSource ds = new ReportDataSource("InvoiceDetailsDataset", bindingInvoice);

			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(ds);
			this.reportViewer1.RefreshReport();
		}
	}
}
