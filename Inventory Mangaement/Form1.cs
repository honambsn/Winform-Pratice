using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Mangaement
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			drawCenter();
		}

		private void drawCenter()
		{
			int panelWidth = panel1.Width;
			int panelHeight = panel1.Height;

			int xPos = (this.ClientSize.Width - panelWidth) / 2;
			int yPos = (this.ClientSize.Height - panelHeight) / 2;

			panel1.Location = new Point(xPos, yPos);

			int labelWidth = label1.Width;
			int labelHeight = label1.Height;

			xPos = (this.panel1.Width - labelWidth) / 2;
			yPos = (this.panel1.Height - labelHeight) / 2;

			label1.Location = new Point(xPos, yPos);

		}

		private void label1_Click(object sender, EventArgs e)
		{
			

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			
		}
	}
}
