using System;

namespace POS.Classes.Finances
{
	public class ClosingShift
	{
		public int Id { get; set; }

		public DateTime Date { get; set; }

		public int UserId { get; set; }

		public double Total { get; set; }

		public double Paid { get; set; }

		public double Quantity { get; set; }

		public bool Credit { get; set; }


	}
}
