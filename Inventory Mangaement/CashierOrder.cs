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
			displayTotalPrice();
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

		private float totalPrice = 0;
		public void displayTotalPrice()
		{
			IDGenerator();
			if (checkConnection())
			{
				try
				{
					con.Open();

					string selectData = "SELECT SUM(total_price) FROM orders WHERE customer_id = @cID";

					using(SqlCommand cmd = new SqlCommand(selectData, con))
					{
						cmd.Parameters.AddWithValue("@cID", idGen);

						object result = cmd.ExecuteScalar();

						if (result != DBNull.Value)
						{
							totalPrice = Convert.ToSingle(result);

							cashierOrder_TotalPrice.Text = totalPrice.ToString("0.00");
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

							MessageBox.Show("Add order successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
			displayAllOrder();
			displayTotalPrice();
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

		private void cashierOrder_btnRemove_Click(object sender, EventArgs e)
		{
			if (prodID == 0)
			{
				MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to Remove ID: " + prodID + "?", "Confirm Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (checkConnection())
					{
						try
						{
							con.Open();

							string deleteData = "DELETE FROM orders WHERE id = @id";

							using (SqlCommand cmd = new SqlCommand(deleteData, con))
							{
								cmd.Parameters.AddWithValue("@id", prodID);

								cmd.ExecuteNonQuery();

								MessageBox.Show("Remove successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
			displayAllOrder();
			displayTotalPrice();
		}

		private int prodID = 0;
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			

		}

		private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

				prodID = (int)row.Cells[0].Value;
			}
		}

		public void clearFields()
		{
			cashierOrder_category.SelectedIndex = -1;
			cashierOrder_ProductID.SelectedIndex = -1;
			cashierOrder_ProductName.Text = "";
			cashierOrder_ProductPrice.Text = "";
			cashierOrder_ProductQty.Value = 0;
		}

		private void cashierOrder_btnClear_Click(object sender, EventArgs e)
		{

			clearFields();
		}

		private static readonly char[] Characters =
		"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();

		public static string GenerateRandomString()
		{
			int length = 4;

			var random = new Random();
			var result = new char[length];

			for (int i = 0; i < length; i++)
			{
				result[i] = Characters[random.Next(Characters.Length)];
			}

			return new string(result);
		}

		private void cashierOrder_btnPayOrder_Click(object sender, EventArgs e)
		{
			IDGenerator();
			string code = GenerateRandomString() + "@cID";

			if(cashierOrder_Amount.Text == "" || dataGridView2.Rows.Count < 0)
			{
				MessageBox.Show("Something wrong", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if(MessageBox.Show("Are you sure to pay your orders?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (checkConnection())
					{
						try
						{
							con.Open();

							string insertData = "INSERT INTO customers (customer_id, prod_id, total_price, amount, change, order_date, order_code)" + "VALUES(@cID, @prodID, @totalPrice, @amount, @change, @date, @order_code)";


							using (SqlCommand cmd = new SqlCommand(insertData, con))
							{
								cmd.Parameters.AddWithValue("@cID", idGen);
								cmd.Parameters.AddWithValue("@prodID", cashierOrder_ProductID.SelectedItem);
								cmd.Parameters.AddWithValue("@totalPrice", cashierOrder_TotalPrice.Text);
								cmd.Parameters.AddWithValue("@amount", cashierOrder_Amount.Text);
								cmd.Parameters.AddWithValue("@change", cashierOrder_Change.Text);
								

								DateTime today = DateTime.Today;
								
								cmd.Parameters.AddWithValue("@date", today);
								cmd.Parameters.AddWithValue("@order_code", code);
								cmd.ExecuteNonQuery();
								clearFields();
								MessageBox.Show("Paid successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}

						} catch (Exception ex)
						{
							MessageBox.Show("Failed connection" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						finally
						{
							//string deleteData = "DELETE FROM orders WHERE id = @id";
							displayAllOrder();
							con.Close();
						}
					}
				}
			}
			cashierOrder_category.Text = "";
			cashierOrder_Change.Text = "";
			cashierOrder_Amount.Text = "";
			cashierOrder_TotalPrice.Text = "";
			displayAllOrder();
			displayTotalPrice();
		}

		private void cashierOrder_Amount_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				try
				{
					float getAmount = Convert.ToSingle(cashierOrder_Amount.Text);
					float getChange = (getAmount - totalPrice);
					if (getChange <= -1)
					{
						MessageBox.Show("Not Enough Money" , "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						cashierOrder_Amount.Text = "";
						cashierOrder_Change.Text = "";
					}
					else
					{
						cashierOrder_Change.Text = getChange.ToString("0.00");
					}
                }
                catch(Exception ex) 
				{
					MessageBox.Show("Somthing wrong" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cashierOrder_Amount.Text = "";
					cashierOrder_Change.Text = "";
				}
			}
		}
	}
}
