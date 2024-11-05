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
	public partial class Cashier : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;

		int qty;
		string id;
		string price;
		public Cashier()
		{
			InitializeComponent();
			drawCenter();
			cn = new SqlConnection(dbcon.myConnection());
			dgvCashier.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
			GetTranNo();
			dgvCashier.Refresh();

		}

		public void drawCenter()
		{
			int xPos = (this.panel2.Width - this.pictureBox1.Width) / 2;
			int yPos = this.pictureBox1.Location.Y;

			this.pictureBox1.Location = new Point(xPos, yPos);

			xPos = (this.panel2.Width - this.lblUsername.Width) / 2;
			yPos = this.lblUsername.Location.Y;
			this.lblUsername.Location = new Point(xPos, yPos);

			yPos = (this.lblname.Height - this.lblname.Height) / 2;
			xPos = this.lblname.Location.X;
			this.lblname.Location = new Point(xPos, yPos);

			yPos = (this.pictureBox2.Height - this.pictureBox2.Height) / 2;
			xPos = this.pictureBox2.Location.X;
			this.pictureBox2.Location = new Point(xPos, yPos);
		}

		private void picClose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		public void slide(Button button)
		{
			panelSlide.BackColor = Color.FromArgb(255, 0, 255);
			panelSlide.Height = button.Height;
			panelSlide.Top = button.Top;

		}

		#region button
		private void btnTransaction_Click(object sender, EventArgs e)
		{
			slide(btnTransaction);
			GetTranNo();
		}

		private void btnSearchProd_Click(object sender, EventArgs e)
		{
			slide(btnSearchProd);
			LookUpProduct lookUp = new LookUpProduct(this);
			lookUp.LoadProduct();
			lookUp.ShowDialog();
		}

		private void btnDiscount_Click(object sender, EventArgs e)
		{
			slide(btnDiscount);
		}

		private void btnPayment_Click(object sender, EventArgs e)
		{
			slide(btnPayment);
		}

		private void btnSales_Click(object sender, EventArgs e)
		{
			slide(btnSales);
		}

		private void btnChangePass_Click(object sender, EventArgs e)
		{
			slide(btnChangePass);
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			slide(btnLogout);
		}

		private void btnClearCart_Click(object sender, EventArgs e)
		{
			slide(btnClearCart);
		}
		#endregion button

		//public void LoadCart()
		//{

		//	cn.Open();
		//	try
		//	{
		//		if (cn.State == ConnectionState.Open)
		//		{
		//			cn.Close();
		//		}
		//		cn.Open();

		//		int i = 0;
		//		double total = 0;
		//		double discount = 0;
		//		dgvCashier.Rows.Clear();
		//		using (SqlCommand cm = new SqlCommand("select c.id, c.ProductCode, p.Description, c.Price, c.qty, c.disc, c.total from Cart " +
		//			"as c inner join Product as p on c.ProductCode = p.ProductCode " +
		//			"where c.transno like @transno and c.status like 'Pending'", cn))
		//		{
		//			cm.Parameters.AddWithValue("@transno", lblTransNo.Text);
		//			dr = cm.ExecuteReader();
		//			while (dr.Read())
		//			{
		//				i++;
		//				total += Convert.ToDouble(dr["total"].ToString());
		//				discount += Convert.ToDouble(dr["disc"].ToString());
		//				dgvCashier.Rows.Add(i, dr["id"].ToString(), dr["ProductCode"].ToString(), dr["Description"].ToString(), dr["Price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));

		//			}
		//			dr.Close();
		//			cn.Close();
		//			lblSaleTotal.Text = total.ToString("#,##0.00");
		//			lblDiscount.Text = discount.ToString("#,##0.00");
		//			GetCartTotal();
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show(ex.Message);
		//	}
		//	finally
		//	{
		//		cn.Close();
		//	}
		//}

		public void LoadCart()
		{
			try
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
				cn.Open();

				int i = 0;
				double total = 0;
				double discount = 0;
				dgvCashier.Rows.Clear();
				using (SqlCommand cm = new SqlCommand("SELECT c.id, c.ProductCode, p.Description, c.Price, c.qty, c.disc, c.total FROM Cart " +
					"AS c INNER JOIN Product AS p ON c.ProductCode = p.ProductCode " +
					"WHERE c.transno LIKE @transno AND c.status LIKE 'Pending'", cn))
				{
					cm.Parameters.AddWithValue("@transno", lblTransNo.Text);
					dr = cm.ExecuteReader();
					while (dr.Read())
					{
						i++;

						// Kiểm tra DBNull và chuyển đổi an toàn
						double itemTotal = dr["total"] != DBNull.Value ? Convert.ToDouble(dr["total"]) : 0;
						double itemDisc = dr["disc"] != DBNull.Value ? Convert.ToDouble(dr["disc"]) : 0;

						total += itemTotal;
						discount += itemDisc;

						dgvCashier.Rows.Add(i,
							dr["id"].ToString(),
							dr["ProductCode"].ToString(),
							dr["Description"].ToString(),
							dr["Price"].ToString(),
							dr["qty"].ToString(),
							itemDisc.ToString("#,##0.00"),
							itemTotal.ToString("#,##0.00")
						);
					}
					dr.Close();
					lblSaleTotal.Text = total.ToString("#,##0.00");
					lblDiscount.Text = discount.ToString("#,##0.00");
					//MessageBox.Show("Total Sale: " + lblSaleTotal.Text);
					//MessageBox.Show("Total dis: " + lblDiscount.Text);
					GetCartTotal();
					
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				GetCartTotal();
				cn.Close();
			}
		}

		public void GetCartTotal()
		{
			double discount = double.Parse(lblDiscount.Text);
			double sales = double.Parse(lblSaleTotal.Text) - discount;
			double vat = sales * 0.12;
			double vatable = sales - vat;

			lblVat.Text = vat.ToString("#,##0.00");
			lblVatable.Text = vatable.ToString("#,##0.00");
			lblDisplayTotal.Text = sales.ToString("#,##0.00");
		}


		private void lblTimerr_Tick(object sender, EventArgs e)
		{
			lblTimer.Text = DateTime.Now.ToString("HH:mm:ss tt");
		}

		public void GetTranNo()
		{
			try
			{
				// Get the transaction number
				string sdate = DateTime.Now.ToString("yyyyMMdd");
				int count;
				string transno = sdate + "1001";
				lblTransNo.Text = transno;
				//using(SqlCommand cm = new SqlCommand("select top 1 transno from Cart where transno like '" + sdate + "%' order by id desc", cn))
				//{
				//	cm.Parameters.AddWithValue("@transno", transno);
				//	cm.Parameters.AddWithValue("@sdate", DateTime.Now);
				//	cm.Parameters.AddWithValue("@cashier", lblUsername.Text);
				//	cm.ExecuteNonQuery();
				//}
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
				cn.Open();

				cm = new SqlCommand("select top 1 transno from Cart where transno like '" + sdate + "%' order by id desc", cn);
				dr = cm.ExecuteReader();
				dr.Read();
				if (dr.HasRows)
				{
					transno = dr[0].ToString();
					count = int.Parse(transno.Substring(8, 4));
					lblTransNo.Text = sdate + (count + 1);
				}
				else
				{
					transno = sdate + "1001";
					lblTransNo.Text = transno;
				}
				dr.Close();
				cn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void txtBarcode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (txtBarcode.Text == string.Empty)
					return;
				else
				{
					string _pcode;
					double _price;
					int _qty;

					using (SqlCommand cm = new SqlCommand("select * from Product where Barcode like '" + txtBarcode.Text + "'", cn))
					{
						dr = cm.ExecuteReader();
						dr.Read();
						if (dr.HasRows)
						{
							qty = int.Parse(dr["qty"].ToString());
							_pcode = dr["ProductCode"].ToString();
							_price = double.Parse(dr["Price"].ToString());
							_qty = int.Parse(txtQty.Text);
							AddToCart(_pcode, _price, _qty);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{

			}
		}

		public void AddToCart(string _pcode, double _price, int _qty)
		{
			try
			{

				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
				cn.Open();

				string id = "";
				int cart_qty = 0;
				bool found = false;
				using (SqlCommand cm = new SqlCommand("select * Cart where transno = @transno and ProductCode = @ProductCode", cn))
				{
					cm.Parameters.AddWithValue("@transno", lblTransNo.Text);
					cm.Parameters.AddWithValue("@ProductCode", _pcode);
					dr = cm.ExecuteReader();

					if (dr.HasRows)
					{
						dr.Read();
						id = dr["id"].ToString();
						cart_qty = int.Parse(dr["qty"].ToString());
						found = true;
					}
					else
					{
						found = false;
					}

					dr.Close();
				}

				if (found)
				{
					if (cn.State == ConnectionState.Open)
					{
						cn.Close();
					}
					cn.Open();

					if (qty < (int.Parse(txtQty.Text) + cart_qty))
					{
						MessageBox.Show("Unable to proceed. Remaining qty on hand is" + qty, "Insufficient stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					using (SqlCommand cm = new SqlCommand("update Cart set qty = (qty + " + _qty + ") where id = '" + id + "'", cn))
					{

						cm.ExecuteNonQuery();
						txtBarcode.SelectionStart = 0;
						txtBarcode.SelectionLength = txtBarcode.Text.Length;
						LoadCart();
					}
				}

				else
				{
					if (qty < (int.Parse(txtQty.Text) + cart_qty))
					{
						MessageBox.Show("Unable to proceed. Remaining qty on hand is" + qty, "Insufficient stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					using (SqlCommand cm = new SqlCommand("insert into Cart(transno, ProductCode, Price, qty, sdate, cashier) values (@transno, @ProductCode, @Price, @qty, @sdate, @cashier", cn))
					{
						cm.Parameters.AddWithValue("@transno", lblTransNo.Text);
						cm.Parameters.AddWithValue("@ProductCode", _pcode);
						cm.Parameters.AddWithValue("@Price", _price);
						cm.Parameters.AddWithValue("@qty", _qty);
						cm.Parameters.AddWithValue("@sdate", DateTime.Now);
						cm.Parameters.AddWithValue("@cashier", lblUsername.Text);
						cm.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				LoadCart();
			}

		}
	}
}