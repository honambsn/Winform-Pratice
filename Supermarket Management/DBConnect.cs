using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Management
{
	internal class DBConnect
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		private string con;
		public string myConnection()
		{
			con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\POS_new.mdf;Integrated Security=True;Connect Timeout=30;";
			return con;
		}

		public DataTable GetTable(string query)
		{
			cn.ConnectionString = myConnection();
			cm = new SqlCommand (query, cn);
			SqlDataAdapter adapter = new SqlDataAdapter(cm);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;

		}

	}
}
