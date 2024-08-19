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
			displayAllUserData();
		}

		public void refreshData()
		{
			if (InvokeRequired)
			{
				Invoke((MethodInvoker)refreshData);
				return;
			}

			displayAllUserData();
		}


		public void displayAllUserData()
		{
			UserData uData = new UserData();

			List<UserData> listData = uData.AllUsersData();

			dataGridView1.DataSource = listData; 
		}

		private void drawCenter()
		{
			
			this.cb_Role.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cb_Status.DropDownStyle = ComboBoxStyle.DropDownList;

			int XdataGridPos = (this.panel2.Width - this.dataGridView1.Width) / 2;

			dataGridView1.Location = new Point(XdataGridPos, 50);
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;
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
									insertD.Parameters.AddWithValue("@status", cb_Status.SelectedItem.ToString());

									DateTime today = DateTime.Today;
									insertD.Parameters.AddWithValue("@date", today);
									insertD.ExecuteNonQuery();
									con.Close();

									MessageBox.Show("Added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
									displayAllUserData();
									ClearFields();
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
									insertD.Parameters.AddWithValue("@status", cb_Status.SelectedItem.ToString());

									DateTime today = DateTime.Today;
									insertD.Parameters.AddWithValue("@date", today);
									insertD.ExecuteNonQuery();
									displayAllUserData();
									con.Close();
									MessageBox.Show("Added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
									ClearFields();
									
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

		public bool checkConnection()
		{
			if (con.State == ConnectionState.Closed) return true;
			else return false;
		}

		public void ClearFields()
		{
			txt_addUsername.Text = "";
			txt_addPassword.Text = "";
			cb_Role.SelectedIndex = -1;
			cb_Status.SelectedIndex = -1;
		}

		private void btn_ClearUser_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to clear?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				ClearFields();
		}

		private void btn_UpdateUser_Click(object sender, EventArgs e)
		{
			if (txt_addUsername.Text == "" || txt_addPassword.Text == "" || cb_Role.SelectedIndex == -1 || cb_Status.SelectedIndex == -1)
			{
				MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to update user ID: " + getID + " ?" , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
					if (checkConnection())
					{
						try
						{
							con.Open();

							string updateData = "UPDATE users SET username  = @username, password = @password, role = @role, status = @status where id = @id";

							using (SqlCommand updateD = new SqlCommand(updateData, con))
							{
								updateD.Parameters.AddWithValue("@username", txt_addUsername.Text.Trim());
								updateD.Parameters.AddWithValue("@password", txt_addPassword.Text.Trim());
								updateD.Parameters.AddWithValue("@role", cb_Role.SelectedItem);
								updateD.Parameters.AddWithValue("@status", cb_Role.SelectedItem);
								updateD.Parameters.AddWithValue("@id", getID);

								updateD.ExecuteNonQuery();
								con.Close();
								MessageBox.Show("Updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

								ClearFields();
								displayAllUserData();

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
		}
		private int getID = 0;

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex != -1)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

				getID = (int)row.Cells[0].Value;
				string username = row.Cells[1].Value.ToString();
				string password = row.Cells[2].Value.ToString();
				string role = row.Cells[3].Value.ToString();
				string status = row.Cells[4].Value.ToString();

				txt_addUsername.Text = username;
				txt_addPassword.Text = password;
				cb_Role.Text = role;
				cb_Status.Text = status;
			}
		}

		private void btn_RemoveUser_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to Remove user ID: " + getID + " ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (checkConnection())
					{
						try
						{
							con.Open();

							string updateData = "DELETE FROM users WHERE id = @id";

							using (SqlCommand updateD = new SqlCommand(updateData, con))
							{
								
								updateD.Parameters.AddWithValue("@id", getID);

								updateD.ExecuteNonQuery();
								con.Close();
								MessageBox.Show("Removed successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

								ClearFields();
								displayAllUserData();

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

		private void button1_Click(object sender, EventArgs e)
		{
			displayAllUserData();
		}

	}
}
