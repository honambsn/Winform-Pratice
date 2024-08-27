namespace IncomeExpensesTrackingSystem
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.registerhere = new System.Windows.Forms.Label();
			this.login_signupBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.close = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.login_username = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.login_password = new System.Windows.Forms.TextBox();
			this.login_btn = new System.Windows.Forms.Button();
			this.login_showpass = new System.Windows.Forms.CheckBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
			this.panel1.Controls.Add(this.registerhere);
			this.panel1.Controls.Add(this.login_signupBtn);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(321, 500);
			this.panel1.TabIndex = 0;
			// 
			// registerhere
			// 
			this.registerhere.AutoSize = true;
			this.registerhere.Enabled = false;
			this.registerhere.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registerhere.ForeColor = System.Drawing.Color.White;
			this.registerhere.Location = new System.Drawing.Point(87, 410);
			this.registerhere.Name = "registerhere";
			this.registerhere.Size = new System.Drawing.Size(151, 23);
			this.registerhere.TabIndex = 16;
			this.registerhere.Text = "REGISTER HERE";
			// 
			// login_signupBtn
			// 
			this.login_signupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
			this.login_signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.login_signupBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
			this.login_signupBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
			this.login_signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.login_signupBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_signupBtn.ForeColor = System.Drawing.Color.White;
			this.login_signupBtn.Location = new System.Drawing.Point(15, 448);
			this.login_signupBtn.Name = "login_signupBtn";
			this.login_signupBtn.Size = new System.Drawing.Size(286, 40);
			this.login_signupBtn.TabIndex = 17;
			this.login_signupBtn.Text = "SIGN UP";
			this.login_signupBtn.UseVisualStyleBackColor = false;
			this.login_signupBtn.Click += new System.EventHandler(this.login_signupBtn_Click);
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
			this.close.Click += new System.EventHandler(this.label1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(53, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "SIGN IN";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(53, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 19);
			this.label4.TabIndex = 10;
			this.label4.Text = "Username";
			// 
			// login_username
			// 
			this.login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_username.Location = new System.Drawing.Point(57, 212);
			this.login_username.Name = "login_username";
			this.login_username.Size = new System.Drawing.Size(268, 29);
			this.login_username.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(53, 272);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 19);
			this.label5.TabIndex = 12;
			this.label5.Text = "Password";
			// 
			// login_password
			// 
			this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_password.Location = new System.Drawing.Point(57, 303);
			this.login_password.Name = "login_password";
			this.login_password.PasswordChar = '*';
			this.login_password.Size = new System.Drawing.Size(268, 29);
			this.login_password.TabIndex = 13;
			// 
			// login_btn
			// 
			this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
			this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.login_btn.FlatAppearance.BorderSize = 0;
			this.login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
			this.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
			this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.login_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_btn.ForeColor = System.Drawing.Color.White;
			this.login_btn.Location = new System.Drawing.Point(57, 393);
			this.login_btn.Name = "login_btn";
			this.login_btn.Size = new System.Drawing.Size(95, 40);
			this.login_btn.TabIndex = 14;
			this.login_btn.Text = "LOGIN";
			this.login_btn.UseVisualStyleBackColor = false;
			this.login_btn.Click += new System.EventHandler(this.button1_Click);
			// 
			// login_showpass
			// 
			this.login_showpass.AutoSize = true;
			this.login_showpass.Cursor = System.Windows.Forms.Cursors.Hand;
			this.login_showpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_showpass.Location = new System.Drawing.Point(184, 351);
			this.login_showpass.Name = "login_showpass";
			this.login_showpass.Size = new System.Drawing.Size(141, 24);
			this.login_showpass.TabIndex = 15;
			this.login_showpass.Text = "Show Password";
			this.login_showpass.UseVisualStyleBackColor = true;
			this.login_showpass.CheckedChanged += new System.EventHandler(this.login_showpass_CheckedChanged);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.panel2.Controls.Add(this.close);
			this.panel2.Controls.Add(this.login_showpass);
			this.panel2.Controls.Add(this.login_btn);
			this.panel2.Controls.Add(this.login_password);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.login_username);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.panel2.Location = new System.Drawing.Point(321, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(379, 500);
			this.panel2.TabIndex = 2;
			// 
			// Form1
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(700, 500);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label close;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox login_username;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox login_password;
		private System.Windows.Forms.Button login_btn;
		private System.Windows.Forms.CheckBox login_showpass;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button login_signupBtn;
		private System.Windows.Forms.Label registerhere;
	}
}

