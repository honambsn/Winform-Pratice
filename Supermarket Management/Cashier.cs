using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management
{
	public partial class Cashier : Form
	{
		public Cashier()
		{
			InitializeComponent();
			drawCenter();
			dgvCashier.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;

			dgvCashier.Refresh();

		}
		
		public void drawCenter()
		{
			int xPos = (this.panel2.Width - this.pictureBox1.Width) / 2;
			int yPos = this.pictureBox1.Location.Y;

			this.pictureBox1.Location = new Point(xPos, yPos);

			xPos = (this.panel2.Width - this.lblUsername.Width) / 2;
			yPos = this.lblUsername.Location.Y;
			this.lblUsername.Location = new Point(xPos, yPos);

			yPos = (this.lblname.Height - this.lblname.Height) / 2;
			xPos = this.lblname.Location.X;
			this.lblname.Location = new Point(xPos, yPos);

			yPos = (this.pictureBox2.Height - this.pictureBox2.Height) / 2;
			xPos = this.pictureBox2.Location.X;
			this.pictureBox2.Location = new Point(xPos, yPos);
		}

		private void picClose_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		public void slide(Button button)
		{
			panelSlide.BackColor = Color.FromArgb(255, 0, 255);
			panelSlide.Height = button.Height;
			panelSlide.Top = button.Top;

		}

		private void btnTransaction_Click(object sender, EventArgs e)
		{
			slide(btnTransaction);
			GetTranNo();
		}

		private void btnSearchProd_Click(object sender, EventArgs e)
		{
			slide(btnSearchProd);
		}

		private void btnDiscount_Click(object sender, EventArgs e)
		{
			slide(btnDiscount);
		}

		private void btnPayment_Click(object sender, EventArgs e)
		{
			slide(btnPayment);
		}

		private void btnSales_Click(object sender, EventArgs e)
		{
			slide(btnSales);
		}

		private void btnChangePass_Click(object sender, EventArgs e)
		{
			slide(btnChangePass);
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			slide(btnLogout);
		}

		private void btnClearCart_Click(object sender, EventArgs e)
		{
			slide(btnClearCart);
		}

		private void lblTimerr_Tick(object sender, EventArgs e)
		{
			lblTimer.Text = DateTime.Now.ToString("HH:mm:ss tt");
		}

		public void GetTranNo()
		{
			// Get the transaction number
			string sdate = DateTime.Now.ToString("yyyyMMdd");
			string transno = sdate + "1001";
			lblTransNo.Text = transno;
		}
	}
}
