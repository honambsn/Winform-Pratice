using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Mangaement
{
	class UserData
	{
		public int ID { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Role { get; set; }
		public string Status { get; set; }
		public string Date {  get; set; }
		public List<UserData> AllUsersData()
		{
			List<UserData> listData = new List<UserData>();

			using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30"))
			{
				con.Open();

				string selectData = "SELECT * FROM users";

				using(SqlCommand cmd = new SqlCommand(selectData, con)) 
				{
					SqlDataReader reader = cmd.ExecuteReader();

					while (reader.Read())
					{
						UserData uData = new UserData();
						uData.ID = (int)reader["id"];
						uData.Username = reader["username"].ToString();
						uData.Password = reader["password"].ToString();
						uData.Role = reader["role"].ToString();
						uData.Status = reader["status"].ToString();
						uData.Date = reader["date"].ToString();
						listData.Add(uData);
					}
				}
			}

			return listData;
		}
	}
}
