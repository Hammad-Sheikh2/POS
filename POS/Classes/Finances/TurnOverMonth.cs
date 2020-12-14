using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes.Finances
{
	class TurnOverMonth
	{
		public string Month { get; set; }

		public double Turnover { get; set; }

		public static TurnOverMonth[] GetTurnOverMonth(Invoice[] arr)
		{
			List<TurnOverMonth> li = new List<TurnOverMonth>();
			List<Invoice> inv = new List<Invoice>(arr);

			var groupBy = inv.GroupBy(x => new { x.InvoiceDate.Year, x.InvoiceDate.Month });

			foreach (var group in groupBy)
			{
				TurnOverMonth turn = new TurnOverMonth();
				var first = group.FirstOrDefault();
				first.Total = group.Sum(x => x.Total);

				turn.Turnover = first.Total;
				turn.Month = first.InvoiceDate.ToString("MMMM");
				li.Add(turn);
			}
			return li.ToArray();
		}
	}
}
