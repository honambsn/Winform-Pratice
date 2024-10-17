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
	public partial class LookUpProduct : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;
		string stitle = "POS";
		public LookUpProduct()
		{
			InitializeComponent();
			LoadProduct();
			cn = new SqlConnection(dbcon.myConnection());
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		public void LoadProduct()
		{
			int i = 0;
			dgvProduct.Rows.Clear();
			cm = new SqlCommand("select p.ProductCode, p.Barcode, p.Description, b.BrandName, c.CategoryName, p.Price, p.qty from Product as p inner join Brand as b on b.id = p.BrandID inner join Category as c on c.id = p.CategoryID " +
				"where concat (p.Description, b.BrandName, c.CategoryName) like '%" + txtSearch.Text + "%'", cn);

			if (cn.State == ConnectionState.Closed)
				cn.Open();

			dr = cm.ExecuteReader();

			while (dr.Read())
			{
				i++;
				dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
			}

			dr.Close();
			cn.Close();
		}
	}
}
