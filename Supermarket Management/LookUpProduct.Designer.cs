﻿namespace Supermarket_Management
{
	partial class LookUpProduct
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookUpProduct));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtSearch = new MetroFramework.Controls.MetroTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvProduct = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Select = new System.Windows.Forms.DataGridViewImageColumn();
			this.btnClose = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewImageColumn2
			// 
			this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewImageColumn2.HeaderText = "";
			this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
			this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewImageColumn1.HeaderText = "";
			this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
			this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.txtSearch);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 533);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1000, 67);
			this.panel1.TabIndex = 4;
			// 
			// txtSearch
			// 
			// 
			// 
			// 
			this.txtSearch.CustomButton.Image = null;
			this.txtSearch.CustomButton.Location = new System.Drawing.Point(293, 1);
			this.txtSearch.CustomButton.Name = "";
			this.txtSearch.CustomButton.Size = new System.Drawing.Size(35, 35);
			this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtSearch.CustomButton.TabIndex = 1;
			this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtSearch.CustomButton.UseSelectable = true;
			this.txtSearch.CustomButton.Visible = false;
			this.txtSearch.DisplayIcon = true;
			this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
			this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
			this.txtSearch.Lines = new string[0];
			this.txtSearch.Location = new System.Drawing.Point(294, 15);
			this.txtSearch.MaxLength = 32767;
			this.txtSearch.Multiline = true;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.PasswordChar = '\0';
			this.txtSearch.PromptText = "Search here ....";
			this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtSearch.SelectedText = "";
			this.txtSearch.SelectionLength = 0;
			this.txtSearch.SelectionStart = 0;
			this.txtSearch.ShortcutsEnabled = true;
			this.txtSearch.Size = new System.Drawing.Size(329, 37);
			this.txtSearch.TabIndex = 2;
			this.txtSearch.UseSelectable = true;
			this.txtSearch.WaterMark = "Search here ....";
			this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtSearch.WaterMarkFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(27, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Search Product";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dgvProduct
			// 
			this.dgvProduct.AllowUserToAddRows = false;
			this.dgvProduct.AllowUserToDeleteRows = false;
			this.dgvProduct.AllowUserToResizeColumns = false;
			this.dgvProduct.AllowUserToResizeRows = false;
			this.dgvProduct.BackgroundColor = System.Drawing.Color.PaleTurquoise;
			this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Select});
			this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvProduct.Location = new System.Drawing.Point(0, 0);
			this.dgvProduct.Name = "dgvProduct";
			this.dgvProduct.ReadOnly = true;
			this.dgvProduct.RowHeadersVisible = false;
			this.dgvProduct.Size = new System.Drawing.Size(1000, 600);
			this.dgvProduct.TabIndex = 5;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column1.HeaderText = "No";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 55;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column2.HeaderText = "PCode";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 85;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column3.HeaderText = "Barcode";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 98;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column4.HeaderText = "Description";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column5.HeaderText = "Brand";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 77;
			// 
			// Column6
			// 
			this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column6.HeaderText = "Category";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 104;
			// 
			// Column7
			// 
			this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.Column7.DefaultCellStyle = dataGridViewCellStyle5;
			this.Column7.HeaderText = "Price";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 71;
			// 
			// Column8
			// 
			this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Column8.DefaultCellStyle = dataGridViewCellStyle6;
			this.Column8.HeaderText = "Qty";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Width = 60;
			// 
			// Select
			// 
			this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Select.HeaderText = "";
			this.Select.Image = ((System.Drawing.Image)(resources.GetObject("Select.Image")));
			this.Select.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.Select.Name = "Select";
			this.Select.ReadOnly = true;
			this.Select.Width = 5;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.Red;
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnClose.FlatAppearance.BorderSize = 2;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(923, 19);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(65, 33);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// LookUpProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 600);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgvProduct);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "LookUpProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LookUpProduct";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.Panel panel1;
		private MetroFramework.Controls.MetroTextBox txtSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvProduct;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewImageColumn Select;
		public System.Windows.Forms.Button btnClose;
	}
}