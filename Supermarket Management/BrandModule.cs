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
	public partial class BrandModule : Form
	{
		public BrandModule()
		{
			InitializeComponent();
			drawCenter();
		}

		private void drawCenter()
		{
			int xPos = this.label1.Location.X;
			int yPos = (this.panel1.Height - this.label1.Height) / 2;

			this.label1.Location = new Point(xPos, yPos);
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			
			if (MessageBox.Show("Are you sure you want to close this form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Close();
			}


		}
	}
}
