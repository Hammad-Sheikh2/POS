using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Classes
{
	public class DB
	{
		public static void CreateDatabase()
		{
			String str;
			SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");

			//str = "CREATE DATABASE GlessInventory ON PRIMARY " +
			// "(NAME = GlessInventory_Data, " +
			// "FILENAME = 'C:\\GlessInventory.mdf', " +
			// "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%)" +
			// "LOG ON (NAME = Peeep, " +
			// "FILENAME = 'C:\\Peeep.ldf', " +
			// "SIZE = 1MB, " +
			// "MAXSIZE = 5MB, " +
			// "FILEGROWTH = 10%)";
			str = "CREATE DATABASE GlessInventory";

			SqlCommand myCommand = new SqlCommand(str, myConn);
			try
			{
				myConn.Open();
				myCommand.ExecuteNonQuery();
				MessageBox.Show("DataBase is Created Successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			finally
			{
				if (myConn.State == ConnectionState.Open)
				{
					myConn.Close();
				}
			}
		}

		public static void CreateTables()
		{
			string query = System.IO.File.ReadAllText(Path.Combine(Application.StartupPath, "SQL\\script.txt"));
			Access.ExecuteCommand(query);
		}

		public static bool CheckDatabaseExists(string databaseName)
		{
			string sqlCreateDBQuery;
			bool result = false;
			SqlConnection tmpConn;

			try
			{
				tmpConn = new SqlConnection("server=.;Trusted_Connection=yes");

				sqlCreateDBQuery = string.Format("SELECT database_id FROM sys.databases WHERE Name = '{0}'", databaseName);

				using (tmpConn)
				{
					using (SqlCommand sqlCmd = new SqlCommand(sqlCreateDBQuery, tmpConn))
					{
						tmpConn.Open();
						object resultObj = sqlCmd.ExecuteScalar();
						int databaseID = 0;
						if (resultObj != null)
						{
							int.TryParse(resultObj.ToString(), out databaseID);
						}
						tmpConn.Close();
						result = (databaseID > 0);
					}
				}
			}
			catch (Exception ex)
			{
				result = false;
			}

			return result;
		}
	}
}
