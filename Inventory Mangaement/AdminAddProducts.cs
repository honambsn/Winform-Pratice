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
	public partial class AdminAddProducts : UserControl
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
		public AdminAddProducts()
		{
			InitializeComponent();
			drawCenter();
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

		private void btn_addProduct_Click(object sender, EventArgs e)
		{
			if (txt_ProductID.Text == "" || txt_ProductName.Text == "" || txt_ProductPrice.Text == "" || txt_ProductStock.Text == "" || cb_ProductCategory.SelectedIndex == -1 || cb_ProductStatus.SelectedIndex == -1)
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
						string checkUsername = "SELECT * FROM products WHERE prod_id = @prodID";
						using (SqlCommand cmd = new SqlCommand(checkUsername, con))
						{
							cmd.Parameters.AddWithValue("@prodID", txt_ProductID.Text.Trim());

							SqlDataAdapter adapter = new SqlDataAdapter(cmd);
							DataTable table = new DataTable();
							adapter.Fill(table);

							if (table.Rows.Count > 0)
							{
								MessageBox.Show("Product ID: " + txt_ProductID.Text.Trim() + " is existed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else
							{
								string insertData = "INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, date_insert) " + "VALUES(@prodID, @prodName, @category, @price, @stock, @path, @status, @date)";
								using (SqlCommand insertD = new SqlCommand(insertData, con))
								{
									insertD.Parameters.AddWithValue("@prodId", txt_ProductID.Text.Trim());
									insertD.Parameters.AddWithValue("@prodName", txt_ProductName.Text.Trim());
									insertD.Parameters.AddWithValue("@category", cb_ProductCategory.SelectedItem);
									insertD.Parameters.AddWithValue("@price", txt_ProductPrice.Text.Trim());
									insertD.Parameters.AddWithValue("@stock", txt_ProductStock.Text.Trim());
									insertD.Parameters.AddWithValue("@path",txt_ProductID.Text.Trim());
									insertD.Parameters.AddWithValue("@status", cb_ProductStatus.SelectedItem);

									DateTime today = DateTime.Today;
									insertD.Parameters.AddWithValue("@date", today);
									insertD.ExecuteNonQuery();
									con.Close();

									MessageBox.Show("Added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
									//displayAllUserData();
									//ClearFields();
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
	}

}
