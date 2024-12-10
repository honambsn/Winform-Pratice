namespace Supermarket_Management
{
	partial class Cashier
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblUsername = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panelSlide = new System.Windows.Forms.Panel();
			this.lblDisplayTotal = new System.Windows.Forms.Panel();
			this.lblName = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.lblTimer = new System.Windows.Forms.Label();
			this.lblVatable = new System.Windows.Forms.Label();
			this.lblVat = new System.Windows.Forms.Label();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.lblSaleTotal = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtBarcode = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblTransNo = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelDisplaytotal = new System.Windows.Forms.Label();
			this.dgvCashier = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblTimerr = new System.Windows.Forms.Timer(this.components);
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
			this.colAdd = new System.Windows.Forms.DataGridViewImageColumn();
			this.colReduce = new System.Windows.Forms.DataGridViewImageColumn();
			this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
			this.picClose = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnChangePass = new System.Windows.Forms.Button();
			this.btnSales = new System.Windows.Forms.Button();
			this.btnClearCart = new System.Windows.Forms.Button();
			this.btnSettle = new System.Windows.Forms.Button();
			this.btnDiscount = new System.Windows.Forms.Button();
			this.btnSearchProd = new System.Windows.Forms.Button();
			this.btnTransaction = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.lblDisplayTotal.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCashier)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.btnLogout);
			this.panel1.Controls.Add(this.btnChangePass);
			this.panel1.Controls.Add(this.btnSales);
			this.panel1.Controls.Add(this.btnClearCart);
			this.panel1.Controls.Add(this.btnSettle);
			this.panel1.Controls.Add(this.btnDiscount);
			this.panel1.Controls.Add(this.btnSearchProd);
			this.panel1.Controls.Add(this.btnTransaction);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 711);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblUsername);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 182);
			this.panel2.TabIndex = 1;
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.Location = new System.Drawing.Point(59, 136);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(82, 18);
			this.lblUsername.TabIndex = 4;
			this.lblUsername.Text = "Username";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.panel3.Controls.Add(this.panelSlide);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(200, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(20, 711);
			this.panel3.TabIndex = 1;
			// 
			// panelSlide
			// 
			this.panelSlide.BackColor = System.Drawing.Color.Magenta;
			this.panelSlide.Location = new System.Drawing.Point(6, 182);
			this.panelSlide.Name = "panelSlide";
			this.panelSlide.Size = new System.Drawing.Size(8, 50);
			this.panelSlide.TabIndex = 4;
			// 
			// lblDisplayTotal
			// 
			this.lblDisplayTotal.BackColor = System.Drawing.Color.Teal;
			this.lblDisplayTotal.Controls.Add(this.picClose);
			this.lblDisplayTotal.Controls.Add(this.pictureBox2);
			this.lblDisplayTotal.Controls.Add(this.lblName);
			this.lblDisplayTotal.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDisplayTotal.Location = new System.Drawing.Point(220, 0);
			this.lblDisplayTotal.Name = "lblDisplayTotal";
			this.lblDisplayTotal.Size = new System.Drawing.Size(1099, 53);
			this.lblDisplayTotal.TabIndex = 2;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.Color.White;
			this.lblName.Location = new System.Drawing.Point(75, 16);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(123, 18);
			this.lblName.TabIndex = 4;
			this.lblName.Text = "Name and Role";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.txtQty);
			this.panel5.Controls.Add(this.lblTimer);
			this.panel5.Controls.Add(this.lblVatable);
			this.panel5.Controls.Add(this.lblVat);
			this.panel5.Controls.Add(this.lblDiscount);
			this.panel5.Controls.Add(this.lblSaleTotal);
			this.panel5.Controls.Add(this.label10);
			this.panel5.Controls.Add(this.label9);
			this.panel5.Controls.Add(this.label8);
			this.panel5.Controls.Add(this.label7);
			this.panel5.Controls.Add(this.txtBarcode);
			this.panel5.Controls.Add(this.label6);
			this.panel5.Controls.Add(this.lblDate);
			this.panel5.Controls.Add(this.label5);
			this.panel5.Controls.Add(this.lblTransNo);
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.labelDisplaytotal);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel5.Location = new System.Drawing.Point(1114, 53);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(205, 658);
			this.panel5.TabIndex = 3;
			// 
			// txtQty
			// 
			this.txtQty.Location = new System.Drawing.Point(153, 252);
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(34, 26);
			this.txtQty.TabIndex = 16;
			this.txtQty.Text = "1";
			this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblTimer
			// 
			this.lblTimer.BackColor = System.Drawing.Color.MediumAquamarine;
			this.lblTimer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblTimer.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimer.ForeColor = System.Drawing.Color.White;
			this.lblTimer.Location = new System.Drawing.Point(0, 613);
			this.lblTimer.Name = "lblTimer";
			this.lblTimer.Size = new System.Drawing.Size(205, 45);
			this.lblTimer.TabIndex = 15;
			this.lblTimer.Text = "00:00:00";
			this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblVatable
			// 
			this.lblVatable.Location = new System.Drawing.Point(101, 483);
			this.lblVatable.Name = "lblVatable";
			this.lblVatable.Size = new System.Drawing.Size(86, 20);
			this.lblVatable.TabIndex = 14;
			this.lblVatable.Text = "0.00";
			this.lblVatable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblVat
			// 
			this.lblVat.Location = new System.Drawing.Point(101, 440);
			this.lblVat.Name = "lblVat";
			this.lblVat.Size = new System.Drawing.Size(86, 20);
			this.lblVat.TabIndex = 13;
			this.lblVat.Text = "0.00";
			this.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblDiscount
			// 
			this.lblDiscount.Location = new System.Drawing.Point(101, 397);
			this.lblDiscount.Name = "lblDiscount";
			this.lblDiscount.Size = new System.Drawing.Size(86, 20);
			this.lblDiscount.TabIndex = 12;
			this.lblDiscount.Text = "0.00";
			this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblSaleTotal
			// 
			this.lblSaleTotal.Location = new System.Drawing.Point(101, 354);
			this.lblSaleTotal.Name = "lblSaleTotal";
			this.lblSaleTotal.Size = new System.Drawing.Size(86, 20);
			this.lblSaleTotal.TabIndex = 11;
			this.lblSaleTotal.Text = "0.00";
			this.lblSaleTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(9, 483);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(73, 20);
			this.label10.TabIndex = 10;
			this.label10.Text = "VATable:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(9, 440);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 20);
			this.label9.TabIndex = 9;
			this.label9.Text = "VAT:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(9, 397);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(76, 20);
			this.label8.TabIndex = 8;
			this.label8.Text = "Discount:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 354);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 20);
			this.label7.TabIndex = 7;
			this.label7.Text = "Sales Total:";
			// 
			// txtBarcode
			// 
			this.txtBarcode.Location = new System.Drawing.Point(10, 252);
			this.txtBarcode.Name = "txtBarcode";
			this.txtBarcode.Size = new System.Drawing.Size(122, 26);
			this.txtBarcode.TabIndex = 6;
			this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label6.Location = new System.Drawing.Point(6, 217);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(153, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "[F8]Barcode";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(6, 180);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(89, 20);
			this.lblDate.TabIndex = 4;
			this.lblDate.Text = "0000000000";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 143);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 20);
			this.label5.TabIndex = 3;
			this.label5.Text = "Date";
			// 
			// lblTransNo
			// 
			this.lblTransNo.AutoSize = true;
			this.lblTransNo.Location = new System.Drawing.Point(6, 106);
			this.lblTransNo.Name = "lblTransNo";
			this.lblTransNo.Size = new System.Drawing.Size(153, 20);
			this.lblTransNo.TabIndex = 2;
			this.lblTransNo.Text = "000000000000000000";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Transaction No";
			// 
			// labelDisplaytotal
			// 
			this.labelDisplaytotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.labelDisplaytotal.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelDisplaytotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDisplaytotal.ForeColor = System.Drawing.Color.White;
			this.labelDisplaytotal.Location = new System.Drawing.Point(0, 0);
			this.labelDisplaytotal.Name = "labelDisplaytotal";
			this.labelDisplaytotal.Size = new System.Drawing.Size(205, 26);
			this.labelDisplaytotal.TabIndex = 0;
			this.labelDisplaytotal.Text = "0.00";
			this.labelDisplaytotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dgvCashier
			// 
			this.dgvCashier.AllowUserToAddRows = false;
			this.dgvCashier.AllowUserToDeleteRows = false;
			this.dgvCashier.AllowUserToResizeColumns = false;
			this.dgvCashier.AllowUserToResizeRows = false;
			this.dgvCashier.BackgroundColor = System.Drawing.Color.PaleTurquoise;
			this.dgvCashier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCashier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6,
            this.Column8,
            this.colAdd,
            this.colReduce,
            this.Delete});
			this.dgvCashier.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCashier.Location = new System.Drawing.Point(220, 53);
			this.dgvCashier.Name = "dgvCashier";
			this.dgvCashier.ReadOnly = true;
			this.dgvCashier.RowHeadersVisible = false;
			this.dgvCashier.Size = new System.Drawing.Size(894, 658);
			this.dgvCashier.TabIndex = 4;
			this.dgvCashier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCashier_CellContentClick);
			this.dgvCashier.SelectionChanged += new System.EventHandler(this.dgvCashier_SelectionChanged);
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
			this.Column9.Width = 43;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column2.HeaderText = "PCode";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 85;
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
			// lblTimerr
			// 
			this.lblTimerr.Enabled = true;
			this.lblTimerr.Tick += new System.EventHandler(this.lblTimerr_Tick);
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewImageColumn1.HeaderText = "";
			this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
			this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.ReadOnly = true;
			this.dataGridViewImageColumn1.Width = 5;
			// 
			// dataGridViewImageColumn2
			// 
			this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewImageColumn2.HeaderText = "";
			this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
			this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			this.dataGridViewImageColumn2.ReadOnly = true;
			this.dataGridViewImageColumn2.Width = 5;
			// 
			// dataGridViewImageColumn3
			// 
			this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewImageColumn3.HeaderText = "";
			this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
			this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
			this.dataGridViewImageColumn3.ReadOnly = true;
			this.dataGridViewImageColumn3.Width = 5;
			// 
			// colAdd
			// 
			this.colAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colAdd.HeaderText = "";
			this.colAdd.Image = ((System.Drawing.Image)(resources.GetObject("colAdd.Image")));
			this.colAdd.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.colAdd.Name = "colAdd";
			this.colAdd.ReadOnly = true;
			this.colAdd.Width = 5;
			// 
			// colReduce
			// 
			this.colReduce.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colReduce.HeaderText = "";
			this.colReduce.Image = ((System.Drawing.Image)(resources.GetObject("colReduce.Image")));
			this.colReduce.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.colReduce.Name = "colReduce";
			this.colReduce.ReadOnly = true;
			this.colReduce.Width = 5;
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
			// picClose
			// 
			this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
			this.picClose.Location = new System.Drawing.Point(1073, 0);
			this.picClose.Name = "picClose";
			this.picClose.Size = new System.Drawing.Size(26, 25);
			this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picClose.TabIndex = 5;
			this.picClose.TabStop = false;
			this.picClose.Click += new System.EventHandler(this.picClose_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(3, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(45, 45);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// btnLogout
			// 
			this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnLogout.FlatAppearance.BorderSize = 0;
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogout.ForeColor = System.Drawing.Color.White;
			this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
			this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLogout.Location = new System.Drawing.Point(0, 666);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(200, 45);
			this.btnLogout.TabIndex = 11;
			this.btnLogout.Text = " Logout";
			this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// btnChangePass
			// 
			this.btnChangePass.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnChangePass.FlatAppearance.BorderSize = 0;
			this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChangePass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChangePass.ForeColor = System.Drawing.Color.White;
			this.btnChangePass.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePass.Image")));
			this.btnChangePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnChangePass.Location = new System.Drawing.Point(0, 452);
			this.btnChangePass.Name = "btnChangePass";
			this.btnChangePass.Size = new System.Drawing.Size(200, 45);
			this.btnChangePass.TabIndex = 10;
			this.btnChangePass.Text = " Change Password";
			this.btnChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnChangePass.UseVisualStyleBackColor = true;
			this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
			// 
			// btnSales
			// 
			this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSales.FlatAppearance.BorderSize = 0;
			this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSales.ForeColor = System.Drawing.Color.White;
			this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
			this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSales.Location = new System.Drawing.Point(0, 407);
			this.btnSales.Name = "btnSales";
			this.btnSales.Size = new System.Drawing.Size(200, 45);
			this.btnSales.TabIndex = 9;
			this.btnSales.Text = " Daily Sales";
			this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSales.UseVisualStyleBackColor = true;
			this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
			// 
			// btnClearCart
			// 
			this.btnClearCart.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnClearCart.Enabled = false;
			this.btnClearCart.FlatAppearance.BorderSize = 0;
			this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClearCart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClearCart.ForeColor = System.Drawing.Color.White;
			this.btnClearCart.Image = ((System.Drawing.Image)(resources.GetObject("btnClearCart.Image")));
			this.btnClearCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClearCart.Location = new System.Drawing.Point(0, 362);
			this.btnClearCart.Name = "btnClearCart";
			this.btnClearCart.Size = new System.Drawing.Size(200, 45);
			this.btnClearCart.TabIndex = 8;
			this.btnClearCart.Text = " Clear Cart";
			this.btnClearCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClearCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClearCart.UseVisualStyleBackColor = true;
			this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
			// 
			// btnSettle
			// 
			this.btnSettle.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSettle.Enabled = false;
			this.btnSettle.FlatAppearance.BorderSize = 0;
			this.btnSettle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSettle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSettle.ForeColor = System.Drawing.Color.White;
			this.btnSettle.Image = ((System.Drawing.Image)(resources.GetObject("btnSettle.Image")));
			this.btnSettle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSettle.Location = new System.Drawing.Point(0, 317);
			this.btnSettle.Name = "btnSettle";
			this.btnSettle.Size = new System.Drawing.Size(200, 45);
			this.btnSettle.TabIndex = 7;
			this.btnSettle.Text = " Settle Payment";
			this.btnSettle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSettle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSettle.UseVisualStyleBackColor = true;
			this.btnSettle.Click += new System.EventHandler(this.btnPayment_Click);
			// 
			// btnDiscount
			// 
			this.btnDiscount.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnDiscount.Enabled = false;
			this.btnDiscount.FlatAppearance.BorderSize = 0;
			this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDiscount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDiscount.ForeColor = System.Drawing.Color.White;
			this.btnDiscount.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscount.Image")));
			this.btnDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDiscount.Location = new System.Drawing.Point(0, 272);
			this.btnDiscount.Name = "btnDiscount";
			this.btnDiscount.Size = new System.Drawing.Size(200, 45);
			this.btnDiscount.TabIndex = 6;
			this.btnDiscount.Text = " Add Discount";
			this.btnDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDiscount.UseVisualStyleBackColor = true;
			this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
			// 
			// btnSearchProd
			// 
			this.btnSearchProd.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSearchProd.FlatAppearance.BorderSize = 0;
			this.btnSearchProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchProd.ForeColor = System.Drawing.Color.White;
			this.btnSearchProd.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchProd.Image")));
			this.btnSearchProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearchProd.Location = new System.Drawing.Point(0, 227);
			this.btnSearchProd.Name = "btnSearchProd";
			this.btnSearchProd.Size = new System.Drawing.Size(200, 45);
			this.btnSearchProd.TabIndex = 5;
			this.btnSearchProd.Text = " Search Product";
			this.btnSearchProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSearchProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSearchProd.UseVisualStyleBackColor = true;
			this.btnSearchProd.Click += new System.EventHandler(this.btnSearchProd_Click);
			// 
			// btnTransaction
			// 
			this.btnTransaction.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnTransaction.FlatAppearance.BorderSize = 0;
			this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTransaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTransaction.ForeColor = System.Drawing.Color.White;
			this.btnTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnTransaction.Image")));
			this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTransaction.Location = new System.Drawing.Point(0, 182);
			this.btnTransaction.Name = "btnTransaction";
			this.btnTransaction.Size = new System.Drawing.Size(200, 45);
			this.btnTransaction.TabIndex = 4;
			this.btnTransaction.Text = " New Transaction";
			this.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTransaction.UseVisualStyleBackColor = true;
			this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(46, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// Cashier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1319, 711);
			this.Controls.Add(this.dgvCashier);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.lblDisplayTotal);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Cashier";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cashier";
			this.Load += new System.EventHandler(this.Cashier_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cashier_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.lblDisplayTotal.ResumeLayout(false);
			this.lblDisplayTotal.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCashier)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnTransaction;
		private System.Windows.Forms.Panel lblDisplayTotal;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btnDiscount;
		private System.Windows.Forms.Button btnSearchProd;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnChangePass;
		private System.Windows.Forms.Button btnSales;
		private System.Windows.Forms.Button btnClearCart;
		private System.Windows.Forms.Button btnSettle;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox picClose;
		private System.Windows.Forms.Panel panelSlide;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblVatable;
		private System.Windows.Forms.Label lblVat;
		private System.Windows.Forms.Label lblDiscount;
		private System.Windows.Forms.Label lblSaleTotal;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblTimer;
		private System.Windows.Forms.Timer lblTimerr;
		public System.Windows.Forms.Label lblUsername;
		public System.Windows.Forms.Label lblTransNo;
		private System.Windows.Forms.TextBox txtQty;
		public System.Windows.Forms.TextBox txtBarcode;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
		public System.Windows.Forms.DataGridView dgvCashier;
		public System.Windows.Forms.Label labelDisplaytotal;
		public System.Windows.Forms.Label lblName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewImageColumn colAdd;
		private System.Windows.Forms.DataGridViewImageColumn colReduce;
		private System.Windows.Forms.DataGridViewImageColumn Delete;
	}
}