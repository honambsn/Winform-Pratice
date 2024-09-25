namespace Supermarket_Management
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
			this.panelSlide = new System.Windows.Forms.Panel();
			this.paneLogo = new System.Windows.Forms.Panel();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.panelMain = new System.Windows.Forms.Panel();
			this.btnDashboard = new System.Windows.Forms.Button();
			this.btn_Product = new System.Windows.Forms.Button();
			this.panelSubProduct = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.panelSubInStock = new System.Windows.Forms.Panel();
			this.btn_InStock = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.panelSlide.SuspendLayout();
			this.panelSubProduct.SuspendLayout();
			this.panelSubInStock.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelSlide
			// 
			this.panelSlide.Controls.Add(this.panelSubInStock);
			this.panelSlide.Controls.Add(this.panelSubProduct);
			this.panelSlide.Controls.Add(this.btn_Product);
			this.panelSlide.Controls.Add(this.btnDashboard);
			this.panelSlide.Controls.Add(this.paneLogo);
			this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSlide.Location = new System.Drawing.Point(0, 0);
			this.panelSlide.Name = "panelSlide";
			this.panelSlide.Size = new System.Drawing.Size(200, 661);
			this.panelSlide.TabIndex = 0;
			// 
			// paneLogo
			// 
			this.paneLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.paneLogo.Location = new System.Drawing.Point(0, 0);
			this.paneLogo.Name = "paneLogo";
			this.paneLogo.Size = new System.Drawing.Size(200, 170);
			this.paneLogo.TabIndex = 1;
			// 
			// panelTitle
			// 
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitle.Location = new System.Drawing.Point(200, 0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(984, 40);
			this.panelTitle.TabIndex = 2;
			// 
			// panelMain
			// 
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(200, 40);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(984, 621);
			this.panelMain.TabIndex = 3;
			// 
			// btnDashboard
			// 
			this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnDashboard.FlatAppearance.BorderSize = 0;
			this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDashboard.ForeColor = System.Drawing.Color.White;
			this.btnDashboard.Location = new System.Drawing.Point(0, 170);
			this.btnDashboard.Name = "btnDashboard";
			this.btnDashboard.Size = new System.Drawing.Size(200, 45);
			this.btnDashboard.TabIndex = 0;
			this.btnDashboard.Text = "Dashboard";
			this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDashboard.UseVisualStyleBackColor = true;
			// 
			// btn_Product
			// 
			this.btn_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
			this.btn_Product.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_Product.FlatAppearance.BorderSize = 0;
			this.btn_Product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Product.ForeColor = System.Drawing.Color.White;
			this.btn_Product.Location = new System.Drawing.Point(0, 215);
			this.btn_Product.Name = "btn_Product";
			this.btn_Product.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btn_Product.Size = new System.Drawing.Size(200, 45);
			this.btn_Product.TabIndex = 2;
			this.btn_Product.Text = "Product";
			this.btn_Product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Product.UseVisualStyleBackColor = false;
			// 
			// panelSubProduct
			// 
			this.panelSubProduct.Controls.Add(this.button4);
			this.panelSubProduct.Controls.Add(this.button3);
			this.panelSubProduct.Controls.Add(this.button2);
			this.panelSubProduct.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelSubProduct.Location = new System.Drawing.Point(0, 260);
			this.panelSubProduct.Name = "panelSubProduct";
			this.panelSubProduct.Size = new System.Drawing.Size(200, 136);
			this.panelSubProduct.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
			this.button2.Dock = System.Windows.Forms.DockStyle.Top;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(0, 0);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
			this.button2.Size = new System.Drawing.Size(200, 45);
			this.button2.TabIndex = 3;
			this.button2.Text = "Product List";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
			this.button3.Dock = System.Windows.Forms.DockStyle.Top;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(0, 45);
			this.button3.Name = "button3";
			this.button3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
			this.button3.Size = new System.Drawing.Size(200, 45);
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
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(0, 90);
			this.button4.Name = "button4";
			this.button4.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
			this.button4.Size = new System.Drawing.Size(200, 45);
			this.button4.TabIndex = 5;
			this.button4.Text = "Brand";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.UseVisualStyleBackColor = false;
			// 
			// panelSubInStock
			// 
			this.panelSubInStock.Controls.Add(this.button5);
			this.panelSubInStock.Controls.Add(this.button6);
			this.panelSubInStock.Controls.Add(this.btn_InStock);
			this.panelSubInStock.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelSubInStock.Location = new System.Drawing.Point(0, 396);
			this.panelSubInStock.Name = "panelSubInStock";
			this.panelSubInStock.Size = new System.Drawing.Size(200, 137);
			this.panelSubInStock.TabIndex = 0;
			// 
			// btn_InStock
			// 
			this.btn_InStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
			this.btn_InStock.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_InStock.FlatAppearance.BorderSize = 0;
			this.btn_InStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_InStock.ForeColor = System.Drawing.Color.White;
			this.btn_InStock.Location = new System.Drawing.Point(0, 0);
			this.btn_InStock.Name = "btn_InStock";
			this.btn_InStock.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btn_InStock.Size = new System.Drawing.Size(200, 45);
			this.btn_InStock.TabIndex = 3;
			this.btn_InStock.Text = "In Stock";
			this.btn_InStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_InStock.UseVisualStyleBackColor = false;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
			this.button5.Dock = System.Windows.Forms.DockStyle.Top;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button5.ForeColor = System.Drawing.Color.White;
			this.button5.Location = new System.Drawing.Point(0, 90);
			this.button5.Name = "button5";
			this.button5.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
			this.button5.Size = new System.Drawing.Size(200, 45);
			this.button5.TabIndex = 7;
			this.button5.Text = "Stock Adjustment";
			this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.UseVisualStyleBackColor = false;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
			this.button6.Dock = System.Windows.Forms.DockStyle.Top;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Location = new System.Drawing.Point(0, 45);
			this.button6.Name = "button6";
			this.button6.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
			this.button6.Size = new System.Drawing.Size(200, 45);
			this.button6.TabIndex = 6;
			this.button6.Text = "Stock Entry";
			this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.UseVisualStyleBackColor = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
			this.ClientSize = new System.Drawing.Size(1184, 661);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.panelTitle);
			this.Controls.Add(this.panelSlide);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Point Of Sales";
			this.panelSlide.ResumeLayout(false);
			this.panelSubProduct.ResumeLayout(false);
			this.panelSubInStock.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelSlide;
		private System.Windows.Forms.Panel paneLogo;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Panel panelSubProduct;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btn_Product;
		private System.Windows.Forms.Button btnDashboard;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel panelSubInStock;
		private System.Windows.Forms.Button btn_InStock;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
	}
}

