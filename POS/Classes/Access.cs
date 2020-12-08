using POS.Classes.Products;
using System.Collections.Generic;
using System.Windows.Forms;

namespace POS.Classes
{
	public static class Access
	{

		#region Customers

		public static List<string> Customers
		{
			get
			{
				List<string> cust = new List<string>();
				cust.Add("Customer 1");
				cust.Add("Customer 2");
				cust.Add("Customer 3");
				cust.Add("Customer 4");
				cust.Add("Customer 5");
				return cust;
			}
		}

		public static AutoCompleteStringCollection CustomerCompletionSource
		{
			get
			{
				AutoCompleteStringCollection cust = new AutoCompleteStringCollection();
				cust.Add("Customer 1");
				cust.Add("Customer 2");
				cust.Add("Customer 3");
				cust.Add("Customer 4");
				cust.Add("Customer 5");
				return cust;
			}
		}

		#endregion

		#region Products

		public static AutoCompleteStringCollection ItemsCompletionSource
		{
			get
			{
				AutoCompleteStringCollection cust = new AutoCompleteStringCollection();
				cust.Add("Item 1");
				cust.Add("Item 2");
				cust.Add("Item 3");
				cust.Add("Item 4");
				cust.Add("Item 5");
				return cust;
			}
		}

		public static List<string> Items
		{
			get
			{
				List<string> cust = new List<string>();
				cust.Add("Item 1");
				cust.Add("Item 2");
				cust.Add("Item 3");
				cust.Add("Item 4");
				cust.Add("Item 5");
				return cust;
			}
		}

		public static Product GetProductByName(string Name)
		{
			List<Product> li = new List<Product>();
			li.Add(new Product() { Id = 1, Name = "Item 1", Shape = "Round", UnitPrice = 100 });
			li.Add(new Product() { Id = 2, Name = "Item 2", Shape = "Box", UnitPrice = 120 });
			li.Add(new Product() { Id = 3, Name = "Item 3", Shape = "Round", UnitPrice = 10 });
			li.Add(new Product() { Id = 4, Name = "Item 4", Shape = "Box", UnitPrice = 70 });
			li.Add(new Product() { Id = 5, Name = "Item 5", Shape = "Round", UnitPrice = 300 });

			foreach (Product item in li)
			{
				if (item.Name == Name)
					return item;
			}
			return null;
		}

		#endregion

	}
}
