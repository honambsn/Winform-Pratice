﻿namespace Supermarket_Management
{
	partial class CancelOrder
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
			System.Windows.Forms.Panel panel1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelOrder));
			this.picClose = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtPCode = new System.Windows.Forms.TextBox();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtTransno = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtDisc = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtCancelBy = new System.Windows.Forms.TextBox();
			this.txtVoidBy = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.cboInventory = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtReason = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.btnCCancel = new System.Windows.Forms.Button();
			this.udCancelQty = new System.Windows.Forms.NumericUpDown();
			panel1 = new System.Windows.Forms.Panel();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udCancelQty)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
			panel1.Controls.Add(this.picClose);
			panel1.Controls.Add(this.label1);
			panel1.Dock = System.Windows.Forms.DockStyle.Top;
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(956, 50);
			panel1.TabIndex = 9;
			// 
			// picClose
			// 
			this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
			this.picClose.Location = new System.Drawing.Point(927, 3);
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
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cancel Order Detail";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "ID:";
			// 
			// txtId
			// 
			this.txtId.Enabled = false;
			this.txtId.Location = new System.Drawing.Point(169, 111);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(188, 26);
			this.txtId.TabIndex = 11;
			// 
			// txtPCode
			// 
			this.txtPCode.Enabled = false;
			this.txtPCode.Location = new System.Drawing.Point(169, 172);
			this.txtPCode.Name = "txtPCode";
			this.txtPCode.Size = new System.Drawing.Size(188, 26);
			this.txtPCode.TabIndex = 12;
			// 
			// txtDesc
			// 
			this.txtDesc.Enabled = false;
			this.txtDesc.Location = new System.Drawing.Point(169, 233);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(188, 87);
			this.txtDesc.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 175);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 20);
			this.label3.TabIndex = 14;
			this.label3.Text = "Product Code:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 236);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 20);
			this.label4.TabIndex = 15;
			this.label4.Text = "Description:";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(408, 236);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 20);
			this.label5.TabIndex = 21;
			this.label5.Text = "Qty / Discount:";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(408, 175);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 20);
			this.label6.TabIndex = 20;
			this.label6.Text = "Price:";
			// 
			// txtQty
			// 
			this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQty.Enabled = false;
			this.txtQty.Location = new System.Drawing.Point(555, 233);
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(119, 26);
			this.txtQty.TabIndex = 19;
			// 
			// txtPrice
			// 
			this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPrice.Enabled = false;
			this.txtPrice.Location = new System.Drawing.Point(555, 172);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(331, 26);
			this.txtPrice.TabIndex = 18;
			// 
			// txtTransno
			// 
			this.txtTransno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTransno.Enabled = false;
			this.txtTransno.Location = new System.Drawing.Point(555, 111);
			this.txtTransno.Name = "txtTransno";
			this.txtTransno.Size = new System.Drawing.Size(331, 26);
			this.txtTransno.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(408, 114);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(120, 20);
			this.label7.TabIndex = 16;
			this.label7.Text = "Transaction No:";
			// 
			// txtDisc
			// 
			this.txtDisc.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
			this.txtDisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDisc.Enabled = false;
			this.txtDisc.Location = new System.Drawing.Point(767, 236);
			this.txtDisc.Name = "txtDisc";
			this.txtDisc.Size = new System.Drawing.Size(119, 26);
			this.txtDisc.TabIndex = 22;
			// 
			// txtTotal
			// 
			this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotal.Enabled = false;
			this.txtTotal.Location = new System.Drawing.Point(555, 294);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(331, 26);
			this.txtTotal.TabIndex = 23;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(408, 297);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 20);
			this.label8.TabIndex = 24;
			this.label8.Text = "Total:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.SeaGreen;
			this.label9.Location = new System.Drawing.Point(22, 71);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(85, 19);
			this.label9.TabIndex = 25;
			this.label9.Text = "SOLD ITEM";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.SeaGreen;
			this.label10.Location = new System.Drawing.Point(22, 357);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(129, 19);
			this.label10.TabIndex = 26;
			this.label10.Text = "CANCEL ITEM(S)";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(22, 538);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(143, 20);
			this.label11.TabIndex = 32;
			this.label11.Text = "Add to Inventory?";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(22, 477);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(111, 20);
			this.label12.TabIndex = 31;
			this.label12.Text = "Cancelled By:";
			// 
			// txtCancelBy
			// 
			this.txtCancelBy.Enabled = false;
			this.txtCancelBy.Location = new System.Drawing.Point(169, 474);
			this.txtCancelBy.Name = "txtCancelBy";
			this.txtCancelBy.Size = new System.Drawing.Size(188, 26);
			this.txtCancelBy.TabIndex = 29;
			// 
			// txtVoidBy
			// 
			this.txtVoidBy.Location = new System.Drawing.Point(169, 413);
			this.txtVoidBy.Name = "txtVoidBy";
			this.txtVoidBy.Size = new System.Drawing.Size(188, 26);
			this.txtVoidBy.TabIndex = 28;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(22, 416);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(68, 20);
			this.label13.TabIndex = 27;
			this.label13.Text = "Void By:";
			// 
			// cboInventory
			// 
			this.cboInventory.FormattingEnabled = true;
			this.cboInventory.Items.AddRange(new object[] {
            "Yes",
            "No"});
			this.cboInventory.Location = new System.Drawing.Point(171, 535);
			this.cboInventory.Name = "cboInventory";
			this.cboInventory.Size = new System.Drawing.Size(186, 28);
			this.cboInventory.TabIndex = 33;
			this.cboInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboInventory_KeyPress);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(408, 477);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(83, 20);
			this.label14.TabIndex = 37;
			this.label14.Text = "Reason(s):";
			// 
			// txtReason
			// 
			this.txtReason.Location = new System.Drawing.Point(555, 474);
			this.txtReason.Multiline = true;
			this.txtReason.Name = "txtReason";
			this.txtReason.Size = new System.Drawing.Size(331, 89);
			this.txtReason.TabIndex = 36;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(408, 416);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(97, 20);
			this.label15.TabIndex = 34;
			this.label15.Text = "Cancel Qty:";
			// 
			// btnCCancel
			// 
			this.btnCCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
			this.btnCCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCCancel.FlatAppearance.BorderSize = 0;
			this.btnCCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCCancel.ForeColor = System.Drawing.Color.White;
			this.btnCCancel.Location = new System.Drawing.Point(735, 610);
			this.btnCCancel.Name = "btnCCancel";
			this.btnCCancel.Size = new System.Drawing.Size(151, 35);
			this.btnCCancel.TabIndex = 38;
			this.btnCCancel.Text = "Confirm Cancel";
			this.btnCCancel.UseVisualStyleBackColor = false;
			this.btnCCancel.Click += new System.EventHandler(this.btnCCancel_Click);
			// 
			// udCancelQty
			// 
			this.udCancelQty.Location = new System.Drawing.Point(554, 414);
			this.udCancelQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.udCancelQty.Name = "udCancelQty";
			this.udCancelQty.Size = new System.Drawing.Size(332, 26);
			this.udCancelQty.TabIndex = 39;
			this.udCancelQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// CancelOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(956, 729);
			this.Controls.Add(this.udCancelQty);
			this.Controls.Add(this.btnCCancel);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.txtReason);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.cboInventory);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtCancelBy);
			this.Controls.Add(this.txtVoidBy);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtDisc);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtQty);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.txtTransno);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDesc);
			this.Controls.Add(this.txtPCode);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label2);
			this.Controls.Add(panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "CancelOrder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cancel Order Detail";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udCancelQty)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		public System.Windows.Forms.Button btnCCancel;
		public System.Windows.Forms.TextBox txtId;
		public System.Windows.Forms.TextBox txtPCode;
		public System.Windows.Forms.TextBox txtDesc;
		public System.Windows.Forms.TextBox txtQty;
		public System.Windows.Forms.TextBox txtPrice;
		public System.Windows.Forms.TextBox txtTransno;
		public System.Windows.Forms.TextBox txtDisc;
		public System.Windows.Forms.TextBox txtTotal;
		public System.Windows.Forms.TextBox txtCancelBy;
		public System.Windows.Forms.NumericUpDown udCancelQty;
		public System.Windows.Forms.TextBox txtVoidBy;
		public System.Windows.Forms.ComboBox cboInventory;
		public System.Windows.Forms.TextBox txtReason;
	}
}