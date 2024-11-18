using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management
{
	public partial class Void : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;
		CancelOrder cancelOrder;
		public Void(CancelOrder cancel)
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			txtUsername.Focus();
			cancelOrder = cancel;
		}

		private void btnVoid_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtUsername.Text == cancelOrder.txtCancelBy.Text)
				{
					MessageBox.Show("Void by name and cancelled by name cannot be the same!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				string user;
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}

				cn.Open();

				//using("select * from Users where username = @username and password = @password", cn)
				using (SqlCommand cm = new SqlCommand("select * from Users where username = @username and password = @password", cn))
				{
					cm.Parameters.AddWithValue("@username", txtUsername.Text);
					cm.Parameters.AddWithValue("@password", txtPassword.Text);

					dr = cm.ExecuteReader();
					dr.Read();
					if (dr.HasRows)
					{
						user = dr["username"].ToString();
						dr.Close();
						SaveCancelOrder(user);
						if (cancelOrder.cboInventory.Text == "yes")
						{
							dbcon.ExcuteQuery("update Product set qty = qty + " + cancelOrder.udCancelQty.Value + " where pcode = '"+cancelOrder.txtPCode.Text+ "'");
						}
						dbcon.ExcuteQuery("update Cart set qty = qty + " + cancelOrder.udCancelQty.Value + " where id lile '" + cancelOrder.txtId.Text + "'");
						MessageBox.Show("Order transaction succesfully cancelled!", "Cancel Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Dispose();
						cancelOrder.ReloadSoldList();
						cancelOrder.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				
			}
		}

		public void SaveCancelOrder(string user)
		{
			try
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}

				cn.Open();

				using(SqlCommand cm = new SqlCommand("insert into Cancel(transno, ProductCode, Price, qty, total, sdate, voidby, cancelledby, reason, action) values (@transno, @ProductCode, @Price, @qty, @total, @sdate, @voidby, @cancelledby, @reason, @action", cn))
				{
					cm.Parameters.AddWithValue("@transno", cancelOrder.txtTransno.Text);
					cm.Parameters.AddWithValue("@ProductCode", cancelOrder.txtPCode.Text);
					cm.Parameters.AddWithValue("@Price", double.Parse(cancelOrder.txtPrice.Text));
					cm.Parameters.AddWithValue("@qty", int.Parse(cancelOrder.txtQty.Text));
					cm.Parameters.AddWithValue("@total", double.Parse(cancelOrder.txtTotal.Text));
					cm.Parameters.AddWithValue("@sdate", DateTime.Now);
					cm.Parameters.AddWithValue("@voidby", user);
					cm.Parameters.AddWithValue("@cancelledby", cancelOrder.txtCancelBy.Text);
					cm.Parameters.AddWithValue("@reason", cancelOrder.txtReason.Text);
					cm.Parameters.AddWithValue("@action",  cancelOrder.cboInventory.Text);
					cm.ExecuteNonQuery();

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				MessageBox.Show("Transaction has been successfully voided!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void picClose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to close this form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Dispose();
			}
		}
	}
}
