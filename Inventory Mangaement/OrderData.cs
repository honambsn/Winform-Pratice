using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Mangaement
{
	class OrderData
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");

		public int ID {  get; set; }
		public string CID { set; get; }
		public string PID { set; get; }
		public string PName { set; get; }
		public string Category { set; get; }
		public string OrigPrice { set; get; }
		public string QTY { set; get; }
		public string TotalPrice { set; get; }
		public string Date { set; get; }
		public string Status { set; get; }

		public List<OrderData> allOrderData()
		{
			List<OrderData> listData = new List<OrderData>();

			if (con.State == ConnectionState.Closed)
			{
				try
				{
					con.Open();

					int cusID = 0;
					string selectCusData = "SELECT MAX(customer_id) FROM orders";

					using (SqlCommand cmd = new SqlCommand(selectCusData, con))
					{
						object result = cmd.ExecuteScalar();

						if (result != DBNull.Value)
						{
							int temp = Convert.ToInt32(result);

							if (temp == 0)
							{
								cusID = 1;
							}
							else
							{
								cusID = temp;
							}
						}
						//else
						//{
						//	MessageBox.Show("There is no order yet", "Notice Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
						//}

					}
					string selectData = "SELECT * FROM orders WHERE customer_id = @cID";

					using (SqlCommand cmd = new SqlCommand(selectData, con))
					{

						cmd.Parameters.AddWithValue("@cID", cusID);

						SqlDataReader reader = cmd.ExecuteReader();

						while (reader.Read())
						{
							OrderData oData = new OrderData();

							oData.ID = (int)reader["id"];
							oData.CID = reader["customer_id"].ToString();
							oData.PID = reader["prod_id"].ToString();
							oData.PName = reader["prod_name"].ToString();
							oData.Category = reader["category"].ToString();
							oData.OrigPrice = reader["orig_price"].ToString();
							oData.QTY = reader["qty"].ToString();
							oData.TotalPrice = reader["total_price"].ToString();
							oData.Date = reader["order_date"].ToString();
							oData.Status = reader["status"].ToString();


							listData.Add(oData);
						}
					}
				}
				catch (Exception e)
				{
					MessageBox.Show("Erorr" + e, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally { con.Close(); }

			}
			return listData;
		}

	}
}
