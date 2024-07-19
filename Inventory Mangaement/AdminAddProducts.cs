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
			if (txt_ProductID.Text == "")
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
								MessageBox.Show("Value: " + txt_ProductID.Text.Trim() , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			cb_ProductCategory.SelectedItem = -1;
			cb_ProductStatus.SelectedItem = -1;
		}
		private void btn_clearProduct_Click(object sender, EventArgs e)
		{
			clearFields();
			MessageBox.Show("Clear successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}

}
