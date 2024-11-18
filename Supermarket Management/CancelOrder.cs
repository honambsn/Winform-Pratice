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
	public partial class CancelOrder : Form
	{
		//SqlConnection cn = new SqlConnection();
		//SqlCommand cm = new SqlCommand();
		//DBConnect dbcon = new DBConnect();
		//SqlDataReader dr;
		//CancelOrder cancelOrder;
		DailySale dailySale;
		public CancelOrder(DailySale sale)
		{
			InitializeComponent();
			dailySale = sale;
			//cn = new SqlConnection(dbcon.myConnection());
		}

		private void picClose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to close this form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Dispose();
			}
		}

		private void btnCCancel_Click(object sender, EventArgs e)
		{
			try
			{
				if (cboInventory.Text != string.Empty && udCancelQty.Value > 0 && txtReason.Text != string.Empty)
				{
					if (int.Parse(txtQty.Text) >= udCancelQty.Value)
					{
						Void @void = new Void(this);
						@void.txtUsername.Focus();
						@void.ShowDialog();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}

		public void ReloadSoldList()
		{
			dailySale.LoadSold();
		}

		private void cboInventory_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;

		}
	}
}
