using System.ComponentModel;

namespace POS.Classes
{
	public class Supplier
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string City { get; set; }

		public string Email { get; set; }
		[DisplayName("Contact 2")]
		public string Contact1 { get; set; }
		[DisplayName("Contact 2")]
		public string Contact2 { get; set; }
		[DisplayName("Airtel Money")]
		public string AirtelMoney { get; set; }
		[DisplayName("Bank Account")]
		public string BankAccount { get; set; }

	}
}
