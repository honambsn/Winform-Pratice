using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Mangaement
{

	class AddProductData
	{
		public int ID { get; set; }
		public string ProdID { get; set; }
		public string ProdName { get; set; }
		public string Category { get; set; }
		public string Price { get; set; }
		public string Stock { get; set; }
		public string ImagePath {  get; set; }
		public string Status { get; set; }
		public string Date { get; set; }
		public List<AddProductData> AllProductData()
		{
			List<AddProductData> listData = new List<AddProductData>();

			using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30"))
			{
				con.Open();

				string selectData = "SELECT * FROM products";

				using (SqlCommand cmd = new SqlCommand(selectData, con))
				{
					SqlDataReader reader = cmd.ExecuteReader();

					while (reader.Read())
					{
						AddProductData pData = new AddProductData();
						pData.ID = (int)reader["id"];
						pData.ProdID = reader["prod_id"].ToString();
						pData.ProdName = reader["prod_name"].ToString();
						pData.Category = reader["category"].ToString();
						pData.Price = reader["price"].ToString();
						pData.Stock = reader["stock"].ToString();
						pData.ImagePath = reader["image_path"].ToString();
						pData.Status = reader["status"].ToString();
						pData.Date = reader["insert_date"].ToString();
						listData.Add(pData);
					}
				}
			}

			return listData;
		}

		public List<AddProductData> allAvailableProducts()
		{
			List<AddProductData> listData = new List<AddProductData>();


			using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30"))
			{
				con.Open();

				string selectData = "SELECT * FROM products WHERE status = @status";

				using (SqlCommand cmd = new SqlCommand(selectData, con))
				{
					cmd.Parameters.AddWithValue("@status", "Available");

					SqlDataReader reader = cmd.ExecuteReader();

					while (reader.Read())
					{
						AddProductData pData = new AddProductData();
						pData.ID = (int)reader["id"];
						pData.ProdID = reader["prod_id"].ToString();
						pData.ProdName = reader["prod_name"].ToString();
						pData.Category = reader["category"].ToString();
						pData.Price = reader["price"].ToString();
						pData.Stock = reader["stock"].ToString();
						pData.ImagePath = reader["image_path"].ToString();
						pData.Status = reader["status"].ToString();
						pData.Date = reader["insert_date"].ToString();
						listData.Add(pData);
					}
				}
			}

			return listData;

		}
	}
}
