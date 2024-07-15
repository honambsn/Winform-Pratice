namespace Inventory_Mangaement
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.close = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.logout_btn = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.CategoryView = new System.Windows.Forms.Button();
			this.UserView = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lbl_username = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.adminAddCategories1 = new Inventory_Mangaement.AdminAddCategories();
			this.adminAdd1 = new Inventory_Mangaement.AdminAdd();
			this.adminDashboard2 = new Inventory_Mangaement.AdminDashboard();
			this.adminAddProducts1 = new Inventory_Mangaement.AdminAddProducts();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.close);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1280, 45);
			this.panel1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.Yellow;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Enabled = false;
			this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
			this.textBox2.Location = new System.Drawing.Point(283, 15);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 13);
			this.textBox2.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(389, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(265, 26);
			this.label4.TabIndex = 2;
			this.label4.Text = "\'s Portal";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(265, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Inventory Management System";
			// 
			// close
			// 
			this.close.BackColor = System.Drawing.Color.Red;
			this.close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.close.ForeColor = System.Drawing.Color.White;
			this.close.Location = new System.Drawing.Point(1224, 3);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(53, 24);
			this.close.TabIndex = 1;
			this.close.Text = "X";
			this.close.UseVisualStyleBackColor = false;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
			this.panel2.Controls.Add(this.logout_btn);
			this.panel2.Controls.Add(this.button6);
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.CategoryView);
			this.panel2.Controls.Add(this.UserView);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.lbl_username);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 45);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 675);
			this.panel2.TabIndex = 1;
			// 
			// logout_btn
			// 
			this.logout_btn.FlatAppearance.BorderSize = 0;
			this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logout_btn.ForeColor = System.Drawing.Color.White;
			this.logout_btn.Location = new System.Drawing.Point(15, 589);
			this.logout_btn.Name = "logout_btn";
			this.logout_btn.Size = new System.Drawing.Size(161, 37);
			this.logout_btn.TabIndex = 11;
			this.logout_btn.Text = "Logout";
			this.logout_btn.UseVisualStyleBackColor = true;
			this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
			// 
			// button6
			// 
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Location = new System.Drawing.Point(15, 431);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(161, 37);
			this.button6.TabIndex = 10;
			this.button6.Text = "Customers";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(15, 380);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(161, 37);
			this.button3.TabIndex = 9;
			this.button3.Text = "Add Products";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// CategoryView
			// 
			this.CategoryView.FlatAppearance.BorderSize = 0;
			this.CategoryView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.CategoryView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.CategoryView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CategoryView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CategoryView.ForeColor = System.Drawing.Color.White;
			this.CategoryView.Location = new System.Drawing.Point(15, 329);
			this.CategoryView.Name = "CategoryView";
			this.CategoryView.Size = new System.Drawing.Size(161, 37);
			this.CategoryView.TabIndex = 8;
			this.CategoryView.Text = "Add Categories";
			this.CategoryView.UseVisualStyleBackColor = true;
			// 
			// UserView
			// 
			this.UserView.FlatAppearance.BorderSize = 0;
			this.UserView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.UserView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.UserView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UserView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UserView.ForeColor = System.Drawing.Color.White;
			this.UserView.Location = new System.Drawing.Point(15, 278);
			this.UserView.Name = "UserView";
			this.UserView.Size = new System.Drawing.Size(161, 37);
			this.UserView.TabIndex = 7;
			this.UserView.Text = "Add Users";
			this.UserView.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(15, 227);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(161, 37);
			this.button1.TabIndex = 6;
			this.button1.Text = "Dashboard";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Violet;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(15, 169);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 13);
			this.textBox1.TabIndex = 2;
			// 
			// lbl_username
			// 
			this.lbl_username.AutoSize = true;
			this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_username.ForeColor = System.Drawing.Color.White;
			this.lbl_username.Location = new System.Drawing.Point(107, 134);
			this.lbl_username.Name = "lbl_username";
			this.lbl_username.Size = new System.Drawing.Size(54, 18);
			this.lbl_username.TabIndex = 4;
			this.lbl_username.Text = "Admin";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 134);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Welcome, ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(56, 31);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(80, 80);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.adminAddProducts1);
			this.panel3.Controls.Add(this.adminAddCategories1);
			this.panel3.Controls.Add(this.adminAdd1);
			this.panel3.Controls.Add(this.adminDashboard2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(200, 45);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1080, 675);
			this.panel3.TabIndex = 12;
			// 
			// adminAddCategories1
			// 
			this.adminAddCategories1.Location = new System.Drawing.Point(0, 0);
			this.adminAddCategories1.Name = "adminAddCategories1";
			this.adminAddCategories1.Size = new System.Drawing.Size(1080, 675);
			this.adminAddCategories1.TabIndex = 0;
			// 
			// adminAdd1
			// 
			this.adminAdd1.Location = new System.Drawing.Point(0, 0);
			this.adminAdd1.Name = "adminAdd1";
			this.adminAdd1.Size = new System.Drawing.Size(1080, 675);
			this.adminAdd1.TabIndex = 1;
			// 
			// adminDashboard2
			// 
			this.adminDashboard2.Location = new System.Drawing.Point(0, 0);
			this.adminDashboard2.Name = "adminDashboard2";
			this.adminDashboard2.Size = new System.Drawing.Size(1080, 675);
			this.adminDashboard2.TabIndex = 0;
			// 
			// adminAddProducts1
			// 
			this.adminAddProducts1.Location = new System.Drawing.Point(0, 0);
			this.adminAddProducts1.Name = "adminAddProducts1";
			this.adminAddProducts1.Size = new System.Drawing.Size(1080, 675);
			this.adminAddProducts1.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1280, 720);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lbl_username;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button CategoryView;
		private System.Windows.Forms.Button UserView;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button logout_btn;
		private AdminDashboard adminDashboard2;
		private AdminAdd adminAdd1;
		private AdminAddCategories adminAddCategories1;
		private AdminAddProducts adminAddProducts1;
	}
}