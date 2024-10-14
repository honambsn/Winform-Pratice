namespace Supermarket_Management
{
	partial class SupplierModule
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierModule));
			this.panel1 = new System.Windows.Forms.Panel();
			this.picClose = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtSupplier = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtContact = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtFax = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblID = new System.Windows.Forms.Label();
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
			this.label1.Size = new System.Drawing.Size(135, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Supplier Module";
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
			this.btnCancel.Location = new System.Drawing.Point(621, 447);
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
			this.btnUpdate.Location = new System.Drawing.Point(508, 447);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(100, 35);
			this.btnUpdate.TabIndex = 11;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Supplier Name:";
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
			this.btnSave.Location = new System.Drawing.Point(395, 447);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 35);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtSupplier
			// 
			this.txtSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSupplier.Location = new System.Drawing.Point(149, 95);
			this.txtSupplier.Name = "txtSupplier";
			this.txtSupplier.Size = new System.Drawing.Size(572, 26);
			this.txtSupplier.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 168);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 20);
			this.label3.TabIndex = 13;
			this.label3.Text = "Address:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 235);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(127, 20);
			this.label4.TabIndex = 14;
			this.label4.Text = "Contact Person:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 302);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 20);
			this.label5.TabIndex = 15;
			this.label5.Text = "Phone No:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 369);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(117, 20);
			this.label6.TabIndex = 16;
			this.label6.Text = "E-mail Address:";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(410, 302);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 20);
			this.label7.TabIndex = 17;
			this.label7.Text = "Fax No:";
			// 
			// txtAddress
			// 
			this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAddress.Location = new System.Drawing.Point(149, 162);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(572, 26);
			this.txtAddress.TabIndex = 18;
			// 
			// txtContact
			// 
			this.txtContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtContact.Location = new System.Drawing.Point(149, 229);
			this.txtContact.Name = "txtContact";
			this.txtContact.Size = new System.Drawing.Size(572, 26);
			this.txtContact.TabIndex = 19;
			// 
			// txtPhone
			// 
			this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPhone.Location = new System.Drawing.Point(149, 296);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(229, 26);
			this.txtPhone.TabIndex = 20;
			// 
			// txtFax
			// 
			this.txtFax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFax.Location = new System.Drawing.Point(492, 296);
			this.txtFax.Name = "txtFax";
			this.txtFax.Size = new System.Drawing.Size(229, 26);
			this.txtFax.TabIndex = 21;
			// 
			// txtEmail
			// 
			this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEmail.Location = new System.Drawing.Point(149, 363);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(572, 26);
			this.txtEmail.TabIndex = 22;
			// 
			// lblID
			// 
			this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(13, 455);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(24, 20);
			this.lblID.TabIndex = 23;
			this.lblID.Text = "Id";
			this.lblID.Visible = false;
			// 
			// SupplierModule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(743, 493);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtFax);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtContact);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtSupplier);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "SupplierModule";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SupplierModule";
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
		public System.Windows.Forms.Button btnCancel;
		public System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Button btnSave;
		public System.Windows.Forms.TextBox txtSupplier;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.TextBox txtAddress;
		public System.Windows.Forms.TextBox txtContact;
		public System.Windows.Forms.TextBox txtPhone;
		public System.Windows.Forms.TextBox txtFax;
		public System.Windows.Forms.TextBox txtEmail;
		public System.Windows.Forms.Label lblID;
	}
}