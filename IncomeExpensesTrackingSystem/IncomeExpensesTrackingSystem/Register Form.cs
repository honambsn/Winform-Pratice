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
			if(reg_username.Text == "" || reg_password.Text == "" || reg_confirmpass.Text == "")
			{
				MessageBox.Show("Fill all blank", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				if (checkConnection())
				{
					try
					{
						con.Open();

						string selectUsername = "select * from users where username = @username";
						using (SqlCommand checkUser = new SqlCommand(selectUsername, con))
						{
							checkUser.Parameters.AddWithValue("@username", reg_username.Text.Trim());

							SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
							DataTable table = new DataTable();

							adapter.Fill(table);

							if (table.Rows.Count != 0)
							{
								string tempUsername = reg_username.Text.Substring(0, 1).ToUpper() + reg_username.Text.Substring(1);
								MessageBox.Show(tempUsername + " is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

							}
							//else if(reg_password.Text.Length < 16)
							//{
							//	MessageBox.Show("Invalid pass, at least 16 characters are needed", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
							//}
							else if(reg_password.Text != reg_confirmpass.Text){
								MessageBox.Show("Password not match", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
							}
							else
							{

								string hashedPass = PasswordHash.HashPassword(reg_username.Text);

								string insertData = "insert into users (username, password, date) values (@username, @password, @date)";

								using (SqlCommand insertUser = new SqlCommand(insertData, con))
								{
									insertUser.Parameters.AddWithValue("@username", reg_username.Text.Trim());
									insertUser.Parameters.AddWithValue("@password", hashedPass.Trim());

									DateTime today = DateTime.Today;
									insertUser.Parameters.AddWithValue("@date", today);
								
									insertUser.ExecuteNonQuery();

									MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

									Form1 loginForm = new Form1();
									loginForm.Show();

									this.Hide();
								}
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Failed connection: "+ ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally 
					{
						con.Close();
					}
				}
			}
		}

		private void reg_showpass_CheckedChanged(object sender, EventArgs e)
		{
			reg_password.PasswordChar = reg_showpass.Checked ? '\0' : '*';
			reg_confirmpass.PasswordChar = reg_showpass.Checked ? '\0' : '*';
		}
	}
}
