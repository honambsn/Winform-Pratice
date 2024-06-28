using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Mangaement
{
	public partial class RegisterForm : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
		public RegisterForm()
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
			//int labelHeight = label1.Height;

			xPos = (this.panel1.Width - labelWidth) / 2;
			//yPos = (this.panel1.Height - labelHeight) / 2;

			label1.Location = new Point(xPos, 117);

			int pictureWidth = pictureBox1.Width;

			xPos = (this.panel1.Width - pictureWidth) / 2;
			pictureBox1.Location = new Point(xPos, 25);
		}

		private void close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void login_label_Click(object sender, EventArgs e)
		{
			Form1 loginForm = new Form1();
			loginForm.Show();

			this.Hide();
		}

		private void register_btn_Click(object sender, EventArgs e)
		{
			if (register_username.Text == "" || register_password.Text == "" || register_cPassword.Text == "")
			{
				MessageBox.Show("Please fill all empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (checkConnection())
				{
					try
					{
						con.Open();

						string checkUsername = "SELECT * FROM users WHERE username = @username";

						using (SqlCommand cmd = new SqlCommand(checkUsername, con))
						{
							cmd.Parameters.AddWithValue("@username", register_username.Text.Trim());

							SqlDataAdapter adapter = new SqlDataAdapter(cmd);
							DataTable table = new DataTable();
							adapter.Fill(table);

							if (table.Rows.Count > 0)
							{
								MessageBox.Show(register_username.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							//else if (register_username.Text.Length < 8)
							//{
							//	MessageBox.Show("Invalid Password, at least	8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
							//}
							else if (register_password.Text.Trim() != register_cPassword.Text.Trim())
							{
								MessageBox.Show("Password does not match.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else
							{
								string insertData = "INSERT INTO users (username, password, role, status, date) VALUES(@username, @password, @role, @status, @date)";

								using (SqlCommand insertD = new SqlCommand(insertData, con))
								{
									insertD.Parameters.AddWithValue("@username", register_username.Text.Trim());
									insertD.Parameters.AddWithValue("@password", register_password.Text.Trim());
									insertD.Parameters.AddWithValue("@role", "Cashier");
									insertD.Parameters.AddWithValue("@status", "Approval");
									DateTime today = DateTime.Today;
									insertD.Parameters.AddWithValue("@date", today);
									
									insertD.ExecuteNonQuery();

									MessageBox.Show("Registered succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

									Form1 loginForm = new Form1();
									loginForm.Show();

									this.Hide();
								}
							}
						}


						
					}
					catch (Exception ex)
					{
						MessageBox.Show("Connection failed: " +ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally
					{
						con.Close();
					}
				}

			}
		}

		public bool checkConnection()
		{
			if (con.State == ConnectionState.Closed)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private void register_showPass_CheckedChanged(object sender, EventArgs e)
		{
			register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
			register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
		}
	}
}
