using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Mangaement
{
	public partial class AdminAddProducts : UserControl
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
		public AdminAddProducts()
		{
			InitializeComponent();
			drawCenter();
			displayCategories();
			displayAllProducts();
		}

		public void refreshData()
		{
			if (InvokeRequired)
			{
				Invoke((MethodInvoker)refreshData);
				return;
			}

			displayCategories();
			displayAllProducts();
		}

		private void drawCenter()
		{
			// Form dimensions
			this.Width = 1080;
			this.Height = 675;

			// Panel margins and distance
			int marginLR = 15; // Left and right margin
			int marginTB = 30; // Top and bottom margin
			int panelDistance = 30; // Distance between panels

			// Panel 1 dimensions and location
			int panel1Height = (this.ClientSize.Height - marginTB * 2 - panelDistance) * 2 / 3;
			int panel1Width = this.ClientSize.Width - marginLR * 2;
			Panel panel1 = new Panel
			{
				Width = panel1Width,
				Height = panel1Height,
				Location = new Point(marginLR, marginTB)
			};

			// Panel 2 dimensions and location
			int panel2Height = (this.ClientSize.Height - marginTB * 2 - panelDistance) * 1 / 3;
			int panel2Width = this.ClientSize.Width - marginLR * 2;
			Panel panel2 = new Panel
			{
				Width = panel2Width,
				Height = panel2Height,
				Location = new Point(marginLR, panel1.Location.Y + panel1.Height + panelDistance),
				BackColor = Color.LightGreen // Example background color
			};

			// Add panels to the form
			this.Controls.Add(panel1);
			this.Controls.Add(panel2);

		}

		public void displayAllProducts()
		{
			AddProductData pData = new AddProductData();
			List<AddProductData> listData = pData.AllProductData();
			dataGridView1.DataSource = listData;
		}

		public void displayCategories()
		{
			if (checkConnection())
			{
				try
				{
					con.Open();

					string selectData = "SELECT * FROM categories";

					using(SqlCommand cmd = new SqlCommand(selectData, con))
					{
						SqlDataReader reader = cmd.ExecuteReader();


						if (reader.HasRows)
						{
							while(reader.Read())
							{
								cb_ProductCategory.Items.Add(reader["category"].ToString());
							}
						}
					}

				}
				catch (Exception ex) 
				{
					MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				
				finally
				{
					con.Close();
				}

			}
		}
		
		public bool emptyFields()
		{
			if (txt_ProductID.Text == "" || txt_ProductName.Text == "" || txt_ProductPrice.Text == "" || txt_ProductStock.Text == "" || cb_ProductCategory.SelectedIndex == -1 || cb_ProductStatus.SelectedIndex == -1 || productImageView.Image == null)
				return true;
			return false;
			
		}


		public bool checkConnection()
		{
			if (con.State != ConnectionState.Open) return true;
			else return false;
		}

		private void btn_Import_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog dialog = new OpenFileDialog();
				dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
				string imagePath = "";

				if (dialog.ShowDialog() == DialogResult.OK)
				{
					imagePath = dialog.FileName;
					productImageView.ImageLocation = imagePath;
					
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_addProduct_Click(object sender, EventArgs e)
		{
			if (emptyFields())
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
						string selectData = "SELECT * FROM products WHERE prod_id = @prod_id";
						using (SqlCommand cmd = new SqlCommand(selectData, con))
						{
							cmd.Parameters.AddWithValue("@prod_id", txt_ProductID.Text.Trim());

							SqlDataAdapter adapter = new SqlDataAdapter(cmd);
							DataTable table = new DataTable();

							adapter.Fill(table);

							if (table.Rows.Count > 0)
							{
								btn_addProduct.Enabled = false;
								btn_addProduct.BackColor = Color.LightGray; // Custom background color for disabled state
								btn_addProduct.ForeColor = Color.DarkGray;  // Custom text color for disabled state
								MessageBox.Show("Existed Product: " + txt_ProductID.Text.Trim() , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else
							{
								string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
								string relativePath = Path.Combine("Product_Directory", txt_ProductID.Text.Trim() + ".jpg");
								string path = Path.Combine(baseDirectory, relativePath);

								string directoryPath = Path.GetDirectoryName(path);

								if (!Directory.Exists(directoryPath))
								{
									Directory.CreateDirectory(directoryPath);
								}

								File.Copy(productImageView.ImageLocation, path, true);
								string insertData = "INSERT INTO products " +
								"(prod_id, prod_name, category, price, stock, image_path, status, insert_date) " + "VALUES (@prod_id, @prodName, @category, @price, @stock, @path, @status, @date)";

								//string insertData = "INSERT INTO test (val) VALUES(@val)";

								using (SqlCommand insertD = new SqlCommand(insertData, con))
								{
									insertD.Parameters.AddWithValue("@prod_id", txt_ProductID.Text.Trim()); 
									insertD.Parameters.AddWithValue("@prodName", txt_ProductName.Text.Trim()); 
									insertD.Parameters.AddWithValue("@category", cb_ProductCategory.SelectedItem); 
									insertD.Parameters.AddWithValue("@price", txt_ProductPrice.Text.Trim()); 
									insertD.Parameters.AddWithValue("@stock", txt_ProductStock.Text.Trim()); 
									insertD.Parameters.AddWithValue("@path", path);
									insertD.Parameters.AddWithValue("@status", cb_ProductStatus.SelectedItem);

									DateTime today = DateTime.Today;
									insertD.Parameters.AddWithValue("@date", today);

									insertD.ExecuteNonQuery();
									clearFields();
									displayAllProducts();

									con.Close();
									MessageBox.Show("Added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
								}
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally
					{
						con.Close();
					}
					
				}
				
			}
					
		}

		public void clearFields()
		{
			txt_ProductID.Text = "";
			txt_ProductName.Text = "";
			txt_ProductPrice.Text = "";
			txt_ProductStock.Text = "";
			cb_ProductCategory.SelectedIndex = -1;
			cb_ProductStatus.SelectedIndex = -1;

			//btn_updateProduct.BackColor = Color.LightGray;
			//btn_updateProduct.ForeColor = Color.DarkGray;
			//btn_updateProduct.Enabled = false;

			//btn_removeProduct.BackColor = Color.LightGray;
			//btn_removeProduct.ForeColor = Color.DarkGray;
			//btn_removeProduct.Enabled = false;
		}
		private void btn_clearProduct_Click(object sender, EventArgs e)
		{
			clearFields();
			MessageBox.Show("Clear successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private int getID = 0;
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

				getID = (int)row.Cells[0].Value;

				txt_ProductID.Text = row.Cells[1].Value.ToString();
				txt_ProductName.Text = row.Cells[2].Value.ToString();
				cb_ProductCategory.Text = row.Cells[3].Value.ToString();
				txt_ProductPrice.Text = row.Cells[4].Value.ToString();
				txt_ProductStock.Text = row.Cells[5].Value.ToString();

				string imgPath = row.Cells[6].Value.ToString();

				try
				{
					if (imgPath != null)
					{
						productImageView.Image = Image.FromFile(imgPath);
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				cb_ProductStatus.Text = row.Cells[7].Value.ToString();
			}
		}

		private void btn_updateProduct_Click(object sender, EventArgs e)
		{
			if (emptyFields())
			{
				MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{ 
				if (MessageBox.Show("Are you sure you want to UPDATE product ID: " + getID + " ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (checkConnection())
					{
						try
						{
							con.Open();							
							string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
							
							string updateData = "UPDATE products SET prod_id = @prod_id, prod_name = @prodName, category = @category, price = @price, stock = @stock, insert_date = @date, status = @status WHERE id = @id";

							using (SqlCommand updateD = new SqlCommand(updateData, con))
							{
								updateD.Parameters.AddWithValue("@prod_id", txt_ProductID.Text.Trim());
								updateD.Parameters.AddWithValue("@prodName", txt_ProductName.Text.Trim());
								updateD.Parameters.AddWithValue("@category", cb_ProductCategory.SelectedItem);
								updateD.Parameters.AddWithValue("@price", txt_ProductPrice.Text.Trim());
								updateD.Parameters.AddWithValue("@stock", txt_ProductStock.Text.Trim());
								updateD.Parameters.AddWithValue("@id", getID);
								updateD.Parameters.AddWithValue("@status", cb_ProductStatus.SelectedItem);

								DateTime today = DateTime.Today;
								updateD.Parameters.AddWithValue("@date", today);

								updateD.ExecuteNonQuery();
								clearFields();
								displayAllProducts();

								con.Close();
								MessageBox.Show("Updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
							
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						finally
						{
							displayAllProducts();
							con.Close();
						}

					}

				}

			}
		}

		private void btn_removeProduct_Click(object sender, EventArgs e)
		{
			if (emptyFields())
			{
				MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to DELETE product ID: " + getID + " ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (checkConnection())
					{
						try
						{
							con.Open();
							string delData = "DELETE FROM products WHERE id = @id";

							using (SqlCommand delD = new SqlCommand(delData, con))
							{

								delD.Parameters.AddWithValue("@id", getID);


								delD.ExecuteNonQuery();
								clearFields();
								displayAllProducts();

								con.Close();
								MessageBox.Show("Deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						finally
						{
							displayAllProducts();
							con.Close();
						}

					}

				}

			}
		}
	}

}
