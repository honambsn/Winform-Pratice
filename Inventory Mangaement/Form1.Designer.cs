namespace Inventory_Mangaement
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
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.register_label = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.login_btn = new System.Windows.Forms.Button();
			this.login_password = new System.Windows.Forms.TextBox();
			this.login_username = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.close = new System.Windows.Forms.Button();
			this.login_showPass = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.login_showPass);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.register_label);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.login_btn);
			this.panel1.Controls.Add(this.login_password);
			this.panel1.Controls.Add(this.login_username);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(150, 100);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(500, 400);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(107, 220);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(29, 29);
			this.pictureBox3.TabIndex = 6;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(107, 161);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(29, 29);
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(210, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(80, 80);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// register_label
			// 
			this.register_label.AutoSize = true;
			this.register_label.Cursor = System.Windows.Forms.Cursors.Hand;
			this.register_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.register_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_label.ForeColor = System.Drawing.Color.Blue;
			this.register_label.Location = new System.Drawing.Point(284, 345);
			this.register_label.Name = "register_label";
			this.register_label.Size = new System.Drawing.Size(81, 15);
			this.register_label.TabIndex = 4;
			this.register_label.Text = "Register here";
			this.register_label.Click += new System.EventHandler(this.register_label_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(141, 345);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Have no account yet?";
			// 
			// login_btn
			// 
			this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
			this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.login_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_btn.ForeColor = System.Drawing.Color.White;
			this.login_btn.Location = new System.Drawing.Point(107, 301);
			this.login_btn.Name = "login_btn";
			this.login_btn.Size = new System.Drawing.Size(299, 41);
			this.login_btn.TabIndex = 1;
			this.login_btn.Text = "Login";
			this.login_btn.UseVisualStyleBackColor = false;
			// 
			// login_password
			// 
			this.login_password.Location = new System.Drawing.Point(158, 220);
			this.login_password.Name = "login_password";
			this.login_password.PasswordChar = '*';
			this.login_password.Size = new System.Drawing.Size(248, 29);
			this.login_password.TabIndex = 2;
			// 
			// login_username
			// 
			this.login_username.Location = new System.Drawing.Point(158, 161);
			this.login_username.Name = "login_username";
			this.login_username.Size = new System.Drawing.Size(248, 29);
			this.login_username.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(183, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Login Account";
			// 
			// close
			// 
			this.close.BackColor = System.Drawing.Color.Red;
			this.close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.close.ForeColor = System.Drawing.Color.White;
			this.close.Location = new System.Drawing.Point(724, 1);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(75, 23);
			this.close.TabIndex = 0;
			this.close.Text = "X";
			this.close.UseVisualStyleBackColor = false;
			this.close.Click += new System.EventHandler(this.button1_Click);
			// 
			// login_showPass
			// 
			this.login_showPass.AutoSize = true;
			this.login_showPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_showPass.Location = new System.Drawing.Point(263, 264);
			this.login_showPass.Name = "login_showPass";
			this.login_showPass.Size = new System.Drawing.Size(143, 21);
			this.login_showPass.TabIndex = 7;
			this.login_showPass.Text = "Show Password";
			this.login_showPass.UseVisualStyleBackColor = true;
			this.login_showPass.CheckedChanged += new System.EventHandler(this.login_showPass_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.close);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox login_password;
		private System.Windows.Forms.TextBox login_username;
		private System.Windows.Forms.Button login_btn;
		private System.Windows.Forms.Label register_label;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.CheckBox login_showPass;
	}
}

