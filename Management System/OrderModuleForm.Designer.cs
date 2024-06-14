namespace Management_System
{
	partial class OrderModuleForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderModuleForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCName = new System.Windows.Forms.TextBox();
			this.txtCId = new System.Windows.Forms.Label();
			this.textCid = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSearchCust = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvCustomer = new System.Windows.Forms.DataGridView();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
			this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
			this.panel3 = new System.Windows.Forms.Panel();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.dgvProduct = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label11 = new System.Windows.Forms.Label();
			this.txtPName = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPId = new System.Windows.Forms.TextBox();
			this.txtSearchProd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
			this.pictureBoxClose.Location = new System.Drawing.Point(1149, 0);
			this.pictureBoxClose.Name = "pictureBoxClose";
			this.pictureBoxClose.Size = new System.Drawing.Size(25, 22);
			this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxClose.TabIndex = 9;
			this.pictureBoxClose.TabStop = false;
			this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.panel1.Controls.Add(this.pictureBoxClose);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1174, 40);
			this.panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Order Module";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.txtCName);
			this.panel2.Controls.Add(this.txtCId);
			this.panel2.Controls.Add(this.textCid);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txtSearchCust);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.dgvCustomer);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 40);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(328, 578);
			this.panel2.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(38, 460);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(107, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "Customer Name:";
			// 
			// txtCName
			// 
			this.txtCName.Enabled = false;
			this.txtCName.Location = new System.Drawing.Point(41, 480);
			this.txtCName.Name = "txtCName";
			this.txtCName.Size = new System.Drawing.Size(268, 22);
			this.txtCName.TabIndex = 10;
			// 
			// txtCId
			// 
			this.txtCId.AutoSize = true;
			this.txtCId.Location = new System.Drawing.Point(38, 394);
			this.txtCId.Name = "txtCId";
			this.txtCId.Size = new System.Drawing.Size(83, 17);
			this.txtCId.TabIndex = 9;
			this.txtCId.Text = "Customer ID:";
			// 
			// textCid
			// 
			this.textCid.Enabled = false;
			this.textCid.Location = new System.Drawing.Point(41, 414);
			this.textCid.Name = "textCid";
			this.textCid.Size = new System.Drawing.Size(268, 22);
			this.textCid.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(38, 321);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Search box:";
			// 
			// txtSearchCust
			// 
			this.txtSearchCust.Location = new System.Drawing.Point(142, 318);
			this.txtSearchCust.Name = "txtSearchCust";
			this.txtSearchCust.Size = new System.Drawing.Size(167, 22);
			this.txtSearchCust.TabIndex = 6;
			this.txtSearchCust.TextChanged += new System.EventHandler(this.txtSearchCust_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Teal;
			this.label2.Location = new System.Drawing.Point(12, 353);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "CUSTOMER";
			// 
			// dgvCustomer
			// 
			this.dgvCustomer.AllowUserToAddRows = false;
			this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Edit,
            this.Delete});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvCustomer.EnableHeadersVisualStyles = false;
			this.dgvCustomer.Location = new System.Drawing.Point(0, 0);
			this.dgvCustomer.Name = "dgvCustomer";
			this.dgvCustomer.RowHeadersVisible = false;
			this.dgvCustomer.ShowRowErrors = false;
			this.dgvCustomer.Size = new System.Drawing.Size(328, 312);
			this.dgvCustomer.TabIndex = 5;
			this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
			// 
			// Column5
			// 
			this.Column5.HeaderText = "No";
			this.Column5.Name = "Column5";
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column1.HeaderText = "Customer ID";
			this.Column1.Name = "Column1";
			this.Column1.Width = 105;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column2.HeaderText = "Name";
			this.Column2.Name = "Column2";
			this.Column2.Width = 69;
			// 
			// Edit
			// 
			this.Edit.HeaderText = "";
			this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
			this.Edit.Name = "Edit";
			this.Edit.Width = 5;
			// 
			// Delete
			// 
			this.Delete.HeaderText = "";
			this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
			this.Delete.Name = "Delete";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.numericUpDown1);
			this.panel3.Controls.Add(this.dgvProduct);
			this.panel3.Controls.Add(this.btnClear);
			this.panel3.Controls.Add(this.btnUpdate);
			this.panel3.Controls.Add(this.btnSave);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Controls.Add(this.dateTimePicker1);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.txtPName);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.txtTotal);
			this.panel3.Controls.Add(this.txtPrice);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.txtPId);
			this.panel3.Controls.Add(this.txtSearchProd);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(347, 40);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(827, 578);
			this.panel3.TabIndex = 3;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(548, 449);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(267, 22);
			this.numericUpDown1.TabIndex = 26;
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// dgvProduct
			// 
			this.dgvProduct.AllowUserToAddRows = false;
			this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Category});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvProduct.EnableHeadersVisualStyles = false;
			this.dgvProduct.Location = new System.Drawing.Point(0, 0);
			this.dgvProduct.Margin = new System.Windows.Forms.Padding(4);
			this.dgvProduct.Name = "dgvProduct";
			this.dgvProduct.RowHeadersVisible = false;
			this.dgvProduct.Size = new System.Drawing.Size(827, 312);
			this.dgvProduct.TabIndex = 7;
			this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn1.HeaderText = "No";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 50;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn2.HeaderText = "Product ID";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 95;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn3.HeaderText = "Name";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 69;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column3.HeaderText = "Qty";
			this.Column3.Name = "Column3";
			this.Column3.Width = 54;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column4.HeaderText = "Price";
			this.Column4.Name = "Column4";
			this.Column4.Width = 63;
			// 
			// Column6
			// 
			this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column6.HeaderText = "Description";
			this.Column6.Name = "Column6";
			// 
			// Category
			// 
			this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Category.HeaderText = "Category";
			this.Category.Name = "Category";
			this.Category.Width = 89;
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnClear.FlatAppearance.BorderSize = 0;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.ForeColor = System.Drawing.Color.White;
			this.btnClear.Location = new System.Drawing.Point(741, 524);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 29);
			this.btnClear.TabIndex = 25;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.Olive;
			this.btnUpdate.FlatAppearance.BorderSize = 0;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(645, 524);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 29);
			this.btnUpdate.TabIndex = 24;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(549, 524);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 29);
			this.btnSave.TabIndex = 23;
			this.btnSave.Text = "Order Insert";
			this.btnSave.UseVisualStyleBackColor = false;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(13, 524);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(78, 17);
			this.label12.TabIndex = 22;
			this.label12.Text = "Order Date:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(16, 544);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker1.TabIndex = 12;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(13, 460);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(97, 17);
			this.label11.TabIndex = 21;
			this.label11.Text = "Product Name:";
			// 
			// txtPName
			// 
			this.txtPName.Enabled = false;
			this.txtPName.Location = new System.Drawing.Point(16, 480);
			this.txtPName.Name = "txtPName";
			this.txtPName.Size = new System.Drawing.Size(268, 22);
			this.txtPName.TabIndex = 20;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(500, 487);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 17);
			this.label10.TabIndex = 19;
			this.label10.Text = "Total:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(504, 452);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 17);
			this.label9.TabIndex = 18;
			this.label9.Text = "Qty:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(501, 417);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(38, 17);
			this.label8.TabIndex = 17;
			this.label8.Text = "Price";
			// 
			// txtTotal
			// 
			this.txtTotal.Enabled = false;
			this.txtTotal.Location = new System.Drawing.Point(548, 484);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(267, 22);
			this.txtTotal.TabIndex = 16;
			// 
			// txtPrice
			// 
			this.txtPrice.Enabled = false;
			this.txtPrice.Location = new System.Drawing.Point(548, 414);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(267, 22);
			this.txtPrice.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 394);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 17);
			this.label7.TabIndex = 13;
			this.label7.Text = "Product ID:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(392, 321);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 17);
			this.label5.TabIndex = 9;
			this.label5.Text = "Search box:";
			// 
			// txtPId
			// 
			this.txtPId.Enabled = false;
			this.txtPId.Location = new System.Drawing.Point(16, 414);
			this.txtPId.Name = "txtPId";
			this.txtPId.Size = new System.Drawing.Size(268, 22);
			this.txtPId.TabIndex = 12;
			// 
			// txtSearchProd
			// 
			this.txtSearchProd.Location = new System.Drawing.Point(504, 318);
			this.txtSearchProd.Name = "txtSearchProd";
			this.txtSearchProd.Size = new System.Drawing.Size(311, 22);
			this.txtSearchProd.TabIndex = 7;
			this.txtSearchProd.TextChanged += new System.EventHandler(this.txtSearchProd_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Teal;
			this.label3.Location = new System.Drawing.Point(13, 353);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 18);
			this.label3.TabIndex = 6;
			this.label3.Text = "PRODUCT";
			// 
			// OrderModuleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1174, 618);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "OrderModuleForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OrderModuleForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dgvCustomer;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewImageColumn Edit;
		private System.Windows.Forms.DataGridViewImageColumn Delete;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView dgvProduct;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Category;
		private System.Windows.Forms.TextBox txtSearchCust;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSearchProd;
		private System.Windows.Forms.TextBox textCid;
		private System.Windows.Forms.Label txtCId;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCName;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtPId;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtPName;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label12;
		public System.Windows.Forms.Button btnClear;
		public System.Windows.Forms.Button btnUpdate;
		public System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
	}
}