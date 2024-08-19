using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Mangaement
{
	public partial class CashierMainForm : Form
	{
		
		public CashierMainForm()
		{
			InitializeComponent();
			//displayUsername();
		}

		public void displayUsername()
		{
			string username = Form1.username.Substring(0, 1).ToUpper() + Form1.username.Substring(1);
			lbl_username.Text = username;

		}


		private void close_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to close?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				//Form1 loginForm = new Form1();
				//loginForm.Show();

				//this.Hide();

				Application.Exit();
			}
		}

		private void logout_btn_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{

				Form1 loginForm = new Form1();
				loginForm.Show();

				this.Hide();


				this.Hide();
			}
		}

		private void dashboard_btn_Click(object sender, EventArgs e)
		{
			adminDashboard1.Visible = true;
			adminAddProducts1.Visible = false;
			cashierCustomer1.Visible = false;
			cashierOrder1.Visible = false;

			AdminDashboard adForm = adminDashboard1 as AdminDashboard;

			if (adForm != null)
			{
				adForm.refreshData();
			}
		}

		private void addProducts_btn_Click(object sender, EventArgs e)
		{
			adminDashboard1.Visible = false;
			adminAddProducts1.Visible = true;
			cashierCustomer1.Visible = false;
			cashierOrder1.Visible = false;

			AdminAddProducts aap = adminAddProducts1 as AdminAddProducts;

			if (aap != null)
			{
				aap.refreshData();
			}
		}

		private void Customer_btn_Click(object sender, EventArgs e)
		{
			adminDashboard1.Visible = false;
			adminAddProducts1.Visible = false;
			cashierCustomer1.Visible = true;
			cashierOrder1.Visible = false;

			CashierCustomer ccForm = cashierCustomer1 as CashierCustomer;

			if (ccForm != null)
			{
				ccForm.refreshData();
			}
		}

		private void Order_btn_Click(object sender, EventArgs e)
		{
			adminDashboard1.Visible = false;
			adminAddProducts1.Visible = false;
			cashierCustomer1.Visible = false;
			cashierOrder1.Visible = true;

			CashierOrder coForm = cashierOrder1 as CashierOrder;

			if(coForm != null)
			{
				coForm.refreshData();
			}
		}

		private void CategoryView_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This function is maintaining", "Warning Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
		}
	}
}
