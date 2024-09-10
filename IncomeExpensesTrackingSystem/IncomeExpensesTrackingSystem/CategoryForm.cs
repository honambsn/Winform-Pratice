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
		string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";
		public CategoryForm()
		{
			InitializeComponent();
			displayCategoryList();
		}

		public void refreshData()
		{
			if (InvokeRequired)
			{
				Invoke((MethodInvoker)refreshData);
				return;
			}

			displayCategoryList();
		}

		public void displayCategoryList()
		{
			CategoryData cData = new CategoryData();
			List<CategoryData> listData = cData.categoryListData();

			category_DataGridView.DataSource = listData;

			//category_DataGridView.Columns["Date"].DefaultCellStyle.Format = "MM-dd-yyyy";
			
		}

		private void category_AddBtn_Click(object sender, EventArgs e)
		{
			if(category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
			{
				MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				try
				{
					using (SqlConnection con = new SqlConnection(connectionString))
					{
						con.Open();

						string insertData = "insert into categories (category, type, status, date) " + "values(@category, @type, @status, @date)";

						using (SqlCommand cmd = new SqlCommand(insertData, con))
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
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
				}
				finally
				{
					clearFields();
					displayCategoryList();
				}
			}
		}

		private void category_DelBtn_Click(object sender, EventArgs e)
		{
			if (category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
			{
				MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to Delete ID: " + getID + "?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					try
					{

						using (SqlConnection con = new SqlConnection(connectionString))
						{
							con.Open();

							string deleteData = "delete from categories where id = @id";

							using (SqlCommand cmd = new SqlCommand(deleteData, con))
							{
								cmd.Parameters.AddWithValue("@id", getID);
								

								cmd.ExecuteNonQuery();

								MessageBox.Show("Category deleted successfully!!!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}

							con.Close();
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
					}
					finally
					{
						clearFields();
						displayCategoryList();
					}
				}
			}
		}

		public void clearFields()
		{
			category_category.Text = "";
			category_type.SelectedIndex = -1;
			category_status.SelectedIndex = -1;
		}

		private void category_ClearBtn_Click(object sender, EventArgs e)
		{
			clearFields();
		}

		private void category_UpdateBtn_Click(object sender, EventArgs e)
		{
			if (category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
			{
				MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to Update ID: " + getID + "?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					try
					{

						using (SqlConnection con = new SqlConnection(connectionString))
						{
							con.Open();

							string updateData = "update categories set category = @category, type = @type, status = @status where id = @id";

							using (SqlCommand cmd = new SqlCommand(updateData, con))
							{
								cmd.Parameters.AddWithValue("@id", getID);
								cmd.Parameters.AddWithValue("@category", category_category.Text.Trim());
								cmd.Parameters.AddWithValue("@type", category_type.SelectedItem);
								cmd.Parameters.AddWithValue("@status", category_status.SelectedItem);

								cmd.ExecuteNonQuery();

								MessageBox.Show("Category updated successfully!!!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}

							con.Close();
						}
					} catch (Exception ex) 
					{
						MessageBox.Show("Error: " +ex, "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
					}
					finally
					{
						clearFields();
						displayCategoryList();
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

				getID = Convert.ToInt32(row.Cells[0].Value);
				category_category.Text = row.Cells[1].Value.ToString();
				category_type.SelectedItem = row.Cells[2].Value.ToString();
				category_status.SelectedItem = row.Cells[3].Value.ToString();
			}
		}
	}
}
