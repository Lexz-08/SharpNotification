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
		/// <param name="InputPlaceholders">Text boxes will be generated for each placeholder string you give.</param>
		/// <param name="InputIds">The ids of each input generated.</param>
		/// <param name="Icon">The icon url string for the image file.</param>
		public void Generate(string Title, string Message, List<string> InputPlaceholders, List<string> InputIds, string Icon = "")
		{
			contentBuilder = new ToastContentBuilder();

			if (InputPlaceholders != null)
			{
				if (InputPlaceholders.Count > 0)
				{
					foreach (string inputPlaceholder in InputPlaceholders)
					{
						if (InputIds != null)
						{
							if (InputIds.Count > 0)
							{
								foreach (string inputId in InputIds)
								{
									ToastTextBox input = new ToastTextBox(inputId);
									input.PlaceholderContent = inputPlaceholder;

									contentBuilder.AddToastInput(input);
								}
							}
						}
					}
				}
			}

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
