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
	public partial class Record : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;
		public Record()
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			LoadCriticalItems();
		}

		public void LoadTopSelling()
		{
			int i = 0;
			dgvTopSelling.Rows.Clear();
			if (cn.State == ConnectionState.Closed)
			{
				cn.Open();
			}
			if (cbTopSell.Text == "Sort By Qty")
			{
				using (SqlCommand cm = new SqlCommand("select top 10 ProductCode, Description, isnull(sum(qty), 0) as qty, isnull(sum(total), 0) as total from vwTopSelling where sdate between @fromDate and @toDate and status = 'Sold' group by ProductCode, Description order by qty DESC", cn))
				{
					cm.Parameters.AddWithValue("@fromDate", dtFromTopSell.Value);
					cm.Parameters.AddWithValue("@toDate", dtToTopSell.Value);
					dr = cm.ExecuteReader();
					while (dr.Read())
					{
						i++;
						dgvTopSelling.Rows.Add(i, dr["ProductCode"].ToString(), dr["Description"].ToString(), dr["qty"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,#0,00"));
					}
					dr.Close();
				}
			}
			else if (cbTopSell.Text == "Sort By Total Amount")
			{
				using (SqlCommand cm = new SqlCommand("select top 10 ProductCode, Description, isnull(sum(qty), 0) as qty, isnull(sum(total), 0) as total from vwTopSelling where sdate between @fromDate and @toDate and status = 'Sold' group by ProductCode, Description order by total DESC", cn))
				{
					cm.Parameters.AddWithValue("@fromDate", dtFromTopSell.Value);
					cm.Parameters.AddWithValue("@toDate", dtToTopSell.Value);
					dr = cm.ExecuteReader();
					while (dr.Read())
					{
						i++;
						dgvTopSelling.Rows.Add(i, dr["ProductCode"].ToString(), dr["Description"].ToString(), dr["qty"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,#0,00"));
					}
					dr.Close();
				}
			}
		}

		private void btnLoadTopSell_Click(object sender, EventArgs e)
		{
			if (cbTopSell.Text == "Select sort type")
			{
				MessageBox.Show("Please select sort by", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cbTopSell.Focus();
				return;
			}
			LoadTopSelling();
		}

		public void LoadSoldItems()
		{
			try
			{
				dgvSoldItems.Rows.Clear();
				int i = 0;
				if (cn.State == ConnectionState.Closed)
				{
					cn.Open();
				}

				using(SqlCommand cm = new SqlCommand("select c.ProductCode, p.Description, c.Price, sum(c.qty) as qty, sum(c.disc) as disc, sum(c.total) as total from Cart as c " +
					"inner join Product as p on c.ProductCode = p.ProductCode " +
					"where status = @status and sdate between @fromDate and @toDate " +
					"group by c.ProductCode, p.Description, c.Price" , cn))
				{
					cm.Parameters.AddWithValue("@status", "Sold");
					cm.Parameters.AddWithValue("@fromDate", dtFromSoldItems.Value);
					cm.Parameters.AddWithValue("@toDate", dtToSoldItems.Value);
					dr = cm.ExecuteReader();
					while (dr.Read())
					{
						i++;
						dgvSoldItems.Rows.Add(i, dr["ProductCode"].ToString(), dr["Description"].ToString(), double.Parse(dr["Price"].ToString()).ToString("#,#0,00"), dr["qty"].ToString(), double.Parse(dr["disc"].ToString()).ToString("#,#0,00"), double.Parse(dr["total"].ToString()).ToString("#,#0,00"));
					}
					dr.Close();
				}

				using(SqlCommand cm = new SqlCommand("select isnull(sum(total), 0) as total from Cart " +
					"where status = @status and sdate between @fromDate and @toDate", cn))
				{
					cm.Parameters.AddWithValue("@status", "Sold");
					cm.Parameters.AddWithValue("@fromDate", dtFromSoldItems.Value);
					cm.Parameters.AddWithValue("@toDate", dtToSoldItems.Value);
					dr = cm.ExecuteReader();
					dr.Read();
					if (dr.HasRows)
					{
						//lblTotal.Text = double.Parse(dr["total"].ToString()).ToString("#,#0,00");
						lblTotal.Text = double.Parse(dr["total"].ToString()).ToString("$#,##0.00");

						//lblTotal.Text = double.Parse(cm.ExecuteScalar().ToString()).ToString("$");

					}
					dr.Close();
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void btnLoadSoldItem_Click(object sender, EventArgs e)
		{
			LoadSoldItems();
		}

		public void LoadCriticalItems()
		{
			try
			{
				dgvCriticalItems.Rows.Clear();
				int i = 0;
				if (cn.State == ConnectionState.Closed)
				{
					cn.Open();
				}

				using (SqlCommand cm = new SqlCommand("select * from vwCriticalItems where Qty <= Reorder", cn))
				{
					dr = cm.ExecuteReader();
					while (dr.Read())
					{
						i++;
						dgvCriticalItems.Rows.Add(i, dr["ProductCode"].ToString(), dr["Barcode"].ToString(), dr["Description"].ToString(), dr["BrandName"].ToString(), dr["CategoryName"].ToString(), double.Parse(dr["Price"].ToString()).ToString("#,#0,00"), dr["ReOrder"].ToString(), dr["qty"].ToString());
						//dgvCriticalItems.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
					}
					dr.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
