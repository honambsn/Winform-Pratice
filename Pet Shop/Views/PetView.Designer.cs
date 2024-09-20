namespace Pet_Shop.Views
{
	partial class PetView
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
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.petview_btnClose = new System.Windows.Forms.Button();
			this.tabPageInformation = new System.Windows.Forms.TabPage();
			this.tabPagePetDetails = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPetId = new System.Windows.Forms.TextBox();
			this.txtPetName = new System.Windows.Forms.TextBox();
			this.txtPetColour = new System.Windows.Forms.TextBox();
			this.save_btn = new System.Windows.Forms.Button();
			this.txtPetType = new System.Windows.Forms.TextBox();
			this.cancel_btn = new System.Windows.Forms.Button();
			this.tabPagePetList = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.petview_btnAdd = new System.Windows.Forms.Button();
			this.petview_btnEdit = new System.Windows.Forms.Button();
			this.petview_btnDel = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.panel1.SuspendLayout();
			this.tabPagePetDetails.SuspendLayout();
			this.tabPagePetList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(10, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "PETS";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.petview_btnClose);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 50);
			this.panel1.TabIndex = 1;
			// 
			// petview_btnClose
			// 
			this.petview_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.petview_btnClose.FlatAppearance.BorderSize = 0;
			this.petview_btnClose.Location = new System.Drawing.Point(726, 3);
			this.petview_btnClose.Name = "petview_btnClose";
			this.petview_btnClose.Size = new System.Drawing.Size(60, 31);
			this.petview_btnClose.TabIndex = 26;
			this.petview_btnClose.Text = "Close";
			this.petview_btnClose.UseVisualStyleBackColor = true;
			// 
			// tabPageInformation
			// 
			this.tabPageInformation.Location = new System.Drawing.Point(4, 29);
			this.tabPageInformation.Name = "tabPageInformation";
			this.tabPageInformation.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageInformation.Size = new System.Drawing.Size(792, 367);
			this.tabPageInformation.TabIndex = 2;
			this.tabPageInformation.Text = "Information";
			this.tabPageInformation.UseVisualStyleBackColor = true;
			// 
			// tabPagePetDetails
			// 
			this.tabPagePetDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tabPagePetDetails.Controls.Add(this.cancel_btn);
			this.tabPagePetDetails.Controls.Add(this.txtPetType);
			this.tabPagePetDetails.Controls.Add(this.txtPetColour);
			this.tabPagePetDetails.Controls.Add(this.txtPetName);
			this.tabPagePetDetails.Controls.Add(this.txtPetId);
			this.tabPagePetDetails.Controls.Add(this.save_btn);
			this.tabPagePetDetails.Controls.Add(this.label4);
			this.tabPagePetDetails.Controls.Add(this.label5);
			this.tabPagePetDetails.Controls.Add(this.label3);
			this.tabPagePetDetails.Controls.Add(this.label2);
			this.tabPagePetDetails.Location = new System.Drawing.Point(4, 29);
			this.tabPagePetDetails.Name = "tabPagePetDetails";
			this.tabPagePetDetails.Padding = new System.Windows.Forms.Padding(3);
			this.tabPagePetDetails.Size = new System.Drawing.Size(792, 367);
			this.tabPagePetDetails.TabIndex = 1;
			this.tabPagePetDetails.Text = "Pet Details";
			this.tabPagePetDetails.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(63, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 20);
			this.label2.TabIndex = 13;
			this.label2.Text = "Pet ID:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(63, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 20);
			this.label3.TabIndex = 14;
			this.label3.Text = "Pet Name:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(303, 109);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 20);
			this.label5.TabIndex = 15;
			this.label5.Text = "Pet Type:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(63, 196);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 20);
			this.label4.TabIndex = 16;
			this.label4.Text = "Pet Colour";
			// 
			// txtPetId
			// 
			this.txtPetId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPetId.Location = new System.Drawing.Point(68, 52);
			this.txtPetId.Name = "txtPetId";
			this.txtPetId.Size = new System.Drawing.Size(199, 26);
			this.txtPetId.TabIndex = 17;
			// 
			// txtPetName
			// 
			this.txtPetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPetName.Location = new System.Drawing.Point(67, 132);
			this.txtPetName.Name = "txtPetName";
			this.txtPetName.Size = new System.Drawing.Size(200, 26);
			this.txtPetName.TabIndex = 18;
			// 
			// txtPetColour
			// 
			this.txtPetColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPetColour.Location = new System.Drawing.Point(67, 219);
			this.txtPetColour.Name = "txtPetColour";
			this.txtPetColour.Size = new System.Drawing.Size(440, 26);
			this.txtPetColour.TabIndex = 19;
			// 
			// save_btn
			// 
			this.save_btn.FlatAppearance.BorderSize = 0;
			this.save_btn.Location = new System.Drawing.Point(67, 271);
			this.save_btn.Name = "save_btn";
			this.save_btn.Size = new System.Drawing.Size(210, 31);
			this.save_btn.TabIndex = 20;
			this.save_btn.Text = "Save";
			this.save_btn.UseVisualStyleBackColor = true;
			// 
			// txtPetType
			// 
			this.txtPetType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPetType.Location = new System.Drawing.Point(307, 132);
			this.txtPetType.Name = "txtPetType";
			this.txtPetType.Size = new System.Drawing.Size(200, 26);
			this.txtPetType.TabIndex = 21;
			// 
			// cancel_btn
			// 
			this.cancel_btn.FlatAppearance.BorderSize = 0;
			this.cancel_btn.Location = new System.Drawing.Point(297, 271);
			this.cancel_btn.Name = "cancel_btn";
			this.cancel_btn.Size = new System.Drawing.Size(210, 31);
			this.cancel_btn.TabIndex = 22;
			this.cancel_btn.Text = "Cancel";
			this.cancel_btn.UseVisualStyleBackColor = true;
			// 
			// tabPagePetList
			// 
			this.tabPagePetList.Controls.Add(this.petview_btnDel);
			this.tabPagePetList.Controls.Add(this.petview_btnEdit);
			this.tabPagePetList.Controls.Add(this.petview_btnAdd);
			this.tabPagePetList.Controls.Add(this.dataGridView1);
			this.tabPagePetList.Controls.Add(this.btnSearch);
			this.tabPagePetList.Controls.Add(this.txtSearch);
			this.tabPagePetList.Controls.Add(this.label6);
			this.tabPagePetList.Location = new System.Drawing.Point(4, 29);
			this.tabPagePetList.Name = "tabPagePetList";
			this.tabPagePetList.Padding = new System.Windows.Forms.Padding(3);
			this.tabPagePetList.Size = new System.Drawing.Size(792, 367);
			this.tabPagePetList.TabIndex = 0;
			this.tabPagePetList.Text = "Pet List";
			this.tabPagePetList.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(7, 14);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 20);
			this.label6.TabIndex = 18;
			this.label6.Text = "Pet ID:";
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(12, 40);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(533, 29);
			this.txtSearch.TabIndex = 19;
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.Location = new System.Drawing.Point(551, 38);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(124, 31);
			this.btnSearch.TabIndex = 21;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(11, 75);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(664, 284);
			this.dataGridView1.TabIndex = 22;
			// 
			// petview_btnAdd
			// 
			this.petview_btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.petview_btnAdd.FlatAppearance.BorderSize = 0;
			this.petview_btnAdd.Location = new System.Drawing.Point(692, 75);
			this.petview_btnAdd.Name = "petview_btnAdd";
			this.petview_btnAdd.Size = new System.Drawing.Size(80, 29);
			this.petview_btnAdd.TabIndex = 23;
			this.petview_btnAdd.Text = "Add";
			this.petview_btnAdd.UseVisualStyleBackColor = true;
			// 
			// petview_btnEdit
			// 
			this.petview_btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.petview_btnEdit.FlatAppearance.BorderSize = 0;
			this.petview_btnEdit.Location = new System.Drawing.Point(693, 121);
			this.petview_btnEdit.Name = "petview_btnEdit";
			this.petview_btnEdit.Size = new System.Drawing.Size(80, 29);
			this.petview_btnEdit.TabIndex = 24;
			this.petview_btnEdit.Text = "Edit";
			this.petview_btnEdit.UseVisualStyleBackColor = true;
			// 
			// petview_btnDel
			// 
			this.petview_btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.petview_btnDel.FlatAppearance.BorderSize = 0;
			this.petview_btnDel.Location = new System.Drawing.Point(692, 165);
			this.petview_btnDel.Name = "petview_btnDel";
			this.petview_btnDel.Size = new System.Drawing.Size(80, 29);
			this.petview_btnDel.TabIndex = 25;
			this.petview_btnDel.Text = "Delete";
			this.petview_btnDel.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPagePetList);
			this.tabControl1.Controls.Add(this.tabPagePetDetails);
			this.tabControl1.Controls.Add(this.tabPageInformation);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(0, 50);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 400);
			this.tabControl1.TabIndex = 2;
			// 
			// PetView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "PetView";
			this.Text = "PetView";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabPagePetDetails.ResumeLayout(false);
			this.tabPagePetDetails.PerformLayout();
			this.tabPagePetList.ResumeLayout(false);
			this.tabPagePetList.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button petview_btnClose;
		private System.Windows.Forms.TabPage tabPageInformation;
		private System.Windows.Forms.TabPage tabPagePetDetails;
		private System.Windows.Forms.Button cancel_btn;
		private System.Windows.Forms.TextBox txtPetType;
		private System.Windows.Forms.TextBox txtPetColour;
		private System.Windows.Forms.TextBox txtPetName;
		private System.Windows.Forms.TextBox txtPetId;
		private System.Windows.Forms.Button save_btn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage tabPagePetList;
		private System.Windows.Forms.Button petview_btnDel;
		private System.Windows.Forms.Button petview_btnEdit;
		private System.Windows.Forms.Button petview_btnAdd;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabControl tabControl1;
	}
}