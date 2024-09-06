namespace IncomeExpensesTrackingSystem
{
	partial class IncomeForm
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

		#region Component Designer generated code

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
			this.panel1 = new System.Windows.Forms.Panel();
			this.category_DataGridView = new System.Windows.Forms.DataGridView();
			this.incomeList_dataGridView = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.income_DelBtn = new System.Windows.Forms.Button();
			this.income_ClearBtn = new System.Windows.Forms.Button();
			this.income_UpdateBtn = new System.Windows.Forms.Button();
			this.income_AddBtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.income_DateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.income_Description = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.income_Income = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.income_Item = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.income_Category = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.category_DataGridView)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.category_DataGridView);
			this.panel1.Controls.Add(this.incomeList_dataGridView);
			this.panel1.Location = new System.Drawing.Point(15, 15);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1120, 336);
			this.panel1.TabIndex = 0;
			// 
			// category_DataGridView
			// 
			this.category_DataGridView.AllowUserToAddRows = false;
			this.category_DataGridView.AllowUserToDeleteRows = false;
			this.category_DataGridView.AllowUserToResizeColumns = false;
			this.category_DataGridView.AllowUserToResizeRows = false;
			this.category_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.category_DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.category_DataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.category_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.category_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Aquamarine;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.category_DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.category_DataGridView.EnableHeadersVisualStyles = false;
			this.category_DataGridView.GridColor = System.Drawing.SystemColors.Control;
			this.category_DataGridView.Location = new System.Drawing.Point(15, 45);
			this.category_DataGridView.Name = "category_DataGridView";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.category_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.category_DataGridView.RowHeadersVisible = false;
			this.category_DataGridView.Size = new System.Drawing.Size(1090, 276);
			this.category_DataGridView.TabIndex = 2;
			this.category_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.category_DataGridView_CellClick);
			// 
			// incomeList_dataGridView
			// 
			this.incomeList_dataGridView.AutoSize = true;
			this.incomeList_dataGridView.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.incomeList_dataGridView.Location = new System.Drawing.Point(15, 10);
			this.incomeList_dataGridView.Name = "incomeList_dataGridView";
			this.incomeList_dataGridView.Size = new System.Drawing.Size(120, 25);
			this.incomeList_dataGridView.TabIndex = 1;
			this.incomeList_dataGridView.Text = "Income List";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.income_DelBtn);
			this.panel2.Controls.Add(this.income_ClearBtn);
			this.panel2.Controls.Add(this.income_UpdateBtn);
			this.panel2.Controls.Add(this.income_AddBtn);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.income_DateTimePicker);
			this.panel2.Controls.Add(this.income_Description);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.income_Income);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.income_Item);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.income_Category);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(15, 401);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1120, 336);
			this.panel2.TabIndex = 2;
			// 
			// income_DelBtn
			// 
			this.income_DelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
			this.income_DelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.income_DelBtn.FlatAppearance.BorderSize = 0;
			this.income_DelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
			this.income_DelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
			this.income_DelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.income_DelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.income_DelBtn.ForeColor = System.Drawing.Color.White;
			this.income_DelBtn.Location = new System.Drawing.Point(587, 267);
			this.income_DelBtn.Name = "income_DelBtn";
			this.income_DelBtn.Size = new System.Drawing.Size(91, 46);
			this.income_DelBtn.TabIndex = 14;
			this.income_DelBtn.Text = "Delete";
			this.income_DelBtn.UseVisualStyleBackColor = false;
			this.income_DelBtn.Click += new System.EventHandler(this.income_DelBtn_Click);
			// 
			// income_ClearBtn
			// 
			this.income_ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
			this.income_ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.income_ClearBtn.FlatAppearance.BorderSize = 0;
			this.income_ClearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
			this.income_ClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
			this.income_ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.income_ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.income_ClearBtn.ForeColor = System.Drawing.Color.White;
			this.income_ClearBtn.Location = new System.Drawing.Point(735, 267);
			this.income_ClearBtn.Name = "income_ClearBtn";
			this.income_ClearBtn.Size = new System.Drawing.Size(91, 46);
			this.income_ClearBtn.TabIndex = 13;
			this.income_ClearBtn.Text = "Clear";
			this.income_ClearBtn.UseVisualStyleBackColor = false;
			this.income_ClearBtn.Click += new System.EventHandler(this.income_ClearBtn_Click);
			// 
			// income_UpdateBtn
			// 
			this.income_UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
			this.income_UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.income_UpdateBtn.FlatAppearance.BorderSize = 0;
			this.income_UpdateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
			this.income_UpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
			this.income_UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.income_UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.income_UpdateBtn.ForeColor = System.Drawing.Color.White;
			this.income_UpdateBtn.Location = new System.Drawing.Point(439, 267);
			this.income_UpdateBtn.Name = "income_UpdateBtn";
			this.income_UpdateBtn.Size = new System.Drawing.Size(91, 46);
			this.income_UpdateBtn.TabIndex = 12;
			this.income_UpdateBtn.Text = "Update";
			this.income_UpdateBtn.UseVisualStyleBackColor = false;
			this.income_UpdateBtn.Click += new System.EventHandler(this.income_UpdateBtn_Click);
			// 
			// income_AddBtn
			// 
			this.income_AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
			this.income_AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.income_AddBtn.FlatAppearance.BorderSize = 0;
			this.income_AddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
			this.income_AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
			this.income_AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.income_AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.income_AddBtn.ForeColor = System.Drawing.Color.White;
			this.income_AddBtn.Location = new System.Drawing.Point(291, 267);
			this.income_AddBtn.Name = "income_AddBtn";
			this.income_AddBtn.Size = new System.Drawing.Size(91, 46);
			this.income_AddBtn.TabIndex = 11;
			this.income_AddBtn.Text = "Add";
			this.income_AddBtn.UseVisualStyleBackColor = false;
			this.income_AddBtn.Click += new System.EventHandler(this.income_AddBtn_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(687, 191);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Date:";
			// 
			// income_DateTimePicker
			// 
			this.income_DateTimePicker.Location = new System.Drawing.Point(779, 188);
			this.income_DateTimePicker.Name = "income_DateTimePicker";
			this.income_DateTimePicker.Size = new System.Drawing.Size(301, 20);
			this.income_DateTimePicker.TabIndex = 9;
			// 
			// income_Description
			// 
			this.income_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.income_Description.Location = new System.Drawing.Point(779, 65);
			this.income_Description.Multiline = true;
			this.income_Description.Name = "income_Description";
			this.income_Description.Size = new System.Drawing.Size(321, 73);
			this.income_Description.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(633, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Description:";
			// 
			// income_Income
			// 
			this.income_Income.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.income_Income.Location = new System.Drawing.Point(123, 191);
			this.income_Income.Name = "income_Income";
			this.income_Income.Size = new System.Drawing.Size(191, 26);
			this.income_Income.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(27, 191);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Income:";
			// 
			// income_Item
			// 
			this.income_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.income_Item.Location = new System.Drawing.Point(123, 129);
			this.income_Item.Name = "income_Item";
			this.income_Item.Size = new System.Drawing.Size(191, 26);
			this.income_Item.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(51, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Item:";
			// 
			// income_Category
			// 
			this.income_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.income_Category.FormattingEnabled = true;
			this.income_Category.Location = new System.Drawing.Point(123, 65);
			this.income_Category.Name = "income_Category";
			this.income_Category.Size = new System.Drawing.Size(191, 28);
			this.income_Category.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Category:";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// IncomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "IncomeForm";
			this.Size = new System.Drawing.Size(1150, 752);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.category_DataGridView)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label incomeList_dataGridView;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker income_DateTimePicker;
		private System.Windows.Forms.TextBox income_Description;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox income_Income;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox income_Item;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox income_Category;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button income_DelBtn;
		private System.Windows.Forms.Button income_ClearBtn;
		private System.Windows.Forms.Button income_UpdateBtn;
		private System.Windows.Forms.Button income_AddBtn;
		private System.Windows.Forms.DataGridView category_DataGridView;
	}
}
