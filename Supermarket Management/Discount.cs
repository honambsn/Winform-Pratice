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
	public partial class Discount : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;
		string stitle = "Simple Market Management System";
		Cashier cashier;
		public Discount(Cashier cash)
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			this.cashier = cash;
			txtDiscount.Focus();
		}

		private void picClose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to close this form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Dispose();
			}
		}

		private void Discount_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
			{
				this.Dispose();
			}

			if (e.KeyCode == Keys.Escape)
			{
				this.Dispose();
			}
			else if (e.KeyCode == Keys.Enter)
			{
				//btnEnter_Click(sender, e);
				btnSave.PerformClick();
			}
		}

		private void txtDiscount_TextChanged(object sender, EventArgs e)
		{
			try
			{
				double disc = double.Parse(txtTotalPrice.Text) * double.Parse(txtDiscount.Text) * 0.01; 
				txtDiscountAmount.Text = disc.ToString("#,##0.00");
			}
			catch (Exception ex)
			{
				txtDiscountAmount.Text = "0.00";
				MessageBox.Show(ex.Message);
			}
			finally
			{

			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (cn.State == ConnectionState.Closed)
					cn.Open();

				if (MessageBox.Show("Are you sure you want to save this discount?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					//cn.Open();
					//cm = new SqlCommand("INSERT INTO Discount (Discount, DiscountAmount) VALUES(@Discount, @DiscountAmount)", cn);
					//cm.Parameters.AddWithValue("@Discount", txtDiscount.Text.Trim());
					//cm.Parameters.AddWithValue("@DiscountAmount", txtDiscountAmount.Text.Trim());
					//cm.ExecuteNonQuery();
					//MessageBox.Show("Discount has been saved successfully!", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
					//this.Dispose();
					using (SqlCommand cm = new SqlCommand("update Cart set disc_percent = @disc_percent where id = @id", cn))
					{
						//cm.Parameters.AddWithValue("@disc", double.Parse(txtDiscountAmount.Text));
						cm.Parameters.AddWithValue("@disc_percent", double.Parse(txtDiscount.Text));
						cm.Parameters.AddWithValue("@id", int.Parse(lblID.Text));

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
				cashier.LoadCart();
				this.Dispose();	
			}
		}
	}
}
