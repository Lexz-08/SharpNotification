using Microsoft.Toolkit.Uwp.Notifications;
using System;
using Windows.Foundation.Collections;

namespace SharpNotification.LocalToast
{
	/// <summary>
	/// When given the XML-data from the <see cref="ToastArguments"/>, it will get the passed user input data.
	/// </summary>
	public class ToastData
	{
		private ToastArguments toastArgs = null;
		private ValueSet toastInputData = null;

		/// <summary>
		/// Initializes a new instance of <see cref="ToastData"/> for retrieving the arguments passed by the toast notification when clicked.
		/// </summary>
		/// <param name="ToastArguments"></param>
		public ToastData(string ToastArgumentXML, ValueSet ToastInput = null)
		{
			ToastArguments args = ToastArguments.Parse(ToastArgumentXML);
			toastArgs = args;
			toastInputData = ToastInput;
		}

		/// <summary>
		/// Retrieves the id (identifier) of the button clicked by the user on the notification.
		/// </summary>
		/// <returns>A string value representing the button id (identifier).</returns>
		public string GetButtonId()
		{
			if (toastArgs == null)
				throw new InvalidOperationException("Couldn't get button id from passed XML string.\n" +
					"Were there any buttons on the notification?");
			return toastArgs.Get("action");
		}

		/// <summary>
		/// Retrieves any input the user put into the text boxes (if any) on the notification.
		/// </summary>
		/// <param name="strInputId">The input for the text box to retrieve the input from.</param>
		/// <returns>A string value representing the text box's text input.</returns>
		public string GetInput(string strInputId)
		{
			if (toastInputData == null)
				throw new InvalidOperationException("Couldn't get any input(s) from the notification activate event.\n" +
					"Were there any inputs/text boxes on the notification?");
			return toastInputData[strInputId].ToString();
		}
	}
}
