using Dapper;
using System.ComponentModel;

namespace POS.Classes
{
	[Table("Customers")]
	public class Customer
	{
		[Key]
		[Required]
		public int Id { get; set; }

		public string Name { get; set; }

		public string Category { get; set; }

		public string City { get; set; }

		public string Province { get; set; }

		public string Email { get; set; }

		public string Contact1 { get; set; }

		public string Contact2 { get; set; }
		[DisplayName("Airtel Money")]
		public string AirtelMoney { get; set; }
		[Editable(false)]
		public double Discount { get; set; }
		[Editable(false)]
		public double DownPayment { get; set; }
		[Editable(false)]
		public double BalanceThreshold { get; set; }
		[Editable(false)]
		public double Paid { get; set; }
		[Editable(false)]
		public double Left { get; set; }

	}
}
