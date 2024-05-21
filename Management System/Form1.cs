﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
		{
			if(checkBoxPass.Checked== false)
			{
				txtPass.UseSystemPasswordChar = true;

			}
			else
			{
				txtPass.UseSystemPasswordChar = false;
			}
		}

		private void lblClear_Click(object sender, EventArgs e)
		{
			txtPass.Clear();
			txtName.Clear();
		}

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Exit application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
