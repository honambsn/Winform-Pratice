using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			CenterPictureBoxVertically();
			displayUsername();
		}

		public void displayUsername()
		{
			// Ensure Form1.username is not null
			if (Form1.username == null)
			{
				// Handle the case where Form1.username is null
				greetUser.Text = "Welcome, Guest";
				return;
			}

			string getUsername = Form1.username;

			// Check if the username is not empty and has at least one character
			if (string.IsNullOrEmpty(getUsername))
			{
				greetUser.Text = "Welcome, Guest";
				return;
			}

			// Properly handle substring and capitalization
			string capitalizedUsername;

			// Capitalize the first letter of the username
			if (getUsername.Length > 1)
			{
				capitalizedUsername = getUsername.Substring(0, 1).ToUpper() + getUsername.Substring(1);
			}
			else
			{
				// If the username is a single character, just capitalize it
				capitalizedUsername = getUsername.ToUpper();
			}

			greetUser.Text = "Welcome, " + capitalizedUsername;
		}


		private void close_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are u sure u want to close?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.Exit();
			}
			
		}

		private void CenterPictureBoxVertically()
		{
			// Check if the panel and picture box are initialized
			if (pictureBox2 != null && pictureBox2 != null)
			{
				// Calculate the X coordinate to center the PictureBox
				int centerX = (panel2.Width - pictureBox2.Width) / 2;

				// Set the Left property of the PictureBox
				pictureBox2.Left = centerX;
			}
		}

		private void logout_Btn_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are u sure u want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Form1 loginForm = new Form1();
				loginForm.Show();

				this.Hide();
			}
		}

		private void income_Btn_Click(object sender, EventArgs e)
		{
			incomeForm1.Visible = true;
			categoryForm1.Visible = false;
			dashboardForm1.Visible = false;
			expensesForm1.Visible = false;

			IncomeForm iForm = incomeForm1 as IncomeForm;

			if(iForm != null)
			{
				iForm.refreshData();
			}
		}

		private void addCate_Btn_Click(object sender, EventArgs e)
		{
			categoryForm1.Visible = true;
			dashboardForm1.Visible = false;
			incomeForm1.Visible = false;
			expensesForm1.Visible = false;

			CategoryForm cForm = categoryForm1 as CategoryForm;
			if(cForm != null)
			{
				cForm.refreshData();
			}
		}

		private void dashboard_Btn_Click(object sender, EventArgs e)
		{
			dashboardForm1.Visible = true;
			incomeForm1.Visible = false;
			categoryForm1.Visible = false;
			expensesForm1.Visible = false;

			DashboardForm dForm = dashboardForm1 as DashboardForm;

			if(dForm != null)
			{
				dForm.refreshData();
			}
		}

		private void expense_Btn_Click(object sender, EventArgs e)
		{
			expensesForm1.Visible = true;
			dashboardForm1.Visible = false;
			incomeForm1.Visible = false;
			categoryForm1.Visible = false;

			ExpensesForm eForm = expensesForm1 as ExpensesForm;
			if(eForm != null)
			{
				eForm.refreshData();
			}
		}
	}
}
