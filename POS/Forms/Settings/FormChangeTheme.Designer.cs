namespace POS.Forms
{
	partial class FormChangeTheme
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
			this.cbxThemes = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbxThemes
			// 
			this.cbxThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxThemes.Font = new System.Drawing.Font("Sitka Small", 14F);
			this.cbxThemes.FormattingEnabled = true;
			this.cbxThemes.Items.AddRange(new object[] {
            "Dark Green",
            "Dark Blue",
            "Dark Cyan",
            "Dark Gray",
            "Dark Purple",
            "Dark Red",
            "Light Blue",
            "Light Cyan",
            "Light Gray",
            "Light Purple",
            "Light Red"});
			this.cbxThemes.Location = new System.Drawing.Point(46, 41);
			this.cbxThemes.Name = "cbxThemes";
			this.cbxThemes.Size = new System.Drawing.Size(259, 36);
			this.cbxThemes.TabIndex = 0;
			this.cbxThemes.SelectedIndexChanged += new System.EventHandler(this.cbxThemes_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(82, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(190, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "sélectionnez un thème";
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOk.Location = new System.Drawing.Point(183, 83);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 29);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(264, 83);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 29);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Annuler";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// FormChangeTheme
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 116);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbxThemes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormChangeTheme";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Changer thème";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxThemes;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
	}
}