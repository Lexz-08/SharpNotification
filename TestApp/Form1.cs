using Microsoft.Toolkit.Uwp.Notifications;
using SharpNotification;
using SharpNotification.Custom;
using SharpNotification.LocalToast;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);

			// uninstall anything relating to the Toast Notifications generated and sent locally by our application
			// so that they do not stay
			ToastNotificationManagerCompat.Uninstall();
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			List<string> choices = new List<string>();

			foreach (string choice in lstChoices.Items)
			{
				choices.Add(choice);
			}

			Notification notification = new Notification();
			notification.Generate(txtTitle.Text, txtMessage.Text, choices, txtIcon.Text != string.Empty ? txtIcon.Text : string.Empty);
			notification.Send();

			notification.Clicked += s =>
			{
				Notification.Send("Toast Arguments", s.Argument);
			};
		}
		private void btnAddChoice_Click(object sender, EventArgs e)
		{
			new AddChoiceForm(this).ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			CustomNotification.Send(txtTitle.Text, txtMessage.Text);
		}
	}
}
