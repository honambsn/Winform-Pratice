using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			CenterPictureBoxVertically();
		}

		private void close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void CenterPictureBoxVertically()
		{
			// Check if the panel and picture box are initialized
			if (pictureBox2 != null && pictureBox2 != null)
			{
				// Calculate the top position for vertical centering
				int centerY = (panel1.ClientSize.Height - pictureBox1.Height) / 2;

				// Set the Top property of the PictureBox
				pictureBox2.Top = centerY;

				int centerX = (panel2.ClientSize.Height - pictureBox1.Height) / 2;

				pictureBox2.Left = centerX;

			}
		}
	}
}
