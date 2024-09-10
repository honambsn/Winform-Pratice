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
	public partial class Form1 : Form
	{
		//SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30");
		string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";
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

			if (panel1.ClientSize.Width > login_signupBtn.Width)
			{
				login_signupBtn.Left = (panel1.ClientSize.Width - login_signupBtn.Width) / 2;
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

			registerhere.Left = (panel1.ClientSize.Width -  registerhere.Width) / 2;
		}

		private void label1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		public static string username;

		private void button1_Click(object sender, EventArgs e)
		{
			string username = login_username.Text.Trim();
			string password = login_password.Text;

			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Username or password cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			using (SqlConnection con = new SqlConnection(stringConnection))
			{
				con.Open();

				string selectData = "SELECT password FROM users WHERE username = @username";

				using (SqlCommand cmd = new SqlCommand(selectData, con))
				{
					cmd.Parameters.AddWithValue("@username", username);

					// Use ExecuteScalar to retrieve a single value (the hashed password)
					object result = cmd.ExecuteScalar();
					if (result != null)
					{
						

						string storedHashedPassword = result as string;

						// Verify the password using a secure method
						bool isPasswordCorrect = PasswordHash.VerifyPassword(password, storedHashedPassword);

						if (isPasswordCorrect)
						{
							username = login_username.Text;

							MessageBox.Show("Login successful!: " + username, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
							
							MainForm mainF = new MainForm();
							mainF.Show();

							this.Hide();
						}
						else
						{
							MessageBox.Show("Invalid username or password. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						// Handle case where username is not found
						MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}

		}

		private void login_signupBtn_Click(object sender, EventArgs e)
		{
			this.Hide();

			Register_Form register_Form = new Register_Form();
			register_Form.Show();
		}

		private void login_showpass_CheckedChanged(object sender, EventArgs e)
		{
			login_password.PasswordChar = login_showpass.Checked ? '\0' : '*';
		}

		
	}
}
