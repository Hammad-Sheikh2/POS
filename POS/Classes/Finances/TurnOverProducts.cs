using Dapper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace POS.Classes.Finances
{
	public class TurnOverProducts
	{
		[Key]
		[Required]
		public string Name { get; set; }
		[Editable(false)]
		public double Quantity { get; set; } = 0;

		public double Sold { get; set; } = 0;
		[DisplayName("Buy Price")]
		public double BuyingPrice { get; set; } = 0;
		[DisplayName("Selling Price")]
		public double SellingPrice { get; set; } = 0;

		public double Margin
		{
			get { return BuyingPrice - SellingPrice; }
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
				first.RetailUnit = group.Sum(x => x.RetailUnit);
				first.UnitPrice = group.Sum(x => x.UnitPrice);
				turn.Name = first.ProductName;
				turn.Quantity = first.Quantity;
				turn.BuyingPrice = first.RetailUnit;
				turn.SellingPrice = first.UnitPrice;
				ret.Add(turn);
			}

			return ret.ToArray();
		}
	}
}
