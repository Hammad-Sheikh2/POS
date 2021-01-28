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
			BindingSource bindingCustomer = new BindingSource();
			Customer cus = Access.GetCustomer(inv.CustomerId);
			bindingCustomer.DataSource = cus;

			List<ReportParameter> parameters = new List<ReportParameter>
			{
				new ReportParameter("CompanyName", Properties.Settings.Default.CompanyName),
				new ReportParameter("Message1", Properties.Settings.Default.Message1),
				new ReportParameter("Message2", Properties.Settings.Default.Message2)
			};

			ReportDataSource ds1 = new ReportDataSource("InvoiceDetailsDataset", bindingInvoice);
			ReportDataSource ds2 = new ReportDataSource("InvoiceCartDataset", bindingCart);
			ReportDataSource ds3 = new ReportDataSource("CustomerDataset", bindingCustomer);

			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(ds1);
			reportViewer1.LocalReport.DataSources.Add(ds2);
			reportViewer1.LocalReport.DataSources.Add(ds3);
			reportViewer1.LocalReport.SetParameters(parameters);
			this.reportViewer1.RefreshReport();
		}

		private void reportViewer1_Print(object sender, ReportPrintEventArgs e)
		{
			this.Close();
		}
	}
}
