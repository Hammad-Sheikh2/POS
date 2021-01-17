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
			Application.Run(new FormLogin());
			Application.ApplicationExit += Application_ApplicationExit;
		}

		private static void Application_ApplicationExit(object sender, EventArgs e)
		{
			Properties.Settings.Default.Save();
		}
	}
}
