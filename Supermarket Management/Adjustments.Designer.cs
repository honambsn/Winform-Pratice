namespace Supermarket_Management
{
	partial class Adjustments
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adjustments));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSearch = new MetroFramework.Controls.MetroTextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblRefNo = new System.Windows.Forms.Label();
			this.lblDesc = new System.Windows.Forms.Label();
			this.lblProdCode = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cbAction = new System.Windows.Forms.ComboBox();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.txtRemark = new System.Windows.Forms.TextBox();
			this.dgvAdjustment = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Select = new System.Windows.Forms.DataGridViewImageColumn();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAdjustment)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.txtSearch);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 400);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(984, 61);
			this.panel1.TabIndex = 5;
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
			this.label1.Size = new System.Drawing.Size(196, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Stock Adjustment";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.txtSearch.Location = new System.Drawing.Point(375, 12);
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
			this.txtSearch.TabIndex = 3;
			this.txtSearch.UseSelectable = true;
			this.txtSearch.WaterMark = "Search here ....";
			this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtSearch.WaterMarkFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.BackColor = System.Drawing.Color.Red;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.Enabled = false;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(857, 14);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 35);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txtRemark);
			this.panel2.Controls.Add(this.txtQty);
			this.panel2.Controls.Add(this.cbAction);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.lblProdCode);
			this.panel2.Controls.Add(this.lblDesc);
			this.panel2.Controls.Add(this.lblRefNo);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.lblUsername);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(984, 142);
			this.panel2.TabIndex = 6;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(35, 35);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(66, 22);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(83, 20);
			this.lblUsername.TabIndex = 1;
			this.lblUsername.Text = "Username";
			this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Reference No:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Description:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(234, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Product Code:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRefNo
			// 
			this.lblRefNo.AutoSize = true;
			this.lblRefNo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRefNo.Location = new System.Drawing.Point(133, 60);
			this.lblRefNo.Name = "lblRefNo";
			this.lblRefNo.Size = new System.Drawing.Size(54, 20);
			this.lblRefNo.TabIndex = 5;
			this.lblRefNo.Text = "RefNo";
			this.lblRefNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblDesc
			// 
			this.lblDesc.AutoSize = true;
			this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDesc.Location = new System.Drawing.Point(133, 96);
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.Size = new System.Drawing.Size(113, 20);
			this.lblDesc.TabIndex = 6;
			this.lblDesc.Text = "Product Detail";
			this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblProdCode
			// 
			this.lblProdCode.AutoSize = true;
			this.lblProdCode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProdCode.Location = new System.Drawing.Point(357, 60);
			this.lblProdCode.Name = "lblProdCode";
			this.lblProdCode.Size = new System.Drawing.Size(113, 20);
			this.lblProdCode.TabIndex = 7;
			this.lblProdCode.Text = "Product Code";
			this.lblProdCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(563, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Action:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(563, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 20);
			this.label6.TabIndex = 9;
			this.label6.Text = "Qty:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(564, 97);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 20);
			this.label7.TabIndex = 10;
			this.label7.Text = "Remarks:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbAction
			// 
			this.cbAction.FormattingEnabled = true;
			this.cbAction.Items.AddRange(new object[] {
            "Remove From Inventory",
            "Add To Inventory"});
			this.cbAction.Location = new System.Drawing.Point(651, 19);
			this.cbAction.Name = "cbAction";
			this.cbAction.Size = new System.Drawing.Size(306, 28);
			this.cbAction.TabIndex = 11;
			// 
			// txtQty
			// 
			this.txtQty.Location = new System.Drawing.Point(651, 57);
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(306, 26);
			this.txtQty.TabIndex = 12;
			// 
			// txtRemark
			// 
			this.txtRemark.Location = new System.Drawing.Point(651, 94);
			this.txtRemark.Name = "txtRemark";
			this.txtRemark.Size = new System.Drawing.Size(306, 26);
			this.txtRemark.TabIndex = 13;
			// 
			// dgvAdjustment
			// 
			this.dgvAdjustment.AllowUserToAddRows = false;
			this.dgvAdjustment.AllowUserToDeleteRows = false;
			this.dgvAdjustment.AllowUserToResizeColumns = false;
			this.dgvAdjustment.AllowUserToResizeRows = false;
			this.dgvAdjustment.BackgroundColor = System.Drawing.Color.PaleTurquoise;
			this.dgvAdjustment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvAdjustment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAdjustment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Select});
			this.dgvAdjustment.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvAdjustment.Location = new System.Drawing.Point(0, 142);
			this.dgvAdjustment.Name = "dgvAdjustment";
			this.dgvAdjustment.ReadOnly = true;
			this.dgvAdjustment.RowHeadersVisible = false;
			this.dgvAdjustment.Size = new System.Drawing.Size(984, 252);
			this.dgvAdjustment.TabIndex = 7;
			this.dgvAdjustment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdjustment_CellContentClick);
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
			this.Column7.HeaderText = "Price";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 71;
			// 
			// Column8
			// 
			this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column8.HeaderText = "Stock On Hand";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Width = 143;
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
			// Adjustments
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(984, 461);
			this.Controls.Add(this.dgvAdjustment);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Adjustments";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adjustments";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAdjustment)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label1;
		private MetroFramework.Controls.MetroTextBox txtSearch;
		public System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblProdCode;
		private System.Windows.Forms.Label lblDesc;
		private System.Windows.Forms.Label lblRefNo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtQty;
		private System.Windows.Forms.ComboBox cbAction;
		private System.Windows.Forms.TextBox txtRemark;
		private System.Windows.Forms.DataGridView dgvAdjustment;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewImageColumn Select;
	}
}