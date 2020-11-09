namespace POS.Forms
{
	partial class Notification
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
			this.lblMessage = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pb = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
			this.SuspendLayout();
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Font = new System.Drawing.Font("Sitka Small", 11F);
			this.lblMessage.ForeColor = System.Drawing.Color.White;
			this.lblMessage.Location = new System.Drawing.Point(50, 24);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(115, 23);
			this.lblMessage.TabIndex = 5;
			this.lblMessage.Text = "Message Text";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pb
			// 
			this.pb.Image = global::POS.Properties.Resources.Success;
			this.pb.Location = new System.Drawing.Point(3, 17);
			this.pb.Name = "pb";
			this.pb.Size = new System.Drawing.Size(41, 36);
			this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb.TabIndex = 4;
			this.pb.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.Image = global::POS.Properties.Resources.cancel;
			this.btnClose.Location = new System.Drawing.Point(271, 24);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(29, 26);
			this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnClose.TabIndex = 3;
			this.btnClose.TabStop = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// Notification
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(222)))));
			this.ClientSize = new System.Drawing.Size(303, 71);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.pb);
			this.Controls.Add(this.btnClose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Notification";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.PictureBox pb;
		private System.Windows.Forms.PictureBox btnClose;
		private System.Windows.Forms.Timer timer1;
	}
}