using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Mangaement
{
	public partial class Form1 : Form
	{
		public static string username;
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
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
			//int labelHeight = label1.Height;

			xPos = (this.panel1.Width - labelWidth) / 2;
			//yPos = (this.panel1.Height - labelHeight) / 2;

			label1.Location = new Point(xPos, yPos);


		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void register_label_Click(object sender, EventArgs e)
		{
			RegisterForm regForm = new RegisterForm();
			regForm.Show();

			this.Hide();
		}

		private void login_showPass_CheckedChanged(object sender, EventArgs e)
		{
			login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';

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

		private void login_btn_Click(object sender, EventArgs e)
		{
			if (checkConnection())
			{
				try
				{
					con.Open();

					string selectData = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password AND status = @status";

					using (SqlCommand cmd = new SqlCommand(selectData, con))
					{
						cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
						cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());
						cmd.Parameters.AddWithValue("status", "Active");

						int rowCount = (int)cmd.ExecuteScalar();

						//SqlDataAdapter adapter = new SqlDataAdapter(cmd);
						//DataTable table = new DataTable();
						//adapter.Fill(table);

						//if (table.Rows.Count > 0)
						if (rowCount > 0)
						{

							string selectRole = "SELECT role FROM users WHERE username = @username AND password = @password";

							using (SqlCommand getRole = new SqlCommand(selectRole, con))
							{
								getRole.Parameters.AddWithValue("@username", login_username.Text.Trim());
								getRole.Parameters.AddWithValue("@password", login_password.Text.Trim());

								string userRole = getRole.ExecuteScalar() as string;

								MessageBox.Show("Login as -" + login_username.Text.Trim() + "- successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

								if (userRole == "Admin")
								{
									MainForm mainForm = new MainForm();
									mainForm.Show();

									this.Hide();

								}
								else if (userRole == "Cashier")
								{
									CashierMainForm cmForm = new CashierMainForm();
									cmForm.Show();

									this.Hide();
								}

							}


						}
						else
						{
							MessageBox.Show("Incorrect username/password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					con.Close();
				}
			}
		}
	}
}
