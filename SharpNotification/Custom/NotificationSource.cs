using System.Drawing;

namespace SharpNotification.Custom
{
	public class CustomNotification
	{
		public static void Send(string strMessage)
		{
			new NotificationWindow("New Message", strMessage);
		}
		public static void Send(string strTitle, string strMessage)
		{
			new NotificationWindow(strTitle, strMessage);
		}
		public static void Send(string strMessage, Image imgIcon)
		{
			new NotificationWindow("New Message", strMessage, imgIcon);
		}
		public static void Send(string strTitle, string strMessage, Image imgIcon)
		{
			new NotificationWindow(strTitle, strMessage, imgIcon);
		}
	}
}
