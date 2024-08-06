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
			displayAllOrder();
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

		public void displayAllOrder()
		{
			OrderData oData = new OrderData();
			List<OrderData> listData = oData.allOrderData();

			dataGridView2.DataSource = listData;
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

		private void cashierOrder_btnAdd_Click(object sender, EventArgs e)
		{
			IDGenerator();

			if (cashierOrder_category.SelectedIndex == -1 || cashierOrder_ProductID.SelectedIndex == -1 || cashierOrder_ProductName.Text == "" || cashierOrder_ProductPrice.Text == "" || cashierOrder_ProductQty.Value == 0) 
			{
				MessageBox.Show("Please select item", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (checkConnection())
				{
					try
					{
						con.Open();

						float getPricee = 0;
						string selectOrder = "SELECT * FROM products WHERE prod_id = @prodID";

						using(SqlCommand getOrder = new SqlCommand(selectOrder, con))
						{
							getOrder.Parameters.AddWithValue("@prodID", cashierOrder_ProductID.SelectedItem);

							using (SqlDataReader reader = getOrder.ExecuteReader())
							{
								if (reader.Read())
								{
									object rawValue = reader["price"];

									if (rawValue != DBNull.Value)
									{
										getPricee = Convert.ToSingle(rawValue);
									}
								}
							}
						}
						string insertData = "INSERT INTO orders (customer_id, prod_id, prod_name, category, qty, orig_price, total_price, order_date) " + "VALUES(@cID, @prodID, @prodName, @cat, @qty, @origPrice, @totalPrice, @date)";

						using(SqlCommand cmd = new SqlCommand(insertData, con))
						{
							cmd.Parameters.AddWithValue("@cID", idGen);
							cmd.Parameters.AddWithValue("@prodID", cashierOrder_ProductID.SelectedItem);
							cmd.Parameters.AddWithValue("@prodName", cashierOrder_ProductName.Text.Trim());
							cmd.Parameters.AddWithValue("@cat", cashierOrder_category.SelectedItem);
							cmd.Parameters.AddWithValue("@qty", cashierOrder_ProductQty.Value);
							cmd.Parameters.AddWithValue("@origPrice", getPricee);

							float totalPrice = (getPricee * (int)cashierOrder_ProductQty.Value);

							cmd.Parameters.AddWithValue("@totalPrice", totalPrice);

							DateTime today  = DateTime.Today;

							cmd.Parameters.AddWithValue("@date", today);
							cmd.ExecuteNonQuery();
							

						}
					} catch (Exception ex)
					{
						MessageBox.Show("Failed connection" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally
					{
						con.Close() ;
					}
				}
			}
		}

		private int idGen;
		public void IDGenerator()
		{
			using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30"))
			{
				con.Open();

				string selectData = "SELECT MAX(customer_id) from customers";

				using (SqlCommand cmd = new SqlCommand(selectData,con))
				{
					object result = cmd.ExecuteScalar();

					if (result != DBNull.Value)
					{
						int temp = Convert.ToInt32(result);

						if (temp == 0)
						{
							idGen = 1;
						}
						else
						{
							idGen = temp + 1;
						}
					}
					else
					{
						idGen = 1;
					}
				}
			}
		}
	}
}
