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
	public partial class IncomeForm : UserControl
	{
		string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";
		public IncomeForm()
		{
			InitializeComponent();
			displayCategoryList();
			displayIncomeData();
		}

		public void refreshData()
		{
			if(InvokeRequired)
			{
				Invoke((MethodInvoker)refreshData);
				return;
			}
			displayCategoryList();
			displayIncomeData();
		}

		public void displayIncomeData()
		{
			IncomeData iData = new IncomeData();
			List<IncomeData> listData = iData.incomeListData();

			category_DataGridView.DataSource = listData;
		}

		public void displayCategoryList()
		{
			using(SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();

				string selectData = "select category from categories where type = @type and status = @status";

				using (SqlCommand cmd = new SqlCommand(selectData, con))
				{
					cmd.Parameters.AddWithValue("@type", "Income");
					cmd.Parameters.AddWithValue("@status", "Active");

					income_Category.Items.Clear();
					SqlDataReader reader = cmd.ExecuteReader();

					while (reader.Read())
					{
						income_Category.Items.Add(reader["category"].ToString());
					}
				}

				con.Close();
			}
		}
		private void income_AddBtn_Click(object sender, EventArgs e)
		{
			if(income_Category.SelectedIndex == -1 || income_Item.Text == "" || income_Income.Text == "" || income_Description.Text == "")
			{
				MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(connectionString))
					{
						conn.Open();

						string insertData = "insert into income (category, item, income, description, date_income, date_insert) " + "values(@category, @item, @income, @description, @date_income, @date_insert)";

						using (SqlCommand cmd = new SqlCommand(insertData, conn))
						{
							cmd.Parameters.AddWithValue("@category", income_Category.SelectedItem);
							cmd.Parameters.AddWithValue("@item", income_Item.Text);
							cmd.Parameters.AddWithValue("@income", income_Income.Text);
							cmd.Parameters.AddWithValue("@description", income_Description.Text);
							cmd.Parameters.AddWithValue("@date_income", income_DateTimePicker.Value);

							DateTime today = DateTime.Today;
							cmd.Parameters.AddWithValue("@date_insert", today);

							cmd.ExecuteNonQuery();
							clearFields();
							displayIncomeData();
							MessageBox.Show("Income added successfylly!!!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}

						conn.Close();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					
				}
			}
		}

		public void clearFields()
		{
			income_Item.Text = "";
			income_Category.SelectedIndex = -1;
			income_Income.Text = "";
			income_Description.Text = "";
		}
		private void income_DelBtn_Click(object sender, EventArgs e)
		{
			if (income_Category.SelectedIndex == -1 || income_Item.Text == "" || income_Income.Text == "" || income_Description.Text == "")
			{
				MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to delete ID: " + getID + "?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						using (SqlConnection conn = new SqlConnection(connectionString))
						{
							conn.Open();

							string delData = "delete from income where id = @id";

							using (SqlCommand cmd = new SqlCommand(delData, conn))
							{
								cmd.Parameters.AddWithValue("@id", getID);

								cmd.ExecuteNonQuery();
								clearFields();
								displayIncomeData();
								MessageBox.Show("Income deleted successfylly!!!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}

							conn.Close();
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally
					{
						
					}
				}
			}
		}

		private void income_UpdateBtn_Click(object sender, EventArgs e)
		{
			if (income_Category.SelectedIndex == -1 || income_Item.Text == "" || income_Income.Text == "" || income_Description.Text == "")
			{
				MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to update ID: " + getID + "?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						using (SqlConnection conn = new SqlConnection(connectionString))
						{
							conn.Open();

							string updateData = "update income set category = @category, item = @item, income = @income, description = @description, date_income = @date_income where id = @id";

							using (SqlCommand cmd = new SqlCommand(updateData, conn))
							{
								cmd.Parameters.AddWithValue("@category", income_Category.SelectedItem);
								cmd.Parameters.AddWithValue("@item", income_Item.Text);
								cmd.Parameters.AddWithValue("@income", income_Income.Text);
								cmd.Parameters.AddWithValue("@description", income_Description.Text);
								cmd.Parameters.AddWithValue("@date_income", income_DateTimePicker.Value);
								cmd.Parameters.AddWithValue("@id", getID);

								cmd.ExecuteNonQuery();
								clearFields();
								displayIncomeData();
								MessageBox.Show("Income updated successfylly!!!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}

							conn.Close();
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally
					{
						
					}
				}
			}
		}

		private int getID = 0;
		private void category_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex != -1)
			{
				DataGridViewRow row = category_DataGridView.Rows[e.RowIndex];

				getID = (int)row.Cells[0].Value;
				income_Category.SelectedItem = row.Cells[1].Value.ToString();
				income_Item.Text = row.Cells[2].Value.ToString();
				income_Income.Text = row.Cells[3].Value.ToString();
				income_Description.Text = row.Cells[4].Value.ToString();
				income_DateTimePicker.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
			}
		}

		private void income_ClearBtn_Click(object sender, EventArgs e)
		{
			clearFields();
		}
	}
}
