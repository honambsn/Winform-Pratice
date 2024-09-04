using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpensesTrackingSystem
{
	internal class CategoryData
	{
		string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";

		public int ID {  get; set; }
		public string Category { get; set; }
		public string Type { get; set; }
		public string Status { get; set; }
		public string Date {  get; set; }

		public List<CategoryData> categoryListData()
		{
			List<CategoryData> listData = new List<CategoryData>();
			
			using(SqlConnection con  = new SqlConnection(connectionString))
			{
				con.Open();
				string selectData = "select * from categories";

				using (SqlCommand cmd = new SqlCommand(selectData, con))
				{
					//SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					//DataTable table = new DataTable();

					//adapter.Fill(table);

					//while (table.Rows.Count > 0)
					//{
					//	CategoryData cData = new CategoryData();

					//	cData.Category =
					//}

					SqlDataReader reader = cmd.ExecuteReader();

					while (reader.Read())
					{
						CategoryData cData = new CategoryData();
						cData.ID = (int)reader["id"];
						cData.Category = reader["category"].ToString();
						cData.Type = reader["type"].ToString();
						cData.Status = reader["status"].ToString();
						cData.Date = ((DateTime)reader["date"]).ToString("dd/MM/yyyy");

						listData.Add(cData);
						
					}

				}
			}

			return listData;
		}
	}
}
