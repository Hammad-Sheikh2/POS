using System.ComponentModel;

namespace POS.Classes
{
	public class Customer
	{
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

		public double Discount { get; set; }

		public double DownPayment { get; set; }

		public double BalanceThreshold { get; set; }

		public double Paid { get; set; }

		public double Left { get; set; }

	}
}
