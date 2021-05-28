
namespace TestApp
{
	partial class AddChoiceForm
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
			this.captionbar = new System.Windows.Forms.Panel();
			this.title = new System.Windows.Forms.Label();
			this.close = new System.Windows.Forms.PictureBox();
			this.minimize = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtChoice = new System.Windows.Forms.TextBox();
			this.btnAddChoice = new System.Windows.Forms.Button();
			this.captionbar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
			this.SuspendLayout();
			// 
			// captionbar
			// 
			this.captionbar.BackColor = System.Drawing.SystemColors.ControlLight;
			this.captionbar.Controls.Add(this.minimize);
			this.captionbar.Controls.Add(this.close);
			this.captionbar.Controls.Add(this.title);
			this.captionbar.Dock = System.Windows.Forms.DockStyle.Top;
			this.captionbar.Location = new System.Drawing.Point(0, 0);
			this.captionbar.Name = "captionbar";
			this.captionbar.Size = new System.Drawing.Size(427, 33);
			this.captionbar.TabIndex = 0;
			this.captionbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Location = new System.Drawing.Point(5, 8);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(124, 19);
			this.title.TabIndex = 0;
			this.title.Text = "Add New Choice";
			this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
			// 
			// close
			// 
			this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.close.Location = new System.Drawing.Point(398, 3);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(26, 26);
			this.close.TabIndex = 1;
			this.close.TabStop = false;
			this.close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close_MouseClick);
			// 
			// minimize
			// 
			this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.minimize.Location = new System.Drawing.Point(369, 3);
			this.minimize.Name = "minimize";
			this.minimize.Size = new System.Drawing.Size(26, 26);
			this.minimize.TabIndex = 2;
			this.minimize.TabStop = false;
			this.minimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minimize_MouseClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Choice:";
			// 
			// txtChoice
			// 
			this.txtChoice.Location = new System.Drawing.Point(78, 39);
			this.txtChoice.Name = "txtChoice";
			this.txtChoice.Size = new System.Drawing.Size(337, 27);
			this.txtChoice.TabIndex = 2;
			// 
			// btnAddChoice
			// 
			this.btnAddChoice.Location = new System.Drawing.Point(167, 80);
			this.btnAddChoice.Name = "btnAddChoice";
			this.btnAddChoice.Size = new System.Drawing.Size(93, 41);
			this.btnAddChoice.TabIndex = 3;
			this.btnAddChoice.Text = "Add";
			this.btnAddChoice.UseVisualStyleBackColor = true;
			this.btnAddChoice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddChoice_MouseClick);
			// 
			// AddChoiceForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(427, 130);
			this.Controls.Add(this.btnAddChoice);
			this.Controls.Add(this.txtChoice);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.captionbar);
			this.Font = new System.Drawing.Font("Roboto", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddChoiceForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add New Choice";
			this.captionbar.ResumeLayout(false);
			this.captionbar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel captionbar;
		private System.Windows.Forms.Label title;
		private System.Windows.Forms.PictureBox close;
		private System.Windows.Forms.PictureBox minimize;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtChoice;
		private System.Windows.Forms.Button btnAddChoice;
	}
}