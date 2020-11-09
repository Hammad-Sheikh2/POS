using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes.Finances
{
	public class Invoice
	{
		public int Id { get; set; }

		public DateTime Date { get; set; }

		public string Cashier { get; set; }

		public string Client { get; set; }

		public double Total { get; set; }

		public double Threshold { get; set; }

		public double Paid { get; set; }

		private double _left;

		public double Left
		{
			get { return Total - Paid; }
			set { _left = value; }
		}


	}
}
