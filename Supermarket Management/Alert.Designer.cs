namespace Supermarket_Management
{
	partial class Alert
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblPCode = new System.Windows.Forms.Label();
			this.lblMsg = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnReOrder = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblPCode);
			this.panel1.Controls.Add(this.lblMsg);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.btnReOrder);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(370, 75);
			this.panel1.TabIndex = 0;
			// 
			// lblPCode
			// 
			this.lblPCode.AutoSize = true;
			this.lblPCode.Location = new System.Drawing.Point(348, 55);
			this.lblPCode.Name = "lblPCode";
			this.lblPCode.Size = new System.Drawing.Size(22, 20);
			this.lblPCode.TabIndex = 7;
			this.lblPCode.Text = "lb";
			this.lblPCode.Visible = false;
			// 
			// lblMsg
			// 
			this.lblMsg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMsg.ForeColor = System.Drawing.Color.White;
			this.lblMsg.Location = new System.Drawing.Point(64, 12);
			this.lblMsg.Name = "lblMsg";
			this.lblMsg.Size = new System.Drawing.Size(254, 50);
			this.lblMsg.TabIndex = 6;
			this.lblMsg.Text = "Message Text";
			this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(324, 23);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(30, 30);
			this.btnClose.TabIndex = 5;
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnReOrder
			// 
			this.btnReOrder.FlatAppearance.BorderSize = 0;
			this.btnReOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnReOrder.Image")));
			this.btnReOrder.Location = new System.Drawing.Point(8, 12);
			this.btnReOrder.Name = "btnReOrder";
			this.btnReOrder.Size = new System.Drawing.Size(50, 50);
			this.btnReOrder.TabIndex = 4;
			this.btnReOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnReOrder.UseVisualStyleBackColor = true;
			this.btnReOrder.Click += new System.EventHandler(this.btnReOrder_Click);
			// 
			// Alert
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(370, 75);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Alert";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Alert";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Timer timer1;
		public System.Windows.Forms.Label lblMsg;
		public System.Windows.Forms.Button btnClose;
		public System.Windows.Forms.Button btnReOrder;
		public System.Windows.Forms.Label lblPCode;
	}
}