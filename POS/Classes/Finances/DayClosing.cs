using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes.Finances
{
	[Table("DayClosings")]
	public class DayClosing
	{
		[Key]
		public int DayId { get; set; }

		public DateTime ClosingDate { get; set; }

		public double TotalAmount { get; set; }

		public double PaidAmount { get; set; }

	}
}
