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
	public partial class ProductStockIn : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;
		StockIn stockIn;

		public ProductStockIn(StockIn stockin)
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			drawCenter();
			LoadProduct();
			stockIn = stockin;
		}

		public void drawCenter()
		{
			int xPos = this.label1.Location.X;
			int yPos = (this.panel1.Height - this.label1.Height) / 2;

			this.label1.Location = new Point(xPos, yPos);

			xPos = this.txtSearch.Location.X;
			yPos = (this.panel1.Height - this.txtSearch.Height) / 2;
			this.txtSearch.Location = new Point(xPos, yPos);

			xPos = this.btnClose.Location.X;
			yPos = (this.panel1.Height - this.btnClose.Height) / 2;
			this.btnClose.Location = new Point(xPos, yPos);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Dispose();
			}
		}

		public void LoadProduct()
		{
			int i = 0;
			dgvProduct.Rows.Clear();
			cm = new SqlCommand("select ProductCode, Description, qty from Product where Description like '%" + txtSearch.Text + "%'", cn);

			if (cn.State == ConnectionState.Closed)
				cn.Open();

			dr = cm.ExecuteReader();

			while (dr.Read())
			{
				i++;
				dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
			}

			dr.Close();
			cn.Close();
		}

		private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string colName = dgvProduct.Columns[e.ColumnIndex].Name;
			if (colName == "Select")
			{
				if (stockIn.txtStockInBy.Text == string.Empty)
				{
					MessageBox.Show("Please enter stock in by", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					stockIn.txtStockInBy.Focus();
					return;
				}
				if (MessageBox.Show("Add this item?", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						if (cn.State != ConnectionState.Open)
							cn.Open();

						using (SqlCommand cm = new SqlCommand("insert into StockIn (refno, ProductCode, sdate, stockinby, supplierID) values(@refno, @ProductCode, @sdate, @stockinby, @supplierID)", cn))
						{
							cm.Parameters.AddWithValue("@refno", stockIn.txtRefNo.Text);
							cm.Parameters.AddWithValue("@ProductCode", dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString());
							cm.Parameters.AddWithValue("@sdate", stockIn.dtStockIn.Value);
							cm.Parameters.AddWithValue("@stockinby", stockIn.txtStockInBy.Text);
							cm.Parameters.AddWithValue("@supplierID", stockIn.labelID.Text);


							cm.ExecuteNonQuery();
							MessageBox.Show("Product successfully added to stock in", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
					finally
					{
						stockIn.LoadStockIn();
					}

				}
			}
        }

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			LoadProduct();
		}
	}
}
