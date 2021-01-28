using Dapper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace POS.Classes.Finances
{
	public class TurnOverProducts
	{
		[DisplayName("identifiant du produit")]
		public int ProductId { get; set; }

		[DisplayName("Nom")]
		public string Name { get; set; }

		[DisplayName("Quantité")]
		public double Quantity { get; set; } = 0;

		[DisplayName("Prix ​​d'achat total")]
		public double BuyingPrice { get; set; } = 0;
		[DisplayName("Prix ​​de vente total")]
		public double SellingPrice { get; set; } = 0;

		public double Margin
		{
			get { return SellingPrice - BuyingPrice; }
			set { Margin = value; }
		}

		public static TurnOverProducts[] GetTurnOverProducts(Cart[] arr)
		{
			List<TurnOverProducts> ret = new List<TurnOverProducts>();
			List<Cart> carts = new List<Cart>(arr);

			var groupBy = carts.GroupBy(x => x.ProductId);

			foreach (var group in groupBy)
			{
				TurnOverProducts turn = new TurnOverProducts();
				var first = group.FirstOrDefault();
				first.Quantity = group.Sum(x => x.Quantity);
				first.Total = group.Sum(x => x.Total);

				turn.ProductId = first.ProductId;
				turn.Name = first.ProductName;
				turn.Quantity = first.Quantity;
				turn.BuyingPrice = first.RetailUnit * first.Quantity;
				turn.SellingPrice = first.UnitPrice * first.Quantity;
				ret.Add(turn);
			}

			return ret.ToArray();
		}
	}
}
