using Dapper;
using System;

namespace POS.Classes.Products
{
	[Table("Products")]
	public class Product
	{
		[Key]
		[Required]
		public int Id { get; set; }

		[Column("ProductName")]
		public string Name { get; set; } = "";

		[Column("ProductShape")]
		public string Shape { get; set; } = "";

		[Column("ProductWeight")]
		public string Weight { get; set; }

		public double QuantityInStore { get; set; }

		public double QuantityInShelves { get; set; }

		public double QuantityInBox { get; set; }

		public double QuantityMaxInShelve { get; set; }

		public double UnitPrice { get; set; }

		[Editable(false)]
		[NotMapped]
		public double NetProfit { get; set; }

		public double SellingPrice { get; set; }

		public double PurchasePrice { get; set; }

		[Editable(false)]
		[NotMapped]
		public double Margin
		{
			get { return Margin; }
			set { Margin = SellingPrice - PurchasePrice; }
		}

		public string ShelfCode { get; set; } = "";

		public double AlertThreshold { get; set; }

		public string CreatedBy { get; set; } = "";

		public DateTime DateCreated { get; set; } = DateTime.Now;

		public DateTime DateModified { get; set; } = DateTime.Now;

		public DateTime ExpiryDate { get; set; }

		public string SupplierName { get; set; } = "";

		public bool Store { get; set; } = true;

	}
}
