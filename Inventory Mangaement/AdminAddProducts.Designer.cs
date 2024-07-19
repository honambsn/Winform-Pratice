namespace Inventory_Mangaement
{
	partial class AdminAddProducts
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btn_clearProduct = new System.Windows.Forms.Button();
			this.btn_removeProduct = new System.Windows.Forms.Button();
			this.btn_updateProduct = new System.Windows.Forms.Button();
			this.btn_addProduct = new System.Windows.Forms.Button();
			this.btn_Import = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.productImageView = new System.Windows.Forms.PictureBox();
			this.cb_ProductStatus = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_ProductStock = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_ProductPrice = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cb_ProductCategory = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_ProductName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_ProductID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productImageView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(15, 30);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1050, 390);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "All Products";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.btn_clearProduct);
			this.panel2.Controls.Add(this.btn_removeProduct);
			this.panel2.Controls.Add(this.btn_updateProduct);
			this.panel2.Controls.Add(this.btn_addProduct);
			this.panel2.Controls.Add(this.btn_Import);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.cb_ProductStatus);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.txt_ProductStock);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.txt_ProductPrice);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.cb_ProductCategory);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txt_ProductName);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txt_ProductID);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(15, 450);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1050, 195);
			this.panel2.TabIndex = 1;
			// 
			// btn_clearProduct
			// 
			this.btn_clearProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
			this.btn_clearProduct.FlatAppearance.BorderSize = 0;
			this.btn_clearProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.btn_clearProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.btn_clearProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_clearProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_clearProduct.ForeColor = System.Drawing.Color.White;
			this.btn_clearProduct.Location = new System.Drawing.Point(910, 115);
			this.btn_clearProduct.Name = "btn_clearProduct";
			this.btn_clearProduct.Size = new System.Drawing.Size(100, 35);
			this.btn_clearProduct.TabIndex = 19;
			this.btn_clearProduct.Text = "Clear";
			this.btn_clearProduct.UseVisualStyleBackColor = false;
			this.btn_clearProduct.Click += new System.EventHandler(this.btn_clearProduct_Click);
			// 
			// btn_removeProduct
			// 
			this.btn_removeProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
			this.btn_removeProduct.FlatAppearance.BorderSize = 0;
			this.btn_removeProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.btn_removeProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.btn_removeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_removeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_removeProduct.ForeColor = System.Drawing.Color.White;
			this.btn_removeProduct.Location = new System.Drawing.Point(910, 40);
			this.btn_removeProduct.Name = "btn_removeProduct";
			this.btn_removeProduct.Size = new System.Drawing.Size(100, 35);
			this.btn_removeProduct.TabIndex = 18;
			this.btn_removeProduct.Text = "Remove";
			this.btn_removeProduct.UseVisualStyleBackColor = false;
			// 
			// btn_updateProduct
			// 
			this.btn_updateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
			this.btn_updateProduct.FlatAppearance.BorderSize = 0;
			this.btn_updateProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.btn_updateProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.btn_updateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_updateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_updateProduct.ForeColor = System.Drawing.Color.White;
			this.btn_updateProduct.Location = new System.Drawing.Point(768, 115);
			this.btn_updateProduct.Name = "btn_updateProduct";
			this.btn_updateProduct.Size = new System.Drawing.Size(100, 35);
			this.btn_updateProduct.TabIndex = 17;
			this.btn_updateProduct.Text = "Update";
			this.btn_updateProduct.UseVisualStyleBackColor = false;
			// 
			// btn_addProduct
			// 
			this.btn_addProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
			this.btn_addProduct.FlatAppearance.BorderSize = 0;
			this.btn_addProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.btn_addProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.btn_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_addProduct.ForeColor = System.Drawing.Color.White;
			this.btn_addProduct.Location = new System.Drawing.Point(768, 40);
			this.btn_addProduct.Name = "btn_addProduct";
			this.btn_addProduct.Size = new System.Drawing.Size(100, 35);
			this.btn_addProduct.TabIndex = 16;
			this.btn_addProduct.Text = "Add";
			this.btn_addProduct.UseVisualStyleBackColor = false;
			this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
			// 
			// btn_Import
			// 
			this.btn_Import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
			this.btn_Import.FlatAppearance.BorderSize = 0;
			this.btn_Import.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.btn_Import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
			this.btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Import.ForeColor = System.Drawing.Color.White;
			this.btn_Import.Location = new System.Drawing.Point(610, 145);
			this.btn_Import.Name = "btn_Import";
			this.btn_Import.Size = new System.Drawing.Size(115, 35);
			this.btn_Import.TabIndex = 0;
			this.btn_Import.Text = "Import";
			this.btn_Import.UseVisualStyleBackColor = false;
			this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DarkGray;
			this.panel3.Controls.Add(this.productImageView);
			this.panel3.Location = new System.Drawing.Point(610, 15);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(115, 115);
			this.panel3.TabIndex = 15;
			// 
			// productImageView
			// 
			this.productImageView.Location = new System.Drawing.Point(0, 0);
			this.productImageView.Name = "productImageView";
			this.productImageView.Size = new System.Drawing.Size(115, 115);
			this.productImageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.productImageView.TabIndex = 16;
			this.productImageView.TabStop = false;
			// 
			// cb_ProductStatus
			// 
			this.cb_ProductStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_ProductStatus.FormattingEnabled = true;
			this.cb_ProductStatus.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
			this.cb_ProductStatus.Location = new System.Drawing.Point(407, 136);
			this.cb_ProductStatus.Name = "cb_ProductStatus";
			this.cb_ProductStatus.Size = new System.Drawing.Size(150, 28);
			this.cb_ProductStatus.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(351, 140);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 18);
			this.label7.TabIndex = 13;
			this.label7.Text = "Status";
			// 
			// txt_ProductStock
			// 
			this.txt_ProductStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_ProductStock.Location = new System.Drawing.Point(407, 82);
			this.txt_ProductStock.Name = "txt_ProductStock";
			this.txt_ProductStock.Size = new System.Drawing.Size(150, 26);
			this.txt_ProductStock.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(350, 86);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(51, 18);
			this.label6.TabIndex = 11;
			this.label6.Text = "Stock:";
			// 
			// txt_ProductPrice
			// 
			this.txt_ProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_ProductPrice.Location = new System.Drawing.Point(407, 28);
			this.txt_ProductPrice.Name = "txt_ProductPrice";
			this.txt_ProductPrice.Size = new System.Drawing.Size(150, 26);
			this.txt_ProductPrice.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(333, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 18);
			this.label5.TabIndex = 9;
			this.label5.Text = "Price ($):";
			// 
			// cb_ProductCategory
			// 
			this.cb_ProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_ProductCategory.FormattingEnabled = true;
			this.cb_ProductCategory.Location = new System.Drawing.Point(143, 136);
			this.cb_ProductCategory.Name = "cb_ProductCategory";
			this.cb_ProductCategory.Size = new System.Drawing.Size(150, 28);
			this.cb_ProductCategory.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(65, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "Category:";
			// 
			// txt_ProductName
			// 
			this.txt_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_ProductName.Location = new System.Drawing.Point(143, 82);
			this.txt_ProductName.Name = "txt_ProductName";
			this.txt_ProductName.Size = new System.Drawing.Size(150, 26);
			this.txt_ProductName.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(18, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Product\'s Name:";
			// 
			// txt_ProductID
			// 
			this.txt_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_ProductID.Location = new System.Drawing.Point(143, 28);
			this.txt_ProductID.Name = "txt_ProductID";
			this.txt_ProductID.Size = new System.Drawing.Size(150, 26);
			this.txt_ProductID.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(55, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Product ID:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.Location = new System.Drawing.Point(15, 60);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(1020, 300);
			this.dataGridView1.TabIndex = 14;
			// 
			// AdminAddProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "AdminAddProducts";
			this.Size = new System.Drawing.Size(1080, 675);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.productImageView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_ProductStock;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_ProductPrice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cb_ProductCategory;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_ProductName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_ProductID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cb_ProductStatus;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btn_Import;
		private System.Windows.Forms.PictureBox productImageView;
		private System.Windows.Forms.Button btn_clearProduct;
		private System.Windows.Forms.Button btn_removeProduct;
		private System.Windows.Forms.Button btn_updateProduct;
		private System.Windows.Forms.Button btn_addProduct;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
