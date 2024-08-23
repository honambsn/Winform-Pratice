namespace IncomeExpensesTrackingSystem
{
	partial class Register_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Form));
			this.panel1 = new System.Windows.Forms.Panel();
			this.signinhere = new System.Windows.Forms.Label();
			this.reg_signinBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.close = new System.Windows.Forms.Label();
			this.reg_showpass = new System.Windows.Forms.CheckBox();
			this.reg_btn = new System.Windows.Forms.Button();
			this.reg_password = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.reg_username = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.reg_confirmpass = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(136)))));
			this.panel1.Controls.Add(this.signinhere);
			this.panel1.Controls.Add(this.reg_signinBtn);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(321, 500);
			this.panel1.TabIndex = 3;
			// 
			// signinhere
			// 
			this.signinhere.AutoSize = true;
			this.signinhere.Enabled = false;
			this.signinhere.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.signinhere.ForeColor = System.Drawing.Color.White;
			this.signinhere.Location = new System.Drawing.Point(93, 410);
			this.signinhere.Name = "signinhere";
			this.signinhere.Size = new System.Drawing.Size(133, 23);
			this.signinhere.TabIndex = 18;
			this.signinhere.Text = "SIGN IN HERE";
			// 
			// reg_signinBtn
			// 
			this.reg_signinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(136)))));
			this.reg_signinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.reg_signinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(191)))), ((int)(((byte)(217)))));
			this.reg_signinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(191)))), ((int)(((byte)(217)))));
			this.reg_signinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.reg_signinBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reg_signinBtn.ForeColor = System.Drawing.Color.White;
			this.reg_signinBtn.Location = new System.Drawing.Point(15, 448);
			this.reg_signinBtn.Name = "reg_signinBtn";
			this.reg_signinBtn.Size = new System.Drawing.Size(286, 40);
			this.reg_signinBtn.TabIndex = 17;
			this.reg_signinBtn.Text = "SIGN IN";
			this.reg_signinBtn.UseVisualStyleBackColor = false;
			this.reg_signinBtn.Click += new System.EventHandler(this.reg_signinBtn_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(10, 174);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(305, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Income and Expeneses Tracker";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(112, 48);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// close
			// 
			this.close.AutoSize = true;
			this.close.BackColor = System.Drawing.Color.White;
			this.close.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.close.Location = new System.Drawing.Point(347, 9);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(20, 20);
			this.close.TabIndex = 1;
			this.close.Text = "X";
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// reg_showpass
			// 
			this.reg_showpass.AutoSize = true;
			this.reg_showpass.Cursor = System.Windows.Forms.Cursors.Hand;
			this.reg_showpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reg_showpass.Location = new System.Drawing.Point(184, 368);
			this.reg_showpass.Name = "reg_showpass";
			this.reg_showpass.Size = new System.Drawing.Size(141, 24);
			this.reg_showpass.TabIndex = 15;
			this.reg_showpass.Text = "Show Password";
			this.reg_showpass.UseVisualStyleBackColor = true;
			this.reg_showpass.CheckedChanged += new System.EventHandler(this.reg_showpass_CheckedChanged);
			// 
			// reg_btn
			// 
			this.reg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(136)))));
			this.reg_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.reg_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
			this.reg_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
			this.reg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.reg_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reg_btn.ForeColor = System.Drawing.Color.White;
			this.reg_btn.Location = new System.Drawing.Point(57, 410);
			this.reg_btn.Name = "reg_btn";
			this.reg_btn.Size = new System.Drawing.Size(95, 40);
			this.reg_btn.TabIndex = 14;
			this.reg_btn.Text = "SIGN UP";
			this.reg_btn.UseVisualStyleBackColor = false;
			this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
			// 
			// reg_password
			// 
			this.reg_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reg_password.Location = new System.Drawing.Point(57, 239);
			this.reg_password.Name = "reg_password";
			this.reg_password.PasswordChar = '*';
			this.reg_password.Size = new System.Drawing.Size(268, 29);
			this.reg_password.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(53, 205);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 19);
			this.label5.TabIndex = 12;
			this.label5.Text = "Password";
			// 
			// reg_username
			// 
			this.reg_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reg_username.Location = new System.Drawing.Point(57, 145);
			this.reg_username.Name = "reg_username";
			this.reg_username.Size = new System.Drawing.Size(268, 29);
			this.reg_username.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(53, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 19);
			this.label4.TabIndex = 10;
			this.label4.Text = "Username";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(53, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "REGISTER";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
			this.panel2.Controls.Add(this.reg_confirmpass);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.close);
			this.panel2.Controls.Add(this.reg_showpass);
			this.panel2.Controls.Add(this.reg_btn);
			this.panel2.Controls.Add(this.reg_password);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.reg_username);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.panel2.Location = new System.Drawing.Point(321, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(379, 500);
			this.panel2.TabIndex = 4;
			// 
			// reg_confirmpass
			// 
			this.reg_confirmpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reg_confirmpass.Location = new System.Drawing.Point(57, 333);
			this.reg_confirmpass.Name = "reg_confirmpass";
			this.reg_confirmpass.PasswordChar = '*';
			this.reg_confirmpass.Size = new System.Drawing.Size(268, 29);
			this.reg_confirmpass.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(53, 299);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 19);
			this.label1.TabIndex = 16;
			this.label1.Text = "Confirm Password";
			// 
			// Register_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 500);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Register_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Register_Form";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button reg_signinBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label close;
		private System.Windows.Forms.CheckBox reg_showpass;
		private System.Windows.Forms.Button reg_btn;
		private System.Windows.Forms.TextBox reg_password;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox reg_username;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox reg_confirmpass;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label signinhere;
	}
}