using POS.Classes.Products;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;
using Dapper.Contrib;
using System.Data;

namespace POS.Classes
{
	public static class Access
	{

		#region General

		public static bool IsDuplicate(string Query)
		{
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand(Query, cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
					return true;
				return false;
			}
		}

		public static List<string> GetStringList(string Query, bool Integer = false)
		{
			List<string> col = new List<string>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand(Query, cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					if (!Integer)
						col.Add(reader.GetString(0));
					else
						col.Add(reader.GetInt32(0).ToString());
				}
			}
			return col;
		}

		public static List<string> GetDoublesStringList(string Query)
		{
			List<string> col = new List<string>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand(Query, cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					col.Add(Math.Round(reader.GetDouble(0), 2).ToString());
				}
			}
			return col;
		}

		#endregion

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

		public static int NextProductId
		{
			get
			{
				using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
				{
					cnn.Open();
					SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(Id), 0) + 1 FROM Products;", cnn);
					SqlDataReader reader = cmd.ExecuteReader();
					if (reader.HasRows)
					{
						while (reader.Read())
							return reader.GetInt32(0);
					}
					return 1;
				}
			}
		}

		public static AutoCompleteStringCollection GetAllProductNamesCollection
		{
			get
			{
				AutoCompleteStringCollection col = new AutoCompleteStringCollection();
				using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
				{
					cnn.Open();
					SqlCommand cmd = new SqlCommand("SELECT ProductName FROM Products;", cnn);
					SqlDataReader reader = cmd.ExecuteReader();
					while (reader.Read())
						col.Add(reader.GetString(0));
				}
				return col;
			}
		}

		public static Product GetProduct(int ProductId)
		{
			Product product = new Product();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Products WHERE Id = {ProductId};", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						product.Id = (int)reader["Id"];
						product.Name = (string)reader["ProductName"];
						product.Shape = (string)reader["ProductShape"];
						product.Weight = (double)reader["ProductWeight"];
						product.QuantityInStore = (double)reader["QuantityInStore"];
						product.QuantityInShelves = (double)reader["QuantityInShelves"];
						product.QuantityInBox = (double)reader["QuantityInBox"];
						product.QuantityMaxInShelve = (double)reader["QuantityMaxInShelve"];
						product.UnitPrice = (double)reader["UnitPrice"];
						product.PurchasePrice = (double)reader["PurchasePrice"];
						product.SellingPrice = (double)reader["SellingPrice"];
						product.ShelfCode = (string)reader["ShelfCode"];
						product.AlertThreshold = (double)reader["AlertThreshold"];
						product.CreatedBy = (string)reader["CreatedBy"];
						product.DateCreated = (DateTime)reader["DateCreated"];
						product.ExpiryDate = (DateTime)reader["ExpiryDate"];
						product.DateModified = (DateTime)reader["DateModified"];
						product.SupplierName = (string)reader["SupplierName"];
						product.Store = (bool)reader["Store"];
					}
				}
			}
			return product;
		}

		public static Product GetProduct(string ProductName)
		{
			Product product = new Product();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Products WHERE ProductName = '{ProductName}';", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						product.Id = (int)reader["Id"];
						product.Name = (string)reader["ProductName"];
						product.Shape = (string)reader["ProductShape"];
						product.Weight = (double)reader["ProductWeight"];
						product.QuantityInStore = (double)reader["QuantityInStore"];
						product.QuantityInShelves = (double)reader["QuantityInShelves"];
						product.QuantityInBox = (double)reader["QuantityInBox"];
						product.QuantityMaxInShelve = (double)reader["QuantityMaxInShelve"];
						product.UnitPrice = (double)reader["UnitPrice"];
						product.PurchasePrice = (double)reader["PurchasePrice"];
						product.SellingPrice = (double)reader["SellingPrice"];
						product.ShelfCode = (string)reader["ShelfCode"];
						product.AlertThreshold = (double)reader["AlertThreshold"];
						product.CreatedBy = (string)reader["CreatedBy"];
						product.DateCreated = (DateTime)reader["DateCreated"];
						product.ExpiryDate = (DateTime)reader["ExpiryDate"];
						product.DateModified = (DateTime)reader["DateModified"];
						product.SupplierName = (string)reader["SupplierName"];
						product.Store = (bool)reader["Store"];
					}
				}
			}
			return product;
		}

		public static Product[] GetProducts(string Query = "SELECT * FROM Products;")
		{
			List<Product> li = new List<Product>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand(Query, cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Product product = new Product();
						product.Id = (int)reader["Id"];
						product.Name = (string)reader["ProductName"];
						product.Shape = (string)reader["ProductShape"];
						product.Weight = (double)reader["ProductWeight"];
						product.QuantityInStore = (double)reader["QuantityInStore"];
						product.QuantityInShelves = (double)reader["QuantityInShelves"];
						product.QuantityInBox = (double)reader["QuantityInBox"];
						product.QuantityMaxInShelve = (double)reader["QuantityMaxInShelve"];
						product.UnitPrice = (double)reader["UnitPrice"];
						product.PurchasePrice = (double)reader["PurchasePrice"];
						product.SellingPrice = (double)reader["SellingPrice"];
						product.ShelfCode = (string)reader["ShelfCode"];
						product.AlertThreshold = (double)reader["AlertThreshold"];
						product.CreatedBy = (string)reader["CreatedBy"];
						product.DateCreated = (DateTime)reader["DateCreated"];
						product.ExpiryDate = (DateTime)reader["ExpiryDate"];
						product.DateModified = (DateTime)reader["DateModified"];
						product.SupplierName = (string)reader["SupplierName"];
						product.Store = (bool)reader["Store"];
					}
				}
			}
			return li.ToArray();
		}

		public static Cart GetCart(Product product)
		{
			Cart cart = new Cart();
			cart.ProductId = product.Id;
			cart.ProductName = product.Name;
			cart.UnitPrice = product.UnitPrice;
			cart.Shape = product.Shape;
			cart.Quantity = 1;
			return cart;
		}

		public static Cart[] GetCart(Product[] products)
		{
			List<Cart> li = new List<Cart>();
			foreach (Product item in products)
			{
				li.Add(GetCart(item));
			}
			return li.ToArray();
		}

		public static void InsertProduct(Product product)
		{
			using (IDbConnection connection = new SqlConnection(Manager.ConnectionString))
			{
				connection.Insert(product);
			}
		}

		public static void UpdateProduct(Product product)
		{
			using (IDbConnection connection = new SqlConnection(Manager.ConnectionString))
			{
				connection.Update(product);
			}
		}

		public static void DeleteProduct(Product product)
		{
			using (IDbConnection connection = new SqlConnection(Manager.ConnectionString))
			{
				connection.Delete(product);
			}
		}

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

		#region Suppliers

		public static int NextSupplierId
		{
			get
			{
				using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
				{
					cnn.Open();
					SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(Id), 0) + 1 FROM Suppliers;", cnn);
					SqlDataReader reader = cmd.ExecuteReader();
					if (reader.HasRows)
					{
						while (reader.Read())
							return reader.GetInt32(0);
					}
					return 1;
				}
			}
		}

		public static AutoCompleteStringCollection GetAllSupplierNamesCollection
		{
			get
			{
				AutoCompleteStringCollection col = new AutoCompleteStringCollection();
				using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
				{
					cnn.Open();
					SqlCommand cmd = new SqlCommand("SELECT Name FROM Suppliers;", cnn);
					SqlDataReader reader = cmd.ExecuteReader();
					while (reader.Read())
						col.Add(reader.GetString(0));
				}
				return col;
			}
		}

		public static void InsertSupplier(Supplier sup)
		{
			using (IDbConnection connection = new SqlConnection(Manager.ConnectionString))
			{
				connection.Insert(sup);
			}
		}

		public static void UpdateSupplier(Supplier sup)
		{
			using (IDbConnection connection = new SqlConnection(Manager.ConnectionString))
			{
				connection.Update(sup);
			}
		}

		public static void DeleteSupplier(Supplier sup)
		{
			using (IDbConnection connection = new SqlConnection(Manager.ConnectionString))
			{
				connection.Delete(sup);
			}
		}

		public static Supplier GetSupplier(int id)
		{
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				Supplier sup = new Supplier();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Suppliers WHERE Id = {id}", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						sup.Id = (int)reader["Id"];
						sup.Name = (string)reader["Name"];
						sup.City = (string)reader["City"];
						sup.Province = (string)reader["Province"];
						sup.Email = (string)reader["Email"];
						sup.Contact1 = (string)reader["Contact1"];
						sup.Contact2 = (string)reader["Contact2"];
						sup.AirtelMoney = (string)reader["AirtelMoney"];
						sup.BankAccount = (string)reader["BankAccount"];
						sup.Category = (string)reader["Category"];
					}
				}
				return sup;
			}
		}

		public static Supplier GetSupplier(string name)
		{
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				Supplier sup = new Supplier();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Suppliers WHERE Name = '{name}'", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						sup.Id = (int)reader["Id"];
						sup.Name = (string)reader["Name"];
						sup.City = (string)reader["City"];
						sup.Province = (string)reader["Province"];
						sup.Email = (string)reader["Email"];
						sup.Contact1 = (string)reader["Contact1"];
						sup.Contact2 = (string)reader["Contact2"];
						sup.AirtelMoney = (string)reader["AirtelMoney"];
						sup.BankAccount = (string)reader["BankAccount"];
						sup.Category = (string)reader["Category"];
					}
				}
				return sup;
			}
		}

		#endregion

		#region Settings

		public static void InsertCategory(string category)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Execute($"INSERT INTO Categories(Value)Values('{category}');");
			}
		}

		public static void InsertShelfNumber(string shelf)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Execute($"INSERT INTO ShelfNumbers(Value)Values('{shelf}');");
			}
		}

		public static void InsertWeight(double weight)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Execute($"INSERT INTO Weights(Value)Values({weight});");
			}
		}

		public static void InsertCity(string city)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Execute($"INSERT INTO Cities(Value)Values('{city}');");
			}
		}

		public static void InsertProvince(string province)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Execute($"INSERT INTO Provinces(Value)Values('{province}');");
			}
		}
		#endregion

	}
}
