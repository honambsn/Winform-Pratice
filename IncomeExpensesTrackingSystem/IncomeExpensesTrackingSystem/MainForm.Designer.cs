namespace IncomeExpensesTrackingSystem
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.close = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.logout_Btn = new System.Windows.Forms.Button();
			this.expense_Btn = new System.Windows.Forms.Button();
			this.income_Btn = new System.Windows.Forms.Button();
			this.addCate_Btn = new System.Windows.Forms.Button();
			this.dashboard_Btn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.categoryForm1 = new IncomeExpensesTrackingSystem.CategoryForm();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.close);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1400, 48);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(21, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(30, 30);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(74, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(249, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "Income and Expenses Tracker";
			// 
			// close
			// 
			this.close.AutoSize = true;
			this.close.BackColor = System.Drawing.Color.White;
			this.close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.close.Location = new System.Drawing.Point(1368, 9);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(18, 18);
			this.close.TabIndex = 2;
			this.close.Text = "X";
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
			this.panel2.Controls.Add(this.logout_Btn);
			this.panel2.Controls.Add(this.expense_Btn);
			this.panel2.Controls.Add(this.income_Btn);
			this.panel2.Controls.Add(this.addCate_Btn);
			this.panel2.Controls.Add(this.dashboard_Btn);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(250, 752);
			this.panel2.TabIndex = 1;
			// 
			// logout_Btn
			// 
			this.logout_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
			this.logout_Btn.FlatAppearance.BorderSize = 0;
			this.logout_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logout_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logout_Btn.ForeColor = System.Drawing.Color.White;
			this.logout_Btn.Image = global::IncomeExpensesTrackingSystem.Properties.Resources.icons8_log_out_25__1_;
			this.logout_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.logout_Btn.Location = new System.Drawing.Point(21, 675);
			this.logout_Btn.Name = "logout_Btn";
			this.logout_Btn.Size = new System.Drawing.Size(200, 40);
			this.logout_Btn.TabIndex = 7;
			this.logout_Btn.Text = "Logout";
			this.logout_Btn.UseVisualStyleBackColor = false;
			this.logout_Btn.Click += new System.EventHandler(this.logout_Btn_Click);
			// 
			// expense_Btn
			// 
			this.expense_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
			this.expense_Btn.FlatAppearance.BorderSize = 0;
			this.expense_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.expense_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.expense_Btn.ForeColor = System.Drawing.Color.White;
			this.expense_Btn.Image = global::IncomeExpensesTrackingSystem.Properties.Resources.icons8_expense_25;
			this.expense_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.expense_Btn.Location = new System.Drawing.Point(21, 435);
			this.expense_Btn.Name = "expense_Btn";
			this.expense_Btn.Size = new System.Drawing.Size(200, 40);
			this.expense_Btn.TabIndex = 6;
			this.expense_Btn.Text = "Expenses";
			this.expense_Btn.UseVisualStyleBackColor = false;
			// 
			// income_Btn
			// 
			this.income_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
			this.income_Btn.FlatAppearance.BorderSize = 0;
			this.income_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.income_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.income_Btn.ForeColor = System.Drawing.Color.White;
			this.income_Btn.Image = global::IncomeExpensesTrackingSystem.Properties.Resources.icons8_income_25;
			this.income_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.income_Btn.Location = new System.Drawing.Point(21, 375);
			this.income_Btn.Name = "income_Btn";
			this.income_Btn.Size = new System.Drawing.Size(200, 40);
			this.income_Btn.TabIndex = 5;
			this.income_Btn.Text = "Income";
			this.income_Btn.UseVisualStyleBackColor = false;
			// 
			// addCate_Btn
			// 
			this.addCate_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
			this.addCate_Btn.FlatAppearance.BorderSize = 0;
			this.addCate_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addCate_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addCate_Btn.ForeColor = System.Drawing.Color.White;
			this.addCate_Btn.Image = global::IncomeExpensesTrackingSystem.Properties.Resources.icons8_category_25__1_;
			this.addCate_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addCate_Btn.Location = new System.Drawing.Point(21, 315);
			this.addCate_Btn.Name = "addCate_Btn";
			this.addCate_Btn.Size = new System.Drawing.Size(200, 40);
			this.addCate_Btn.TabIndex = 4;
			this.addCate_Btn.Text = "Add Category";
			this.addCate_Btn.UseVisualStyleBackColor = false;
			// 
			// dashboard_Btn
			// 
			this.dashboard_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
			this.dashboard_Btn.FlatAppearance.BorderSize = 0;
			this.dashboard_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dashboard_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dashboard_Btn.ForeColor = System.Drawing.Color.White;
			this.dashboard_Btn.Image = global::IncomeExpensesTrackingSystem.Properties.Resources.icons8_dashboard_25;
			this.dashboard_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.dashboard_Btn.Location = new System.Drawing.Point(21, 255);
			this.dashboard_Btn.Name = "dashboard_Btn";
			this.dashboard_Btn.Size = new System.Drawing.Size(200, 40);
			this.dashboard_Btn.TabIndex = 3;
			this.dashboard_Btn.Text = "Dashboard";
			this.dashboard_Btn.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(17, 186);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Welcome, ";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(77, 57);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(94, 94);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.categoryForm1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(250, 48);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1150, 752);
			this.panel3.TabIndex = 2;
			// 
			// categoryForm1
			// 
			this.categoryForm1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.categoryForm1.Location = new System.Drawing.Point(0, 0);
			this.categoryForm1.Name = "categoryForm1";
			this.categoryForm1.Size = new System.Drawing.Size(1150, 752);
			this.categoryForm1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1400, 800);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label close;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button dashboard_Btn;
		private System.Windows.Forms.Button logout_Btn;
		private System.Windows.Forms.Button expense_Btn;
		private System.Windows.Forms.Button income_Btn;
		private System.Windows.Forms.Button addCate_Btn;
		private System.Windows.Forms.Panel panel3;
		private CategoryForm categoryForm1;
	}
}