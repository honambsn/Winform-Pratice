﻿namespace Supermarket_Management
{
	partial class Brand
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Brand));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvBrand = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
			this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 481);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(984, 80);
			this.panel1.TabIndex = 0;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.Location = new System.Drawing.Point(918, 26);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(54, 31);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Image = global::Supermarket_Management.Properties.Resources.icons8_brand_30;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(29, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Manage Brand";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dgvBrand
			// 
			this.dgvBrand.AllowUserToAddRows = false;
			this.dgvBrand.AllowUserToDeleteRows = false;
			this.dgvBrand.AllowUserToResizeColumns = false;
			this.dgvBrand.AllowUserToResizeRows = false;
			this.dgvBrand.BackgroundColor = System.Drawing.Color.PaleTurquoise;
			this.dgvBrand.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBrand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Edit,
            this.Delete});
			this.dgvBrand.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvBrand.Location = new System.Drawing.Point(0, 0);
			this.dgvBrand.Name = "dgvBrand";
			this.dgvBrand.ReadOnly = true;
			this.dgvBrand.RowHeadersVisible = false;
			this.dgvBrand.Size = new System.Drawing.Size(984, 481);
			this.dgvBrand.TabIndex = 1;
			this.dgvBrand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrand_CellContentClick);
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
			this.Column2.HeaderText = "ID";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Visible = false;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.HeaderText = "Brand";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Edit
			// 
			this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Edit.HeaderText = "";
			this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
			this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.Edit.Name = "Edit";
			this.Edit.ReadOnly = true;
			this.Edit.Width = 5;
			// 
			// Delete
			// 
			this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Delete.HeaderText = "";
			this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
			this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.Delete.Name = "Delete";
			this.Delete.ReadOnly = true;
			this.Delete.Width = 5;
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewImageColumn1.HeaderText = "";
			this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
			this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			// 
			// dataGridViewImageColumn2
			// 
			this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewImageColumn2.HeaderText = "";
			this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
			this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			// 
			// Brand
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.ControlBox = false;
			this.Controls.Add(this.dgvBrand);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Brand";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Brand";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvBrand;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewImageColumn Edit;
		private System.Windows.Forms.DataGridViewImageColumn Delete;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
	}
}