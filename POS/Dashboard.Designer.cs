﻿using System.Drawing;
using System.Windows.Forms;

namespace POS
{
	partial class Dashboard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
			this.panelMenu = new System.Windows.Forms.Panel();
			this.BtnSettings = new FontAwesome.Sharp.IconButton();
			this.PanelProducts = new System.Windows.Forms.Panel();
			this.btnPurchases = new FontAwesome.Sharp.IconButton();
			this.btnStoreShelves = new FontAwesome.Sharp.IconButton();
			this.btnProducts = new FontAwesome.Sharp.IconButton();
			this.btnProductsMenu = new FontAwesome.Sharp.IconButton();
			this.PanelFinance = new System.Windows.Forms.Panel();
			this.btnFinanceEndOfPeriod = new FontAwesome.Sharp.IconButton();
			this.btnFinanceInvoices = new FontAwesome.Sharp.IconButton();
			this.btnFinanceTurnOvers = new FontAwesome.Sharp.IconButton();
			this.btnFinanceDashboard = new FontAwesome.Sharp.IconButton();
			this.btnFinances = new FontAwesome.Sharp.IconButton();
			this.btnCustomers = new FontAwesome.Sharp.IconButton();
			this.btnSuppliers = new FontAwesome.Sharp.IconButton();
			this.btnDashboard = new FontAwesome.Sharp.IconButton();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.lblSoftwareName = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.pbCurrentControlIcon = new FontAwesome.Sharp.IconPictureBox();
			this.labelCurrentControl = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.pbMinimize = new FontAwesome.Sharp.IconPictureBox();
			this.pbMaximize = new FontAwesome.Sharp.IconPictureBox();
			this.pbClose = new FontAwesome.Sharp.IconPictureBox();
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.panelFill = new System.Windows.Forms.Panel();
			this.panelMenu.SuspendLayout();
			this.PanelProducts.SuspendLayout();
			this.PanelFinance.SuspendLayout();
			this.panelLogo.SuspendLayout();
			this.panelTitle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCurrentControlIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
			this.panelMenu.Controls.Add(this.BtnSettings);
			this.panelMenu.Controls.Add(this.PanelProducts);
			this.panelMenu.Controls.Add(this.PanelFinance);
			this.panelMenu.Controls.Add(this.btnCustomers);
			this.panelMenu.Controls.Add(this.btnSuppliers);
			this.panelMenu.Controls.Add(this.btnDashboard);
			this.panelMenu.Controls.Add(this.panelLogo);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(223, 658);
			this.panelMenu.TabIndex = 0;
			// 
			// BtnSettings
			// 
			this.BtnSettings.Dock = System.Windows.Forms.DockStyle.Top;
			this.BtnSettings.FlatAppearance.BorderSize = 0;
			this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnSettings.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.BtnSettings.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnSettings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
			this.BtnSettings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnSettings.IconSize = 30;
			this.BtnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnSettings.Location = new System.Drawing.Point(0, 319);
			this.BtnSettings.Name = "BtnSettings";
			this.BtnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.BtnSettings.Rotation = 0D;
			this.BtnSettings.Size = new System.Drawing.Size(223, 50);
			this.BtnSettings.TabIndex = 20;
			this.BtnSettings.Text = "Paramètres";
			this.BtnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnSettings.UseVisualStyleBackColor = true;
			this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
			// 
			// PanelProducts
			// 
			this.PanelProducts.Controls.Add(this.btnPurchases);
			this.PanelProducts.Controls.Add(this.btnStoreShelves);
			this.PanelProducts.Controls.Add(this.btnProducts);
			this.PanelProducts.Controls.Add(this.btnProductsMenu);
			this.PanelProducts.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelProducts.Location = new System.Drawing.Point(0, 269);
			this.PanelProducts.Name = "PanelProducts";
			this.PanelProducts.Size = new System.Drawing.Size(223, 50);
			this.PanelProducts.TabIndex = 19;
			// 
			// btnPurchases
			// 
			this.btnPurchases.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnPurchases.FlatAppearance.BorderSize = 0;
			this.btnPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPurchases.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnPurchases.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPurchases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnPurchases.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnPurchases.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnPurchases.IconSize = 30;
			this.btnPurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPurchases.Location = new System.Drawing.Point(0, 112);
			this.btnPurchases.Name = "btnPurchases";
			this.btnPurchases.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnPurchases.Rotation = 0D;
			this.btnPurchases.Size = new System.Drawing.Size(223, 31);
			this.btnPurchases.TabIndex = 20;
			this.btnPurchases.Text = "Achats";
			this.btnPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPurchases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPurchases.UseVisualStyleBackColor = true;
			this.btnPurchases.Click += new System.EventHandler(this.btnPurchases_Click);
			// 
			// btnStoreShelves
			// 
			this.btnStoreShelves.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnStoreShelves.FlatAppearance.BorderSize = 0;
			this.btnStoreShelves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStoreShelves.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnStoreShelves.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStoreShelves.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnStoreShelves.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnStoreShelves.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnStoreShelves.IconSize = 30;
			this.btnStoreShelves.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnStoreShelves.Location = new System.Drawing.Point(0, 81);
			this.btnStoreShelves.Name = "btnStoreShelves";
			this.btnStoreShelves.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnStoreShelves.Rotation = 0D;
			this.btnStoreShelves.Size = new System.Drawing.Size(223, 31);
			this.btnStoreShelves.TabIndex = 19;
			this.btnStoreShelves.Text = "Magasin / Rayons";
			this.btnStoreShelves.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnStoreShelves.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnStoreShelves.UseVisualStyleBackColor = true;
			this.btnStoreShelves.Click += new System.EventHandler(this.btnStoreShelves_Click);
			// 
			// btnProducts
			// 
			this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnProducts.FlatAppearance.BorderSize = 0;
			this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProducts.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnProducts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnProducts.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnProducts.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnProducts.IconSize = 30;
			this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProducts.Location = new System.Drawing.Point(0, 50);
			this.btnProducts.Name = "btnProducts";
			this.btnProducts.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnProducts.Rotation = 0D;
			this.btnProducts.Size = new System.Drawing.Size(223, 31);
			this.btnProducts.TabIndex = 18;
			this.btnProducts.Text = "Produits";
			this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnProducts.UseVisualStyleBackColor = true;
			this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
			// 
			// btnProductsMenu
			// 
			this.btnProductsMenu.AccessibleDescription = "Collapsed";
			this.btnProductsMenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnProductsMenu.FlatAppearance.BorderSize = 0;
			this.btnProductsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProductsMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnProductsMenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProductsMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnProductsMenu.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
			this.btnProductsMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnProductsMenu.IconSize = 30;
			this.btnProductsMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProductsMenu.Location = new System.Drawing.Point(0, 0);
			this.btnProductsMenu.Name = "btnProductsMenu";
			this.btnProductsMenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnProductsMenu.Rotation = 0D;
			this.btnProductsMenu.Size = new System.Drawing.Size(223, 50);
			this.btnProductsMenu.TabIndex = 17;
			this.btnProductsMenu.Text = "Produits";
			this.btnProductsMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProductsMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnProductsMenu.UseVisualStyleBackColor = true;
			this.btnProductsMenu.Click += new System.EventHandler(this.btnProductsMenu_Click);
			// 
			// PanelFinance
			// 
			this.PanelFinance.Controls.Add(this.btnFinanceEndOfPeriod);
			this.PanelFinance.Controls.Add(this.btnFinanceInvoices);
			this.PanelFinance.Controls.Add(this.btnFinanceTurnOvers);
			this.PanelFinance.Controls.Add(this.btnFinanceDashboard);
			this.PanelFinance.Controls.Add(this.btnFinances);
			this.PanelFinance.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelFinance.Location = new System.Drawing.Point(0, 219);
			this.PanelFinance.Name = "PanelFinance";
			this.PanelFinance.Size = new System.Drawing.Size(223, 50);
			this.PanelFinance.TabIndex = 0;
			// 
			// btnFinanceEndOfPeriod
			// 
			this.btnFinanceEndOfPeriod.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnFinanceEndOfPeriod.FlatAppearance.BorderSize = 0;
			this.btnFinanceEndOfPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFinanceEndOfPeriod.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnFinanceEndOfPeriod.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFinanceEndOfPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFinanceEndOfPeriod.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnFinanceEndOfPeriod.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFinanceEndOfPeriod.IconSize = 30;
			this.btnFinanceEndOfPeriod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFinanceEndOfPeriod.Location = new System.Drawing.Point(0, 143);
			this.btnFinanceEndOfPeriod.Name = "btnFinanceEndOfPeriod";
			this.btnFinanceEndOfPeriod.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnFinanceEndOfPeriod.Rotation = 0D;
			this.btnFinanceEndOfPeriod.Size = new System.Drawing.Size(223, 31);
			this.btnFinanceEndOfPeriod.TabIndex = 21;
			this.btnFinanceEndOfPeriod.Text = "Fin d\'une période ";
			this.btnFinanceEndOfPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFinanceEndOfPeriod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFinanceEndOfPeriod.UseVisualStyleBackColor = true;
			this.btnFinanceEndOfPeriod.Click += new System.EventHandler(this.btnFinanceEndOfPeriod_Click);
			// 
			// btnFinanceInvoices
			// 
			this.btnFinanceInvoices.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnFinanceInvoices.FlatAppearance.BorderSize = 0;
			this.btnFinanceInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFinanceInvoices.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnFinanceInvoices.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFinanceInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFinanceInvoices.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnFinanceInvoices.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFinanceInvoices.IconSize = 30;
			this.btnFinanceInvoices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFinanceInvoices.Location = new System.Drawing.Point(0, 112);
			this.btnFinanceInvoices.Name = "btnFinanceInvoices";
			this.btnFinanceInvoices.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnFinanceInvoices.Rotation = 0D;
			this.btnFinanceInvoices.Size = new System.Drawing.Size(223, 31);
			this.btnFinanceInvoices.TabIndex = 20;
			this.btnFinanceInvoices.Text = "Facture";
			this.btnFinanceInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFinanceInvoices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFinanceInvoices.UseVisualStyleBackColor = true;
			this.btnFinanceInvoices.Click += new System.EventHandler(this.btnFinanceInvoices_Click);
			// 
			// btnFinanceTurnOvers
			// 
			this.btnFinanceTurnOvers.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnFinanceTurnOvers.FlatAppearance.BorderSize = 0;
			this.btnFinanceTurnOvers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFinanceTurnOvers.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnFinanceTurnOvers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFinanceTurnOvers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFinanceTurnOvers.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnFinanceTurnOvers.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFinanceTurnOvers.IconSize = 30;
			this.btnFinanceTurnOvers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFinanceTurnOvers.Location = new System.Drawing.Point(0, 81);
			this.btnFinanceTurnOvers.Name = "btnFinanceTurnOvers";
			this.btnFinanceTurnOvers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnFinanceTurnOvers.Rotation = 0D;
			this.btnFinanceTurnOvers.Size = new System.Drawing.Size(223, 31);
			this.btnFinanceTurnOvers.TabIndex = 19;
			this.btnFinanceTurnOvers.Text = "Chiffre d\'affaires ";
			this.btnFinanceTurnOvers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFinanceTurnOvers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFinanceTurnOvers.UseVisualStyleBackColor = true;
			this.btnFinanceTurnOvers.Click += new System.EventHandler(this.btnFinanceTurnOvers_Click);
			// 
			// btnFinanceDashboard
			// 
			this.btnFinanceDashboard.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnFinanceDashboard.FlatAppearance.BorderSize = 0;
			this.btnFinanceDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFinanceDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnFinanceDashboard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFinanceDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFinanceDashboard.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnFinanceDashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFinanceDashboard.IconSize = 30;
			this.btnFinanceDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFinanceDashboard.Location = new System.Drawing.Point(0, 50);
			this.btnFinanceDashboard.Name = "btnFinanceDashboard";
			this.btnFinanceDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnFinanceDashboard.Rotation = 0D;
			this.btnFinanceDashboard.Size = new System.Drawing.Size(223, 31);
			this.btnFinanceDashboard.TabIndex = 18;
			this.btnFinanceDashboard.Text = "Tableau de bord ";
			this.btnFinanceDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFinanceDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFinanceDashboard.UseVisualStyleBackColor = true;
			this.btnFinanceDashboard.Click += new System.EventHandler(this.btnFinanceDashboard_Click);
			// 
			// btnFinances
			// 
			this.btnFinances.AccessibleDescription = "Collapsed";
			this.btnFinances.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnFinances.FlatAppearance.BorderSize = 0;
			this.btnFinances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFinances.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnFinances.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFinances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFinances.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
			this.btnFinances.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnFinances.IconSize = 30;
			this.btnFinances.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFinances.Location = new System.Drawing.Point(0, 0);
			this.btnFinances.Name = "btnFinances";
			this.btnFinances.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnFinances.Rotation = 0D;
			this.btnFinances.Size = new System.Drawing.Size(223, 50);
			this.btnFinances.TabIndex = 17;
			this.btnFinances.Text = "Finances";
			this.btnFinances.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFinances.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFinances.UseVisualStyleBackColor = true;
			this.btnFinances.Click += new System.EventHandler(this.btnFinances_Click);
			// 
			// btnCustomers
			// 
			this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCustomers.FlatAppearance.BorderSize = 0;
			this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustomers.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCustomers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnCustomers.IconChar = FontAwesome.Sharp.IconChar.Users;
			this.btnCustomers.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnCustomers.IconSize = 30;
			this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCustomers.Location = new System.Drawing.Point(0, 169);
			this.btnCustomers.Name = "btnCustomers";
			this.btnCustomers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnCustomers.Rotation = 0D;
			this.btnCustomers.Size = new System.Drawing.Size(223, 50);
			this.btnCustomers.TabIndex = 9;
			this.btnCustomers.Text = "Clients";
			this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCustomers.UseVisualStyleBackColor = true;
			this.btnCustomers.Click += new System.EventHandler(this.btnNewSymptom_Click);
			// 
			// btnSuppliers
			// 
			this.btnSuppliers.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSuppliers.FlatAppearance.BorderSize = 0;
			this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSuppliers.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnSuppliers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnSuppliers.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry;
			this.btnSuppliers.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnSuppliers.IconSize = 30;
			this.btnSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSuppliers.Location = new System.Drawing.Point(0, 119);
			this.btnSuppliers.Name = "btnSuppliers";
			this.btnSuppliers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnSuppliers.Rotation = 0D;
			this.btnSuppliers.Size = new System.Drawing.Size(223, 50);
			this.btnSuppliers.TabIndex = 8;
			this.btnSuppliers.Text = "Fournisseurs";
			this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSuppliers.UseVisualStyleBackColor = true;
			this.btnSuppliers.Click += new System.EventHandler(this.btnPrediction_Click);
			// 
			// btnDashboard
			// 
			this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnDashboard.FlatAppearance.BorderSize = 0;
			this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Home;
			this.btnDashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnDashboard.IconSize = 30;
			this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDashboard.Location = new System.Drawing.Point(0, 69);
			this.btnDashboard.Name = "btnDashboard";
			this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnDashboard.Rotation = 0D;
			this.btnDashboard.Size = new System.Drawing.Size(223, 50);
			this.btnDashboard.TabIndex = 7;
			this.btnDashboard.Text = "Accueil";
			this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDashboard.UseVisualStyleBackColor = true;
			this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
			// 
			// panelLogo
			// 
			this.panelLogo.Controls.Add(this.bunifuCustomLabel1);
			this.panelLogo.Controls.Add(this.lblSoftwareName);
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(223, 69);
			this.panelLogo.TabIndex = 0;
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoEllipsis = true;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Sitka Small", 10F);
			this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(4, 39);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(214, 20);
			this.bunifuCustomLabel1.TabIndex = 6;
			this.bunifuCustomLabel1.Text = "System de gestion";
			this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSoftwareName
			// 
			this.lblSoftwareName.AutoEllipsis = true;
			this.lblSoftwareName.Font = new System.Drawing.Font("Sitka Small", 14F);
			this.lblSoftwareName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.lblSoftwareName.Location = new System.Drawing.Point(4, 2);
			this.lblSoftwareName.Name = "lblSoftwareName";
			this.lblSoftwareName.Size = new System.Drawing.Size(214, 34);
			this.lblSoftwareName.TabIndex = 5;
			this.lblSoftwareName.Text = "{Software Name}";
			this.lblSoftwareName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelTitle
			// 
			this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
			this.panelTitle.Controls.Add(this.pbCurrentControlIcon);
			this.panelTitle.Controls.Add(this.labelCurrentControl);
			this.panelTitle.Controls.Add(this.pbMinimize);
			this.panelTitle.Controls.Add(this.pbMaximize);
			this.panelTitle.Controls.Add(this.pbClose);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitle.Location = new System.Drawing.Point(223, 0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(1085, 56);
			this.panelTitle.TabIndex = 1;
			// 
			// pbCurrentControlIcon
			// 
			this.pbCurrentControlIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
			this.pbCurrentControlIcon.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbCurrentControlIcon.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.pbCurrentControlIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
			this.pbCurrentControlIcon.IconColor = System.Drawing.Color.WhiteSmoke;
			this.pbCurrentControlIcon.IconSize = 28;
			this.pbCurrentControlIcon.Location = new System.Drawing.Point(14, 20);
			this.pbCurrentControlIcon.Name = "pbCurrentControlIcon";
			this.pbCurrentControlIcon.Size = new System.Drawing.Size(28, 30);
			this.pbCurrentControlIcon.TabIndex = 4;
			this.pbCurrentControlIcon.TabStop = false;
			// 
			// labelCurrentControl
			// 
			this.labelCurrentControl.AutoSize = true;
			this.labelCurrentControl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCurrentControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelCurrentControl.Location = new System.Drawing.Point(47, 21);
			this.labelCurrentControl.Name = "labelCurrentControl";
			this.labelCurrentControl.Size = new System.Drawing.Size(113, 22);
			this.labelCurrentControl.TabIndex = 3;
			this.labelCurrentControl.Text = "Dashboard";
			// 
			// pbMinimize
			// 
			this.pbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pbMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
			this.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbMinimize.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.pbMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
			this.pbMinimize.IconColor = System.Drawing.Color.WhiteSmoke;
			this.pbMinimize.IconSize = 24;
			this.pbMinimize.Location = new System.Drawing.Point(1012, 1);
			this.pbMinimize.Name = "pbMinimize";
			this.pbMinimize.Size = new System.Drawing.Size(24, 24);
			this.pbMinimize.TabIndex = 2;
			this.pbMinimize.TabStop = false;
			this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
			// 
			// pbMaximize
			// 
			this.pbMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pbMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
			this.pbMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbMaximize.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.pbMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
			this.pbMaximize.IconColor = System.Drawing.Color.WhiteSmoke;
			this.pbMaximize.IconSize = 24;
			this.pbMaximize.Location = new System.Drawing.Point(1036, 1);
			this.pbMaximize.Name = "pbMaximize";
			this.pbMaximize.Size = new System.Drawing.Size(24, 24);
			this.pbMaximize.TabIndex = 1;
			this.pbMaximize.TabStop = false;
			this.pbMaximize.Click += new System.EventHandler(this.pbMaximize_Click);
			// 
			// pbClose
			// 
			this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
			this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbClose.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.pbClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
			this.pbClose.IconColor = System.Drawing.Color.WhiteSmoke;
			this.pbClose.IconSize = 24;
			this.pbClose.Location = new System.Drawing.Point(1060, 1);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(24, 24);
			this.pbClose.TabIndex = 0;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.panelTitle;
			this.bunifuDragControl1.Vertical = true;
			// 
			// panelFill
			// 
			this.panelFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
			this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelFill.Location = new System.Drawing.Point(223, 56);
			this.panelFill.Name = "panelFill";
			this.panelFill.Size = new System.Drawing.Size(1085, 602);
			this.panelFill.TabIndex = 2;
			this.panelFill.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFill_Paint);
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
			this.ClientSize = new System.Drawing.Size(1308, 658);
			this.ControlBox = false;
			this.Controls.Add(this.panelFill);
			this.Controls.Add(this.panelTitle);
			this.Controls.Add(this.panelMenu);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Dashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Dashboard_Load);
			this.panelMenu.ResumeLayout(false);
			this.PanelProducts.ResumeLayout(false);
			this.PanelFinance.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCurrentControlIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panelMenu;
		private Panel panelTitle;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private Panel panelFill;
		private FontAwesome.Sharp.IconPictureBox pbMinimize;
		private FontAwesome.Sharp.IconPictureBox pbMaximize;
		private FontAwesome.Sharp.IconPictureBox pbClose;
		private FontAwesome.Sharp.IconPictureBox pbCurrentControlIcon;
		private Bunifu.Framework.UI.BunifuCustomLabel labelCurrentControl;
		private FontAwesome.Sharp.IconButton btnCustomers;
		private FontAwesome.Sharp.IconButton btnSuppliers;
		private FontAwesome.Sharp.IconButton btnDashboard;
		private Panel panelLogo;
		public Bunifu.Framework.UI.BunifuCustomLabel lblSoftwareName;
		private Panel PanelFinance;
		private FontAwesome.Sharp.IconButton btnFinanceDashboard;
		private FontAwesome.Sharp.IconButton btnFinances;
		private FontAwesome.Sharp.IconButton btnFinanceEndOfPeriod;
		private FontAwesome.Sharp.IconButton btnFinanceInvoices;
		private FontAwesome.Sharp.IconButton btnFinanceTurnOvers;
		private FontAwesome.Sharp.IconButton BtnSettings;
		private Panel PanelProducts;
		private FontAwesome.Sharp.IconButton btnPurchases;
		private FontAwesome.Sharp.IconButton btnStoreShelves;
		private FontAwesome.Sharp.IconButton btnProducts;
		private FontAwesome.Sharp.IconButton btnProductsMenu;
		public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
	}
}