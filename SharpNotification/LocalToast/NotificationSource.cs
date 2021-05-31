using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;

namespace SharpNotification.LocalToast
{
	public class Notification
	{
		private ToastContentBuilder contentBuilder = null;

		/// <summary>
		/// Generates the Notification's content.
		/// </summary>
		/// <param name="Title">The title of the notification.</param>
		/// <param name="Message">The small text below the <paramref name="Title"/>.</param>
		/// <param name="Icon">The icon url string for the image file.</param>
		public void Generate(string Title, string Message, string Icon = "")
		{
			contentBuilder = new ToastContentBuilder();

			contentBuilder.AddText(Title);
			contentBuilder.AddText(Message);

			if (Icon != string.Empty) contentBuilder.AddAppLogoOverride(new Uri(Icon));
		}

		/// <summary>
		/// Generates the Notification's content.
		/// </summary>
		/// <param name="Title">The title of the notification.</param>
		/// <param name="Message">The small text below the <paramref name="Title"/>.</param>
		/// <param name="Choices">The buttons for the user to click.</param>
		/// <param name="Icon">The icon url string for the image file.</param>
		public void Generate(string Title, string Message, List<string> Choices, string Icon = "")
		{
			contentBuilder = new ToastContentBuilder();

			if (Choices != null)
			{
				if (Choices.Count > 0)
				{
					foreach (string choice in Choices)
					{
						ToastButton button = new ToastButton();
						button.SetContent(choice);
						button.AddArgument("action", choice.ToLower());

						contentBuilder.AddButton(button);
					}
				}
			}

			contentBuilder.AddText(Title);
			contentBuilder.AddText(Message);

			if (Icon != string.Empty) contentBuilder.AddAppLogoOverride(new Uri(Icon));
		}

		/// <summary>
		/// Generates the Notification's content.
		/// </summary>
		/// <param name="Title">The title of the notification.</param>
		/// <param name="Message">The small text below the <paramref name="Title"/>.</param>
		/// <param name="InputPlaceholders">The grayed out text individual to each text box.</param>
		/// <param name="InputIds">The identifier used to access the text box's text input.</param>
		/// <param name="Icon">The icon url string for the image file.</param>
		public void Generate(string Title, string Message, string SendButtonText, string SendButtonId, List<string> InputPlaceholders, List<string> InputIds, string Icon = "")
		{
			contentBuilder = new ToastContentBuilder();

			if (InputPlaceholders != null && InputIds != null)
			{
				if (InputPlaceholders.Count > 0 && InputIds.Count > 0)
				{
					for (int i = 0; i < InputIds.Count; i++)
					{
						string inputPlaceholder = InputPlaceholders[i];
						string inputId = InputIds[i];

						ToastTextBox input = new ToastTextBox(inputId);
						input.PlaceholderContent = inputPlaceholder;

						contentBuilder.AddToastInput(input);
					}
				}
			}

			ToastButton sendButton = new ToastButton();
			sendButton.SetContent(SendButtonText);
			sendButton.AddArgument("action", SendButtonId);
			contentBuilder.AddButton(sendButton);

			contentBuilder.AddText(Title);
			contentBuilder.AddText(Message);

			if (Icon != string.Empty) contentBuilder.AddAppLogoOverride(new Uri(Icon));
		}

		/// <summary>
		/// Sends the notification to the user.
		/// </summary>
		public void Send()
		{
			contentBuilder.Show();
		}
	}
}
