using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes.Finances
{
	[Table("Shifts")]
	public class Shift
	{
		[Required]
		[Key]
		public int Id { get; set; }

		public double QuantitySold { get; set; }

		public double TotalAmount { get; set; }

		public double PaidAmount { get; set; }

		public int CreditInvoices { get; set; }

		public int CashInvoices { get; set; }

		public string Explanation { get; set; }

		public DateTime ClosedOn { get; set; }

	}
}
