using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
	public partial class Register_Form : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30");
		public Register_Form()
		{
			InitializeComponent();
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

			

			if (panel1.ClientSize.Width > reg_signinBtn.Width)
			{
				reg_signinBtn.Left = (panel1.ClientSize.Width - reg_signinBtn.Width) / 2;
			}
		}

		private void panel1_Resize(object sender, EventArgs e)
		{
			CenterLabelHorizontally();

		}

		private void CenterTextBoxHorizontally()
		{
			// Calculate the horizontal center position and apply it
			reg_username.Left = (panel2.ClientSize.Width - reg_username.Width) / 2;
			reg_password.Left = (panel2.ClientSize.Width - reg_password.Width) / 2;

			signinhere.Left = (panel1.ClientSize.Width - signinhere.Width) / 2;
		}

		

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Login", "Login successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void reg_signinBtn_Click(object sender, EventArgs e)
		{
			Form1 loginForm = new Form1();
			loginForm.Show();

			this.Hide();
		}

		public bool checkConnection()
		{
			return (con.State == ConnectionState.Closed) ? true :  false;
		}

		private void reg_btn_Click(object sender, EventArgs e)
		{

		}

		private void reg_showpass_CheckedChanged(object sender, EventArgs e)
		{
			reg_password.PasswordChar = reg_showpass.Checked ? '\0' : '*';
			reg_confirmpass.PasswordChar = reg_showpass.Checked ? '\0' : '*';
		}
	}
}
