using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes.Selling
{
	public class CreditInvoice
	{
		public DateTime Date { get; set; }
		[DisplayName("Invoice #")]
		public int InvoiceNumber { get; set; }

		public double Total { get; set; }

		public double Paid { get; set; }

		private double _Left;

		public double Left
		{
			get { return Total - Paid; }
			set { _Left = value; }
		}

	}
}
