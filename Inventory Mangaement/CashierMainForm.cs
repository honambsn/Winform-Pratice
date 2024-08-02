using System;
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
	}
}
