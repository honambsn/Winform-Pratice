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
	public partial class ExpensesForm : UserControl
	{
		string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";
		public ExpensesForm()
		{
			InitializeComponent();
			displayCategoryList();
			displayExpenseData();
		}

		public void displayCategoryList()
		{

			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();

				string selectData = "select category from categories where type = @type and status = @status";

				using (SqlCommand cmd = new SqlCommand(selectData, con))
				{
					cmd.Parameters.AddWithValue("@type", "Income");
					cmd.Parameters.AddWithValue("@status", "Active");

					expenses_Category.Items.Clear();
					SqlDataReader reader = cmd.ExecuteReader();

					while (reader.Read())
					{
						expenses_Category.Items.Add(reader["category"].ToString());
					}
				}

				con.Close();
			}
		}

		public void displayExpenseData()
		{
			ExpensesData eData = new ExpensesData();
			List<ExpensesData> listData = eData.expenseListData();

			expense_DataGridView.DataSource = listData;
		}

		public void clearFields()
		{
			expenses_Item.Text = "";
			expenses_Category.SelectedIndex = -1;
			expenses_Cost.Text = "";
			expenses_Description.Text = "";
		}

		private int getID = 0;

		private void expenses_AddBtn_Click(object sender, EventArgs e)
		{
			if (expenses_Category.SelectedIndex == -1 || expenses_Item.Text == "" || expenses_Cost.Text == "" || expenses_Description.Text == "")
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

						string insertData = "insert into expenses (category, item, cost, description, date_expense, date_insert) " + "values(@category, @item, @cost, @description, @date_expense, @date_insert)";
				
						using (SqlCommand cmd = new SqlCommand(insertData, conn))
						{
							cmd.Parameters.AddWithValue("@category", expenses_Category.SelectedItem);
							cmd.Parameters.AddWithValue("@item", expenses_Item.Text);
							cmd.Parameters.AddWithValue("@cost", expenses_Cost.Text);
							cmd.Parameters.AddWithValue("@description", expenses_Description.Text);
							cmd.Parameters.AddWithValue("@date_expense", expenses_DateTimePicker.Value);

							DateTime today = DateTime.Today;
							cmd.Parameters.AddWithValue("@date_insert", today);

							cmd.ExecuteNonQuery();
							clearFields();
							displayExpenseData();
							MessageBox.Show("Expense added successfylly!!!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void expenses_UpdateBtn_Click(object sender, EventArgs e)
		{
			if (expenses_Category.SelectedIndex == -1 || expenses_Item.Text == "" || expenses_Cost.Text == "" || expenses_Description.Text == "")
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

							string updateData = "update expenses set category = @category, item = @item, cost = @cost, description = @description, date_expense = @date_expense where id = @id";

							using (SqlCommand cmd = new SqlCommand(updateData, conn))
							{
								cmd.Parameters.AddWithValue("@category", expenses_Category.SelectedItem);
								cmd.Parameters.AddWithValue("@item", expenses_Item.Text);
								cmd.Parameters.AddWithValue("@cost", expenses_Cost.Text);
								cmd.Parameters.AddWithValue("@description", expenses_Description.Text);
								cmd.Parameters.AddWithValue("@date_expense", expenses_DateTimePicker.Value);
								cmd.Parameters.AddWithValue("@id", getID);

								cmd.ExecuteNonQuery();
								clearFields();
								displayExpenseData();
								MessageBox.Show("Expense updated successfylly!!!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void expenses_DelBtn_Click(object sender, EventArgs e)
		{
			if (expenses_Category.SelectedIndex == -1 || expenses_Item.Text == "" || expenses_Cost.Text == "" || expenses_Description.Text == "")
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

							string delData = "delete from expenses where id = @id";

							using (SqlCommand cmd = new SqlCommand(delData, conn))
							{
								cmd.Parameters.AddWithValue("@id", getID);

								cmd.ExecuteNonQuery();
								clearFields();
								displayExpenseData();
								MessageBox.Show("Expenses deleted successfylly!!!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void expenses_ClearBtn_Click(object sender, EventArgs e)
		{
			clearFields();
		}

		private void expense_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				DataGridViewRow row = expense_DataGridView.Rows[e.RowIndex];

				getID = (int)row.Cells[0].Value;
				expenses_Category.SelectedItem = row.Cells[1].Value.ToString();
				expenses_Item.Text = row.Cells[2].Value.ToString();
				expenses_Cost.Text = row.Cells[3].Value.ToString();
				expenses_Description.Text = row.Cells[4].Value.ToString();
				expenses_DateTimePicker.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
			}
		}

	}
}
