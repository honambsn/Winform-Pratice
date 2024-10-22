namespace Supermarket_Management
{
	partial class StockIn
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockIn));
			this.panel1 = new System.Windows.Forms.Panel();
			this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtConPerson = new System.Windows.Forms.TextBox();
			this.cbSupplier = new System.Windows.Forms.ComboBox();
			this.lblID = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.dtStockIn = new System.Windows.Forms.DateTimePicker();
			this.txtStockInBy = new System.Windows.Forms.TextBox();
			this.txtRefNo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgvStockIn = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSave = new System.Windows.Forms.Button();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
			this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
			this.txtSearch = new MetroFramework.Controls.MetroTextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
			this.panel1.SuspendLayout();
			this.metroTabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStockIn)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
			this.panel1.Controls.Add(this.txtSearch);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 500);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(984, 61);
			this.panel1.TabIndex = 4;
			// 
			// metroTabControl1
			// 
			this.metroTabControl1.Controls.Add(this.tabPage1);
			this.metroTabControl1.Controls.Add(this.tabPage2);
			this.metroTabControl1.Controls.Add(this.tabPage3);
			this.metroTabControl1.Controls.Add(this.tabPage4);
			this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
			this.metroTabControl1.Name = "metroTabControl1";
			this.metroTabControl1.SelectedIndex = 0;
			this.metroTabControl1.Size = new System.Drawing.Size(984, 500);
			this.metroTabControl1.TabIndex = 5;
			this.metroTabControl1.UseSelectable = true;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.White;
			this.tabPage1.Controls.Add(this.panel3);
			this.tabPage1.Controls.Add(this.panel2);
			this.tabPage1.Location = new System.Drawing.Point(4, 38);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(976, 458);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "StockIn";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txtAddress);
			this.panel2.Controls.Add(this.txtConPerson);
			this.panel2.Controls.Add(this.cbSupplier);
			this.panel2.Controls.Add(this.lblID);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.linkLabel1);
			this.panel2.Controls.Add(this.linkLabel2);
			this.panel2.Controls.Add(this.dtStockIn);
			this.panel2.Controls.Add(this.txtStockInBy);
			this.panel2.Controls.Add(this.txtRefNo);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(976, 170);
			this.panel2.TabIndex = 0;
			// 
			// txtAddress
			// 
			this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtAddress.Location = new System.Drawing.Point(715, 85);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(253, 26);
			this.txtAddress.TabIndex = 20;
			// 
			// txtConPerson
			// 
			this.txtConPerson.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtConPerson.Location = new System.Drawing.Point(715, 53);
			this.txtConPerson.Name = "txtConPerson";
			this.txtConPerson.Size = new System.Drawing.Size(253, 26);
			this.txtConPerson.TabIndex = 19;
			// 
			// cbSupplier
			// 
			this.cbSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbSupplier.FormattingEnabled = true;
			this.cbSupplier.Location = new System.Drawing.Point(714, 17);
			this.cbSupplier.Name = "cbSupplier";
			this.cbSupplier.Size = new System.Drawing.Size(254, 28);
			this.cbSupplier.TabIndex = 18;
			this.cbSupplier.SelectedIndexChanged += new System.EventHandler(this.cbSupplier_SelectedIndexChanged);
			this.cbSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbSupplier_KeyPress);
			// 
			// lblID
			// 
			this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(577, 127);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(45, 20);
			this.lblID.TabIndex = 17;
			this.lblID.Text = "lblID:";
			this.lblID.Visible = false;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(577, 90);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 20);
			this.label7.TabIndex = 16;
			this.label7.Text = "Address:";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(577, 55);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(130, 20);
			this.label6.TabIndex = 15;
			this.label6.Text = "Contack Person:";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(577, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 20);
			this.label5.TabIndex = 14;
			this.label5.Text = "Supplier:";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
			this.linkLabel1.Location = new System.Drawing.Point(127, 127);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(204, 20);
			this.linkLabel1.TabIndex = 13;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "[ Click to browse product ]";
			// 
			// linkLabel2
			// 
			this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.LinkColor = System.Drawing.Color.DimGray;
			this.linkLabel2.Location = new System.Drawing.Point(292, 20);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(99, 20);
			this.linkLabel2.TabIndex = 12;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "[ Generate ]";
			// 
			// dtStockIn
			// 
			this.dtStockIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dtStockIn.Location = new System.Drawing.Point(131, 85);
			this.dtStockIn.Name = "dtStockIn";
			this.dtStockIn.Size = new System.Drawing.Size(258, 26);
			this.dtStockIn.TabIndex = 10;
			// 
			// txtStockInBy
			// 
			this.txtStockInBy.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtStockInBy.Location = new System.Drawing.Point(131, 51);
			this.txtStockInBy.Name = "txtStockInBy";
			this.txtStockInBy.Size = new System.Drawing.Size(258, 26);
			this.txtStockInBy.TabIndex = 9;
			// 
			// txtRefNo
			// 
			this.txtRefNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtRefNo.Location = new System.Drawing.Point(131, 17);
			this.txtRefNo.Name = "txtRefNo";
			this.txtRefNo.Size = new System.Drawing.Size(155, 26);
			this.txtRefNo.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 90);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Stock In Date:";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Stock In By:";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Reference No:";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 38);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(976, 458);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "StockIn Record";
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 38);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(976, 458);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "tabPage3";
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(4, 38);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(976, 458);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "tabPage4";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnSave);
			this.panel3.Controls.Add(this.dgvStockIn);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 170);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(976, 288);
			this.panel3.TabIndex = 1;
			// 
			// dgvStockIn
			// 
			this.dgvStockIn.AllowUserToAddRows = false;
			this.dgvStockIn.AllowUserToDeleteRows = false;
			this.dgvStockIn.AllowUserToResizeColumns = false;
			this.dgvStockIn.AllowUserToResizeRows = false;
			this.dgvStockIn.BackgroundColor = System.Drawing.Color.PaleTurquoise;
			this.dgvStockIn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Chocolate;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvStockIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvStockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStockIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column10,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Edit,
            this.Delete});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvStockIn.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvStockIn.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvStockIn.Location = new System.Drawing.Point(0, 0);
			this.dgvStockIn.Name = "dgvStockIn";
			this.dgvStockIn.ReadOnly = true;
			this.dgvStockIn.RowHeadersVisible = false;
			this.dgvStockIn.Size = new System.Drawing.Size(976, 244);
			this.dgvStockIn.TabIndex = 5;
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
			this.Column9.HeaderText = "ID";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			this.Column9.Visible = false;
			// 
			// Column10
			// 
			this.Column10.HeaderText = "Reference No";
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
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
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column5.HeaderText = "Qty";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 60;
			// 
			// Column6
			// 
			this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column6.HeaderText = "Stock In Date";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 132;
			// 
			// Column7
			// 
			this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column7.HeaderText = "Stock In By";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 88;
			// 
			// Column8
			// 
			this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column8.HeaderText = "Supplier ID";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Width = 102;
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
			this.btnSave.Location = new System.Drawing.Point(876, 250);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 35);
			this.btnSave.TabIndex = 10;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewImageColumn1.HeaderText = "";
			this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
			this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.Width = 5;
			// 
			// dataGridViewImageColumn2
			// 
			this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewImageColumn2.HeaderText = "";
			this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
			this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			this.dataGridViewImageColumn2.Width = 5;
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
			// txtSearch
			// 
			// 
			// 
			// 
			this.txtSearch.CustomButton.Image = null;
			this.txtSearch.CustomButton.Location = new System.Drawing.Point(198, 1);
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
			this.txtSearch.Location = new System.Drawing.Point(295, 12);
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
			this.txtSearch.Size = new System.Drawing.Size(234, 37);
			this.txtSearch.TabIndex = 2;
			this.txtSearch.UseSelectable = true;
			this.txtSearch.WaterMark = "Search here ....";
			this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtSearch.WaterMarkFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.Location = new System.Drawing.Point(990, 21);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(54, 31);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(20, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Stock In Module";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dataGridViewImageColumn3
			// 
			this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewImageColumn3.HeaderText = "";
			this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
			this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
			// 
			// dataGridViewImageColumn4
			// 
			this.dataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewImageColumn4.HeaderText = "";
			this.dataGridViewImageColumn4.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn4.Image")));
			this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
			// 
			// StockIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.ControlBox = false;
			this.Controls.Add(this.metroTabControl1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "StockIn";
			this.Text = "STOCK ENTRY";
			this.panel1.ResumeLayout(false);
			this.metroTabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStockIn)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private MetroFramework.Controls.MetroTextBox txtSearch;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
		private System.Windows.Forms.Panel panel1;
		private MetroFramework.Controls.MetroTabControl metroTabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView dgvStockIn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewImageColumn Edit;
		private System.Windows.Forms.DataGridViewImageColumn Delete;
		public System.Windows.Forms.Button btnSave;
		public System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.TextBox txtStockInBy;
		public System.Windows.Forms.TextBox txtRefNo;
		public System.Windows.Forms.DateTimePicker dtStockIn;
		public System.Windows.Forms.TextBox txtAddress;
		public System.Windows.Forms.TextBox txtConPerson;
		public System.Windows.Forms.ComboBox cbSupplier;
		public System.Windows.Forms.Label lblID;
	}
}