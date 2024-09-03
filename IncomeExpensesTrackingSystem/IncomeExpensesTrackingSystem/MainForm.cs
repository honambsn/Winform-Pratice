﻿using System;
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
			if (MessageBox.Show("Are u sure u want to close?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.Exit();
			}
			
		}

		private void CenterPictureBoxVertically()
		{
			// Check if the panel and picture box are initialized
			if (pictureBox2 != null && pictureBox2 != null)
			{
				// Calculate the X coordinate to center the PictureBox
				int centerX = (panel2.Width - pictureBox2.Width) / 2;

				// Set the Left property of the PictureBox
				pictureBox2.Left = centerX;
			}
		}

		private void logout_Btn_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are u sure u want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Form1 loginForm = new Form1();
				loginForm.Show();

				this.Hide();
			}
		}
	}
}