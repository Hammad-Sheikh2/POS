using POS.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
