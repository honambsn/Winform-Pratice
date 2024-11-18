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

namespace Supermarket_Management
{
	public partial class DailySale : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;

		public string solduser;
		public DailySale()
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			LoadCashier();
			//LoadSold();
		}

		private void picClose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to close this form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Dispose();
			}
		}

		public void LoadCashier()
		{
			cbCashier.Items.Clear();
			cbCashier.Items.Add("All Cashier");

			if (cn.State != ConnectionState.Open)
				cn.Open();

			try
			{
				using (SqlCommand cm = new SqlCommand("SELECT username FROM Users WHERE role = @role", cn))
				{
					
					// Use parameterized query to prevent SQL injection
					cm.Parameters.AddWithValue("@role", "Cashier");

					// Ensure the connection is open
					if (cn.State != System.Data.ConnectionState.Open)
					{
						cn.Open();
					}

					using (SqlDataReader dr = cm.ExecuteReader())
					{
						// Clear existing items before adding new ones
						//cbCashier.Items.Clear(); 

						// Read data and add usernames to ComboBox
						while (dr.Read())
						{
							cbCashier.Items.Add(dr["username"].ToString());
						}
					}
				}
			}
			catch (Exception ex)
			{
				// Handle any errors (e.g., log them, display a message to the user, etc.)
				MessageBox.Show("Error: " + ex.Message);
			}

		}

		#region Old code
		//public void LoadSold()
		//{
		//	int i = 0;
		//	double total = 0;
		//	dgvSold.Rows.Clear();
		//	if (cn.State != ConnectionState.Open)
		//		cn.Open();

		//	#region Old code
		//	//if (cbCashier.Text == "All Cashier")
		//	//{
		//	//	try
		//	//	{
		//	//		using (SqlCommand cm = new SqlCommand(
		//	//			"SELECT c.id, c.transno, c.ProductCode, p.Description, c.Price, c.qty, c.disc, c.total " +
		//	//			"FROM Cart AS c " +
		//	//			"INNER JOIN Product AS p ON c.ProductCode = p.ProductCode " +
		//	//			"WHERE status = 'Sold' and sdate between @dtFrom and @dtTo", cn))
		//	//		{
		//	//			cm.Parameters.AddWithValue("@dtFrom", dtFrom.Value);
		//	//			cm.Parameters.AddWithValue("@dtTo", dtTo.Value);

		//	//			using (SqlDataReader dr = cm.ExecuteReader())
		//	//			{
		//	//				while (dr.Read())
		//	//				{
		//	//					i++;
		//	//					total += double.Parse(dr["total"].ToString());
		//	//					dgvSold.Rows.Add(i, dr["id"].ToString(), dr["transno"].ToString(), dr["ProductCode"].ToString(), dr["Description"].ToString(), dr["Price"].ToString(), dr["Qty"].ToString(), dr["Disc"].ToString(), dr["Total"].ToString());
		//	//				}
		//	//			}
		//	//		}
		//	//	}
		//	//	catch (Exception ex)
		//	//	{
		//	//		MessageBox.Show("Error: " + ex.Message);
		//	//	}
		//	//}
		//	//else
		//	//{
		//	//	try
		//	//	{
		//	//		using (SqlCommand cm = new SqlCommand(
		//	//			"SELECT c.id, c.transno, c.ProductCode, p.Description, c.Price, c.qty, c.disc, c.total " +
		//	//			"FROM Cart AS c " +
		//	//			"INNER JOIN Product AS p ON c.ProductCode = p.ProductCode " +
		//	//			"WHERE status = 'Sold' and sdate between @dtFrom and @dtTo and cashier like @cashier", cn))
		//	//		{
		//	//			cm.Parameters.AddWithValue("@dtFrom", dtFrom.Value);
		//	//			cm.Parameters.AddWithValue("@dtTo", dtTo.Value);
		//	//			cm.Parameters.AddWithValue("@cashier", cbCashier.Text);

		//	//			using (SqlDataReader dr = cm.ExecuteReader())
		//	//			{
		//	//				while (dr.Read())
		//	//				{
		//	//					i++;
		//	//					total += double.Parse(dr["total"].ToString());
		//	//					dgvSold.Rows.Add(i, dr["id"].ToString(), dr["transno"].ToString(), dr["ProductCode"].ToString(), dr["Description"].ToString(), dr["Price"].ToString(), dr["Qty"].ToString(), dr["Disc"].ToString(), dr["Total"].ToString());
		//	//				}
		//	//			}
		//	//		}
		//	//	}
		//	//	catch (Exception ex)
		//	//	{
		//	//		MessageBox.Show("Error: " + ex.Message);
		//	//	}
		//	//}

		//	#endregion

		//	if (cbCashier.Text == "All Cashier")
		//	{
		//		cm = new SqlCommand("select c.id, c.transno, c.ProductCode, p.Description, c.Price, c.qty, c.disc, c.total from Cart as c inner join Product as p on c.ProductCode = p.ProductCode where status = 'Sold' and sdate between @dtFrom and @dtTo", cn);
		//	}
		//	else 
		//	{
		//		cm = new SqlCommand("select c.id, c.transno, c.ProductCode, p.Description, c.Price, c.qty, c.disc, c.total from Cart as c inner join Product as p on c.ProductCode = p.ProductCode where status = 'Sold' and sdate between @dtFrom and @dtTo and cashier like @cashier", cn);
		//	}
		//	dr = cm.ExecuteReader();
		//	while (dr.Read())
		//	{
		//		i++;
		//		total += double.Parse(dr["total"].ToString());
		//		dgvSold.Rows.Add(i, dr["id"].ToString(), dr["transno"].ToString(), dr["ProductCode"].ToString(), dr["Description"].ToString(), dr["Price"].ToString(), dr["Qty"].ToString(), dr["Disc"].ToString(), dr["Total"].ToString());
		//	}
		//	dr.Close();
		//	cn.Close();
		//	lblTotal.Text = total.ToString("#,##0.00");

		//}
		#endregion


		public void LoadSold()
		{
			int i = 0;
			double total = 0;
			dgvSold.Rows.Clear();

			if (cn.State != ConnectionState.Open)
				cn.Open();

			try
			{
				// Prepare the SQL query
				string query = @"
            SELECT c.id, c.transno, c.ProductCode, p.Description, c.Price, c.qty, c.disc, c.total 
            FROM Cart AS c 
            INNER JOIN Product AS p ON c.ProductCode = p.ProductCode 
            WHERE c.status = 'Sold' AND c.sdate BETWEEN @dtFrom AND @dtTo";

				// If a specific cashier is selected, add the cashier filter
				if (cbCashier.Text != "All Cashier")
				{
					query += " AND c.cashier LIKE @cashier";
				}

				using (SqlCommand cm = new SqlCommand(query, cn))
				{
					// Add parameters for the date range
					cm.Parameters.AddWithValue("@dtFrom", dtFrom.Value.Date); // Assuming dtpFrom is a DateTimePicker control
					cm.Parameters.AddWithValue("@dtTo", dtTo.Value.Date); // Assuming dtpTo is a DateTimePicker control

					// Add the cashier parameter if a cashier is selected
					if (cbCashier.Text != "All Cashier")
					{
						cm.Parameters.AddWithValue("@cashier", "%" + cbCashier.Text + "%");
					}

					// Execute the query and read the data
					using (SqlDataReader dr = cm.ExecuteReader())
					{
						while (dr.Read())
						{
							i++;

							// Initialize values with defaults
							double rowTotal = 0;
							decimal price = 0;
							int qty = 0;
							decimal disc = 0;

							// Safely read the 'total' field and handle DBNull
							
							if (!dr.IsDBNull(dr.GetOrdinal("total")))
							{
								rowTotal = (double)dr.GetDecimal(dr.GetOrdinal("total"));
							}
								

							// Accumulate the total
							total += rowTotal;

							// Safely read the 'Price', 'Qty', and 'Disc' fields
							if (!dr.IsDBNull(dr.GetOrdinal("Price")))
							{
								price = dr.GetDecimal(dr.GetOrdinal("Price"));
							}

							if (!dr.IsDBNull(dr.GetOrdinal("qty")))
							{
								qty = dr.GetInt32(dr.GetOrdinal("qty"));
							}

							if (!dr.IsDBNull(dr.GetOrdinal("disc")))
							{
								disc = dr.GetDecimal(dr.GetOrdinal("disc"));
							}

							// Add the data to the DataGridView, making sure to format numbers
							dgvSold.Rows.Add(
								i,
								dr["id"].ToString(),
								dr["transno"].ToString(),
								dr["ProductCode"].ToString(),
								dr["Description"].ToString(),
								price.ToString("#,##0.00"),  // Format price as currency
								qty.ToString(),  // Just show qty as integer
								disc.ToString("#,##0.00"),  // Format discount as currency
								rowTotal.ToString("#,##0.00") // Format total as currency
							);
						}
					}
				}

				// Set the total sum of all items
				lblTotal.Text = total.ToString("#,##0.00"); // Format total as currency
			}
			catch (Exception ex)
			{
				// Handle any errors (e.g., log them, display a message to the user, etc.)
				MessageBox.Show("Error: " + ex.Message);
			}
			finally
			{
				// Ensure the connection is always closed
				cn.Close();
			}
		}



		private void cbCashier_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadSold();
		}

		private void dtFrom_ValueChanged(object sender, EventArgs e)
		{
			LoadSold();
		}

		private void dtTo_ValueChanged(object sender, EventArgs e)
		{
			LoadSold();
		}

		private void DailySale_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
			{
				this.Dispose();
			}
		}

		private void dgvSold_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string colName = dgvSold.Columns[e.ColumnIndex].Name;
			if (colName == "Cancel")
			{
				CancelOrder cancelOrder = new CancelOrder(this);
				cancelOrder.txtId.Text = dgvSold.Rows[e.RowIndex].Cells[1].Value.ToString();
				cancelOrder.txtTransno.Text = dgvSold.Rows[e.RowIndex].Cells[2].Value.ToString();
				cancelOrder.txtPCode.Text = dgvSold.Rows[e.RowIndex].Cells[3].Value.ToString();
				cancelOrder.txtDesc.Text = dgvSold.Rows[e.RowIndex].Cells[4].Value.ToString();
				cancelOrder.txtPrice.Text = dgvSold.Rows[e.RowIndex].Cells[5].Value.ToString();
				cancelOrder.txtQty.Text = dgvSold.Rows[e.RowIndex].Cells[6].Value.ToString();
				cancelOrder.txtDisc.Text = dgvSold.Rows[e.RowIndex].Cells[7].Value.ToString();
				cancelOrder.txtTotal.Text = dgvSold.Rows[e.RowIndex].Cells[8].Value.ToString();
				cancelOrder.txtCancelBy.Text = solduser;
				cancelOrder.ShowDialog();
			}
		}
	}
}
