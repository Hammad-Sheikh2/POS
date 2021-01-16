using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes
{
	[Table("Purchases")]
	public class Purchase
	{
		[Key]
		[Required]
		public int Id { get; set; }

		public string ProductName { get; set; }

		public string SupplierName { get; set; }

		public double PurchasePrice { get; set; }

		public double Quantity { get; set; }

		public DateTime PurchaseDate { get; set; } = DateTime.Now;

		public double TotalPaid { get; set; }

	}
}
