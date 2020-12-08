using System;

namespace POS.Classes.Products
{
	public class Product
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Shape { get; set; }

		public double Weight { get; set; }

		public double QuantityInStore { get; set; }

		public double QuantityInShelves { get; set; }

		public double QuantityInBox { get; set; }

		public double UnitPrice { get; set; }

		public double NetProfit { get; set; }

		public double SellingPrice { get; set; }

		public double PurchasePrice { get; set; }

		public double Margin
		{
			get { return Margin; }
			set { Margin = SellingPrice - PurchasePrice; }
		}

		public string ShelfCode { get; set; }

		public double AlertThreshold { get; set; }

		public double QuantityMaxInShelve { get; set; }

		public string CreatedBy { get; set; }

		public DateTime DateCreated { get; set; }

		public DateTime ExpiryDate { get; set; }

		public string SupplierName { get; set; }

		public bool Store { get; set; }

	}
}
