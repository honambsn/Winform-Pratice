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

				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
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

		public String getPassword(string username)
		{
			string password = "";
			try
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
				cn.ConnectionString = myConnection();
				cn.Open();
				cm = new SqlCommand("select password from Users where username = @username", cn);
				cm.Parameters.AddWithValue("@username", username);
				SqlDataReader dr = cm.ExecuteReader();
				dr.Read();
				if (dr.HasRows)
				{
					password = dr["password"].ToString();
				}
				dr.Close();
				cn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			return password;
		}

		public double ExtractData(string sql)
		{
			double data = 0.0;

			// Ensure the connection is open
			if (cn.State == ConnectionState.Open)
			{
				cn.Close();
			}
			cn.ConnectionString = myConnection();
			cn.Open();

			try
			{
				using (SqlCommand cm = new SqlCommand(sql, cn))
				{
					// Execute the scalar query and get the result
					object result = cm.ExecuteScalar();

					// Check if the result is not null and convert to double
					if (result != null && double.TryParse(result.ToString(), out data))
					{
						return data;
					}
					else
					{
						// Handle the case when the result is null or not a valid double
						throw new InvalidOperationException("The query did not return a valid double value.");
					}
				}
			}
			catch (Exception ex)
			{
				// Log or handle the exception as necessary
				Console.WriteLine($"Error executing SQL query: {ex.Message}");
				// Return 0 or handle as needed
				return 0.0;
			}
			finally
			{
				// Ensure connection is closed after execution
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
			}
		}


	}
}
