using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
			cm = new SqlCommand(query, cn);
			SqlDataAdapter adapter = new SqlDataAdapter(cm);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;

		}

		public void ExcuteQuery(String query)
		{
			try
			{
				cn.ConnectionString = myConnection();
				cn.Open();
				cm = new SqlCommand(query, cn);
				cm.ExecuteNonQuery();
				cn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

	
		public DataTable ExecuteQueryMultiParams(string query, params SqlParameter[] parameters)
		{
			try
			{
				cn.ConnectionString = myConnection();
				if (cn.State == ConnectionState.Closed)
				{
					cn.ConnectionString = myConnection();
					cn.Open();
				}

				{
					using (SqlCommand cmd = new SqlCommand(query, cn))
					{
						cmd.Parameters.AddRange(parameters);

						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							DataTable dt = new DataTable();
							dt.Load(reader);
							return dt;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}
	}
}
