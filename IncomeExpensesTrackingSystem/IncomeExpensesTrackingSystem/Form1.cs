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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//CenterPictureBoxVertically();
			CenterPictureBoxHorizontally();
			panel1.Resize += new EventHandler(panel1_Resize);
			CenterLabelHorizontally();
			CenterTextBoxHorizontally();

		}

		private void CenterPictureBoxVertically()
		{
			// Check if the panel and picture box are initialized
			if (panel1 != null && pictureBox1 != null)
			{
				// Calculate the top position for vertical centering
				int centerY = (panel1.ClientSize.Height - pictureBox1.Height) / 2;

				// Set the Top property of the PictureBox
				pictureBox1.Top = centerY;

			}
		}

		// Assuming you have a Panel named panel1 and a PictureBox named pictureBox1

		private void CenterPictureBoxHorizontally()
		{
			// Check if the panel and picture box are initialized
			if (panel1 != null && pictureBox1 != null)
			{
				// Calculate the left position for horizontal centering
				int centerX = (panel1.ClientSize.Width - pictureBox1.Width) / 2;

				// Set the Left property of the PictureBox
				pictureBox1.Left = centerX;
			}
		}

		private void CenterLabelHorizontally()
		{
			if (panel1 != null && label2 != null)
			{
				// Calculate the left position for horizontal centering
				int centerX = (panel1.ClientSize.Width - label2.Width) / 2;

				// Set the Left property of the PictureBox
				label2.Left = centerX;
			}

			if (panel1.ClientSize.Width > login_register.Width)
			{
				login_register.Left = (panel1.ClientSize.Width - login_register.Width) / 2;
			}

			if (panel1.ClientSize.Width > login_signup.Width)
			{
				login_signup.Left = (panel1.ClientSize.Width - login_signup.Width) / 2;
			}
		}

		private void panel1_Resize(object sender, EventArgs e)
		{
			CenterLabelHorizontally();

		}

		private void CenterTextBoxHorizontally()
		{
			// Calculate the horizontal center position and apply it
			login_username.Left = (panel2.ClientSize.Width - login_username.Width) / 2;
			login_password.Left = (panel2.ClientSize.Width - login_password.Width) / 2;
		}

		private void label1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Login", "Login successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}
	}
}
