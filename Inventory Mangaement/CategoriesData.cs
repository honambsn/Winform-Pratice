using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Mangaement
{
	class CategoriesData
	{
		public int ID { get; set; }
		public string Category { get; set; }
		public string Date { get; set; }
		public List<CategoriesData> AllCategoriesData()
		{
			List<CategoriesData> listData = new List<CategoriesData>();

			using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30"))
			{
				con.Open();

				string selectData = "SELECT * FROM categories";

				using (SqlCommand cmd = new SqlCommand(selectData, con))
				{
					SqlDataReader reader = cmd.ExecuteReader();

					while (reader.Read())
					{
						CategoriesData cData = new CategoriesData();
						cData.ID = (int)reader["id"];
						cData.Category = (string)reader["category"].ToString();
						cData.Date = reader["date"].ToString();
						listData.Add(cData);
					}
				}
			}

			return listData;
		}
	}
}
