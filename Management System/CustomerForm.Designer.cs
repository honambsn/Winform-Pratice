namespace Management_System
{
	partial class CustomerForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
			this.dgvCustomer = new System.Windows.Forms.DataGridView();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
			this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.customerButton1 = new Management_System.CustomerButton();
			this.btnCAdd = new Management_System.CustomerButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.customerButton1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCAdd)).BeginInit();
			this.SuspendLayout();
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
            this.Column4,
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
			this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCustomer.EnableHeadersVisualStyles = false;
			this.dgvCustomer.Location = new System.Drawing.Point(0, 0);
			this.dgvCustomer.Name = "dgvCustomer";
			this.dgvCustomer.ShowRowErrors = false;
			this.dgvCustomer.Size = new System.Drawing.Size(984, 419);
			this.dgvCustomer.TabIndex = 3;
			this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
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
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText = "Name";
			this.Column2.Name = "Column2";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Phone";
			this.Column4.Name = "Column4";
			// 
			// Edit
			// 
			this.Edit.HeaderText = "";
			this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
			this.Edit.Name = "Edit";
			// 
			// Delete
			// 
			this.Delete.HeaderText = "";
			this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
			this.Delete.Name = "Delete";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.panel1.Controls.Add(this.customerButton1);
			this.panel1.Controls.Add(this.btnCAdd);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 419);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(984, 50);
			this.panel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Manage Customers";
			// 
			// customerButton1
			// 
			this.customerButton1.Image = ((System.Drawing.Image)(resources.GetObject("customerButton1.Image")));
			this.customerButton1.ImageHover = ((System.Drawing.Image)(resources.GetObject("customerButton1.ImageHover")));
			this.customerButton1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customerButton1.ImageNormal")));
			this.customerButton1.Location = new System.Drawing.Point(427, 6);
			this.customerButton1.Name = "customerButton1";
			this.customerButton1.Size = new System.Drawing.Size(39, 36);
			this.customerButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.customerButton1.TabIndex = 13;
			this.customerButton1.TabStop = false;
			this.customerButton1.Click += new System.EventHandler(this.customerButton1_Click);
			// 
			// btnCAdd
			// 
			this.btnCAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnCAdd.Image")));
			this.btnCAdd.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnCAdd.ImageHover")));
			this.btnCAdd.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnCAdd.ImageNormal")));
			this.btnCAdd.Location = new System.Drawing.Point(933, 6);
			this.btnCAdd.Name = "btnCAdd";
			this.btnCAdd.Size = new System.Drawing.Size(39, 36);
			this.btnCAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnCAdd.TabIndex = 12;
			this.btnCAdd.TabStop = false;
			this.btnCAdd.Click += new System.EventHandler(this.btnCAdd_Click);
			// 
			// CustomerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 469);
			this.Controls.Add(this.dgvCustomer);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CustomerForm";
			this.Text = "CustomerForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.customerButton1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCAdd)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCustomer;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewImageColumn Edit;
		private System.Windows.Forms.DataGridViewImageColumn Delete;
		private CustomerButton customerButton1;
		private CustomerButton btnCAdd;
	}
}