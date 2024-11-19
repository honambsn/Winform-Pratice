namespace Supermarket_Management
{
	partial class ChangePassword
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
			this.picClose = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtPass = new MetroFramework.Controls.MetroTextBox();
			this.lbUsername = new System.Windows.Forms.Label();
			this.txtConfirmPass = new MetroFramework.Controls.MetroTextBox();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtNewPass = new MetroFramework.Controls.MetroTextBox();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// picClose
			// 
			this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
			this.picClose.Location = new System.Drawing.Point(504, 3);
			this.picClose.Name = "picClose";
			this.picClose.Size = new System.Drawing.Size(26, 25);
			this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picClose.TabIndex = 1;
			this.picClose.TabStop = false;
			this.picClose.Click += new System.EventHandler(this.picClose_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
			this.panel1.Controls.Add(this.picClose);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(533, 50);
			this.panel1.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Change Password";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(241, 83);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// txtPass
			// 
			// 
			// 
			// 
			this.txtPass.CustomButton.Image = null;
			this.txtPass.CustomButton.Location = new System.Drawing.Point(230, 1);
			this.txtPass.CustomButton.Name = "";
			this.txtPass.CustomButton.Size = new System.Drawing.Size(29, 29);
			this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPass.CustomButton.TabIndex = 1;
			this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPass.CustomButton.UseSelectable = true;
			this.txtPass.CustomButton.Visible = false;
			this.txtPass.DisplayIcon = true;
			this.txtPass.Icon = ((System.Drawing.Image)(resources.GetObject("txtPass.Icon")));
			this.txtPass.Lines = new string[0];
			this.txtPass.Location = new System.Drawing.Point(136, 154);
			this.txtPass.MaxLength = 32767;
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '●';
			this.txtPass.PromptText = "Current Password";
			this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPass.SelectedText = "";
			this.txtPass.SelectionLength = 0;
			this.txtPass.SelectionStart = 0;
			this.txtPass.ShortcutsEnabled = true;
			this.txtPass.Size = new System.Drawing.Size(260, 31);
			this.txtPass.TabIndex = 13;
			this.txtPass.UseSelectable = true;
			this.txtPass.UseSystemPasswordChar = true;
			this.txtPass.WaterMark = "Current Password";
			this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
			// 
			// lbUsername
			// 
			this.lbUsername.AutoSize = true;
			this.lbUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUsername.Location = new System.Drawing.Point(314, 115);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Size = new System.Drawing.Size(82, 18);
			this.lbUsername.TabIndex = 14;
			this.lbUsername.Text = "Username";
			// 
			// txtConfirmPass
			// 
			// 
			// 
			// 
			this.txtConfirmPass.CustomButton.Image = null;
			this.txtConfirmPass.CustomButton.Location = new System.Drawing.Point(230, 1);
			this.txtConfirmPass.CustomButton.Name = "";
			this.txtConfirmPass.CustomButton.Size = new System.Drawing.Size(29, 29);
			this.txtConfirmPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtConfirmPass.CustomButton.TabIndex = 1;
			this.txtConfirmPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtConfirmPass.CustomButton.UseSelectable = true;
			this.txtConfirmPass.CustomButton.Visible = false;
			this.txtConfirmPass.DisplayIcon = true;
			this.txtConfirmPass.Icon = ((System.Drawing.Image)(resources.GetObject("txtConfirmPass.Icon")));
			this.txtConfirmPass.Lines = new string[0];
			this.txtConfirmPass.Location = new System.Drawing.Point(136, 217);
			this.txtConfirmPass.MaxLength = 32767;
			this.txtConfirmPass.Name = "txtConfirmPass";
			this.txtConfirmPass.PasswordChar = '●';
			this.txtConfirmPass.PromptText = "Confirm New Password";
			this.txtConfirmPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtConfirmPass.SelectedText = "";
			this.txtConfirmPass.SelectionLength = 0;
			this.txtConfirmPass.SelectionStart = 0;
			this.txtConfirmPass.ShortcutsEnabled = true;
			this.txtConfirmPass.Size = new System.Drawing.Size(260, 31);
			this.txtConfirmPass.TabIndex = 16;
			this.txtConfirmPass.UseSelectable = true;
			this.txtConfirmPass.UseSystemPasswordChar = true;
			this.txtConfirmPass.Visible = false;
			this.txtConfirmPass.WaterMark = "Confirm New Password";
			this.txtConfirmPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtConfirmPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.txtConfirmPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmPass_KeyPress);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
			this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNext.FlatAppearance.BorderSize = 0;
			this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.ForeColor = System.Drawing.Color.White;
			this.btnNext.Location = new System.Drawing.Point(296, 275);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(100, 35);
			this.btnNext.TabIndex = 17;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Visible = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(296, 275);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 35);
			this.btnSave.TabIndex = 15;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Visible = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtNewPass
			// 
			// 
			// 
			// 
			this.txtNewPass.CustomButton.Image = null;
			this.txtNewPass.CustomButton.Location = new System.Drawing.Point(230, 1);
			this.txtNewPass.CustomButton.Name = "";
			this.txtNewPass.CustomButton.Size = new System.Drawing.Size(29, 29);
			this.txtNewPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtNewPass.CustomButton.TabIndex = 1;
			this.txtNewPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtNewPass.CustomButton.UseSelectable = true;
			this.txtNewPass.CustomButton.Visible = false;
			this.txtNewPass.DisplayIcon = true;
			this.txtNewPass.Icon = ((System.Drawing.Image)(resources.GetObject("txtNewPass.Icon")));
			this.txtNewPass.Lines = new string[0];
			this.txtNewPass.Location = new System.Drawing.Point(136, 154);
			this.txtNewPass.MaxLength = 32767;
			this.txtNewPass.Name = "txtNewPass";
			this.txtNewPass.PasswordChar = '●';
			this.txtNewPass.PromptText = "New Password";
			this.txtNewPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNewPass.SelectedText = "";
			this.txtNewPass.SelectionLength = 0;
			this.txtNewPass.SelectionStart = 0;
			this.txtNewPass.ShortcutsEnabled = true;
			this.txtNewPass.Size = new System.Drawing.Size(260, 31);
			this.txtNewPass.TabIndex = 18;
			this.txtNewPass.UseSelectable = true;
			this.txtNewPass.UseSystemPasswordChar = true;
			this.txtNewPass.WaterMark = "New Password";
			this.txtNewPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtNewPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// ChangePassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 347);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.txtConfirmPass);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lbUsername);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtNewPass);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ChangePassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChangePassword";
			((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picClose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private MetroFramework.Controls.MetroTextBox txtPass;
		private System.Windows.Forms.Label lbUsername;
		private MetroFramework.Controls.MetroTextBox txtConfirmPass;
		public System.Windows.Forms.Button btnNext;
		public System.Windows.Forms.Button btnSave;
		private MetroFramework.Controls.MetroTextBox txtNewPass;
	}
}