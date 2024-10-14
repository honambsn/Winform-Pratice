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
	public partial class SupplierModule : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		string stitle = "Point Of Sales";
		Supplier supplier;

		public SupplierModule(Supplier sp)
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			supplier = sp;
		}

		private void picClose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to close this form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		public void Clear()
		{
			txtAddress.Clear();
			txtContact.Clear();
			txtEmail.Clear();
			txtFax.Clear();
			txtPhone.Clear();
			txtSupplier.Clear();

			btnSave.Enabled = true;
			btnUpdate.Enabled = false;
			txtSupplier.Focus();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Are u sure u want to save this product?", "Save product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{	
					if (ConnectionState.Closed == cn.State) cn.Open();

					try
					{
						using (SqlCommand cm = new SqlCommand("INSERT INTO Supplier (supplierName, address, contact, phone, email, fax) VALUES(@supplierName, @address, @contact, @phone, @email, @fax)", cn))
						{
							cm.Parameters.AddWithValue("@supplierName", txtSupplier.Text.Trim());
							cm.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
							cm.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
							cm.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
							cm.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
							cm.Parameters.AddWithValue("@fax", txtFax.Text.Trim());

							MessageBox.Show("Supplier has been saved successfully", stitle);

							cm.ExecuteNonQuery();
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				supplier.LoadSupplier();
				Clear();
				//this.Dispose();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Update this record?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (ConnectionState.Closed == cn.State) cn.Open();

					using (SqlCommand cm = new SqlCommand("UPDATE Supplier SET supplierName = @supplierName, address = @address, contact = @contact, phone = @phone, email = @email, fax = @fax WHERE id = @id", cn))
					{

						cm.Parameters.AddWithValue("@id", lblID.Text);
						cm.Parameters.AddWithValue("@supplierName", txtSupplier.Text.Trim());
						cm.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
						cm.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
						cm.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
						cm.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
						cm.Parameters.AddWithValue("@fax", txtFax.Text.Trim());

						cm.ExecuteNonQuery();
						MessageBox.Show("Record has been successfully updated", stitle);
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
//				this.Dispose();
				supplier.LoadSupplier();
			}
		}
	}
}
