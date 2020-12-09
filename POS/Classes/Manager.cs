using POS.Forms;
using System.Configuration;

namespace POS.Classes
{
	public static class Manager
	{
		public static string ConnectionString
		{
			get
			{
				return ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
			}
		}

		public static void Show(string Message, Notification.Type type)
		{
			Notification not = new Notification();
			not.Popup(Message, type);
		}
	}

	public static class CurrentUser
	{
		public static int Id { get; set; } = 0;

		public static string Name { get; set; } = "Usama";

		public static string Role { get; set; } = "Developer";

		public static string Username { get; set; } = "usama";

		public static string Password { get; set; } = "123";


	}
}
