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
	public partial class Settle : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;
		Cashier cashier;
		public Settle(Cashier cash)
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			this.KeyPreview = true;
			cashier = cash;
		}

		private void btnOne_Click(object sender, EventArgs e)
		{
			txtCash.Text += btnOne.Text;
		}

		private void btnTwo_Click(object sender, EventArgs e)
		{
			txtCash.Text += btnTwo.Text;
		}

		private void btnThree_Click(object sender, EventArgs e)
		{
			txtCash.Text += btnThree.Text;
		}

		private void btnFour_Click(object sender, EventArgs e)
		{
			txtCash.Text += btnFour.Text;
		}

		private void btnFive_Click(object sender, EventArgs e)
		{
			txtCash.Text += btnFive.Text;
		}

		private void btnSix_Click(object sender, EventArgs e)
		{
			txtCash.Text += btnSix.Text;
		}

		private void btnSeven_Click(object sender, EventArgs e)
		{
			txtCash.Text += btnSeven.Text;
		}

		private void btnEight_Click(object sender, EventArgs e)
		{
			txtCash.Text += btnEight.Text;
		}

		private void btnNine_Click(object sender, EventArgs e)
		{
			txtCash.Text += btnNine.Text;
		}

		private void btnDZero_Click(object sender, EventArgs e)
		{
			txtCash.Text += btnDZero.Text;
		}

		private void btnZero_Click(object sender, EventArgs e)
		{
			txtCash.Text += btnZero.Text;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtCash.Clear();
			txtCash.Focus();
		}

		private void btnEnter_Click(object sender, EventArgs e)
		{
			try
			{
				if ((double.Parse(txtChange.Text) < 0) || (txtCash.Text.Equals("")))
				{
					MessageBox.Show("Insufficient amount, Please enter the correct amount!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				else
				{
					for (int i = 0; i < cashier.dgvCashier.Rows.Count; i++)
					{
						if (cn.State == ConnectionState.Open)
						{
							cn.Close();
						}
						cn.Open();

						//using(SqlCommand cm = new SqlCommand("update Cart set status = 'Sold', cash = @cash, change = @change where id = @id", cn))
						using (SqlCommand cm = new SqlCommand("update Product set qty = qty - " + int.Parse(cashier.dgvCashier.Rows[i].Cells[3].Value.ToString()) + " where pcode = '" + cashier.dgvCashier.Rows[i].Cells[5].Value.ToString()
							+ "where ProductCode = @ProductCode '" + cashier.dgvCashier.Rows[i].Cells[2].Value.ToString() + "'", cn))
						{
							//cm.Parameters.AddWithValue("@cash", double.Parse(txtCash.Text));
							//cm.Parameters.AddWithValue("@change", double.Parse(txtChange.Text));
							//cm.Parameters.AddWithValue("@id", int.Parse(cashier.dgvCashier.Rows[i].Cells[0].Value.ToString()));
							cm.ExecuteNonQuery();
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

		private void txtCash_TextChanged(object sender, EventArgs e)
		{
			try
			{
				double sale = 0;
				double cash = 0;

				
				string saleText = txtSale.Text.Replace(',', '.');
				string cashText = txtCash.Text.Replace(',', '.');

				
				if (!string.IsNullOrEmpty(saleText) && double.TryParse(saleText, out sale))
				{
					if (!string.IsNullOrEmpty(cashText) && double.TryParse(cashText, out cash))
					{
						double charge = cash - sale;
						txtChange.Text = charge.ToString("#,##0.00");
					}
					else
					{
						txtChange.Text = "0.00";
					}
				}
				else
				{
					txtChange.Text = "0.00";
				}
			}
			catch (Exception ex)
			{
				txtChange.Text = "0.00";
				MessageBox.Show(ex.Message);
			}
			finally
			{

			}
		}

		private void Settle_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Dispose();
			}
			else if (e.KeyCode == Keys.Enter)
			{
				//btnEnter_Click(sender, e);
				btnEnter.PerformClick();
			}
			else if (e.KeyCode == Keys.D1)
			{
				txtCash.Text += 1;
			}
			
		}
	}
}
