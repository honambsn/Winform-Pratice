﻿namespace Supermarket_Management
{
	partial class Discount
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discount));
			this.panel1 = new System.Windows.Forms.Panel();
			this.picClose = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDiscount = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDiscountAmount = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(750, 50);
			this.panel1.TabIndex = 7;
			// 
			// picClose
			// 
			this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
			this.picClose.Location = new System.Drawing.Point(721, 3);
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
			this.label1.Size = new System.Drawing.Size(74, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Discount";
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(12, 238);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(24, 20);
			this.lblID.TabIndex = 13;
			this.lblID.Text = "Id";
			this.lblID.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Total Price:";
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
			this.btnSave.Location = new System.Drawing.Point(621, 263);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 35);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Confirm";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotalPrice.Enabled = false;
			this.txtTotalPrice.Location = new System.Drawing.Point(149, 73);
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.Size = new System.Drawing.Size(572, 26);
			this.txtTotalPrice.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 20);
			this.label3.TabIndex = 15;
			this.label3.Text = "Discount (%):";
			// 
			// txtDiscount
			// 
			this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDiscount.Location = new System.Drawing.Point(149, 133);
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.Size = new System.Drawing.Size(572, 26);
			this.txtDiscount.TabIndex = 14;
			this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 193);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 20);
			this.label4.TabIndex = 17;
			this.label4.Text = "Discount Amount:";
			// 
			// txtDiscountAmount
			// 
			this.txtDiscountAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDiscountAmount.Enabled = false;
			this.txtDiscountAmount.Location = new System.Drawing.Point(149, 193);
			this.txtDiscountAmount.Name = "txtDiscountAmount";
			this.txtDiscountAmount.Size = new System.Drawing.Size(572, 26);
			this.txtDiscountAmount.TabIndex = 16;
			// 
			// Discount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(750, 310);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtDiscountAmount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDiscount);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtTotalPrice);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Discount";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DISCOUNT";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Discount_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox picClose;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Button btnSave;
		public System.Windows.Forms.TextBox txtTotalPrice;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox txtDiscount;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox txtDiscountAmount;
	}
}