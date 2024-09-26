namespace Supermarket_Management
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
			this.panelSlide = new System.Windows.Forms.Panel();
			this.btn_Logout = new System.Windows.Forms.Button();
			this.panelSubProduct = new System.Windows.Forms.Panel();
			this.Productbtn_Brand = new System.Windows.Forms.Button();
			this.Productbtn_Category = new System.Windows.Forms.Button();
			this.Productbtn_ProductList = new System.Windows.Forms.Button();
			this.btn_Product = new System.Windows.Forms.Button();
			this.btn_Dashboard = new System.Windows.Forms.Button();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_Username = new System.Windows.Forms.Label();
			this.lbl_Role = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.lbl_Title = new System.Windows.Forms.Label();
			this.panelMain = new System.Windows.Forms.Panel();
			this.btn_Supplier = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.panelSlide.SuspendLayout();
			this.panelSubProduct.SuspendLayout();
			this.panelLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelTitle.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelSlide
			// 
			this.panelSlide.AutoScroll = true;
			this.panelSlide.Controls.Add(this.panel1);
			this.panelSlide.Controls.Add(this.button1);
			this.panelSlide.Controls.Add(this.btn_Logout);
			this.panelSlide.Controls.Add(this.btn_Supplier);
			this.panelSlide.Controls.Add(this.panelSubProduct);
			this.panelSlide.Controls.Add(this.btn_Product);
			this.panelSlide.Controls.Add(this.btn_Dashboard);
			this.panelSlide.Controls.Add(this.panelLogo);
			this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSlide.Location = new System.Drawing.Point(0, 0);
			this.panelSlide.Name = "panelSlide";
			this.panelSlide.Size = new System.Drawing.Size(230, 862);
			this.panelSlide.TabIndex = 0;
			// 
			// btn_Logout
			// 
			this.btn_Logout.BackColor = System.Drawing.Color.Fuchsia;
			this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btn_Logout.FlatAppearance.BorderSize = 0;
			this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Logout.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Logout.ForeColor = System.Drawing.Color.White;
			this.btn_Logout.Location = new System.Drawing.Point(0, 817);
			this.btn_Logout.Name = "btn_Logout";
			this.btn_Logout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btn_Logout.Size = new System.Drawing.Size(230, 45);
			this.btn_Logout.TabIndex = 7;
			this.btn_Logout.Text = "Log Out";
			this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Logout.UseVisualStyleBackColor = false;
			this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
			// 
			// panelSubProduct
			// 
			this.panelSubProduct.Controls.Add(this.Productbtn_Brand);
			this.panelSubProduct.Controls.Add(this.Productbtn_Category);
			this.panelSubProduct.Controls.Add(this.Productbtn_ProductList);
			this.panelSubProduct.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelSubProduct.Location = new System.Drawing.Point(0, 303);
			this.panelSubProduct.Name = "panelSubProduct";
			this.panelSubProduct.Size = new System.Drawing.Size(230, 136);
			this.panelSubProduct.TabIndex = 0;
			// 
			// Productbtn_Brand
			// 
			this.Productbtn_Brand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
			this.Productbtn_Brand.Dock = System.Windows.Forms.DockStyle.Top;
			this.Productbtn_Brand.FlatAppearance.BorderSize = 0;
			this.Productbtn_Brand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Productbtn_Brand.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Productbtn_Brand.ForeColor = System.Drawing.Color.White;
			this.Productbtn_Brand.Location = new System.Drawing.Point(0, 90);
			this.Productbtn_Brand.Name = "Productbtn_Brand";
			this.Productbtn_Brand.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
			this.Productbtn_Brand.Size = new System.Drawing.Size(230, 46);
			this.Productbtn_Brand.TabIndex = 5;
			this.Productbtn_Brand.Text = "Brand";
			this.Productbtn_Brand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Productbtn_Brand.UseVisualStyleBackColor = false;
			this.Productbtn_Brand.Click += new System.EventHandler(this.Productbtn_Brand_Click);
			// 
			// Productbtn_Category
			// 
			this.Productbtn_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
			this.Productbtn_Category.Dock = System.Windows.Forms.DockStyle.Top;
			this.Productbtn_Category.FlatAppearance.BorderSize = 0;
			this.Productbtn_Category.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Productbtn_Category.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Productbtn_Category.ForeColor = System.Drawing.Color.White;
			this.Productbtn_Category.Location = new System.Drawing.Point(0, 45);
			this.Productbtn_Category.Name = "Productbtn_Category";
			this.Productbtn_Category.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
			this.Productbtn_Category.Size = new System.Drawing.Size(230, 45);
			this.Productbtn_Category.TabIndex = 4;
			this.Productbtn_Category.Text = "Category";
			this.Productbtn_Category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Productbtn_Category.UseVisualStyleBackColor = false;
			this.Productbtn_Category.Click += new System.EventHandler(this.Productbtn_Category_Click);
			// 
			// Productbtn_ProductList
			// 
			this.Productbtn_ProductList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
			this.Productbtn_ProductList.Dock = System.Windows.Forms.DockStyle.Top;
			this.Productbtn_ProductList.FlatAppearance.BorderSize = 0;
			this.Productbtn_ProductList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Productbtn_ProductList.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Productbtn_ProductList.ForeColor = System.Drawing.Color.White;
			this.Productbtn_ProductList.Location = new System.Drawing.Point(0, 0);
			this.Productbtn_ProductList.Name = "Productbtn_ProductList";
			this.Productbtn_ProductList.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
			this.Productbtn_ProductList.Size = new System.Drawing.Size(230, 45);
			this.Productbtn_ProductList.TabIndex = 3;
			this.Productbtn_ProductList.Text = "Product List";
			this.Productbtn_ProductList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Productbtn_ProductList.UseVisualStyleBackColor = false;
			this.Productbtn_ProductList.Click += new System.EventHandler(this.Productbtn_ProductList_Click);
			// 
			// btn_Product
			// 
			this.btn_Product.BackColor = System.Drawing.Color.Fuchsia;
			this.btn_Product.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_Product.FlatAppearance.BorderSize = 0;
			this.btn_Product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Product.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Product.ForeColor = System.Drawing.Color.White;
			this.btn_Product.Location = new System.Drawing.Point(0, 258);
			this.btn_Product.Name = "btn_Product";
			this.btn_Product.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btn_Product.Size = new System.Drawing.Size(230, 45);
			this.btn_Product.TabIndex = 2;
			this.btn_Product.Text = "Product";
			this.btn_Product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Product.UseVisualStyleBackColor = false;
			this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
			// 
			// btn_Dashboard
			// 
			this.btn_Dashboard.BackColor = System.Drawing.Color.Fuchsia;
			this.btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_Dashboard.FlatAppearance.BorderSize = 0;
			this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Dashboard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Dashboard.ForeColor = System.Drawing.Color.White;
			this.btn_Dashboard.Location = new System.Drawing.Point(0, 213);
			this.btn_Dashboard.Name = "btn_Dashboard";
			this.btn_Dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btn_Dashboard.Size = new System.Drawing.Size(230, 45);
			this.btn_Dashboard.TabIndex = 0;
			this.btn_Dashboard.Text = "Dashboard";
			this.btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Dashboard.UseVisualStyleBackColor = false;
			this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
			// 
			// panelLogo
			// 
			this.panelLogo.Controls.Add(this.label1);
			this.panelLogo.Controls.Add(this.lbl_Username);
			this.panelLogo.Controls.Add(this.lbl_Role);
			this.panelLogo.Controls.Add(this.pictureBox1);
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(230, 213);
			this.panelLogo.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 123);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ln";
			// 
			// lbl_Username
			// 
			this.lbl_Username.AutoSize = true;
			this.lbl_Username.Location = new System.Drawing.Point(44, 145);
			this.lbl_Username.Name = "lbl_Username";
			this.lbl_Username.Size = new System.Drawing.Size(90, 21);
			this.lbl_Username.TabIndex = 0;
			this.lbl_Username.Text = "UserName";
			// 
			// lbl_Role
			// 
			this.lbl_Role.AutoSize = true;
			this.lbl_Role.Location = new System.Drawing.Point(32, 178);
			this.lbl_Role.Name = "lbl_Role";
			this.lbl_Role.Size = new System.Drawing.Size(116, 21);
			this.lbl_Role.TabIndex = 0;
			this.lbl_Role.Text = "Administrator";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(48, 48);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(80, 80);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// panelTitle
			// 
			this.panelTitle.Controls.Add(this.lbl_Title);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitle.Location = new System.Drawing.Point(230, 0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(1107, 60);
			this.panelTitle.TabIndex = 2;
			// 
			// lbl_Title
			// 
			this.lbl_Title.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.Location = new System.Drawing.Point(423, 12);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(200, 30);
			this.lbl_Title.TabIndex = 1;
			this.lbl_Title.Text = "TitleName";
			this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelMain
			// 
			this.panelMain.BackColor = System.Drawing.Color.PowderBlue;
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(230, 60);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(1107, 802);
			this.panelMain.TabIndex = 3;
			// 
			// btn_Supplier
			// 
			this.btn_Supplier.BackColor = System.Drawing.Color.Fuchsia;
			this.btn_Supplier.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_Supplier.FlatAppearance.BorderSize = 0;
			this.btn_Supplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Supplier.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Supplier.ForeColor = System.Drawing.Color.White;
			this.btn_Supplier.Location = new System.Drawing.Point(0, 439);
			this.btn_Supplier.Name = "btn_Supplier";
			this.btn_Supplier.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btn_Supplier.Size = new System.Drawing.Size(230, 45);
			this.btn_Supplier.TabIndex = 3;
			this.btn_Supplier.Text = "Supplier";
			this.btn_Supplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Supplier.UseVisualStyleBackColor = false;
			this.btn_Supplier.Click += new System.EventHandler(this.btn_Supplier_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Fuchsia;
			this.button1.Dock = System.Windows.Forms.DockStyle.Top;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(0, 484);
			this.button1.Name = "button1";
			this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.button1.Size = new System.Drawing.Size(230, 45);
			this.button1.TabIndex = 8;
			this.button1.Text = "Product";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 529);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(230, 136);
			this.panel1.TabIndex = 9;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
			this.button2.Dock = System.Windows.Forms.DockStyle.Top;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(0, 90);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
			this.button2.Size = new System.Drawing.Size(230, 46);
			this.button2.TabIndex = 5;
			this.button2.Text = "Brand";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
			this.button3.Dock = System.Windows.Forms.DockStyle.Top;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(0, 45);
			this.button3.Name = "button3";
			this.button3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
			this.button3.Size = new System.Drawing.Size(230, 45);
			this.button3.TabIndex = 4;
			this.button3.Text = "Category";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
			this.button4.Dock = System.Windows.Forms.DockStyle.Top;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(0, 0);
			this.button4.Name = "button4";
			this.button4.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
			this.button4.Size = new System.Drawing.Size(230, 45);
			this.button4.TabIndex = 3;
			this.button4.Text = "Product List";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.UseVisualStyleBackColor = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aqua;
			this.ClientSize = new System.Drawing.Size(1337, 862);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.panelTitle);
			this.Controls.Add(this.panelSlide);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Point Of Sales";
			this.panelSlide.ResumeLayout(false);
			this.panelSubProduct.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			this.panelLogo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelTitle.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelSlide;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Panel panelSubProduct;
		private System.Windows.Forms.Button Productbtn_ProductList;
		private System.Windows.Forms.Button btn_Product;
		private System.Windows.Forms.Button btn_Dashboard;
		private System.Windows.Forms.Button Productbtn_Brand;
		private System.Windows.Forms.Button Productbtn_Category;
		private System.Windows.Forms.Button btn_Logout;
		private System.Windows.Forms.Label lbl_Role;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbl_Username;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_Supplier;
	}
}

