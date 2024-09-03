using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
	public partial class CategoryForm : UserControl
	{
		string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False";
		public CategoryForm()
		{
			InitializeComponent();
		}

		private void category_AddBtn_Click(object sender, EventArgs e)
		{
			if(category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
			{
				MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				using(SqlConnection con  = new SqlConnection(connectionString))
				{
					con.Open();

					string insertData = "insert into categories (category, type, status, date) " + "values(@category, @type, @status, @date)";

					using(SqlCommand cmd = new SqlCommand(insertData, con))
					{
						cmd.Parameters.AddWithValue("@category", category_category.Text.Trim());
						cmd.Parameters.AddWithValue("@type", category_type.SelectedItem);
						cmd.Parameters.AddWithValue("@status", category_status.SelectedItem);

						DateTime today = DateTime.Today;
						cmd.Parameters.AddWithValue("@date", today);

						cmd.ExecuteNonQuery();

						MessageBox.Show("Category added successfully!!!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}

					con.Close();
				}
			}
		}
	}
}
