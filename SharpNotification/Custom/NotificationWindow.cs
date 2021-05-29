using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SharpNotification.Custom
{
	internal partial class NotificationWindow : Form
	{
		public NotificationWindow(string strTitle, string strMessage, Image imgIcon = null, bool bBlackClose = true)
		{
			InitializeComponent();

			close.MouseEnter += (s, e) => close.BackColor = Color.FromArgb(30, 0, 0, 0);
			close.MouseLeave += (s, e) => close.BackColor = BackColor;

			this.bBlackClose = bBlackClose;
			close.Image = CloseBmp;

			ShowAlert(strTitle, strMessage, Images.info);
			ShowAlert(strTitle, strMessage, Images.info);
		}

		private bool bBlackClose = false;
		private NotificationAction action = NotificationAction.None;

		private int pos = 8;
		private Bitmap CloseBmp
		{
			get
			{
				Point[] pts1 = new Point[]
				{
					new Point(pos, pos),
					new Point(close.Width - pos, close.Height - pos),
				};
				Point[] pts2 = new Point[]
				{
					new Point(pos, close.Height - pos),
					new Point(close.Width - pos, pos),
				};

				Bitmap bmp = new Bitmap(close.Width, close.Height);
				using (Graphics gfx = Graphics.FromImage(bmp))
				{
					gfx.SmoothingMode = SmoothingMode.HighQuality;
					gfx.DrawLines(new Pen(bBlackClose ? Color.Black : Color.White, 2), pts1);
					gfx.DrawLines(new Pen(bBlackClose ? Color.Black : Color.White, 2), pts2);
				}

				return bmp;
			}
		}

		private int cX, cY;

		private void updater_Tick(object sender, EventArgs e)
		{
			switch (action)
			{
				case NotificationAction.Close:
					updater.Interval = 1;
					Opacity -= 0.1d;
					Left -= 3;

					if (Opacity == 0.0d)
					{
						Close();
					}
					break;
				case NotificationAction.Open:
					updater.Interval = 1;
					Opacity += 0.1d;
					
					if (cX < Location.X)
					{
						Left--;
					}
					else
					{
						if (Opacity == 1d)
						{
							action = NotificationAction.Wait;
						}
					}
					break;
				case NotificationAction.Wait:
					updater.Interval = 5000;
					action = NotificationAction.Close;
					break;
				default:
					break;
			}
		}

		private void close_Click(object sender, EventArgs e)
		{
			updater.Interval = 1;
			action = NotificationAction.Close;
		}

		private void ShowAlert(string strTitle, string strMessage, Image imgIcon)
		{
			Opacity = 0.0d;
			StartPosition = FormStartPosition.Manual;
			string formName = string.Empty;

			for (int i = 0; i < 10; i++)
			{
				formName = "Notification" + i.ToString();
				NotificationWindow n = (NotificationWindow)Application.OpenForms[formName];

				if (n == null)
				{
					Name = formName;
					cX = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
					cY = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
					Location = new Point(cX, cY);
					break;
				}
			}

			cX = Screen.PrimaryScreen.WorkingArea.Width - Width - 5;

			lblMessage.Text = strMessage;
			lblTitle.Text = strTitle;
			icon.Image = imgIcon;

			Show();

			action = NotificationAction.Open;
			updater.Start();
		}
	}
}
