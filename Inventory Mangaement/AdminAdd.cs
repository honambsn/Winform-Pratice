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
	public partial class AdminAdd : UserControl
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
		public AdminAdd()
		{
			InitializeComponent();
			drawCenter();
		}

		private void drawCenter()
		{
			int XdataGridPos = (this.panel2.Width - this.dataGridView1.Width) / 2;

			dataGridView1.Location = new Point(XdataGridPos, 50);
		}

		private void btn_AddUser_Click(object sender, EventArgs e)
		{
			if (txt_addUsername.Text == "" || txt_addPassword.Text == "" || cb_Role.SelectedIndex == -1 || cb_Status.SelectedIndex == -1)
			{
				MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
							cmd.Parameters.AddWithValue("@username", txt_addUsername.Text.Trim());

							SqlDataAdapter adapter = new SqlDataAdapter(cmd);
							DataTable table = new DataTable();
							adapter.Fill(table);

							if (table.Rows.Count > 0)
							{
								MessageBox.Show(txt_addUsername.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else
							{
								string insertData = "INSERT INTO users (username, password, role, status, date) " + "VALUES(@username, @password, @role, @status, @date)";
								using (SqlCommand insertD = new SqlCommand(insertData, con))
								{
									insertD.Parameters.AddWithValue("@username", txt_addUsername.Text.Trim());
									insertD.Parameters.AddWithValue("@password", txt_addPassword.Text.Trim());
									insertD.Parameters.AddWithValue("@role", cb_Role.SelectedItem.ToString());
									insertD.Parameters.AddWithValue("@status", cb_Status.SelectedIndex.ToString());

									DateTime today = DateTime.Today;
									insertD.Parameters.AddWithValue("@date", today);
									insertD.ExecuteNonQuery();

									MessageBox.Show("Added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
								}
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally {
						con.Close();
					}
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (txt_addUsername.Text == "" || txt_addPassword.Text == "" || cb_Role.SelectedIndex == -1 || cb_Status.SelectedIndex == -1)
			{
				MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
							cmd.Parameters.AddWithValue("username", txt_addUsername.Text.Trim());

							SqlDataAdapter adapter = new SqlDataAdapter(cmd);
							DataTable table = new DataTable();
							adapter.Fill(table);

							if (table.Rows.Count > 0)
							{
								MessageBox.Show(txt_addUsername.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else
							{
								string insertData = "INSERT INTO users (username, password, role, status, date)" + "VALUES(@username, @password, @role, @status, @date)";
								using (SqlCommand insertD = new SqlCommand(insertData, con))
								{
									insertD.Parameters.AddWithValue("@username", txt_addUsername.Text.Trim());
									insertD.Parameters.AddWithValue("@password", txt_addPassword.Text.Trim());
									insertD.Parameters.AddWithValue("@role", cb_Role.SelectedItem.ToString());
									insertD.Parameters.AddWithValue("@username", cb_Status.SelectedIndex.ToString());

									DateTime today = DateTime.Today;
									insertD.Parameters.AddWithValue("@date", today);
									insertD.ExecuteNonQuery();
									MessageBox.Show("Added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
								}
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally { }
				}
			}
		}

		//public bool checkConnection()
		//{
		//	if (con.State == ConnectionState.Closed)
		//	{
		//		return true;
		//	}
		//	else
		//	{
		//		return false;
		//	}
		//}
		public bool checkConnection()
		{
			if (con.State == ConnectionState.Closed) return true;
			else return false;
		}
	}
}
