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
	public partial class CashierOrder : UserControl
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
		public CashierOrder()
		{
			InitializeComponent();
			displayAllAvailableProducts();
			displayAllCategories();
		}

		public void displayAllAvailableProducts()
		{
			AddProductData apData = new AddProductData();
			List<AddProductData> listData = apData.allAvailableProducts();

			dataGridView1.DataSource = listData;
		}

		public bool checkConnection()
		{
			if (con.State == ConnectionState.Closed) return true;
			else return false;
		}

		public void displayAllCategories()
		{
			if (checkConnection())
			{
				try
				{
					con.Open();

					string selectData = "SELECT * FROM categories";
					using(SqlCommand cmd = new SqlCommand(selectData, con))
					{
						using(SqlDataReader reader = cmd.ExecuteReader())
						{
							cashierOrder_category.Items.Clear(); ;
							while(reader.Read())
							{
								string item = reader.GetString(1);
								cashierOrder_category.Items.Add(item);
							}
						}
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show("Failed connection" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					con.Close();
				}
			}
		}

		private void cashierOrder_category_SelectedIndexChanged(object sender, EventArgs e)
		{
			cashierOrder_ProductID.SelectedIndex = -1;
			cashierOrder_ProductID.Items.Clear();
			cashierOrder_ProductName.Text = "";
			cashierOrder_ProductPrice.Text = "";
			cashierOrder_ProductQty.Value = 0;


			string selectedValue = cashierOrder_category.SelectedItem as string;
			if (selectedValue != null)
			{
				if (checkConnection())
				{
					try
					{
						con.Open();

						string selectData = $"SELECT * FROM products WHERE category = '{selectedValue}' AND status = @status";
						
						using (SqlCommand cmd = new SqlCommand(selectData, con))
						{
							cmd.Parameters.AddWithValue("@status", "Available");

							using (SqlDataReader reader = cmd.ExecuteReader())
							{
								while (reader.Read())
								{
									string value = reader["prod_id"].ToString();

									cashierOrder_ProductID.Items.Add(value);
								}
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Failed connection" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally
					{
						con.Close();
					}
				}
				
			}
		}

		private void cashierOrder_ProductID_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedValue = cashierOrder_ProductID.SelectedItem as string;

			if (checkConnection())
			{
				if(selectedValue != null)
				{
					try
					{
						con.Open();

						string selectData = $"SELECT * FROM products WHERE prod_id = '{selectedValue}' AND status = @status";

						using (SqlCommand cmd = new SqlCommand(selectData, con))
						{
							cmd.Parameters.AddWithValue("@status", "Available");
							using(SqlDataReader reader = cmd.ExecuteReader())
							{
								while (reader.Read())
								{
									string prodName = reader["prod_name"].ToString();
									float prodPrice = Convert.ToSingle(reader["price"]);

									cashierOrder_ProductName.Text = prodName;
									cashierOrder_ProductPrice.Text = prodPrice.ToString("0.00");
								}
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Failed connection" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally 
					{
						con.Close();
					}

				}
			}
		}
	}
}
