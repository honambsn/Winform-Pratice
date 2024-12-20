﻿using System;
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
			lblDate.Text = DateTime.Now.ToShortDateString();

		}

		public void drawCenter()
		{
			int xPos = (this.panel2.Width - this.pictureBox1.Width) / 2;
			int yPos = this.pictureBox1.Location.Y;

			this.pictureBox1.Location = new Point(xPos, yPos);

			xPos = (this.panel2.Width - this.lblUsername.Width) / 2;
			yPos = this.lblUsername.Location.Y;
			this.lblUsername.Location = new Point(xPos, yPos);

		///	yPos = (this.lblName.Height - this.lblName.Height) / 2;
			//xPos = this.lblName.Location.X;
			//this.lblName.Location = new Point(xPos, yPos);

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
			Discount discount = new Discount(this);
			discount.lblID.Text = id;
			discount.txtTotalPrice.Text = price;
			discount.ShowDialog();
		}

		private void btnPayment_Click(object sender, EventArgs e)
		{
			slide(btnSettle);
			Settle settle = new Settle(this);
			settle.txtSale.Text = lblDisplayTotal.Text;
			settle.ShowDialog();
		}

		private void btnSales_Click(object sender, EventArgs e)
		{
			slide(btnSales);
			DailySale dailySale = new DailySale(new MainForm());
			dailySale.solduser = lblUsername.Text;
			dailySale.picClose.Visible = true;
			dailySale.lblTitle.Visible = true;
			dailySale.ShowDialog();
		}

		private void btnChangePass_Click(object sender, EventArgs e)
		{
			slide(btnChangePass);
			ChangePassword changePassword = new ChangePassword(this);
			changePassword.ShowDialog();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			slide(btnLogout);
			if (dgvCashier.Rows.Count > 0)
			{
				MessageBox.Show("Unable to logout. Please settle the transaction first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Hide();
				Login login = new Login();
				login.ShowDialog();
			}
		}

		private void btnClearCart_Click(object sender, EventArgs e)
		{
			slide(btnClearCart);
			if (MessageBox.Show("Are you sure you want to clear the cart?", "Clear Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
				cn.Open();
				using (SqlCommand cm = new SqlCommand("delete from Cart where transno like @transno", cn))
				{
					cm.Parameters.AddWithValue("@transno", lblTransNo.Text);
					cm.ExecuteNonQuery();
					LoadCart();
				}
			}
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

				Boolean hascart = false;
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

						hascart = true;
					}
					dr.Close();
					lblSaleTotal.Text = total.ToString("#,##0.00");
					lblDiscount.Text = discount.ToString("#,##0.00");
					//MessageBox.Show("Total Sale: " + lblSaleTotal.Text);
					//MessageBox.Show("Total dis: " + lblDiscount.Text);
					GetCartTotal();
					
					if (hascart)
					{
						btnClearCart.Enabled = true;
						btnSettle.Enabled = true;
						btnDiscount.Enabled = true;
					}
					else
					{
						btnClearCart.Enabled = false;
						btnSettle.Enabled = false;
						btnDiscount.Enabled = false;
					}
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
			double sales = double.Parse(lblSaleTotal.Text);
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
					if (cn.State == ConnectionState.Closed)
					{
						cn.Open();
					}

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
				using (SqlCommand cm = new SqlCommand("select * from Cart where transno = @transno and ProductCode = @ProductCode", cn))
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

					using (SqlCommand cm = new SqlCommand("insert into Cart(transno, ProductCode, Price, qty, sdate, cashier) values (@transno, @ProductCode, @Price, @qty, @sdate, @cashier)", cn))
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

		private void dgvCashier_SelectionChanged(object sender, EventArgs e)
		{
			int i = dgvCashier.CurrentRow.Index;
			id = dgvCashier[1, i].Value.ToString();
			price = dgvCashier[7, i].Value.ToString();
		}

		private void dgvCashier_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string colName = dgvCashier.Columns[e.ColumnIndex].Name;

			if (colName == "Delete")
			{
				if (MessageBox.Show("Are you sure you want to delete this item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						if (cn.State == ConnectionState.Open)
						{
							cn.Close();
						}
						cn.Open();


						//using (SqlCommand cm = new SqlCommand("delete from Cart where id =  @id", cn))
						//{
						//	cm.Parameters.AddWithValue("@id", dgvCashier.Rows[e.RowIndex].Cells[1].Value.ToString());
						//	cm.ExecuteNonQuery();

						//	if (cm.ExecuteNonQuery() > 0)
						//	{
						//		MessageBox.Show("Item has been deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
						//	}
						//	else
						//	{
						//		MessageBox.Show("Item not found or could not be deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						//	}
						//}

						dbcon.ExecuteQueryMultiParams("delete from Cart where id = @id", new SqlParameter("@id", dgvCashier.Rows[e.RowIndex].Cells[1].Value.ToString()));
						MessageBox.Show("Item has been deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
			else if (colName == "colAdd")
			{
				try
				{
					int i = 0;
					if (cn.State == ConnectionState.Open)
					{
						cn.Close();
					}

					cn.Open();

					using (SqlCommand cm = new SqlCommand("select sum(qty) as qty from Product where ProductCode like '" + dgvCashier.Rows[e.RowIndex].Cells[2].Value.ToString()
								+ "' group by ProductCode", cn))
					{
						i = int.Parse(cm.ExecuteScalar().ToString());

					}


					if (int.Parse(dgvCashier.Rows[e.RowIndex].Cells[5].Value.ToString()) < i)
					{
						dbcon.ExcuteQuery("update Cart set  qty = qty + " + int.Parse(txtQty.Text) + "where transno like '" +
							lblTransNo.Text + "' and ProductCode like '" + dgvCashier.Rows[e.RowIndex].Cells[2].Value.ToString() + "'");
					}
					else
					{
						MessageBox.Show("Remaining qty on hand is" + i, "Insufficient stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			else if (colName == "colReduce")
			{
				try
				{
					int i = 0;
					if (cn.State == ConnectionState.Open)
					{
						cn.Close();
					}

					cn.Open();

					using (SqlCommand cm = new SqlCommand("select sum(qty) as qty from Cart where ProductCode like '" + dgvCashier.Rows[e.RowIndex].Cells[2].Value.ToString()
								+ "' group by ProductCode", cn))
					{
						i = int.Parse(cm.ExecuteScalar().ToString());

					}

					if (i > 1)
					{
						dbcon.ExcuteQuery("update Cart set  qty = qty - " + int.Parse(txtQty.Text) + "where transno like '" +
							lblTransNo.Text + "' and ProductCode like '" + dgvCashier.Rows[e.RowIndex].Cells[2].Value.ToString() + "'");
					}
					else
					{
						MessageBox.Show("Remaining qty on hand is: " + i, "Insufficient stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		public void Notify()
		{
			int i = 0;
			if (cn.State == ConnectionState.Closed)
				cn.Open();

			using (SqlCommand cm = new SqlCommand("select * from vwCriticalItems", cn))
			{
				dr = cm.ExecuteReader();
				while (dr.Read())
				{
					i++;
					Alert alert = new Alert(new MainForm());
					alert.lblPCode.Text = dr["ProductCode"].ToString();
					//alert.btnReOrder.Enabled = false;
					alert.showAlert(i + ". " + dr["Description"].ToString() + " - " + dr["qty"].ToString());
				}
				dr.Close();
			}
		}

		private void Cashier_Load(object sender, EventArgs e)
		{
			Notify();
		}

		private void Cashier_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F8)
			{

			}
		}
	}
}