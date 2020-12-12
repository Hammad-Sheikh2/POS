using System;

namespace POS.Classes.Finances
{
	public class Shift
	{
		public int Id { get; set; }

		public DateTime Date { get; set; }

		public int UserId { get; set; }

		public double Value { get; set; }

	}
}
