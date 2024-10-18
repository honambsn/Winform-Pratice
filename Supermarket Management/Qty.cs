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
				try
				{
					if (cn.State == ConnectionState.Open)
					{
						cn.Close();
					}
					cn.Open();
					using (SqlCommand cm = new SqlCommand("insert into Cart (transno, ProductCode, Price, qty, sdate, cashier) values (@transno, @ProductCode, @Price, @qty, @sdate, @cashier)", cn))
					{
						cm.Parameters.AddWithValue("@transno", transno);
						cm.Parameters.AddWithValue("@ProductCode", pcode);
						cm.Parameters.AddWithValue("@Price", price);
						cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
						cm.Parameters.AddWithValue("@sdate", DateTime.Now);
						cm.Parameters.AddWithValue("@cashier", cashier.lblUsername.Text);
						cm.ExecuteNonQuery();
						cashier.LoadCart();
						this.Dispose();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				finally
				{
					
				}
			}
		}
	}
}
