using POS.Classes;
using POS.Forms;
using POS.Forms.Accounts;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if (InitializeConnection())
			{
				if (Access.UsersCount == 0)
				{
					Application.Run(new FormRegister());
				}
				else
				{
					Application.Run(new FormLogin());
				}
			}
			Application.ApplicationExit += Application_ApplicationExit;
		}

		private static bool InitializeConnection()
		{
			try
			{
				using (SqlConnection cnn = new SqlConnection(Manager.ConnectionString))
				{
					cnn.Open();
					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Failed to connect to server due to:{ex.Message}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
				return false;
			}
		}

		private static void Application_ApplicationExit(object sender, EventArgs e)
		{
			Properties.Settings.Default.Save();
		}
	}
}
