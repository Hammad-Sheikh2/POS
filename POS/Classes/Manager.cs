using POS.Forms;

namespace POS.Classes
{
	public static class Manager
	{
		public static void Show(string Message, Notification.Type type)
		{
			Notification not = new Notification();
			not.Popup(Message, type);
		}
	}
}
