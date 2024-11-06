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
	public partial class Qty : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;

		private string pcode;
		private double price;
		private int qty;
		private String transno;
		Cashier cashier;
		public Qty(Cashier cash)
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			this.cashier = cash;
		}

		public void ProductDetails(string pcode, double price, string transno, int qty)
		{
			this.pcode = pcode;
			this.price = price;
			this.transno = transno;
			this.qty = qty;

		}

		private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar == 13) && (txtQty.Text != string.Empty))
			{
				//try
				//{
				//	if (cn.State == ConnectionState.Open)
				//	{
				//		cn.Close();
				//	}
				//	cn.Open();
				//	using (SqlCommand cm = new SqlCommand("insert into Cart (transno, ProductCode, Price, qty, sdate, cashier) values (@transno, @ProductCode, @Price, @qty, @sdate, @cashier)", cn))
				//	{
				//		cm.Parameters.AddWithValue("@transno", transno);
				//		cm.Parameters.AddWithValue("@ProductCode", pcode);
				//		cm.Parameters.AddWithValue("@Price", price);
				//		cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
				//		cm.Parameters.AddWithValue("@sdate", DateTime.Now);
				//		cm.Parameters.AddWithValue("@cashier", cashier.lblUsername.Text);
				//		cm.ExecuteNonQuery();
				//		cashier.LoadCart();

				//	}
				//}
				//catch (Exception ex)
				//{
				//	MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				//}
				//finally
				//{
				//	MessageBox.Show("Item added to cart", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
				//	this.Dispose();
				//}


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
						cm.Parameters.AddWithValue("@transno", transno);
						cm.Parameters.AddWithValue("@ProductCode", pcode);
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

						using (SqlCommand cm = new SqlCommand("update Cart set qty = (qty + " + int.Parse(txtQty.Text) + ") where id = '" + id + "'", cn))
						{

							cm.ExecuteNonQuery();
							//txtBarcode.SelectionStart = 0;
							//txtBarcode.SelectionLength = txtBarcode.Text.Length;
							//LoadCart();
							cashier.txtBarcode.Clear();
							cashier.txtBarcode.Focus();
							cashier.LoadCart();
							this.Dispose();
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
							cm.Parameters.AddWithValue("@transno", transno);
							cm.Parameters.AddWithValue("@ProductCode", pcode);
							cm.Parameters.AddWithValue("@Price", price);
							cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
							cm.Parameters.AddWithValue("@sdate", DateTime.Now);
							cm.Parameters.AddWithValue("@cashier", cashier.lblUsername.Text);
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
					//LoadCart();
					cashier.txtBarcode.Clear();
					cashier.txtBarcode.Focus();
					cashier.LoadCart();
					this.Dispose();
				}
			}
		}

	}
}
