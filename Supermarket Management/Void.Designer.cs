﻿namespace Supermarket_Management
{
	partial class Void
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Void));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.picClose = new System.Windows.Forms.PictureBox();
			this.txtUsername = new MetroFramework.Controls.MetroTextBox();
			this.txtPassword = new MetroFramework.Controls.MetroTextBox();
			this.btnVoid = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
			this.panel1.Controls.Add(this.picClose);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(504, 50);
			this.panel1.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Void Cancel Order";
			// 
			// picClose
			// 
			this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
			this.picClose.Location = new System.Drawing.Point(475, 3);
			this.picClose.Name = "picClose";
			this.picClose.Size = new System.Drawing.Size(26, 25);
			this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picClose.TabIndex = 1;
			this.picClose.TabStop = false;
			this.picClose.Click += new System.EventHandler(this.picClose_Click);
			// 
			// txtUsername
			// 
			// 
			// 
			// 
			this.txtUsername.CustomButton.Image = null;
			this.txtUsername.CustomButton.Location = new System.Drawing.Point(230, 1);
			this.txtUsername.CustomButton.Name = "";
			this.txtUsername.CustomButton.Size = new System.Drawing.Size(29, 29);
			this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtUsername.CustomButton.TabIndex = 1;
			this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtUsername.CustomButton.UseSelectable = true;
			this.txtUsername.CustomButton.Visible = false;
			this.txtUsername.DisplayIcon = true;
			this.txtUsername.Icon = ((System.Drawing.Image)(resources.GetObject("txtUsername.Icon")));
			this.txtUsername.Lines = new string[0];
			this.txtUsername.Location = new System.Drawing.Point(122, 108);
			this.txtUsername.MaxLength = 32767;
			this.txtUsername.Multiline = true;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.PasswordChar = '\0';
			this.txtUsername.PromptText = "Username";
			this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtUsername.SelectedText = "";
			this.txtUsername.SelectionLength = 0;
			this.txtUsername.SelectionStart = 0;
			this.txtUsername.ShortcutsEnabled = true;
			this.txtUsername.Size = new System.Drawing.Size(260, 31);
			this.txtUsername.TabIndex = 11;
			this.txtUsername.UseSelectable = true;
			this.txtUsername.WaterMark = "Username";
			this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtPassword
			// 
			// 
			// 
			// 
			this.txtPassword.CustomButton.Image = null;
			this.txtPassword.CustomButton.Location = new System.Drawing.Point(230, 1);
			this.txtPassword.CustomButton.Name = "";
			this.txtPassword.CustomButton.Size = new System.Drawing.Size(29, 29);
			this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPassword.CustomButton.TabIndex = 1;
			this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPassword.CustomButton.UseSelectable = true;
			this.txtPassword.CustomButton.Visible = false;
			this.txtPassword.DisplayIcon = true;
			this.txtPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtPassword.Icon")));
			this.txtPassword.Lines = new string[0];
			this.txtPassword.Location = new System.Drawing.Point(123, 171);
			this.txtPassword.MaxLength = 32767;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '●';
			this.txtPassword.PromptText = "Password";
			this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPassword.SelectedText = "";
			this.txtPassword.SelectionLength = 0;
			this.txtPassword.SelectionStart = 0;
			this.txtPassword.ShortcutsEnabled = true;
			this.txtPassword.Size = new System.Drawing.Size(260, 31);
			this.txtPassword.TabIndex = 12;
			this.txtPassword.UseSelectable = true;
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.WaterMark = "Password";
			this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// btnVoid
			// 
			this.btnVoid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnVoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
			this.btnVoid.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnVoid.FlatAppearance.BorderSize = 0;
			this.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVoid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoid.ForeColor = System.Drawing.Color.White;
			this.btnVoid.Location = new System.Drawing.Point(122, 231);
			this.btnVoid.Name = "btnVoid";
			this.btnVoid.Size = new System.Drawing.Size(260, 35);
			this.btnVoid.TabIndex = 14;
			this.btnVoid.Text = "Void";
			this.btnVoid.UseVisualStyleBackColor = false;
			this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
			// 
			// Void
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 278);
			this.Controls.Add(this.btnVoid);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Void";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Void";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picClose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private MetroFramework.Controls.MetroTextBox txtPassword;
		public System.Windows.Forms.Button btnVoid;
		public MetroFramework.Controls.MetroTextBox txtUsername;
	}
}