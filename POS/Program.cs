using POS.Classes;
using POS.Forms;
using System;
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
			if (DB.CheckDatabaseExists("GlessInventory"))
			{
				Application.Run(new FormLogin());
			}
			else
			{
				DB.CreateDatabase();
				DB.CreateTables();
				Manager.Show("Database initialized", Notification.Type.Success);
				Application.Run(new FormLogin());
			}
			//Application.Run(new FormLogin());
		}
	}
}
