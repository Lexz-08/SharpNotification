using Microsoft.Toolkit.Uwp.Notifications;
using System;

namespace SharpNotification.LocalToast
{
	/// <summary>
	/// When given the XML-data from the <see cref="ToastArguments"/>, it will get the passed user input data.
	/// </summary>
	public class ToastData
	{
		private ToastArguments toastArgs = null;

		/// <summary>
		/// Initializes a new instance of <see cref="ToastData"/> for retrieving the arguments passed by the toast notification when clicked.
		/// </summary>
		/// <param name="ToastArguments"></param>
		public ToastData(string ToastArgumentXML)
		{
			ToastArguments args = ToastArguments.Parse(ToastArgumentXML);
			toastArgs = args;
		}

		/// <summary>
		/// Retrieves data from the passed arguments when the user clicks the notification.
		/// </summary>
		/// <param name="strKeyName">The name of the argument passed from the click event.</param>
		/// <returns>A value that can be converted to your specified type if not listed in this class.</returns>
		public object GetValue(string strKeyName)
		{
			return toastArgs.Get(strKeyName);
		}

		/// <summary>
		/// Retrieves data from the passed arguments when the user clicks the notification.
		/// </summary>
		/// <param name="strKeyName">The name of the argument passed from the click event.</param>
		/// <returns>A string value representing the arguments passed by the notification.</returns>
		public string GetString(string strKeyName) => GetValue(strKeyName).ToString();

		/// <summary>
		/// Retrieves data from the passed arguments when the user clicks the notification.
		/// </summary>
		/// <param name="strKeyName">The name of the argument passed from the click event.</param>
		/// <returns>A number representing the arguments passed by the notification.</returns>
		public int GetInt(string strKeyName) => Convert.ToInt32(GetValue(strKeyName).ToString());

		/// <summary>
		/// Retrieves data from the passed arguments when the user clicks the notification.
		/// </summary>
		/// <param name="strKeyName">The name of the argument passed from the click event.</param>
		/// <returns>A number representing the arguments passed by the notification.</returns>
		public long GetLong(string strKeyName) => Convert.ToInt64(GetValue(strKeyName).ToString());

		/// <summary>
		/// Retrieves data from the passed arguments when the user clicks the notification.
		/// </summary>
		/// <param name="strKeyName">The name of the argument passed from the click event.</param>
		/// <returns>A number representing the arguments passed by the notification.</returns>
		public short GetShort(string strKeyName) => Convert.ToInt16(GetValue(strKeyName).ToString());

		/// <summary>
		/// Retrieves data from the passed arguments when the user clicks the notification.
		/// </summary>
		/// <param name="strKeyName">The name of the argument passed from the click event.</param>
		/// <returns>A number representing the arguments passed by the notification.</returns>
		public byte GetByte(string strKeyName) => Convert.ToByte(GetValue(strKeyName).ToString());
	}
}
