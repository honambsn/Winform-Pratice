using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
	public partial class DashboardForm : UserControl
	{

		string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";
		public DashboardForm()
		{
			InitializeComponent();
			CenterPanelInForm();
			incomeTodayIncome();
			incomeYesterdayIncome();
			incomeThisMonthIncome();
			incomeThisYearIncome();
			expenseTodayExpense();
			expensesYesterdayExpense();
			expenseThisMonthExpense();
			expenseThisYearExpense();
		}

		private void CenterPanelInForm()
		{
			// Ensure both the Panel and Form are initialized
			if (panel1 == null || this == null)
				return;

			// Calculate the X and Y coordinates to center the Panel
			int centerX = (this.ClientSize.Width - panel1.Width) / 2;
			//int centerY = (this.ClientSize.Height - panel1.Height) / 2;

			// Set the Location property of the Panel
			panel1.Location = new Point(centerX, 15);
		}

		//INCOME

		public void incomeTodayIncome()
		{
			using(SqlConnection con  = new SqlConnection(connectionString))
			{
				con.Open();

				string query = "select sum(income) from income where date_income = @date_income";
				
				using(SqlCommand cmd = new SqlCommand(query,con))
				{
					DateTime today = DateTime.Today;
					cmd.Parameters.AddWithValue("@date_income", today);

					object result = cmd.ExecuteScalar();

					if(result != DBNull.Value)
					{
						decimal todayCost = Convert.ToDecimal(result);

						income_todayIncome.Text = "$" + todayCost.ToString("0.00");
						//income_todayIncome.Text = todayCost.ToString("C", CultureInfo.CurrentCulture);

					}
					else
					{
						income_todayIncome.Text = "$0.00";
					}
				}
			}
		}

		public void incomeYesterdayIncome()
		{
			using(SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();

				string query = "select sum(income) from income where convert(DATE, date_income) = DATEADD(day, DATEDIFF(day, 0, GETDATE()), -1)";

				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					object result = cmd.ExecuteScalar();

					if(result != DBNull.Value)
					{
						decimal yesterdayCost = Convert.ToDecimal(result);

						income_yesterdayIncome.Text = "$" + yesterdayCost.ToString("0.00");
						//income_yesterdayIncome.Text = yesterdayCost.ToString("C");
					}
					else
					{
						income_yearIncome.Text = "$0.00";
					}
				}
			}
		}

		public void incomeThisMonthIncome()
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();

				DateTime today = DateTime.Now.Date;

				DateTime startMonth = new DateTime(today.Year, today.Month,1);
				DateTime endMonth = startMonth.AddMonths(1).AddDays(1);

				string query = "select sum(income) from income where date_income >= @startMonth AND date_income <=  @endMonth";

				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					cmd.Parameters.AddWithValue("@startMonth", startMonth);
					cmd.Parameters.AddWithValue("@endMonth", endMonth); 
					
					object result = cmd.ExecuteScalar();

					if (result != DBNull.Value)
					{
						decimal monthCost = Convert.ToDecimal(result);

						income_monthIncome.Text = "$" + monthCost.ToString("0.00");
						//income_yesterdayIncome.Text = yesterdayCost.ToString("C");
					}
					else
					{
						income_monthIncome.Text = "$0.00";
						//income_yearIncome
					}
				}
			}
		}

		public void incomeThisYearIncome()
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();

				DateTime today = DateTime.Now.Date;

				DateTime startYear = new DateTime(today.Year, 1, 1);
				DateTime endYear = startYear.AddYears(1).AddDays(-1);
				

				string query = "select sum(income) from income where date_income >= @startYear AND date_income <=  @endYear";

				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					cmd.Parameters.AddWithValue("@startYear", startYear);
					cmd.Parameters.AddWithValue("@endYear", endYear);

					object result = cmd.ExecuteScalar();

					if (result != DBNull.Value)
					{
						decimal yearCost = Convert.ToDecimal(result);

						income_yearIncome.Text = "$" + yearCost.ToString("0.00");
						//income_yesterdayIncome.Text = yesterdayCost.ToString("C");
					}
					else
					{
						income_yearIncome.Text = "$0.00";
						//income_yearIncome
					}
				}
			}
		}



		//EXPENSES
		public void expenseTodayExpense()
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();

				string query = "select sum(cost) from expenses where date_expense = @date_expense";

				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					DateTime today = DateTime.Today;
					cmd.Parameters.AddWithValue("date_expense", today);

					object result = cmd.ExecuteScalar();

					if (result != DBNull.Value)
					{
						decimal todayCost = Convert.ToDecimal(result);

						expenses_todayExpense.Text = "$" + todayCost.ToString("0.00");
						//income_yesterdayIncome.Text = yesterdayCost.ToString("C");
					}
					else
					{
						expenses_todayExpense.Text = "$0.00";
						//income_yearIncome
					}
				}
			}
		}


		public void expensesYesterdayExpense()
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();

				string query = "select sum(cost) from expenses where convert(DATE, date_expense) = DATEADD(day, DATEDIFF(day, 0, GETDATE()), -1)";
				
				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					object result = cmd.ExecuteScalar();

					if (result != DBNull.Value)
					{
						decimal yesterdayCost = Convert.ToDecimal(result);

						expenses_yesterdayExpense.Text = "$" + yesterdayCost.ToString("0.00");
						//income_yesterdayIncome.Text = yesterdayCost.ToString("C");
					}
					else
					{
						expenses_yesterdayExpense.Text = "$0.00";
					}
				}
			}
		}

		public void expenseThisMonthExpense()
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();

				DateTime today = DateTime.Now.Date;
				DateTime startMonth = new DateTime(today.Year, today.Month, 1);
				DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

				string query = "select sum(cost) from expenses where date_expense >= @startMonth and date_expense <= @endMonth";
				
				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					cmd.Parameters.AddWithValue("@startMonth", startMonth);
					cmd.Parameters.AddWithValue("@endMonth", endMonth);

					object result = cmd.ExecuteScalar();

					if (result != DBNull.Value)
					{
						decimal monthCost = Convert.ToDecimal(result);

						expenses_monthExpense.Text = "$" + monthCost.ToString("0.00");
						//income_yesterdayIncome.Text = yesterdayCost.ToString("C");
					}
					else
					{
						expenses_monthExpense.Text = "$0.00";
					}
				}
			}
		}

		public void expenseThisYearExpense()
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();

				DateTime today = DateTime.Now.Date;

				DateTime startYear = new DateTime(today.Year, 1, 1);
				DateTime endYear = startYear.AddYears(1).AddDays(-1);


				string query = "select sum(cost) from expenses where date_expense >= @startYear and date_expense <= @endYear";

				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					cmd.Parameters.AddWithValue("@startYear", startYear);
					cmd.Parameters.AddWithValue("@endYear", endYear);

					object result = cmd.ExecuteScalar();

					if (result != DBNull.Value)
					{
						decimal yearCost = Convert.ToDecimal(result);

						expenses_yearExpense.Text = "$" + yearCost.ToString("0.00");
						//income_yesterdayIncome.Text = yesterdayCost.ToString("C");
					}
					else
					{
						expenses_yearExpense.Text = "$0.00";
						//income_yearIncome
					}
				}
			}
		}

	}
}
