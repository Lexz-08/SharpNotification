
namespace SharpNotification.Custom
{
	partial class NotificationWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.close = new System.Windows.Forms.PictureBox();
			this.icon = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblMessage = new System.Windows.Forms.Label();
			this.updater = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
			this.SuspendLayout();
			// 
			// close
			// 
			this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.close.Location = new System.Drawing.Point(345, 6);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(28, 28);
			this.close.TabIndex = 0;
			this.close.TabStop = false;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// icon
			// 
			this.icon.Location = new System.Drawing.Point(6, 6);
			this.icon.Name = "icon";
			this.icon.Size = new System.Drawing.Size(28, 28);
			this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.icon.TabIndex = 1;
			this.icon.TabStop = false;
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitle.Location = new System.Drawing.Point(37, 6);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(302, 28);
			this.lblTitle.TabIndex = 2;
			this.lblTitle.Text = "Title";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblMessage
			// 
			this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMessage.Font = new System.Drawing.Font("Roboto", 10F);
			this.lblMessage.Location = new System.Drawing.Point(2, 42);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(337, 75);
			this.lblMessage.TabIndex = 3;
			this.lblMessage.Text = "Message";
			// 
			// updater
			// 
			this.updater.Interval = 1;
			this.updater.Tick += new System.EventHandler(this.updater_Tick);
			// 
			// NotificationWindow
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(379, 126);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.icon);
			this.Controls.Add(this.close);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Roboto", 14F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "NotificationWindow";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "NotificationWindow";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox close;
		private System.Windows.Forms.PictureBox icon;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Timer updater;
	}
}