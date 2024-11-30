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
				using (SqlCommand cm = new SqlCommand("select top 10 ProductCode, Description, isnull(sum(qty), 0) as qty, isnull(sum(total), 0) as total from vwSoldItems where sdate between @fromDate and @toDate and status = 'Sold' group by ProductCode, Description order by qty DESC", cn))
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
				using (SqlCommand cm = new SqlCommand("select top 10 ProductCode, Description, isnull(sum(qty), 0) as qty, isnull(sum(total), 0) as total from vwSoldItems where sdate between @fromDate and @toDate and status = 'Sold' group by ProductCode, Description order by total DESC", cn))
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
			if(cbTopSell.Text == "Select sort type")
			{
				MessageBox.Show("Please select sort by", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cbTopSell.Focus();
				return;
			}
			LoadTopSelling();
		}
	}
}
