using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpensesTrackingSystem
{
	internal class IncomeData
	{
		string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";
		
		public int ID { get; set; }
		public string Category { get; set; }
		public string Item { get; set; }
		public float Income { get; set; }
		public string Description { get; set; }
		public string DateIncome {  get; set; }
		public List<IncomeData> incomeListData()
		{
			List<IncomeData> listData = new List<IncomeData> ();

			using(SqlConnection  connect = new SqlConnection (connectionString))
			{
				connect.Open();

				string selectData = "select * from income";

				using(SqlCommand cmd = new SqlCommand (selectData, connect))
				{
					SqlDataReader reader = cmd.ExecuteReader();
                    
					while (reader.Read())
                    {
                        IncomeData iData = new IncomeData();
						iData.ID = (int)reader["id"];
						iData.Category = reader["category"].ToString();
						iData.Item = reader["item"].ToString();
						iData.Income = Convert.ToSingle(reader["income"]);
						iData.Description = reader["description"].ToString();
						iData.DateIncome = ((DateTime)reader["date_income"]).ToString("MM-dd-yyyy");

						listData.Add(iData);
                    }

                }
			}
			return listData;
		}
		
	}
}
