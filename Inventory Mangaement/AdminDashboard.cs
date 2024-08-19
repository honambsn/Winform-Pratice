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
	public partial class AdminDashboard : UserControl
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
		public AdminDashboard()
		{
			InitializeComponent();
			displayTodaysCustomer();
			displayAllCustomers();
			displayAllUsers();
			displayTodaysIncome();
			displayTotalIncome();
		}

		public void refreshData()
		{
			if (InvokeRequired)
			{
				Invoke((MethodInvoker)refreshData);
				return;
			}

			displayAllUsers();
			displayAllCustomers();
			displayTodaysIncome();
			displayTotalIncome();
		}

		public void displayTodaysCustomer()
		{
			CustomerData cData = new CustomerData();

			List<CustomerData> listData = cData.allTodayCustomer();

			dataGridView1.DataSource = listData;
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

		public void displayAllUsers()
		{
			if (checkConnection())
			{
				try
				{
					con.Open();

					string selectData = "SELECT COUNT(id) FROM users WHERE status = @status";

					using(SqlCommand cmd = new SqlCommand(selectData, con))
					{
						cmd.Parameters.AddWithValue("@status", "Active");

						SqlDataReader reader = cmd.ExecuteReader();

						if (reader.Read())
						{
							int count = Convert.ToInt32(reader[0]);
							dashboard_AU.Text = count.ToString();
						}
						reader.Close();
					}

				}catch (Exception ex)
				{
					MessageBox.Show("Connection failed" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					con.Close();
				}
			}
		}

		public void displayAllCustomers()
		{
			if (checkConnection())
			{
				try
				{
					con.Open();

					string selectData = "SELECT COUNT(id) FROM customers";

					using (SqlCommand cmd = new SqlCommand(selectData, con))
					{
											
						SqlDataReader reader = cmd.ExecuteReader();

						if (reader.Read())
						{
							int count = Convert.ToInt32(reader[0]);
							dashboard_AC.Text = count.ToString();
						}
						reader.Close();
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Connection failed" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					con.Close();
				}
			}
		}

		public void displayTodaysIncome()
		{
			if (checkConnection())
			{
				try
				{
					con.Open();

					string selectData = "SELECT SUM(total_price) FROM customers WHERE order_date = @date";

					using (SqlCommand cmd = new SqlCommand(selectData, con))
					{
						DateTime today = DateTime.Today;
						string getToday = today.ToString("yyyy-MM-dd");

						cmd.Parameters.AddWithValue("@date", getToday);

						SqlDataReader reader = cmd.ExecuteReader();

						if (reader.Read())
						{
							object value = reader[0];
							
							if(value != DBNull.Value)
							{
								int count = Convert.ToInt32(reader[0]);
								dashboard_TI.Text = "$" + count.ToString("0.00");
							}
							reader.Close();
						}
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Connection failed" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					con.Close();
				}
			}
		}

		public void displayTotalIncome()
		{
			if (checkConnection())
			{
				try
				{
					con.Open();

					string selectData = "SELECT SUM(total_price) FROM customers";

					using (SqlCommand cmd = new SqlCommand(selectData, con))
					{
						

						SqlDataReader reader = cmd.ExecuteReader();

						if (reader.Read())
						{
							int count = Convert.ToInt32(reader[0]);
							dashboard_TotalIncome.Text = "$" + count.ToString("0.00");
							
						}
						reader.Close();
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Connection failed" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					con.Close();
				}
			}
		}
			
	}
}
