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
	public partial class Store : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;

		bool havestoreinfo = false;
		public Store()
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			LoadStore();
		}

		public void LoadStore()
		{
			if (cn.State == ConnectionState.Open)
			{
				cn.Close();
			}
			cn.Open();

			try
			{
				using (SqlCommand cm = new SqlCommand("select * from Store", cn))
				{
					using (SqlDataReader reader = cm.ExecuteReader())
					{
						reader.Read();
						if (reader.HasRows)
						{
							havestoreinfo = true;
							txtStName.Text = reader["store"].ToString();
							txtAddress.Text = reader["address"].ToString();
						}
						else
						{
							txtStName.Clear();
							txtAddress.Clear();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}


		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (cn.State != ConnectionState.Open)
					cn.Open();
				if (MessageBox.Show("Save store details?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (havestoreinfo)
					{
						try
						{
							if (cn.State != ConnectionState.Open)
								cn.Open();
							using (SqlCommand cm = new SqlCommand("update Store set store = @store, address = @address", cn))
							{
								cm.Parameters.AddWithValue("@store", txtStName.Text);
								cm.Parameters.AddWithValue("@address", txtAddress.Text);
								cm.ExecuteNonQuery();
								MessageBox.Show("Store details successfully updated!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
					else
					{
						try
						{
							if (cn.State != ConnectionState.Open)
								cn.Open();
							using (SqlCommand cm = new SqlCommand("insert into Store (store, address) values (@store, @address)", cn))
							{
								cm.Parameters.AddWithValue("@store", txtStName.Text);
								cm.Parameters.AddWithValue("@address", txtAddress.Text);
								cm.ExecuteNonQuery();
								MessageBox.Show("Store details successfully saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}

					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
