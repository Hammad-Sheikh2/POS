using Dapper;
using System;

namespace POS.Classes.Finances
{
	[Table("Invoices")]
	public class Invoice
	{
		[Key]
		[Required]
		public int Id { get; set; }

		public int UserId { get; set; }

		public int ShiftId { get; set; }

		public int CustomerId { get; set; }

		public bool Credit { get; set; }

		public DateTime InvoiceDate { get; set; }

		public double Total { get; set; }

		public double Paid { get; set; }

		[Editable(false)]
		public double Threshold { get; set; }

		[Editable(false)]
		public double Left
		{
			get { return Total - Paid; }
			set { Left = value; }
		}


	}
}
