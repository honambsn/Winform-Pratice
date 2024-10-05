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
	public partial class Brand : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		public Brand()
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			drawCenter();
			LoadBrand();
		}

		private void drawCenter()
		{
			//int xPos = (this.panel1.Width - this.label1.Width) / 2;
			int xPos = this.label1.Location.X;
			int yPos = (this.panel1.Height - this.label1.Height) / 2;

			this.label1.Location = new Point(xPos, yPos);

			//xPos = (this.panel1.Width - this.button1.Width) / 2;
			xPos = this.btnAdd.Location.X;
			yPos = (this.panel1.Height - this.btnAdd.Height) / 2;
			this.btnAdd.Location = new Point(xPos, yPos);
		}

		//data retrieve from tbBrand to dgbBrand on Brand from
		public void LoadBrand()
		{
			try
			{
				int i = 0;
				dgvBrand.Rows.Clear();
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
				cn.Open();
				cm = new SqlCommand("SELECT * FROM Brand ORDER BY BrandName", cn);
				SqlDataReader dr = cm.ExecuteReader();
				while (dr.Read())
				{
					i++;
					dgvBrand.Rows.Add(i, dr["id"].ToString(), dr["BrandName"].ToString());
				}
				dr.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				cn.Close();
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			BrandModule moduleForm = new BrandModule(this);
			moduleForm.ShowDialog();
		}

		private void dgvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string colname = dgvBrand.Columns[e.ColumnIndex].Name;
			if (colname == "Delete")
			{
				if (MessageBox.Show("Are u sure u want to delete this record?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
				{	
					try
					{
						using (SqlCommand cm = new SqlCommand("DELETE FROM Brand WHERE id = @id", cn))
						{
							// Set the command parameter
							cm.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(dgvBrand.Rows[e.RowIndex].Cells[1].Value);

							cn.Open(); // Open the connection
							int rowsAffected = cm.ExecuteNonQuery(); // Execute the command

							if (rowsAffected > 0)
							{
								MessageBox.Show("Record has been successfully deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
							else
							{
								MessageBox.Show("No record found with the specified ID.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}
						}
					}
					catch(Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
					finally
					{
						LoadBrand();
						cn.Close();
					}
				}
			}
			else if (colname == "Edit")
			{
				try
				{
					BrandModule brandModule = new BrandModule(this);
					brandModule.lblID.Text = dgvBrand.Rows[e.RowIndex].Cells[1].Value.ToString();
					brandModule.txtBrand.Text = dgvBrand.Rows[e.RowIndex].Cells[2].Value.ToString();
					brandModule.btnSave.Enabled = false;
					brandModule.btnUpdate.Enabled = true;
					brandModule.ShowDialog();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					LoadBrand();
					cn.Close();
				}
			}
		}
	}
}
