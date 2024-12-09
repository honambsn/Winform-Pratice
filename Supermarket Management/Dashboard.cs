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
	public partial class Dashboard : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;

		public Dashboard()
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
		}

		private void Dashboard_Load(object sender, EventArgs e)
		{
			string sdate = DateTime.Now.ToShortDateString();
			lblDailySales.Text = dbcon.ExtractData("select isnull(sum(total), 0) as total from Cart where status = 'Sold' and sdate between '" + sdate + "' and '" + sdate +"'").ToString("$#,##0.00");
			lblTotalProd.Text = dbcon.ExtractData("select count(*) from Product").ToString("$#,##0");
			lblStockOnHand.Text = dbcon.ExtractData("select isnull(sum(total), 0) as total from Cart").ToString("$#,##0");
			lblCriticalItems.Text = dbcon.ExtractData("select count(*) from vwCriticalItems").ToString("$#,##0");
		}
	}
}
