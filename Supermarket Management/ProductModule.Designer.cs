namespace Supermarket_Management
{
	partial class ProductModule
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModule));
			this.panel1 = new System.Windows.Forms.Panel();
			this.picClose = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtPCode = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtBarcode = new System.Windows.Forms.TextBox();
			this.txtPDesc = new System.Windows.Forms.TextBox();
			this.cbBrand = new System.Windows.Forms.ComboBox();
			this.cbCate = new System.Windows.Forms.ComboBox();
			this.UDReOrder = new System.Windows.Forms.NumericUpDown();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UDReOrder)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(743, 50);
			this.panel1.TabIndex = 7;
			// 
			// picClose
			// 
			this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
			this.picClose.Location = new System.Drawing.Point(714, 3);
			this.picClose.Name = "picClose";
			this.picClose.Size = new System.Drawing.Size(26, 25);
			this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picClose.TabIndex = 1;
			this.picClose.TabStop = false;
			this.picClose.Click += new System.EventHandler(this.picClose_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Product Module";
			// 
			// lblID
			// 
			this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(12, 408);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(24, 20);
			this.lblID.TabIndex = 13;
			this.lblID.Text = "Id";
			this.lblID.Visible = false;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.BackColor = System.Drawing.Color.Gray;
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(621, 401);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(100, 35);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpdate.FlatAppearance.BorderSize = 0;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(508, 401);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(100, 35);
			this.btnUpdate.TabIndex = 11;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Product Code:";
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
			this.btnSave.Location = new System.Drawing.Point(395, 401);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 35);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtPCode
			// 
			this.txtPCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.txtPCode.Location = new System.Drawing.Point(147, 101);
			this.txtPCode.Name = "txtPCode";
			this.txtPCode.Size = new System.Drawing.Size(202, 26);
			this.txtPCode.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(391, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 20);
			this.label3.TabIndex = 14;
			this.label3.Text = "Barcode:";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 162);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 20);
			this.label4.TabIndex = 15;
			this.label4.Text = "Description:";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 223);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 20);
			this.label5.TabIndex = 16;
			this.label5.Text = "Brand:";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 284);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 20);
			this.label6.TabIndex = 17;
			this.label6.Text = "Category:";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 345);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 20);
			this.label7.TabIndex = 18;
			this.label7.Text = "Price:";
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(387, 348);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(124, 20);
			this.label9.TabIndex = 19;
			this.label9.Text = "Re-Order Level:";
			// 
			// txtBarcode
			// 
			this.txtBarcode.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.txtBarcode.Location = new System.Drawing.Point(517, 101);
			this.txtBarcode.Name = "txtBarcode";
			this.txtBarcode.Size = new System.Drawing.Size(202, 26);
			this.txtBarcode.TabIndex = 20;
			// 
			// txtPDesc
			// 
			this.txtPDesc.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.txtPDesc.Location = new System.Drawing.Point(147, 161);
			this.txtPDesc.Name = "txtPDesc";
			this.txtPDesc.Size = new System.Drawing.Size(572, 26);
			this.txtPDesc.TabIndex = 21;
			// 
			// cbBrand
			// 
			this.cbBrand.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBrand.FormattingEnabled = true;
			this.cbBrand.Location = new System.Drawing.Point(147, 221);
			this.cbBrand.Name = "cbBrand";
			this.cbBrand.Size = new System.Drawing.Size(572, 28);
			this.cbBrand.TabIndex = 22;
			// 
			// cbCate
			// 
			this.cbCate.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.cbCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCate.FormattingEnabled = true;
			this.cbCate.Location = new System.Drawing.Point(147, 283);
			this.cbCate.Name = "cbCate";
			this.cbCate.Size = new System.Drawing.Size(572, 28);
			this.cbCate.TabIndex = 23;
			// 
			// UDReOrder
			// 
			this.UDReOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.UDReOrder.Location = new System.Drawing.Point(517, 346);
			this.UDReOrder.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.UDReOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.UDReOrder.Name = "UDReOrder";
			this.UDReOrder.Size = new System.Drawing.Size(202, 26);
			this.UDReOrder.TabIndex = 25;
			this.UDReOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.UDReOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// txtPrice
			// 
			this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.txtPrice.Location = new System.Drawing.Point(147, 345);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(202, 26);
			this.txtPrice.TabIndex = 26;
			// 
			// ProductModule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(743, 447);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.UDReOrder);
			this.Controls.Add(this.cbCate);
			this.Controls.Add(this.cbBrand);
			this.Controls.Add(this.txtPDesc);
			this.Controls.Add(this.txtBarcode);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtPCode);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ProductModule";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ProductModule";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UDReOrder)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox picClose;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label lblID;
		public System.Windows.Forms.Button btnCancel;
		public System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Button btnSave;
		public System.Windows.Forms.TextBox txtPCode;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		public System.Windows.Forms.TextBox txtBarcode;
		public System.Windows.Forms.TextBox txtPDesc;
		public System.Windows.Forms.TextBox txtPrice;
		public System.Windows.Forms.ComboBox cbBrand;
		public System.Windows.Forms.ComboBox cbCate;
		public System.Windows.Forms.NumericUpDown UDReOrder;
	}
}