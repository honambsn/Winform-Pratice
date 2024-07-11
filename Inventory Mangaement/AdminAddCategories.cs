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

namespace Inventory_Mangaement
{
	public partial class AdminAddCategories : UserControl
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
		public AdminAddCategories()
		{
			InitializeComponent();
			drawCenter();
			displayAllCategoryData();
		}

		private void drawCenter()
		{
			int XdataGridPos = (this.panel2.Width - this.dataGridView1.Width) / 2;

			dataGridView1.Location = new Point(XdataGridPos, 50);
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;
		}

		public void displayAllCategoryData()
		{
			
			CategoriesData cData = new CategoriesData();

			List<CategoriesData> listData = cData.AllCategoriesData();

			dataGridView1.DataSource = listData;
		}

		private void btn_AddCategory_Click(object sender, EventArgs e)
		{
			if (txt_AddCategory.Text == "")
			{
				MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (checkConnection())
				{
					try
					{
						con.Open();
						string checkUsername = "SELECT * FROM categories WHERE category = @category";
						using (SqlCommand cmd = new SqlCommand(checkUsername, con))
						{
							cmd.Parameters.AddWithValue("@category", txt_AddCategory.Text.Trim());

							SqlDataAdapter adapter = new SqlDataAdapter(cmd);
							DataTable table = new DataTable();
							adapter.Fill(table);

							if (table.Rows.Count > 0)
							{
								MessageBox.Show(txt_AddCategory.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else
							{
								string insertData = "INSERT INTO categories (category, date) " + "VALUES(@category, @date)";
								using (SqlCommand insertD = new SqlCommand(insertData, con))
								{
									insertD.Parameters.AddWithValue("@category", txt_AddCategory.Text.Trim());

									DateTime today = DateTime.Today;
									insertD.Parameters.AddWithValue("@date", today);
									insertD.ExecuteNonQuery();
									con.Close();

									MessageBox.Show("Added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
									displayAllCategoryData();
									ClearFields();
								}
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally
					{
						con.Close();
					}
				}
			}
		}

		public bool checkConnection()
		{
			if (con.State == ConnectionState.Closed) return true;
			else return false;
		}

		public void ClearFields()
		{
			txt_AddCategory.Text = "";
		}

		private void btn_ClearCategory_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to clear?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				ClearFields();
		}

		private int getID = 0;
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

				getID = (int)row.Cells[0].Value;
				string category = row.Cells[1].Value.ToString();

				txt_AddCategory.Text = category;
			}
		}

		private void btn_UpdateCategory_Click(object sender, EventArgs e)
		{
			if (txt_AddCategory.Text == "")
			{
				MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to update category ID: " + getID + " ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (checkConnection())
					{
						try
						{
							con.Open();

							string updateData = "UPDATE categories SET category  = @category where id = @id";

							using (SqlCommand updateD = new SqlCommand(updateData, con))
							{
								updateD.Parameters.AddWithValue("@category", txt_AddCategory.Text.Trim());
								updateD.Parameters.AddWithValue("@id", getID);

								updateD.ExecuteNonQuery();
								con.Close();
								MessageBox.Show("Updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

								ClearFields();
								displayAllCategoryData();

							}
						}
						catch (Exception ex)
						{
							MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						finally
						{
							con.Close();
						}
					}
				}

			}
		}

		private void btn_RemoveCategory_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to Remove user ID: " + getID + " ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (checkConnection())
				{
					try
					{
						con.Open();

						string updateData = "DELETE FROM categories WHERE id = @id";

						using (SqlCommand updateD = new SqlCommand(updateData, con))
						{

							updateD.Parameters.AddWithValue("@id", getID);

							updateD.ExecuteNonQuery();
							con.Close();
							MessageBox.Show("Removed successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

							ClearFields();
							displayAllCategoryData();

						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally
					{
						con.Close();
					}
				}
			}
		}
	}
}
