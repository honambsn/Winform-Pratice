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
	public partial class StockIn : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;
		string stitle = "Simple Market";
		public StockIn()
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			drawCenter();
			LoadSupplier();
			GetReferenceNo();
		}

		public void GetReferenceNo()
		{
			//cn.Open();
			//cm = new SqlCommand("SELECT TOP 1 refNo FROM StockIn ORDER BY refNo DESC", cn);
			//dr = cm.ExecuteReader();
			//dr.Read();
			//if (dr.HasRows)
			//{
			//	int v = Convert.ToInt32(dr[0].ToString()) + 1;
			//	txtRefNo.Text = v.ToString();
			//}
			//else
			//{
			//	txtRefNo.Text = "1";
			//}
			//dr.Close();
			//cn.Close();

			Random rnd = new Random();
			txtRefNo.Clear();
			txtRefNo.Text += rnd.Next();
		}

		public void drawCenter()
		{
			int xPos = this.label1.Location.X;
			int yPos = (this.panel1.Height - this.label1.Height) / 2;

			this.label1.Location = new Point(xPos, yPos);

			xPos = this.txtSearch.Location.X;
			yPos = (this.panel1.Height - this.txtSearch.Height) / 2;
			this.txtSearch.Location = new Point(xPos, yPos);
		}

		public void LoadSupplier()
		{
			try
			{
				var supplierData = dbcon.GetTable("SELECT * FROM Supplier");
				if (supplierData != null && supplierData.Rows.Count > 0)
				{
					cbSupplier.DataSource = supplierData;
					cbSupplier.DisplayMember = "supplierName"; // Correct column name
					//cbSupplier.ValueMember = "id"; // Optional, if you want to use the ID later
				}
				else
				{
					cbSupplier.DataSource = null; // Clear the data source if no data
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while loading suppliers: " + ex.Message);
			}
		}

		public void ProductForSupplier(string pcode)
		{
			try
			{
				if (cn.State != ConnectionState.Open)
					cn.Open();

				string supplier = "";
				using (SqlCommand cm = new SqlCommand("SELECT * FROM vwStockIn WHERE ProductCode = @pcode", cn))
				{
					cm.Parameters.AddWithValue("@pcode", pcode);

					using (SqlDataReader dr = cm.ExecuteReader())
					{
						if (dr.Read()) // Check if there are rows
						{
							supplier= dr["supplierName"].ToString(); // Use the correct column name
						}
						dr.Close();
						cbSupplier.Text = supplier;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while loading products: " + ex.Message);
			}

		}
		public void LoadStockIn()
		{
			try
			{
				int i = 0;
				dgvStockIn.Rows.Clear();
				if (cn.State != ConnectionState.Open)
					cn.Open();

				using (SqlCommand cm = new SqlCommand("SELECT * FROM vwStockIn WHERE refno LIKE @refNo AND status = 'Pending'", cn))
				//using(SqlCommand cm = new SqlCommand("SELECT * FROM StockIn where refno like '" + txtRefNo.Text + "' and status like 'Pending'", cn))
				{
					cm.Parameters.AddWithValue("@refNo", txtRefNo.Text + "%");
					using (SqlDataReader dr = cm.ExecuteReader())
					{
						while (dr.Read())
						{
							i++;
							//dgvStockIn.Rows.Add(i, dr["refNo"].ToString(), dr["pcode"].ToString(), dr["pname"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["sdate"].ToString(), dr["supplier"].ToString(), dr["address"].ToString(), dr["contact"].ToString());
							dgvStockIn.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr["supplierName"].ToString());
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while loading stock in: " + ex.Message);
			}
		}


		private void cbSupplier_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;

		}

		private void linkGen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			GetReferenceNo();
		}

		private void linkProd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ProductStockIn prodStock = new ProductStockIn(this);
			prodStock.ShowDialog();
		}

		private void btnEntry_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgvStockIn.Rows.Count > 0)
				{
					if (MessageBox.Show("Are you sure you want to save this records", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						//if (cn.State != ConnectionState.Open)
						//	cn.Open();

						//using (SqlCommand cm = new SqlCommand("UPDATE StockIn SET status = 'Done' WHERE refNo = @refNo", cn))
						//{
						//	cm.Parameters.AddWithValue("@refNo", txtRefNo.Text);
						//	cm.ExecuteNonQuery();
						//}

						//MessageBox.Show("Stock In successfully saved", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
						//LoadStockIn();

						try
						{
							for (int i = 0; i < dgvStockIn.Rows.Count; i++)
							{
								if (cn.State != ConnectionState.Open)
									cn.Open();

								//using (SqlCommand cm = new SqlCommand("INSERT INTO StockIn (refNo, pcode, pname, price, qty, sdate, supplier, address, contact, status) VALUES (@refNo, @pcode, @pname, @price, @qty, @sdate, @supplier, @address, @contact, @status)", cn))
								//{
								//	cm.Parameters.AddWithValue("@refNo", dgvStockIn.Rows[i].Cells[1].Value);
								//	cm.Parameters.AddWithValue("@pcode", dgvStockIn.Rows[i].Cells[2].Value);
								//	cm.Parameters.AddWithValue("@pname", dgvStockIn.Rows[i].Cells[3].Value);
								//	cm.Parameters.AddWithValue("@price", dgvStockIn.Rows[i].Cells[4].Value);
								//	cm.Parameters.AddWithValue("@qty", dgvStockIn.Rows[i].Cells[5].Value);
								//	cm.Parameters.AddWithValue("@sdate", dgvStockIn.Rows[i].Cells[6].Value);
								//	cm.Parameters.AddWithValue("@supplier", dgvStockIn.Rows[i].Cells[7].Value);
								//	cm.Parameters.AddWithValue("@address", dgvStockIn.Rows[i].Cells[8].Value);
								//	cm.Parameters.AddWithValue("@contact", dgvStockIn.Rows[i].Cells[9].Value);
								//	cm.Parameters.AddWithValue("@status", "Done");
								//	cm.ExecuteNonQuery();
								//}

								using (SqlCommand cm = new SqlCommand("update Product set qty = qty + " + int.Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString()) + " where ProductCode = '" + dgvStockIn.Rows[i].Cells[4].Value.ToString() + "'", cn))
								{

									cm.ExecuteNonQuery();
								}

								using (SqlCommand cm = new SqlCommand("update StockIn set qty = qty + " + int.Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString()) + ", status = 'Done' where id like '" + dgvStockIn.Rows[i].Cells[1].Value.ToString() + "'", cn))
								{

									cm.ExecuteNonQuery();
								}
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show("An error occurred while saving stock in: " + ex.Message);
						}
						finally
						{
							Clear();
							LoadStockIn();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while saving stock in: " + ex.Message);
			}
			finally
			{

			}
		}

		public void Clear()
		{
			txtRefNo.Clear();
			txtStockInBy.Clear();
			dtStockIn.Value = DateTime.Now;
		}

		private void dgvStockIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string colName = dgvStockIn.Columns[e.ColumnIndex].Name;
			if (colName == "Delete")
			{
				if (MessageBox.Show("Are you sure you want to delete this record", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					//dgvStockIn.Rows.RemoveAt(e.RowIndex);

					try
					{
						using (SqlCommand cm = new SqlCommand("delete from StockIn where id = '" + dgvStockIn.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn))
						{
							cm.ExecuteNonQuery();
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("An error occurred while deleting stock in: " + ex.Message);
					}
					finally
					{
						LoadStockIn();
					}
				}
			}
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			try
			{
				int i = 0;
				dgvInStockHistory.Rows.Clear();
				if (cn.State != ConnectionState.Open)
					cn.Open();

				using (SqlCommand cm = new SqlCommand("SELECT * FROM vwStockIn WHERE cast(sdate as date) between @fromdate and @todate and status = 'Done'", cn))				
				{
					//cm.Parameters.AddWithValue("@fromdate", dtFrom.Value.ToShortDateString());
					//cm.Parameters.AddWithValue("@todate", dtTo.Value.ToShortDateString());
					cm.Parameters.AddWithValue("@fromdate", dtFrom.Value.ToString("yyyy-MM-dd"));
					cm.Parameters.AddWithValue("@todate", dtTo.Value.ToString("yyyy-MM-dd"));
					using (SqlDataReader dr = cm.ExecuteReader())
					{
						
						while (dr.Read())
						{
							i++;
							//dgvStockIn.Rows.Add(i, dr["refNo"].ToString(), dr["pcode"].ToString(), dr["pname"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["sdate"].ToString(), dr["supplier"].ToString(), dr["address"].ToString(), dr["contact"].ToString());
							dgvInStockHistory.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortTimeString(), dr[6].ToString(), dr["supplierName"].ToString());
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while loading stock in: " + ex.Message);
			}
			finally
			{
				
			}
		}

		private void cbSupplier_TextChanged(object sender, EventArgs e)
		{
			if (cbSupplier.SelectedItem != null) // Ensure an item is selected
			{
				if (cn.State != ConnectionState.Open)
					cn.Open();

				using (SqlCommand cm = new SqlCommand("SELECT * FROM Supplier WHERE supplierName = @supplierName", cn))
				{
					cm.Parameters.AddWithValue("@supplierName", cbSupplier.Text);

					using (SqlDataReader dr = cm.ExecuteReader())
					{
						if (dr.Read()) // Check if there are rows
						{
							labelID.Text = dr["id"].ToString(); // Use the correct column name
							txtConPerson.Text = dr["contact"].ToString(); // Use the correct column name
							txtAddress.Text = dr["address"].ToString();
						}
					}
				}
			}
		}
	}
}