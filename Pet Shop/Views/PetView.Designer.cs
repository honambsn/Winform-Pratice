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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPagePetDetail = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.cancel_btn = new System.Windows.Forms.Button();
			this.txtPetType = new System.Windows.Forms.TextBox();
			this.save_btn = new System.Windows.Forms.Button();
			this.txtPetColour = new System.Windows.Forms.TextBox();
			this.txtPetName = new System.Windows.Forms.TextBox();
			this.txtPetId = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPagePetDetail.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 50);
			this.panel1.TabIndex = 1;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPagePetDetail);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(0, 50);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 400);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPagePetDetail
			// 
			this.tabPagePetDetail.Controls.Add(this.button4);
			this.tabPagePetDetail.Controls.Add(this.button3);
			this.tabPagePetDetail.Controls.Add(this.button2);
			this.tabPagePetDetail.Controls.Add(this.dataGridView1);
			this.tabPagePetDetail.Controls.Add(this.btnSearch);
			this.tabPagePetDetail.Controls.Add(this.txtSearch);
			this.tabPagePetDetail.Controls.Add(this.label6);
			this.tabPagePetDetail.Location = new System.Drawing.Point(4, 29);
			this.tabPagePetDetail.Name = "tabPagePetDetail";
			this.tabPagePetDetail.Padding = new System.Windows.Forms.Padding(3);
			this.tabPagePetDetail.Size = new System.Drawing.Size(792, 367);
			this.tabPagePetDetail.TabIndex = 0;
			this.tabPagePetDetail.Text = "Pet List";
			this.tabPagePetDetail.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tabPage2.Controls.Add(this.cancel_btn);
			this.tabPage2.Controls.Add(this.txtPetType);
			this.tabPage2.Controls.Add(this.save_btn);
			this.tabPage2.Controls.Add(this.txtPetColour);
			this.tabPage2.Controls.Add(this.txtPetName);
			this.tabPage2.Controls.Add(this.txtPetId);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(792, 367);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Pet Details";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 29);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(792, 347);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Information";
			this.tabPage3.UseVisualStyleBackColor = true;
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
			// txtPetType
			// 
			this.txtPetType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPetType.Location = new System.Drawing.Point(307, 132);
			this.txtPetType.Name = "txtPetType";
			this.txtPetType.Size = new System.Drawing.Size(200, 26);
			this.txtPetType.TabIndex = 21;
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
			// txtPetColour
			// 
			this.txtPetColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPetColour.Location = new System.Drawing.Point(67, 219);
			this.txtPetColour.Name = "txtPetColour";
			this.txtPetColour.Size = new System.Drawing.Size(440, 26);
			this.txtPetColour.TabIndex = 19;
			// 
			// txtPetName
			// 
			this.txtPetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPetName.Location = new System.Drawing.Point(67, 132);
			this.txtPetName.Name = "txtPetName";
			this.txtPetName.Size = new System.Drawing.Size(200, 26);
			this.txtPetName.TabIndex = 18;
			// 
			// txtPetId
			// 
			this.txtPetId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPetId.Location = new System.Drawing.Point(68, 52);
			this.txtPetId.Name = "txtPetId";
			this.txtPetId.Size = new System.Drawing.Size(199, 26);
			this.txtPetId.TabIndex = 17;
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
			// txtSearch
			// 
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(12, 40);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(533, 29);
			this.txtSearch.TabIndex = 19;
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
			// btnSearch
			// 
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
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(11, 75);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(664, 284);
			this.dataGridView1.TabIndex = 22;
			// 
			// button2
			// 
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.Location = new System.Drawing.Point(692, 75);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 29);
			this.button2.TabIndex = 23;
			this.button2.Text = "Add";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.Location = new System.Drawing.Point(693, 121);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(80, 29);
			this.button3.TabIndex = 24;
			this.button3.Text = "Edit";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.Location = new System.Drawing.Point(692, 165);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(80, 29);
			this.button4.TabIndex = 25;
			this.button4.Text = "Delete";
			this.button4.UseVisualStyleBackColor = true;
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
			this.tabControl1.ResumeLayout(false);
			this.tabPagePetDetail.ResumeLayout(false);
			this.tabPagePetDetail.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPagePetDetail;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button cancel_btn;
		private System.Windows.Forms.TextBox txtPetType;
		private System.Windows.Forms.Button save_btn;
		private System.Windows.Forms.TextBox txtPetColour;
		private System.Windows.Forms.TextBox txtPetName;
		private System.Windows.Forms.TextBox txtPetId;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
	}
}