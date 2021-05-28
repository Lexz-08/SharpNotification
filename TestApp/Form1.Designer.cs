
namespace TestApp
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtIcon = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lstChoices = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAddChoice = new System.Windows.Forms.Button();
			this.btnSend = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Title:";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(62, 14);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(391, 27);
			this.txtTitle.TabIndex = 1;
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(95, 47);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(358, 27);
			this.txtMessage.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Message:";
			// 
			// txtIcon
			// 
			this.txtIcon.Location = new System.Drawing.Point(105, 80);
			this.txtIcon.Name = "txtIcon";
			this.txtIcon.Size = new System.Drawing.Size(348, 27);
			this.txtIcon.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 19);
			this.label3.TabIndex = 4;
			this.label3.Text = "Icon (URL):";
			// 
			// lstChoices
			// 
			this.lstChoices.Font = new System.Drawing.Font("Roboto", 10F);
			this.lstChoices.FormattingEnabled = true;
			this.lstChoices.ItemHeight = 15;
			this.lstChoices.Items.AddRange(new object[] {
            "Ok"});
			this.lstChoices.Location = new System.Drawing.Point(87, 113);
			this.lstChoices.Name = "lstChoices";
			this.lstChoices.Size = new System.Drawing.Size(366, 184);
			this.lstChoices.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 19);
			this.label4.TabIndex = 7;
			this.label4.Text = "Choices:";
			// 
			// btnAddChoice
			// 
			this.btnAddChoice.Location = new System.Drawing.Point(12, 140);
			this.btnAddChoice.Name = "btnAddChoice";
			this.btnAddChoice.Size = new System.Drawing.Size(69, 30);
			this.btnAddChoice.TabIndex = 8;
			this.btnAddChoice.Text = "...";
			this.btnAddChoice.UseVisualStyleBackColor = true;
			this.btnAddChoice.Click += new System.EventHandler(this.btnAddChoice_Click);
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(12, 176);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(69, 30);
			this.btnSend.TabIndex = 9;
			this.btnSend.Text = "»";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(465, 302);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.btnAddChoice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lstChoices);
			this.Controls.Add(this.txtIcon);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Roboto", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtIcon;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAddChoice;
		private System.Windows.Forms.Button btnSend;
		public System.Windows.Forms.ListBox lstChoices;
	}
}

