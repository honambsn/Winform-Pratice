using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpensesTrackingSystem
{
	internal class ExpensesData
	{
		string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";

		public int ID { get; set; }
		public string Category { get; set; }
		public string Item { get; set; }
		public float Cost { get; set; }
		public string Description { get; set; }
		public string DateExpense { get; set; }
		public List<ExpensesData> expenseListData()
		{
			List<ExpensesData> listData = new List<ExpensesData>();

			using (SqlConnection connect = new SqlConnection(connectionString))
			{
				connect.Open();

				string selectData = "select * from expenses";

				using (SqlCommand cmd = new SqlCommand(selectData, connect))
				{
					SqlDataReader reader = cmd.ExecuteReader();

					while (reader.Read())
					{
						ExpensesData eData = new ExpensesData();
						eData.ID = (int)reader["id"];
						eData.Category = reader["category"].ToString();
						eData.Item = reader["item"].ToString();
						eData.Cost = Convert.ToSingle(reader["cost"]);
						eData.Description = reader["description"].ToString();
						eData.DateExpense = ((DateTime)reader["date_expense"]).ToString("MM-dd-yyyy");

						listData.Add(eData);
					}

				}
			}
			return listData;
		}
	}
}
