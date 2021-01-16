using Dapper;
using System.ComponentModel;

namespace POS.Classes
{
	[Table("InvoiceDetails")]
	public class Cart
	{
		public int ProductId { get; set; }

		[DisplayName("Name of Product")]
		[Editable(false)]
		public string ProductName { get; set; }
		[DisplayName("Shape")]
		[Editable(false)]
		public string Shape { get; set; }

		public double RetailUnit { get; set; }

		[DisplayName("Unit Price")]
		public double UnitPrice { get; set; }
		[DisplayName("Quantity")]
		public double Quantity { get; set; }

		private double _Total;

		public double Total
		{
			get { return UnitPrice * Quantity; }
			set { _Total = value; }
		}



	}
}
