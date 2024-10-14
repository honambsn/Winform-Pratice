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
	public partial class Supplier : Form
	{

		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		string stitle = "Point Of Sales";
		public Supplier()
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			LoadSupplier();
		}

		public void LoadSupplier()
		{
			// Clear existing rows in the DataGridView
			dgvSupplier.Rows.Clear();

			// Use a variable for row index
			int i = 0;

			// Ensure the connection is properly closed even if an error occurs
			try
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
				cn.Open();
				using (SqlCommand cm = new SqlCommand("SELECT * FROM Supplier", cn))
				using (SqlDataReader dr = cm.ExecuteReader())
				{
					while (dr.Read())
					{
						i++;
						// Add rows to the DataGridView
						dgvSupplier.Rows.Add(i,
											 dr["id"].ToString(),
											 dr["supplierName"].ToString(),
											 dr["address"].ToString(),
											 dr["contact"].ToString(),
											 dr["phone"].ToString(),
											 dr["email"].ToString(),
											 dr["fax"].ToString());
					}
				} // SqlDataReader and SqlCommand are disposed here
			}
			catch (Exception ex)
			{
				// Handle exceptions (logging, displaying a message, etc.)
				MessageBox.Show("An error occurred while loading suppliers: " + ex.Message);
			}
			finally
			{
				// Ensure the connection is closed
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			SupplierModule moduleForm = new SupplierModule(this);
			moduleForm.ShowDialog();

		}

		private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string colName = dgvSupplier.Columns[e.ColumnIndex].Name;
			if (colName == "Edit")
			{
				try
				{
					SupplierModule supplierModule = new SupplierModule(this);
					supplierModule.lblID.Text = dgvSupplier[1, e.RowIndex].Value.ToString();
					supplierModule.txtSupplier.Text = dgvSupplier[2, e.RowIndex].Value.ToString();
					supplierModule.txtAddress.Text = dgvSupplier[3, e.RowIndex].Value.ToString();
					supplierModule.txtContact.Text = dgvSupplier[4, e.RowIndex].Value.ToString();
					supplierModule.txtPhone.Text = dgvSupplier[5, e.RowIndex].Value.ToString();
					supplierModule.txtEmail.Text = dgvSupplier[6, e.RowIndex].Value.ToString();
					supplierModule.txtFax.Text = dgvSupplier[7, e.RowIndex].Value.ToString();
					
					supplierModule.btnSave.Enabled = false;
					supplierModule.btnUpdate.Enabled = true;
				
					supplierModule.ShowDialog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					LoadSupplier();
				}
			}
			else if (colName == "Delete")
			{
				if (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
				{
					try
					{
						using (SqlCommand cm = new SqlCommand("DELETE FROM Supplier WHERE id = @id", cn))
						{
							// Get the cell value and check for null
							var cellValue = dgvSupplier.Rows[e.RowIndex].Cells[1].Value;
							if (cellValue == null)
							{
								MessageBox.Show("No ID found for the selected record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								return;
							}

							// Set the command parameter
							cm.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(cellValue);

							cn.Open(); // Open the connection
							int rowsAffected = cm.ExecuteNonQuery(); // Execute the command

							// Provide feedback to the user
							if (rowsAffected > 0)
							{
								MessageBox.Show("Record has been successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
							else
							{
								MessageBox.Show("No record found with the specified ID.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}
						}
						
					}
					catch (Exception ex)
					{
						MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally
					{
						LoadSupplier(); // Refresh the supplier list
					}
				}


			}
		}
	}
}
