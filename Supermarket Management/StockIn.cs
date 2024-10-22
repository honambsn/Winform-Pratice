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
					cbSupplier.ValueMember = "id"; // Optional, if you want to use the ID later
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
							txtAddress.Text = dr["address"].ToString();
							txtConPerson.Text = dr["contact"].ToString(); // Use the correct column name
						}
					}
				}
			}
		}

		private void cbSupplier_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;

		}
	}
}
