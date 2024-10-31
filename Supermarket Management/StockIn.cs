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
	public partial class StockIn : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;
		string stitle = "Simple Market";
		public StockIn()
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			drawCenter();
			LoadSupplier();
			GetReferenceNo();
		}

		public void GetReferenceNo()
		{
			//cn.Open();
			//cm = new SqlCommand("SELECT TOP 1 refNo FROM StockIn ORDER BY refNo DESC", cn);
			//dr = cm.ExecuteReader();
			//dr.Read();
			//if (dr.HasRows)
			//{
			//	int v = Convert.ToInt32(dr[0].ToString()) + 1;
			//	txtRefNo.Text = v.ToString();
			//}
			//else
			//{
			//	txtRefNo.Text = "1";
			//}
			//dr.Close();
			//cn.Close();

			Random rnd = new Random();
			txtRefNo.Clear();
			txtRefNo.Text += rnd.Next();
		}

		public void drawCenter()
		{
			int xPos = this.label1.Location.X;
			int yPos = (this.panel1.Height - this.label1.Height) / 2;

			this.label1.Location = new Point(xPos, yPos);

			xPos = this.txtSearch.Location.X;
			yPos = (this.panel1.Height - this.txtSearch.Height) / 2;
			this.txtSearch.Location = new Point(xPos, yPos);
		}

		public void LoadSupplier()
		{
			try
			{
				var supplierData = dbcon.GetTable("SELECT * FROM Supplier");
				if (supplierData != null && supplierData.Rows.Count > 0)
				{
					cbSupplier.DataSource = supplierData;
					cbSupplier.DisplayMember = "supplierName"; // Correct column name
					//cbSupplier.ValueMember = "id"; // Optional, if you want to use the ID later
				}
				else
				{
					cbSupplier.DataSource = null; // Clear the data source if no data
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while loading suppliers: " + ex.Message);
			}
		}

		public void LoadStockIn()
		{
			try
			{
				int i = 0;
				dgvStockIn.Rows.Clear();
				if (cn.State != ConnectionState.Open)
					cn.Open();

				using (SqlCommand cm = new SqlCommand("SELECT * FROM vwStockIn WHERE refno LIKE @refNo AND status = 'Pending'", cn))
				//using(SqlCommand cm = new SqlCommand("SELECT * FROM StockIn where refno like '" + txtRefNo.Text + "' and status like 'Pending'", cn))
				{
					cm.Parameters.AddWithValue("@refNo", txtRefNo.Text + "%");
					using (SqlDataReader dr = cm.ExecuteReader())
					{
						while (dr.Read())
						{
							i++;
							//dgvStockIn.Rows.Add(i, dr["refNo"].ToString(), dr["pcode"].ToString(), dr["pname"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["sdate"].ToString(), dr["supplier"].ToString(), dr["address"].ToString(), dr["contact"].ToString());
							dgvStockIn.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while loading stock in: " + ex.Message);
			}
		}


		private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbSupplier.SelectedItem != null) // Ensure an item is selected
			{
				if (cn.State != ConnectionState.Open)
					cn.Open();

				using (SqlCommand cm = new SqlCommand("SELECT * FROM Supplier WHERE supplierName = @supplierName", cn))
				{
					cm.Parameters.AddWithValue("@supplierName", cbSupplier.Text);

					using (SqlDataReader dr = cm.ExecuteReader())
					{
						if (dr.Read()) // Check if there are rows
						{
							labelID.Text = dr["id"].ToString(); // Use the correct column name
							txtConPerson.Text = dr["contact"].ToString(); // Use the correct column name
							txtAddress.Text = dr["address"].ToString();
						}
					}
				}
			}
		}

		private void cbSupplier_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;

		}

		private void linkGen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			GetReferenceNo();
		}

		private void linkProd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ProductStockIn prodStock = new ProductStockIn(this);
			prodStock.ShowDialog();
		}
	}
}