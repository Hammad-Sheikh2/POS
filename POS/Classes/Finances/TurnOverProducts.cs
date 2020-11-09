using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes.Finances
{
	public class TurnOverProducts
	{
		public string Name { get; set; }

		public double Quantity { get; set; }

		public double Sold { get; set; }
		[DisplayName("Buy Price")]
		public double BuyingPrice { get; set; }
		[DisplayName("Selling Price")]
		public double SellingPrice { get; set; }

		private double _Margin;

		public double Margin
		{
			get { return BuyingPrice - SellingPrice; }
			set { _Margin = value; }
		}


	}
}
