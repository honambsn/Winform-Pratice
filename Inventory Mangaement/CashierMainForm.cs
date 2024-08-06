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


				form1 loginform = new form1();
				loginform.show();



				this.Hide();
			}
		}
	}
}
