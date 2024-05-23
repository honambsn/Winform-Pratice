namespace Management_System
{
	partial class UserForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvUser = new System.Windows.Forms.DataGridView();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
			this.customerButton2 = new Management_System.CustomerButton();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerButton2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.panel1.Controls.Add(this.customerButton2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 419);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(984, 50);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Manage Users";
			// 
			// dgvUser
			// 
			this.dgvUser.AllowUserToAddRows = false;
			this.dgvUser.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7});
			this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvUser.EnableHeadersVisualStyles = false;
			this.dgvUser.Location = new System.Drawing.Point(0, 0);
			this.dgvUser.Name = "dgvUser";
			this.dgvUser.Size = new System.Drawing.Size(984, 419);
			this.dgvUser.TabIndex = 1;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "No";
			this.Column5.Name = "Column5";
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column1.HeaderText = "User Name";
			this.Column1.Name = "Column1";
			this.Column1.Width = 97;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText = "Full Name";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column3.HeaderText = "Password";
			this.Column3.Name = "Column3";
			this.Column3.Width = 88;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Phone";
			this.Column4.Name = "Column4";
			// 
			// Column6
			// 
			this.Column6.HeaderText = "";
			this.Column6.Image = ((System.Drawing.Image)(resources.GetObject("Column6.Image")));
			this.Column6.Name = "Column6";
			// 
			// Column7
			// 
			this.Column7.HeaderText = "";
			this.Column7.Image = ((System.Drawing.Image)(resources.GetObject("Column7.Image")));
			this.Column7.Name = "Column7";
			// 
			// customerButton2
			// 
			this.customerButton2.Image = ((System.Drawing.Image)(resources.GetObject("customerButton2.Image")));
			this.customerButton2.ImageHover = ((System.Drawing.Image)(resources.GetObject("customerButton2.ImageHover")));
			this.customerButton2.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customerButton2.ImageNormal")));
			this.customerButton2.Location = new System.Drawing.Point(933, 6);
			this.customerButton2.Name = "customerButton2";
			this.customerButton2.Size = new System.Drawing.Size(39, 36);
			this.customerButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.customerButton2.TabIndex = 12;
			this.customerButton2.TabStop = false;
			// 
			// UserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 469);
			this.Controls.Add(this.dgvUser);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UserForm";
			this.Text = "UserForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerButton2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvUser;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewImageColumn Column6;
		private System.Windows.Forms.DataGridViewImageColumn Column7;
		private CustomerButton customerButton2;
	}
}