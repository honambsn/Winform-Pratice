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
	public partial class Adjustments : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;
		MainForm main;
		int _qty;
		public Adjustments(MainForm mn)
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			main = mn;
			ReferenceNo();
			LoadStock();
			lblUsername.Text = main.lbl_Username.Text;
		}

		public void ReferenceNo()
		{
			Random rnd = new Random();
			lblRefNo.Text = rnd.Next().ToString();
		}

		public void LoadStock2()
		{
			int i = 0;
			dgvAdjustment.Rows.Clear();
			cm = new SqlCommand("select p.ProductCode, p.Barcode, p.Description, b.BrandName, c.CategoryName, p.Price, p.qty from Product as p inner join Brand as b on b.id = p.BrandID inner join Category as c on c.id = p.CategoryID " +
				"where concat (p.Description, b.BrandName, c.CategoryName, p.ProductCode) like '%" + txtSearch.Text + "%'", cn);

			if (cn.State == ConnectionState.Closed)
				cn.Open();

			dr = cm.ExecuteReader();

			while (dr.Read())
			{
				i++;
				dgvAdjustment.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
			}

			dr.Close();
			cn.Close();
		}

		public void LoadStock()
		{
			int i = 0;
			dgvAdjustment.Rows.Clear();


			// SQL query with parameterized search
			string query = "select p.ProductCode, p.Barcode, p.Description, b.BrandName, c.CategoryName, p.Price, p.qty " +
						   "from Product as p " +
						   "inner join Brand as b on b.id = p.BrandID " +
						   "inner join Category as c on c.id = p.CategoryID " +
						   "where concat(p.Description, b.BrandName, c.CategoryName, p.ProductCode) like @SearchTerm";

			using (SqlCommand cm = new SqlCommand(query, cn))
			{
				cm.Parameters.AddWithValue("@SearchTerm", "%" + txtSearch.Text + "%");

				if (cn.State == ConnectionState.Closed)
					cn.Open();

				using (SqlDataReader dr = cm.ExecuteReader())
				{
					while (dr.Read())
					{
						i++;
						dgvAdjustment.Rows.Add(i,
											   dr["ProductCode"].ToString(),
											   dr["Barcode"].ToString(),
											   dr["Description"].ToString(),
											   dr["BrandName"].ToString(),
											   dr["CategoryName"].ToString(),
											   dr["Price"].ToString(),
											   dr["qty"].ToString());
					}
				}
			}

			cn.Close();
		}


		private void dgvAdjustment_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string colName = dgvAdjustment.Columns[e.ColumnIndex].Name;
			if (colName == "Select")
			{
				lblProdCode.Text = dgvAdjustment.Rows[e.RowIndex].Cells[1].Value.ToString();
				lblDesc.Text = dgvAdjustment.Rows[e.RowIndex].Cells[3].Value.ToString() + " " + dgvAdjustment.Rows[e.RowIndex].Cells[4].Value.ToString()
					+ " " + dgvAdjustment.Rows[e.RowIndex].Cells[5].Value.ToString();

				_qty = int.Parse(dgvAdjustment.Rows[e.RowIndex].Cells[7].Value.ToString());
				btnSave.Enabled = true;
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			LoadStock();
		}

		public void Clear()
		{
			lblDesc.Text = "";
			lblProdCode.Text = "";
			txtQty.Clear();
			txtRemark.Clear();
			cbAction.Text = "";
			ReferenceNo();

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{

				if (ConnectionState.Closed == cn.State)
				{
					cn.Open();
				}

				//validation empty fields
				if (string.IsNullOrWhiteSpace(cbAction.Text))
				{
					MessageBox.Show("Please select action", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					cbAction.Focus();
					return;
				}

				if (!int.TryParse(txtQty.Text, out int qty) || qty <= 0)
				{
					MessageBox.Show("Please enter quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtQty.Focus();
					return;
				}

				if (string.IsNullOrWhiteSpace(txtRemark.Text))

				{
					MessageBox.Show("Need reason for stock adjustment", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtRemark.Focus();
					return;
				}

				//update stock
				if (int.Parse(txtQty.Text) > _qty)
				{
					MessageBox.Show("Insufficient stock", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (cbAction.Text == "Remove From Inventory")
				{
					using (SqlCommand cm = new SqlCommand("update Product set qty = (qty - " + int.Parse(txtQty.Text) + ") where ProductCode = '" + lblProdCode.Text + "'", cn))
					{
						cm.ExecuteNonQuery();
					}
				}
				else if (cbAction.Text == "Add To Inventory")
				{
					using (SqlCommand cm = new SqlCommand("update Product set qty = (qty + " + int.Parse(txtQty.Text) + ") where ProductCode = '" + lblProdCode.Text + "'", cn))
					{
						
						cm.ExecuteNonQuery();
						
					}
				}

				using(SqlCommand cm = new SqlCommand("insert into Adjustment (refNo, ProductCode, qty, action, remarks, sdate, [user]) values (@refNo, @ProductCode, @qty, @action, @remarks, @sdate, @user)", cn))
				{
					cm.Parameters.AddWithValue("@refNo", lblRefNo.Text);
					cm.Parameters.AddWithValue("@ProductCode", lblProdCode.Text);
					cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
					cm.Parameters.AddWithValue("@action", cbAction.Text);
					cm.Parameters.AddWithValue("@remarks", txtRemark.Text);
					cm.Parameters.AddWithValue("@sdate", DateTime.Now);
					cm.Parameters.AddWithValue("@user", lblUsername.Text);
					cm.ExecuteNonQuery();

				}
				MessageBox.Show("Stock Adjustment successfully saved", "Stock Adjustment", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while saving stock in: " + ex.Message);
			}
			finally
			{
				Clear();
				LoadStock();
				btnSave.Enabled = false;
			}
		}
	}
}
