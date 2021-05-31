using Microsoft.Toolkit.Uwp.Notifications;
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

			ToastNotificationManagerCompat.OnActivated += s =>
			{
				ToastData data = new ToastData(s.Argument);
				if (data.GetButtonId() == "ok")
				{
					MessageBox.Show("You clicked the 'Ok' button! Hooray!", "Toast Data",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if (data.GetButtonId() == "send" && s.UserInput["input"].ToString() == "Toast")
				{
					MessageBox.Show("Nice! You inputted '" + s.UserInput["input"].ToString() + "' into the text box! Hooray!", "Toast Data",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			};

			Notification n = new Notification();
			n.Generate(txtTitle.Text, txtMessage.Text, "Send", "send", new List<string> { "Type something... please..." }, new List<string> { "input" }, txtIcon.Text);
			n.Send();
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
			notification.Generate(txtTitle.Text, txtMessage.Text, choices, txtIcon.Text);

			notification.Send();
		}
		private void btnAddChoice_Click(object sender, EventArgs e)
		{
			new AddChoiceForm(this).ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SharpNotification.Custom.Notification.Send(txtTitle.Text, txtMessage.Text);
		}
	}
}
