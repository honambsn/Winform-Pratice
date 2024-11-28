namespace Supermarket_Management
{
	partial class DailySale
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailySale));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.picClose = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.dgvSold = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cancel = new System.Windows.Forms.DataGridViewImageColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cbCashier = new System.Windows.Forms.ComboBox();
			this.dtTo = new System.Windows.Forms.DateTimePicker();
			this.lblTotal = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtFrom = new System.Windows.Forms.DateTimePicker();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSold)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
			this.panel1.Controls.Add(this.picClose);
			this.panel1.Controls.Add(this.lblTitle);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(867, 50);
			this.panel1.TabIndex = 8;
			// 
			// picClose
			// 
			this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
			this.picClose.Location = new System.Drawing.Point(838, 3);
			this.picClose.Name = "picClose";
			this.picClose.Size = new System.Drawing.Size(26, 25);
			this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picClose.TabIndex = 1;
			this.picClose.TabStop = false;
			this.picClose.Visible = false;
			this.picClose.Click += new System.EventHandler(this.picClose_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(12, 16);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(86, 19);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Sold Items";
			this.lblTitle.Visible = false;
			// 
			// dgvSold
			// 
			this.dgvSold.AllowUserToAddRows = false;
			this.dgvSold.AllowUserToDeleteRows = false;
			this.dgvSold.AllowUserToResizeColumns = false;
			this.dgvSold.AllowUserToResizeRows = false;
			this.dgvSold.BackgroundColor = System.Drawing.Color.PaleTurquoise;
			this.dgvSold.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Cancel});
			this.dgvSold.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvSold.Location = new System.Drawing.Point(0, 50);
			this.dgvSold.Name = "dgvSold";
			this.dgvSold.ReadOnly = true;
			this.dgvSold.RowHeadersVisible = false;
			this.dgvSold.Size = new System.Drawing.Size(867, 431);
			this.dgvSold.TabIndex = 9;
			this.dgvSold.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSold_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column1.HeaderText = "No";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 55;
			// 
			// Column9
			// 
			this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column9.HeaderText = "ID";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			this.Column9.Visible = false;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column3.HeaderText = "Invoice#";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 102;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column2.HeaderText = "Product Code";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 138;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column4.HeaderText = "Description";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.Column7.DefaultCellStyle = dataGridViewCellStyle1;
			this.Column7.HeaderText = "Price";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 71;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
			this.Column5.HeaderText = "Qty";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 60;
			// 
			// Column6
			// 
			this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.Column6.DefaultCellStyle = dataGridViewCellStyle3;
			this.Column6.HeaderText = "Discount";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 97;
			// 
			// Column8
			// 
			this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.Column8.DefaultCellStyle = dataGridViewCellStyle4;
			this.Column8.HeaderText = "Total";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Width = 67;
			// 
			// Cancel
			// 
			this.Cancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Cancel.HeaderText = "";
			this.Cancel.Image = ((System.Drawing.Image)(resources.GetObject("Cancel.Image")));
			this.Cancel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.Cancel.Name = "Cancel";
			this.Cancel.ReadOnly = true;
			this.Cancel.Width = 5;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.cbCashier);
			this.panel2.Controls.Add(this.dtTo);
			this.panel2.Controls.Add(this.lblTotal);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.dtFrom);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 420);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(867, 61);
			this.panel2.TabIndex = 10;
			// 
			// cbCashier
			// 
			this.cbCashier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbCashier.FormattingEnabled = true;
			this.cbCashier.Location = new System.Drawing.Point(539, 16);
			this.cbCashier.Name = "cbCashier";
			this.cbCashier.Size = new System.Drawing.Size(137, 28);
			this.cbCashier.TabIndex = 22;
			this.cbCashier.Text = "Select Cashier";
			this.cbCashier.SelectedIndexChanged += new System.EventHandler(this.cbCashier_SelectedIndexChanged);
			// 
			// dtTo
			// 
			this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtTo.Location = new System.Drawing.Point(376, 17);
			this.dtTo.Name = "dtTo";
			this.dtTo.Size = new System.Drawing.Size(117, 26);
			this.dtTo.TabIndex = 21;
			this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
			// 
			// lblTotal
			// 
			this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.ForeColor = System.Drawing.Color.Red;
			this.lblTotal.Location = new System.Drawing.Point(774, 21);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(84, 19);
			this.lblTotal.TabIndex = 20;
			this.lblTotal.Text = "0.00";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(332, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 20);
			this.label3.TabIndex = 19;
			this.label3.Text = "To:";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 20);
			this.label2.TabIndex = 18;
			this.label2.Text = "Filter By Date: From";
			// 
			// dtFrom
			// 
			this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFrom.Location = new System.Drawing.Point(179, 17);
			this.dtFrom.Name = "dtFrom";
			this.dtFrom.Size = new System.Drawing.Size(117, 26);
			this.dtFrom.TabIndex = 17;
			this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
			// 
			// DailySale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(867, 481);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.dgvSold);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "DailySale";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Select Cashier";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DailySale_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSold)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.DataGridView dgvSold;
		public System.Windows.Forms.PictureBox picClose;
		public System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox cbCashier;
		private System.Windows.Forms.DateTimePicker dtTo;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtFrom;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewImageColumn Cancel;
	}
}