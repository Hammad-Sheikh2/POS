﻿using POS.Classes.Products;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;
using Dapper.Contrib;
using System.Data;
using POS.Classes.Finances;
using System.Linq;
using POS.UserControls;
using System.Threading.Tasks;

namespace POS.Classes
{
	public static class Access
	{

		#region General

		public static void ExecuteCommand(string query)
		{
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand(query, cnn);
				cmd.ExecuteNonQuery();
			}
		}

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

		public static async Task<List<string>> GetStringListAsync(string Query, bool Integer = false)
		{
			List<string> col = new List<string>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				await cnn.OpenAsync();
				SqlCommand cmd = new SqlCommand(Query, cnn);
				SqlDataReader reader = await cmd.ExecuteReaderAsync();
				while (await reader.ReadAsync())
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

		public static int NextCustomerId
		{
			get
			{
				using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
				{
					cnn.Open();
					SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(Id), 0) + 1 FROM Customers;", cnn);
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

		public static AutoCompleteStringCollection GetAllCustomerNamesCollection
		{
			get
			{
				AutoCompleteStringCollection col = new AutoCompleteStringCollection();
				using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
				{
					cnn.Open();
					SqlCommand cmd = new SqlCommand("SELECT Name FROM Customers;", cnn);
					SqlDataReader reader = cmd.ExecuteReader();
					while (reader.Read())
						col.Add(reader.GetString(0));
				}
				return col;
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

		public static void InsertCustomer(Customer cus)
		{
			using (IDbConnection connection = new SqlConnection(Manager.ConnectionString))
			{
				connection.Insert(cus);
			}
		}

		public static void UpdateCustomer(Customer cus)
		{
			using (IDbConnection connection = new SqlConnection(Manager.ConnectionString))
			{
				connection.Update(cus);
			}
		}

		public static void DeleteCustomer(Customer cus)
		{
			using (IDbConnection connection = new SqlConnection(Manager.ConnectionString))
			{
				connection.Delete(cus);
			}
		}

		public static Customer GetCustomer(int id)
		{
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				Customer cus = new Customer();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Customers WHERE Id = {id}", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						cus.Id = (int)reader["Id"];
						cus.Name = (string)reader["Name"];
						cus.City = (string)reader["City"];
						cus.Province = (string)reader["Province"];
						cus.Email = (string)reader["Email"];
						cus.Contact1 = (string)reader["Contact1"];
						cus.Contact2 = (string)reader["Contact2"];
						cus.AirtelMoney = (string)reader["AirtelMoney"];
						cus.Category = (string)reader["Category"];
					}

				}
				reader.Close();
				using (IDbConnection idb = cnn)
				{
					cus.Paid = idb.Query<double>($"SELECT ISNULL(SUM(Invoices.Paid), 0) FROM (Customers INNER JOIN Invoices ON Customers.Id=Invoices.CustomerId) WHERE Customers.Id = {cus.Id};").First<double>();
					cus.Left = idb.Query<double>($"SELECT ISNULL(SUM(Invoices.Total - Invoices.Paid), 0) FROM (Customers INNER JOIN Invoices ON Customers.Id=Invoices.CustomerId) WHERE Customers.Id = {cus.Id};").First<double>();
				}
				return cus;
			}
		}

		public static Customer GetCustomer(string name)
		{
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				Customer cus = new Customer();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Customers WHERE Name = '{name}'", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						cus.Id = (int)reader["Id"];
						cus.Name = (string)reader["Name"];
						cus.City = (string)reader["City"];
						cus.Province = (string)reader["Province"];
						cus.Email = (string)reader["Email"];
						cus.Contact1 = (string)reader["Contact1"];
						cus.Contact2 = (string)reader["Contact2"];
						cus.AirtelMoney = (string)reader["AirtelMoney"];
						cus.Category = (string)reader["Category"];
					}

				}
				reader.Close();
				using (IDbConnection idb = cnn)
				{
					cus.Paid = idb.Query<double>($"SELECT ISNULL(SUM(Invoices.Paid), 0) FROM (Customers INNER JOIN Invoices ON Customers.Id=Invoices.CustomerId) WHERE Customers.Id = {cus.Id};").First<double>();
					cus.Left = idb.Query<double>($"SELECT ISNULL(SUM(Invoices.Total - Invoices.Paid), 0) FROM (Customers INNER JOIN Invoices ON Customers.Id=Invoices.CustomerId) WHERE Customers.Id = {cus.Id};").First<double>();
				}
				return cus;
			}
		}

		public static Customer[] GetCustomers()
		{
			List<Customer> li = new List<Customer>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Customers", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Customer cus = new Customer();
						cus.Id = (int)reader["Id"];
						cus.Name = (string)reader["Name"];
						cus.City = (string)reader["City"];
						cus.Province = (string)reader["Province"];
						cus.Email = (string)reader["Email"];
						cus.Contact1 = (string)reader["Contact1"];
						cus.Contact2 = (string)reader["Contact2"];
						cus.AirtelMoney = (string)reader["AirtelMoney"];
						cus.Category = (string)reader["Category"];

						li.Add(cus);
					}
				}
				reader.Close();
				using (IDbConnection idb = cnn)
				{
					foreach (Customer cus in li)
					{
						cus.Paid = idb.Query<double>($"SELECT ISNULL(SUM(Invoices.Paid), 0) FROM (Customers INNER JOIN Invoices ON Customers.Id=Invoices.CustomerId) WHERE Customers.Id = {cus.Id};").First<double>();
						cus.Left = idb.Query<double>($"SELECT ISNULL(SUM(Invoices.Total - Invoices.Paid), 0) FROM (Customers INNER JOIN Invoices ON Customers.Id=Invoices.CustomerId) WHERE Customers.Id = {cus.Id};").First<double>();
					}
				}
				return li.ToArray();
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
						product.Weight = (string)reader["ProductWeight"];
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
						product.Weight = (string)reader["ProductWeight"];
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
						product.Weight = (string)reader["ProductWeight"];
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
						li.Add(product);
					}
				}
			}
			return li.ToArray();
		}

		public static Product[] GetProducts(ProductFilter filter)
		{
			List<Product> li = new List<Product>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand("", cnn);
				switch (filter)
				{
					case ProductFilter.All:
						cmd.CommandText = "SELECT * FROM Products";
						break;
					case ProductFilter.InStore:
						cmd.CommandText = "SELECT * FROM Products WHERE QuantityInStore > 0";
						break;
					case ProductFilter.InShelves:
						cmd.CommandText = "SELECT * FROM Products WHERE QuantityInShelves > 0";
						break;
					case ProductFilter.Returned:
						cmd.CommandText = $"SELECT * FROM Products WHERE Id IN(SELECT ProductId FROM (InvoiceDetails INNER JOIN Invoices ON InvoiceDetails.InvoiceId= Invoices.Id) WHERE InvoiceDetails.Quantity < 0)";
						break;
					case ProductFilter.Dormant:
						cmd.CommandText = $"SELECT * FROM Products WHERE Id NOT IN (SELECT ProductId FROM (InvoiceDetails INNER JOIN Invoices ON InvoiceDetails.InvoiceId=Invoices.Id))";
						break;
					case ProductFilter.Expired:
						cmd.CommandText = "SELECT * FROM Products WHERE GETDATE() > ExpiryDate";
						break;
					case ProductFilter.OutOfStock:
						cmd.CommandText = "SELECT * FROM Products WHERE ISNULL(QuantityInStore + QuantityInShelves, 0) < AlertThreshold;";
						break;
					case ProductFilter.InStock:
						cmd.CommandText = "SELECT * FROM Products WHERE ISNULL(QuantityInStore + QuantityInShelves, 0) > AlertThreshold;";
						break;
					default:
						break;
				}
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Product product = new Product();
						product.Id = (int)reader["Id"];
						product.Name = (string)reader["ProductName"];
						product.Shape = (string)reader["ProductShape"];
						product.Weight = (string)reader["ProductWeight"];
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
						li.Add(product);
					}
				}
			}
			return li.ToArray();
		}

		public static Product[] GetProducts(ProductFilter filter, DateTime start, DateTime end)
		{
			List<Product> li = new List<Product>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand("", cnn);
				switch (filter)
				{
					case ProductFilter.All:
						cmd.CommandText = "SELECT * FROM Products";
						break;
					case ProductFilter.InStore:
						cmd.CommandText = "SELECT * FROM Products WHERE QuantityInStore > 0";
						break;
					case ProductFilter.InShelves:
						cmd.CommandText = "SELECT * FROM Products WHERE QuantityInShelves > 0";
						break;
					case ProductFilter.Returned:
						cmd.CommandText = $"SELECT * FROM Products WHERE Id IN (SELECT ProductId FROM (InvoiceDetails INNER JOIN Invoices ON InvoiceDetails.InvoiceId=Invoices.Id) WHERE InvoiceDate BETWEEN '{start.ToString("yyyy-MM-dd")}' AND '{end.ToString("yyyy-MM-dd")}' AND InvoiceDetails.Quantity < 0)";
						break;
					case ProductFilter.Dormant:
						cmd.CommandText = $"SELECT * FROM Products WHERE Id = (SELECT ProductId FROM (InvoiceDetails INNER JOIN Invoices ON InvoiceDetails.InvoiceId=Invoices.Id) WHERE InvoiceDate BETWEEN '{start.ToString("yyyy-MM-dd")}' AND '{end.ToString("yyyy-MM-dd")}')";
						break;
					case ProductFilter.Expired:
						cmd.CommandText = "SELECT * FROM Products WHERE GETDATE() > ExpiryDate";
						break;
					case ProductFilter.OutOfStock:
						cmd.CommandText = "SELECT * FROM Products WHERE ISNULL(QuantityInStore + QuantityInShelves, 0) < AlertThreshold;";
						break;
					case ProductFilter.InStock:
						cmd.CommandText = "SELECT * FROM Products WHERE ISNULL(QuantityInStore + QuantityInShelves, 0) > AlertThreshold;";
						break;
					default:
						break;
				}
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Product product = new Product();
						product.Id = (int)reader["Id"];
						product.Name = (string)reader["ProductName"];
						product.Shape = (string)reader["ProductShape"];
						product.Weight = (string)reader["ProductWeight"];
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
						li.Add(product);
					}
				}
			}
			return li.ToArray();
		}

		public static Cart GetCart(Product product)
		{
			return new Cart
			{
				ProductId = product.Id,
				ProductName = product.Name,
				UnitPrice = product.SellingPrice,
				Shape = product.Shape,
				RetailUnit = product.PurchasePrice,
				Quantity = 1
			};
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

		public static async Task InsertProductAsync(Product product)
		{
			using (IDbConnection connection = new SqlConnection(Manager.ConnectionString))
			{
				await connection.InsertAsync(product);
			}
		}

		public static async Task UpdateProductAsync(Product product)
		{
			using (IDbConnection connection = new SqlConnection(Manager.ConnectionString))
			{
				await connection.UpdateAsync(product);
			}
		}

		public static void DeleteProduct(Product product)
		{
			using (IDbConnection connection = new SqlConnection(Manager.ConnectionString))
			{
				connection.Delete(product);
			}
		}

		public static Product[] GetProducts(Cart[] arr)
		{
			List<Product> li = new List<Product>();
			foreach (Cart item in arr)
			{
				Product product = GetProduct(item.ProductId);
				li.Add(product);
			}
			return li.ToArray();
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

		public static Supplier[] GetSuppliers()
		{
			List<Supplier> li = new List<Supplier>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Suppliers;", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Supplier sup = new Supplier();
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
						li.Add(sup);
					}
				}
				return li.ToArray();
			}
		}

		#endregion

		#region Invoices

		public static int NextInvoiceId
		{
			get
			{
				using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
				{
					cnn.Open();
					SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(Id), 0) + 1 FROM Invoices;", cnn);
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

		public static void InsertInvoice(Invoice inv, Cart[] cart)
		{
			using (IDbConnection connection = new SqlConnection(Manager.ConnectionString))
			{
				connection.Insert(inv);
				foreach (Cart item in cart)
				{
					ExecuteCommand($"UPDATE Products SET QuantityInShelves = QuantityInShelves - {item.Quantity} WHERE Id = {item.ProductId}");
					ExecuteCommand($"INSERT INTO InvoiceDetails(InvoiceId, ProductId, ProductName, RetailUnit, UnitPrice, Quantity, Total)VALUES({inv.Id}, {item.ProductId}, '{item.ProductName}', {item.RetailUnit}, {item.UnitPrice}, {item.Quantity}, '{item.Total}');");
				}
			}
		}

		public static void UpdateInvoice(Invoice inv)
		{
			using (IDbConnection connection = new SqlConnection(Manager.ConnectionString))
			{
				connection.Update(inv);
			}
		}

		public static void DeleteInvoice(Invoice inv)
		{
			using (IDbConnection connection = new SqlConnection(Manager.ConnectionString))
			{
				connection.Delete(inv);
			}
		}

		public static Invoice GetInvoice(int id)
		{
			Invoice inv = new Invoice();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE Id = {id}", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
					}
				}
				return inv;
			}
		}

		public static async Task<Invoice> GetInvoiceAsync(int id)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return await cnn.GetAsync<Invoice>(new { Id = id });
			}
		}

		public static Invoice[] GetInvoices(DateTime InvoiceDate)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE InvoiceDate = '{InvoiceDate.ToString("yyyy-MM-dd")}'", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Invoice[] GetInvoices(int CustomerId, int UserId, DateTime StartDate, DateTime EndDate)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE UserId = {UserId} AND CustomerId = {CustomerId} AND (InvoiceDate BETWEEN '{StartDate.ToString("yyyy-MM-dd")}' AND '{EndDate.ToString("yyyy-MM-dd")}')", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Invoice[] GetInvoicesCredit(int CustomerId, int UserId, DateTime StartDate, DateTime EndDate)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE Credit = 1 AND UserId = {UserId} AND CustomerId = {CustomerId} AND (InvoiceDate BETWEEN '{StartDate.ToString("yyyy-MM-dd")}' AND '{EndDate.ToString("yyyy-MM-dd")}')", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Invoice[] GetInvoicesCash(int CustomerId, int UserId, DateTime StartDate, DateTime EndDate)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE Credit = 0 AND UserId = {UserId} AND CustomerId = {CustomerId} AND (InvoiceDate BETWEEN '{StartDate.ToString("yyyy-MM-dd")}' AND '{EndDate.ToString("yyyy-MM-dd")}')", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Invoice[] GetInvoices(DateTime StartDate, DateTime EndDate)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE InvoiceDate BETWEEN '{StartDate.ToString("yyyy-MM-dd")}' AND '{EndDate.ToString("yyyy-MM-dd")}'", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Invoice[] GetInvoicesCredit(DateTime StartDate, DateTime EndDate)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE Credit = 1 AND InvoiceDate BETWEEN '{StartDate.ToString("yyyy-MM-dd")}' AND '{EndDate.ToString("yyyy-MM-dd")}'", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Invoice[] GetInvoicesCash(DateTime StartDate, DateTime EndDate)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE Credit = 0 AND InvoiceDate BETWEEN '{StartDate.ToString("yyyy-MM-dd")}' AND '{EndDate.ToString("yyyy-MM-dd")}'", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Invoice[] GetInvoicesByUser(int UserId)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE UserId = {UserId}", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Invoice[] GetInvoicesByUser(int UserId, DateTime InvoiceDate)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE UserId = {UserId} AND InvoiceDate = '{InvoiceDate.ToString("yyyy-MM-dd")}'", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Invoice[] GetInvoicesByUser(int UserId, DateTime StartDate, DateTime EndDate)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE UserId = {UserId} AND InvoiceDate BETWEEN '{StartDate.ToString("yyyy-MM-dd")}' AND '{EndDate.ToString("yyyy-MM-dd")}'", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Invoice[] GetInvoicesCreditByUser(int UserId, DateTime StartDate, DateTime EndDate)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE Credit = 1 AND UserId = {UserId} AND InvoiceDate BETWEEN '{StartDate.ToString("yyyy-MM-dd")}' AND '{EndDate.ToString("yyyy-MM-dd")}'", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Invoice[] GetInvoicesCashByUser(int UserId, DateTime StartDate, DateTime EndDate)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE Credit = 0 AND UserId = {UserId} AND InvoiceDate BETWEEN '{StartDate.ToString("yyyy-MM-dd")}' AND '{EndDate.ToString("yyyy-MM-dd")}'", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Invoice[] GetInvoicesByCustomers(int CustomerId)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE CustomerId = {CustomerId}", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Invoice[] GetInvoicesCreditByCustomers(int CustomerId)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE Credit = 1 AND CustomerId = {CustomerId}", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Invoice[] GetInvoicesCashByCustomers(int CustomerId)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE Credit = 0 AND CustomerId = {CustomerId}", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Invoice[] GetInvoicesByCustomersUnpaid(int CustomerId)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE CustomerId = {CustomerId} AND Total > Paid", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Invoice[] GetInvoicesByCustomers(int CustomerId, DateTime StartDate, DateTime EndDate)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE CustomerId = {CustomerId} AND (InvoiceDate BETWEEN '{StartDate.ToString("yyyy-MM-dd")}' AND '{EndDate.ToString("yyyy-MM-dd")}')", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Invoice[] GetInvoicesCreditByCustomers(int CustomerId, DateTime StartDate, DateTime EndDate)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE Credit = 1 AND CustomerId = {CustomerId} AND (InvoiceDate BETWEEN '{StartDate.ToString("yyyy-MM-dd")}' AND '{EndDate.ToString("yyyy-MM-dd")}')", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Invoice[] GetInvoicesCashByCustomers(int CustomerId, DateTime StartDate, DateTime EndDate)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE Credit = 0 AND CustomerId = {CustomerId} AND (InvoiceDate BETWEEN '{StartDate.ToString("yyyy-MM-dd")}' AND '{EndDate.ToString("yyyy-MM-dd")}')", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Invoice[] GetInvoicesByShift(int ShiftId)
		{
			List<Invoice> li = new List<Invoice>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE ShiftId = {ShiftId}", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Invoice inv = new Invoice();
						inv.Id = (int)reader["Id"];
						inv.CustomerId = (int)reader["CustomerId"];
						inv.InvoiceDate = (DateTime)reader["InvoiceDate"];
						inv.Credit = (bool)reader["Credit"];
						inv.Total = (double)reader["Total"];
						inv.Paid = (double)reader["Paid"];
						inv.UserId = (int)reader["UserId"];
						inv.ShiftId = (int)reader["ShiftId"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static Cart[] GetCarts(int InvoiceId)
		{
			List<Cart> li = new List<Cart>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM InvoiceDetails WHERE InvoiceId = {InvoiceId}", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Cart inv = new Cart();
						inv.ProductId = (int)reader["ProductId"];
						inv.ProductName = (string)reader["ProductName"];
						inv.UnitPrice = (double)reader["UnitPrice"];
						inv.Quantity = (double)reader["Quantity"];
						inv.Total = (double)reader["Total"];
						inv.RetailUnit = (double)reader["RetailUnit"];
						li.Add(inv);
					}
				}
			}
			return li.ToArray();
		}

		public static async Task<IEnumerable<Cart>> GetCartsAsync(int invoiceId)
		{

			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return await cnn.GetListAsync<Cart>(new { InvoiceId = invoiceId });
			}
		}

		public static Cart[] GetCarts(Invoice[] arr)
		{
			//List<Cart[]> li = new List<Cart[]>();
			List<Cart> carts = new List<Cart>();
			foreach (Invoice item in arr)
			{
				carts.AddRange(GetCarts(item.Id));
			}
			return carts.ToArray();
		}

		#endregion

		#region Purchases

		public static int NextPurchaseId
		{
			get
			{
				using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
				{
					cnn.Open();
					SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(Id), 0) + 1 FROM Purchases;", cnn);
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

		public static async Task InsertPurchaseAsync(Purchase pur)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				await cnn.InsertAsync(pur);
			}
		}

		public static async Task<IEnumerable<Purchase>> GetPurchasesAsync()
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return await cnn.GetListAsync<Purchase>("ORDER BY PurchaseDate DESC");
			}
		}

		#endregion

		#region Shifts

		public static async Task InsertShiftAsync(Shift shift)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				await cnn.InsertAsync(shift);
			}
		}

		public static async Task InsertDayClosingAsync(DayClosing shift)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				await cnn.InsertAsync(shift);
			}
		}

		public static ClosingShift GetShift()
		{
			ClosingShift shift = new ClosingShift();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT Value FROM Variables WHERE Variable = 'Shift'", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						shift.Id = Convert.ToInt32(reader["Value"]);
					}
				}
				return shift;
			}
		}

		public static async Task<int> StartNewShift()
		{
			var nextId = 0;
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				await cnn.OpenAsync();
				SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(ShiftId), 0) + 1 from Invoices", cnn);
				nextId = Convert.ToInt32(await cmd.ExecuteScalarAsync());
				cmd.CommandText = $"UPDATE Variables SET Value = '{nextId}' WHERE Variable = 'Shift'";
				await cmd.ExecuteNonQueryAsync();
			}
			return nextId;
		}

		public static async Task<ClosingShift[]> GetClosingShiftsAsync()
		{
			List<ClosingShift> li = new List<ClosingShift>();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				await cnn.OpenAsync();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Invoices WHERE ShiftId = {GetShift().Id}", cnn);
				SqlDataReader reader = await cmd.ExecuteReaderAsync();
				if (reader.HasRows)
				{
					while (await reader.ReadAsync())
					{
						ClosingShift shift = new ClosingShift();
						shift.Id = (int)reader["Id"];
						shift.Credit = (bool)reader["Credit"];
						shift.Date = (DateTime)reader["InvoiceDate"];
						shift.Paid = (double)reader["Paid"];
						shift.Total = (double)reader["Total"];
						shift.Quantity = (await GetCartsAsync(shift.Id)).Sum(item => item.Quantity);
						li.Add(shift);
					}
				}
				return li.ToArray();
			}
		}

		public static async Task<IEnumerable<Shift>> GetShiftsAsync(DateTime dt)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return await cnn.GetListAsync<Shift>(new { ClosedOn = dt.Date });
			}
		}

		public static async Task<IEnumerable<DayClosing>> GetDayClosingsAsync(DateTime dt)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return await cnn.GetListAsync<DayClosing>($"WHERE MONTH(ClosingDate)='{dt.ToString("MM")}' AND YEAR(ClosingDate)='{dt.ToString("yyyy")}'");
			}
		}

		#endregion

		#region Users

		public static int NextUserId
		{
			get
			{
				using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
				{
					cnn.Open();
					SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(Id), 0) + 1 FROM Users;", cnn);
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

		public static int UsersCount
		{
			get
			{
				using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
				{
					cnn.Open();
					SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users;", cnn);
					SqlDataReader reader = cmd.ExecuteReader();
					if (reader.HasRows)
					{
						while (reader.Read())
							return reader.GetInt32(0);
					}
					return 0;
				}
			}
		}

		public static AutoCompleteStringCollection GetAllUserNamesCollection
		{
			get
			{
				AutoCompleteStringCollection col = new AutoCompleteStringCollection();
				using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
				{
					cnn.Open();
					SqlCommand cmd = new SqlCommand("SELECT Name FROM Users;", cnn);
					SqlDataReader reader = cmd.ExecuteReader();
					while (reader.Read())
						col.Add(reader.GetString(0));
				}
				return col;
			}
		}

		public static void InsertUser(User user)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Insert(user);
			}
		}

		public static User GetUser(string name)
		{
			User user = new User();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Users WHERE Name = '{name}';", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						user.Id = (int)reader["Id"];
						user.Name = (string)reader["Name"];
						user.Username = (string)reader["Username"];
						user.Pass = (string)reader["Pass"];
						user.Role = (string)reader["Role"];
					}
				}
			}
			return user;
		}

		public static User GetUser(int id)
		{
			User user = new User();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				SqlCommand cmd = new SqlCommand($"SELECT * FROM Users WHERE Id = {id};", cnn);
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						user.Id = (int)reader["Id"];
						user.Name = (string)reader["Name"];
						user.Username = (string)reader["Username"];
						user.Pass = (string)reader["Pass"];
						user.Role = (string)reader["Role"];
					}
				}
			}
			return user;
		}

		public static User GetUserByUsername(string username)
		{
			User user = new User();
			using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Open();
				try
				{
					SqlCommand cmd = new SqlCommand($"SELECT * FROM Users WHERE Username = '{username}';", cnn);
					SqlDataReader reader = cmd.ExecuteReader();
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							user.Id = (int)reader["Id"];
							user.Name = (string)reader["Name"];
							user.Username = (string)reader["Username"];
							user.Pass = (string)reader["Pass"];
							user.Role = (string)reader["Role"];
						}
					}
				}
				catch (Exception)
				{
					return null;
				}
			}
			return user;
		}

		public static bool IsValidUsername(string username)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return cnn.Query<int>($"SELECT COUNT(*) FROM Users WHERE Username = '{username}'").First() <= 0;
			}
		}

		public static async Task DeleteUser(User user)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				await cnn.DeleteAsync(user);
			}
		}

		#endregion

		#region DashboardContents

		public static double GetTotalTurnOver(DateTime start, DateTime end)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return cnn.Query<double>($"SELECT ISNULL(SUM(Total), 0) FROM Invoices WHERE InvoiceDate BETWEEN '{start.ToString("yyyy-MM-dd")}' AND '{end.ToString("yyyy-MM-dd")}'").AsList<double>().First();
			}
		}

		public static double GetTotalBuyPrice(DateTime start, DateTime end)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return cnn.Query<double>($"SELECT ISNULL(SUM(det.RetailUnit * det.Quantity), 0) FROM (InvoiceDetails det INNER JOIN Invoices ON det.InvoiceId=Invoices.Id)  WHERE Invoices.InvoiceDate BETWEEN '{start.ToString("yyyy-MM-dd")}' AND '{end.ToString("yyyy-MM-dd")}';").AsList<double>().First();
			}
		}

		public static double GetTotalSellPrice(DateTime start, DateTime end)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return cnn.Query<double>($"SELECT ISNULL(SUM(det.UnitPrice * det.Quantity), 0) FROM (InvoiceDetails det INNER JOIN Invoices ON det.InvoiceId=Invoices.Id)  WHERE Invoices.InvoiceDate BETWEEN '{start.ToString("yyyy-MM-dd")}' AND '{end.ToString("yyyy-MM-dd")}';").AsList<double>().First();
			}
		}

		public static double GetCreditPayments(DateTime start, DateTime end)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return cnn.Query<double>($"SELECT ISNULL(SUM(Total), 0) FROM Invoices WHERE Credit = 1 AND InvoiceDate BETWEEN '{start.ToString("yyyy-MM-dd")}' AND '{end.ToString("yyyy-MM-dd")}'").AsList<double>().First();
			}
		}

		public static double GetCashPayments(DateTime start, DateTime end)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return cnn.Query<double>($"SELECT ISNULL(SUM(Total), 0) FROM Invoices WHERE Credit = 0 AND InvoiceDate BETWEEN '{start.ToString("yyyy-MM-dd")}' AND '{end.ToString("yyyy-MM-dd")}'").AsList<double>().First();
			}
		}

		public static double GetUnpaidPayments(DateTime start, DateTime end)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return cnn.Query<double>($"SELECT ISNULL(SUM(Total - Paid), 0) FROM Invoices WHERE Total > Paid AND Credit = 1 AND InvoiceDate BETWEEN '{start.ToString("yyyy-MM-dd")}' AND '{end.ToString("yyyy-MM-dd")}'").AsList<double>().First();
			}
		}

		public static double GetAverageSale(DateTime start, DateTime end)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return cnn.Query<double>($"SELECT ISNULL(AVG(Total), 0) FROM Invoices WHERE InvoiceDate BETWEEN '{start.ToString("yyyy-MM-dd")}' AND '{end.ToString("yyyy-MM-dd")}'").AsList<double>().First();
			}
		}

		public static double GetInShelvesProductsPrice()
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return cnn.Query<double>($"SELECT ISNULL(sum(QuantityInShelves * PurchasePrice), 0) FROM Products;").AsList<double>().First();
			}
		}

		public static double GetInStoreProductsPrice()
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return cnn.Query<double>($"SELECT ISNULL(SUM(QuantityInStore * PurchasePrice), 0) FROM Products;").AsList<double>().First();
			}
		}

		public static double GetInShelvesProductsQuantity()
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return cnn.Query<double>($"SELECT ISNULL(SUM(QuantityInShelves), 0) FROM Products;").AsList<double>().First();
			}
		}

		public static double GetInStoreProductsQuantity()
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return cnn.Query<double>($"SELECT ISNULL(SUM(QuantityInStore), 0) FROM Products;").AsList<double>().First();
			}
		}

		public static double GetExpiredProductsQuantity()
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return cnn.Query<double>($"SELECT ISNULL(Sum(QuantityInShelves)+SUM(QuantityInStore), 0) FROM Products WHERE GETDATE() > ExpiryDate;").AsList<double>().First();
			}
		}

		public static double GetExpiredProductsPurchasePrice()
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return cnn.Query<double>($"SELECT ISNULL(Sum(QuantityInShelves * PurchasePrice)+SUM(QuantityInStore * PurchasePrice), 0) FROM Products WHERE GETDATE() > ExpiryDate;").AsList<double>().First();
			}
		}

		public static double GetExpiredProductsCount()
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return cnn.Query<double>($"SELECT ISNULL(Count(Id), 0) FROM Products WHERE GETDATE() > ExpiryDate;").AsList<double>().First();
			}
		}

		public static double GetDormantProductsCount(DateTime start, DateTime end)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return cnn.Query<double>($"SELECT ISNULL(COUNT(Id), 0) FROM Products WHERE Id NOT IN (SELECT ProductId FROM (InvoiceDetails INNER JOIN Invoices ON InvoiceDetails.InvoiceId=Invoices.Id) WHERE InvoiceDate BETWEEN '{start.ToString("yyyy-MM-dd")}' AND '{end.ToString("yyyy-MM-dd")}');").AsList<double>().First();
			}
		}

		public static double GetReturnedProductsCount(DateTime start, DateTime end)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				return cnn.Query<double>($"SELECT COUNT(*) FROM Products WHERE Id IN (SELECT ProductId FROM (InvoiceDetails INNER JOIN Invoices ON InvoiceDetails.InvoiceId=Invoices.Id) WHERE InvoiceDate BETWEEN '{start.ToString("yyyy-MM-dd")}' AND '{end.ToString("yyyy-MM-dd")}' AND InvoiceDetails.Quantity < 0)").AsList<double>().First();
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

		public static void InsertWeight(string weight)
		{
			using (IDbConnection cnn = new SqlConnection(Manager.ConnectionString))
			{
				cnn.Execute($"INSERT INTO Weights(Value)Values('{weight}');");
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
