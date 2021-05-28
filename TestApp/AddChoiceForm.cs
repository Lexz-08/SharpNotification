using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TestApp
{
	public partial class AddChoiceForm : Form
	{
		public AddChoiceForm(Form1 mainWindow)
		{
			InitializeComponent();

			this.mainWindow = mainWindow;

			close.Image = CloseBitmap;
			minimize.Image = MinimizeBitmap;
		}

		private Form1 mainWindow;

		private int pos = 8;
		private Bitmap CloseBitmap
		{
			get
			{
				Point[] closePts1 = new Point[]
				{
					new Point(pos, pos),
					new Point(close.Width - pos, close.Height - pos),
				};
				Point[] closePts2 = new Point[]
				{
					new Point(pos, close.Height - pos),
					new Point(close.Width - pos, pos),
				};

				Bitmap bmp = new Bitmap(close.Width, close.Height);
				using (Graphics gfx = Graphics.FromImage(bmp))
				{
					gfx.SmoothingMode = SmoothingMode.HighQuality;
					gfx.DrawLines(new Pen(Color.FromArgb(45, 45, 45), 2), closePts1);
					gfx.DrawLines(new Pen(Color.FromArgb(45, 45, 45), 2), closePts2);
				}

				return bmp;
			}
		}
		private Bitmap MinimizeBitmap
		{
			get
			{
				Point[] minPts = new Point[]
				{
					new Point(pos, minimize.Height - pos),
					new Point(minimize.Width - pos, minimize.Height - pos),
				};

				Bitmap bmp = new Bitmap(minimize.Width, minimize.Height);
				using (Graphics gfx = Graphics.FromImage(bmp))
				{
					gfx.SmoothingMode = SmoothingMode.None;
					gfx.DrawLines(new Pen(Color.FromArgb(45, 45, 45), 2), minPts);
					gfx.DrawLines(new Pen(Color.FromArgb(45, 45, 45), 2), minPts);
				}

				return bmp;
			}
		}

		[DllImport("user32")]
		private static extern bool ReleaseCapture();

		[DllImport("user32")]
		private static extern int SendMessage(IntPtr handle, int msg, int wp, int lp);

		private void DragForm(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, 161, 2, 0);
			}
		}

		private void close_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Close();
			}
		}
		private void minimize_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				WindowState = FormWindowState.Minimized;
			}
		}
		private void btnAddChoice_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Close();
				mainWindow.lstChoices.Items.Add(txtChoice.Text);
			}
		}
	}
}
