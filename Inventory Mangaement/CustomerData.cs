using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Mangaement
{
	internal class CustomerData
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");

		public string CustomerID { get; set; }
		public string TotalPrice { get; set; }
		public string Amount { get; set; }
		public string Change { get; set; }
		public string Date { get; set; }
		public List<CustomerData> allCustomer()
		{
			List<CustomerData> listData = new List<CustomerData>();

			if (con.State != ConnectionState.Open)
			{
				try
				{
					con.Open();

					string selectData = "SELECT * FROM customers";

					using (SqlCommand cmd = new SqlCommand(selectData, con))
					{
						SqlDataReader reader = cmd.ExecuteReader();

						while (reader.Read())
						{
							CustomerData cData = new CustomerData();

							cData.CustomerID = reader["customer_id"].ToString();
							cData.TotalPrice = reader["total_price"].ToString();
							cData.Amount = reader["amount"].ToString();
							cData.Change = reader["change"].ToString();
							cData.Date = reader["order_date"].ToString();

							listData.Add(cData);
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
			return listData;
		}
	}
}
