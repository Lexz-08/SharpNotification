using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;

namespace SharpNotification.LocalToast
{
	public class Notification
	{
		private string
			notificationTitle,
			notificationMessage,
			notificationIcon;
		private List<string> choices = new List<string>();
		private ToastContentBuilder contentBuilder = null;

		public event OnActivated Clicked;
		private void OnClicked(ToastNotificationActivatedEventArgsCompat e)
		{
			Clicked?.Invoke(e);
		}

		public void Generate(string Title, string Message, List<string> Choices = null, string Icon = "")
		{
			notificationTitle = Title;
			notificationMessage = Message;
			notificationIcon = Icon;
			choices = Choices;

			contentBuilder = new ToastContentBuilder();

			if (choices != null)
			{
				if (choices.Count > 0)
				{
					foreach (string choice in choices)
					{
						ToastButton button = new ToastButton();
						button.SetContent(choice);
						button.AddArgument("action");
						button.SetBackgroundActivation();

						contentBuilder.AddButton(button);
					}
				}
			}

			contentBuilder.AddText(notificationTitle);
			contentBuilder.AddText(notificationMessage);

			if (notificationIcon != string.Empty) contentBuilder.AddAppLogoOverride(new Uri(notificationIcon));
		}

		public void Send()
		{
			contentBuilder.Show();

			ToastNotificationManagerCompat.OnActivated += e =>
			{
				OnClicked(e);
			};
		}

		public static void Send(string Title, string Message, List<string> Choices = null, string Icon = "")
		{
			Notification n = new Notification();
			n.Generate(Title, Message, Choices, Icon);
			n.Send();
		}
	}
}
