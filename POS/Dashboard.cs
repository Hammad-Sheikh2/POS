using FontAwesome.Sharp;
using POS.Classes;
using POS.UserControls;
using POS.UserControls.Finances;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace POS
{
	public partial class Dashboard : Form
	{
		#region Variables

		private IconButton currentBtn;
		private Panel leftBorderBtn = new Panel();
		private struct RGBColors
		{
			public static Color color1 = Color.FromArgb(172, 126, 241);
			public static Color color2 = Color.FromArgb(249, 118, 176);
			public static Color color3 = Color.FromArgb(253, 138, 218);
			public static Color color4 = Color.FromArgb(95, 77, 121);
			public static Color color5 = Color.FromArgb(249, 88, 155);
			public static Color color6 = Color.FromArgb(24, 161, 251);
		}

		public Dashboard()
		{
			InitializeComponent();
			ActivateCurrentTheme();
			//Form
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
			ActivateButton(btnDashboard, Color.WhiteSmoke);
			OpenChildForm(new UC_SellingWindow());

		}


		#endregion

		#region Events

		private void pbMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void pbMaximize_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Normal)
				this.WindowState = FormWindowState.Maximized;
			else
				this.WindowState = FormWindowState.Normal;
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.Save();

			Application.Exit();
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, Color.WhiteSmoke);
			OpenChildForm(new UC_SellingWindow());
		}

		private void btnPrediction_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, Color.WhiteSmoke);
			OpenChildForm(new UC_Suppliers());
		}

		private void btnNewSymptom_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, Color.WhiteSmoke);
			OpenChildForm(new UC_Customers());
		}

		private void btnNewMedicine_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, Color.WhiteSmoke);
			OpenChildForm(new UserControl());
		}

		private void btnMedicines_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, Color.WhiteSmoke);
			OpenChildForm(new UC_Products());
		}

		private void btnSymptoms_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, Color.WhiteSmoke);
			OpenChildForm(new UserControl());
		}

		private void panelFill_Paint(object sender, PaintEventArgs e)
		{

		}

		private void BtnSettings_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, Color.WhiteSmoke);
			OpenChildForm(new UC_Settings());
		}

		private void btnRecords_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, Color.WhiteSmoke);
			OpenChildForm(new UserControl());
		}

		private void Dashboard_Load(object sender, EventArgs e)
		{
			ActivateCurrentTheme();
			this.Refresh();
		}

		#endregion

		#region Methods

		public void ActivateCurrentTheme()
		{
			panelLogo.BackColor = Properties.Settings.Default.HeaderColor;
			panelTitle.BackColor = Properties.Settings.Default.HeaderColor;
			panelMenu.BackColor = Properties.Settings.Default.MenuBarColor;
			pbClose.BackColor = Properties.Settings.Default.HeaderColor;
			pbMaximize.BackColor = Properties.Settings.Default.HeaderColor;
			pbMinimize.BackColor = Properties.Settings.Default.HeaderColor;
			lblSoftwareName.Text = Properties.Settings.Default.CompanyName;
			foreach (var textbox in GetAllChildren(this).OfType<IconButton>())
			{
				textbox.IconColor = Properties.Settings.Default.ForeColor;
				textbox.ForeColor = Properties.Settings.Default.ForeColor;
				textbox.BackColor = Properties.Settings.Default.MenuBarColor;
			}
		}

		private void ClearEverything()
		{
			foreach (var textbox in GetAllChildren(this).OfType<TextBox>())
				textbox.Clear();
			foreach (var combobox in GetAllChildren(this).OfType<ComboBox>())
				combobox.SelectedIndex = -1;
			foreach (var textbox in GetAllChildren(this).OfType<RichTextBox>())
				textbox.Clear();
			foreach (var textbox in GetAllChildren(this).OfType<DateTimePicker>())
				textbox.Value = DateTime.Now;
		}

		private static IEnumerable<Control> GetAllChildren(Control root)
		{
			var stack = new Stack<Control>();
			stack.Push(root);

			while (stack.Any())
			{
				var next = stack.Pop();
				foreach (Control child in next.Controls)
					stack.Push(child);
				yield return next;
			}
		}

		private void ActivateButton(object senderBtn, Color color)
		{
			if (senderBtn != null)
			{
				DisableButtons();
				//button Customization
				currentBtn = (IconButton)senderBtn;
				currentBtn.BackColor = Properties.Settings.Default.OnHoverColor;
				currentBtn.ForeColor = Properties.Settings.Default.ForeColor;
				currentBtn.TextAlign = ContentAlignment.MiddleCenter;
				currentBtn.IconColor = Properties.Settings.Default.ForeColor;
				currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
				currentBtn.ImageAlign = ContentAlignment.MiddleRight;
				//leftBorder customization
				leftBorderBtn.BackColor = color;
				leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
				leftBorderBtn.Visible = true;
				leftBorderBtn.BringToFront();
				//Update Current Button Icon and text
				pbCurrentControlIcon.IconChar = currentBtn.IconChar;
				pbCurrentControlIcon.IconColor = currentBtn.IconColor;
				labelCurrentControl.Text = currentBtn.Text;
				labelCurrentControl.ForeColor = currentBtn.IconColor;
			}
		}

		private void DisableButtons()
		{
			if (currentBtn != null)
			{
				currentBtn.BackColor = Properties.Settings.Default.MenuBarColor;
				currentBtn.ForeColor = Properties.Settings.Default.ForeColor;
				currentBtn.TextAlign = ContentAlignment.MiddleLeft;
				currentBtn.IconColor = Properties.Settings.Default.ForeColor;
				currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
				currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
			}
		}

		private void OpenChildForm(UserControl childForm)
		{
			//if (currentChildForm != null)
			//{
			//    //open only one form at a time
			//    currentChildForm.Close();
			//}
			panelFill.Controls.Clear();
			childForm.Dock = DockStyle.Fill;
			panelFill.Tag = childForm;
			panelFill.Controls.Add(childForm);
			labelCurrentControl.Text = currentBtn.Text;
			childForm.BringToFront();
		}

		#endregion

		private void btnFinances_Click(object sender, EventArgs e)
		{
			if (btnFinances.AccessibleDescription == "Collapsed")
			{
				PanelFinance.Size = new Size(223, 176);
				btnFinances.AccessibleDescription = "Expanded";
			}
			else
			{
				PanelFinance.Size = new Size(223, 50);
				btnFinances.AccessibleDescription = "Collapsed";
			}
		}

		private void btnProductsMenu_Click(object sender, EventArgs e)
		{
			if (btnProductsMenu.AccessibleDescription == "Collapsed")
			{
				PanelProducts.Size = new Size(223, 146);
				btnProductsMenu.AccessibleDescription = "Expanded";
			}
			else
			{
				PanelProducts.Size = new Size(223, 50);
				btnProductsMenu.AccessibleDescription = "Collapsed";
			}
		}

		private void btnFinanceDashboard_Click(object sender, EventArgs e)
		{
			if (Login.Role != "Admin")
			{
				Manager.Show("Admins only", Forms.Notification.Type.Error);
				return;
			}
			ActivateButton(sender, Color.WhiteSmoke);
			OpenChildForm(new UC_FinanceDashboard());
		}

		private void btnFinanceTurnOvers_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, Color.WhiteSmoke);
			OpenChildForm(new UC_Turnovers());
		}

		private void btnFinanceInvoices_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, Color.WhiteSmoke);
			OpenChildForm(new UC_Invoices());
		}

		private void btnFinanceEndOfPeriod_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, Color.WhiteSmoke);
			OpenChildForm(new UC_Closing());
			//cmxEndOfPeriod.Show(btnFinanceEndOfPeriod, new Point(btnFinanceEndOfPeriod.Width / 2, btnFinanceEndOfPeriod.Height));
		}

		private void btnProducts_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, Color.WhiteSmoke);
			OpenChildForm(new UC_Products());
		}

		private void btnStoreShelves_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, Color.WhiteSmoke);
			OpenChildForm(new UC_StoreToShelves());
		}

		private void btnPurchases_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, Color.WhiteSmoke);
			OpenChildForm(new UC_Purchases());
		}
	}
}
