using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes.Finances
{
	public class TurnOverCashier
	{
		[DisplayName("Id d'utilisateur")]
		public int CashierId { get; set; }

		[DisplayName("Nom")]
		public string Name { get; set; }

		[DisplayName("Chiffre d'affair")]
		public double Turnover { get; set; }

		public static TurnOverCashier[] GetTurnOverCashiers(Invoice[] arr)
		{
			List<TurnOverCashier> li = new List<TurnOverCashier>();
			List<Invoice> inv = new List<Invoice>(arr);

			var groupBy = inv.GroupBy(x => x.UserId);

			foreach (var group in groupBy)
			{
				TurnOverCashier turn = new TurnOverCashier();
				var first = group.FirstOrDefault();
				first.Total = group.Sum(x => x.Total);

				turn.Turnover = first.Total;
				turn.CashierId = first.UserId;
				turn.Name = Access.GetUser(turn.CashierId).Name;
				li.Add(turn);
			}
			return li.ToArray();
		}
	}
}
