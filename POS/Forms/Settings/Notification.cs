using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS.Forms
{
	public partial class Notification : Form
	{
		public Notification()
		{
			InitializeComponent();
		}

		public enum Action { Wait, Start, Close }

		public enum Type { Success, Warning, Error, Info }

		private Notification.Action action;

		private int x, y;

		private void btnClose_Click(object sender, EventArgs e)
		{
			timer1.Interval = 1;
			action = Action.Close;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			switch (this.action)
			{
				case Action.Wait:
					timer1.Interval = 5000;
					action = Action.Close;
					break;
				case Action.Start:
					timer1.Interval = 1;
					this.Opacity += 0.1;
					if (this.x < this.Location.X)
						this.Left--;
					else
					{
						if (this.Opacity == 1.0)
							action = Action.Wait;
					}
					break;
				case Action.Close:
					timer1.Interval = 1;
					this.Opacity -= 0.1;
					this.Left -= 3;
					if (base.Opacity == 0.0)
						this.Close();
					break;
				default:
					break;
			}
		}

		public void Popup(string Message, Type type)
		{
			this.Opacity = 0.0;
			this.StartPosition = FormStartPosition.Manual;
			string fname;
			for (int i = 1; i < 10; i++)
			{
				fname = "alert" + i.ToString();
				Notification frm = (Notification)Application.OpenForms[fname];
				if (frm == null)
				{
					this.Name = fname;
					this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
					this.y = Screen.PrimaryScreen.WorkingArea.Height - (this.Height * i);
					this.Location = new Point(this.x, this.y);
					break;
				}
			}
			this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
			this.Show();
			switch (type)
			{
				case Type.Success:
					pb.Image = Properties.Resources.Success;
					this.BackColor = Color.SeaGreen;
					break;
				case Type.Warning:
					pb.Image = Properties.Resources.Warning;
					this.BackColor = Color.DarkOrange;
					break;
				case Type.Error:
					pb.Image = Properties.Resources.cancel;
					this.BackColor = Color.DarkRed;
					break;
				case Type.Info:
					pb.Image = Properties.Resources.Info;
					this.BackColor = Color.RoyalBlue;
					break;
				default:
					break;
			}

			this.lblMessage.Text = Message;
			this.action = Action.Start;
			timer1.Interval = 1;
			this.timer1.Start();
		}
	}
}
