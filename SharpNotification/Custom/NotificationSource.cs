using System.Drawing;

namespace SharpNotification.Custom
{
	/// <summary>
	/// Generates custom notifications without inputs for sending simple messages.
	/// </summary>
	public class Notification
	{
		/// <summary>
		/// Sends a notification to the user in the same place a toast notification would be.
		/// </summary>
		/// <param name="strMessage">The small text below the <paramref name="Title"/>.</param>
		public static void Send(string strMessage)
		{
			new NotificationWindow("New Message", strMessage);
		}

		/// <summary>
		/// Sends a notification to the user in the same place a toast notification would be.
		/// </summary>
		/// <param name="strTitle">The title of the notification.</param>
		/// <param name="strMessage">The small text below the <paramref name="Title"/>.</param>
		public static void Send(string strTitle, string strMessage)
		{
			new NotificationWindow(strTitle, strMessage);
		}

		/// <summary>
		/// Sends a notification to the user in the same place a toast notification would be.
		/// </summary>
		/// <param name="strMessage">The small text below the <paramref name="Title"/>.</param>
		/// <param name="imgIcon">The image for the notification if you don't want to use the default Info.</param>
		public static void Send(string strMessage, Image imgIcon)
		{
			new NotificationWindow("New Message", strMessage, imgIcon);
		}

		/// <summary>
		/// Sends a notification to the user in the same place a toast notification would be.
		/// </summary>
		/// <param name="strTitle">The title of the notification.</param>
		/// <param name="strMessage">The small text below the <paramref name="Title"/>.</param>
		/// <param name="imgIcon">The image for the notification if you don't want to use the default Info.</param>
		public static void Send(string strTitle, string strMessage, Image imgIcon)
		{
			new NotificationWindow(strTitle, strMessage, imgIcon);
		}
	}
}
