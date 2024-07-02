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

namespace Inventory_Mangaement
{
	public partial class Form1 : Form
	{
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

					string selectData = "SELECT * FROM users WHERE username = @username AND password = @password";

					using (SqlCommand cmd = new SqlCommand(selectData, con)) 
					{
						cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
						cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

						SqlDataAdapter adapter = new SqlDataAdapter(cmd);
						DataTable table = new DataTable();
						adapter.Fill(table);

						if (table.Rows.Count > 0)
						{
							MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
							
							MainForm mainForm = new MainForm();
							mainForm.Show();
							this.Hide();
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
