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
	public partial class ProductModule : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		Product product;
		string stitle = "Simple Market Management System";
		public ProductModule(Product pd)
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			product = pd;
			LoadBrand();
			LoadCategory();	
		}

		public void LoadCategory()
		{
			cbCate.Items.Clear();
			cbCate.DataSource = dbcon.GetTable("select * from Category");
			cbCate.DisplayMember = "CategoryName";
			cbCate.ValueMember = "id";
		}

		public void LoadBrand()
		{
			cbBrand.Items.Clear();
			cbBrand.DataSource = dbcon.GetTable("select * from Brand");
			cbBrand.DisplayMember = "BrandName";
			cbBrand.ValueMember = "id";
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
			txtPCode.Clear();
			txtBarcode.Clear();
			txtPDesc.Clear();
			txtPrice.Clear();
			cbBrand.SelectedIndex = -1;
			cbCate.SelectedIndex = -1;
			UDReOrder.Value = 1;

			txtPCode.Enabled = true;
			txtBarcode.Focus();
			btnSave.Enabled = true;
			btnUpdate.Enabled = false;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if(MessageBox.Show("Are u sure u want to save this product?", "Save product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					cn.Open();
					try
					{
						using (SqlCommand cm = new SqlCommand("INSERT INTO Product (ProductCode, Barcode, Description, BrandID, CategoryID, Price, ReOrder) VALUES(@ProductCode, @Barcode, @Description, @BrandID, @CategoryID, @Price, @ReOrder)", cn))
						{
							cm.Parameters.AddWithValue("@ProductCode", txtPCode.Text.Trim());
							cm.Parameters.AddWithValue("@Barcode", txtBarcode.Text.Trim());
							cm.Parameters.AddWithValue("@Description", txtPDesc.Text.Trim());
							cm.Parameters.AddWithValue("@BrandID", cbBrand.SelectedValue);
							cm.Parameters.AddWithValue("@CategoryID", cbCate.SelectedValue);
							cm.Parameters.AddWithValue("@Price", txtPrice.Text.Trim());
							cm.Parameters.AddWithValue("@ReOrder", UDReOrder.Value);
							MessageBox.Show("Product has been saved successfully", stitle);
							cm.ExecuteNonQuery();
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Clear();
				MessageBox.Show("Record has been saved successfully", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Clear();
				cn.Close();
				product.LoadProduct();
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
				// Ensure the connection is open
				if (cn.State != ConnectionState.Open)
					cn.Open();

				if (MessageBox.Show("Are u sure want to update this product?", "Update product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					
					try
					{
						using (SqlCommand cm = new SqlCommand("UPDATE Product SET Barcode = @Barcode, Description = @Description, BrandID = @BrandID, CategoryID = @CategoryID, Price=@Price, ReOrder=@ReOrder where ProductCode like @ProductCode", cn))
						{
							cm.Parameters.AddWithValue("@ProductCode", txtPCode.Text.Trim());
							cm.Parameters.AddWithValue("@Barcode", txtBarcode.Text.Trim());
							cm.Parameters.AddWithValue("@Description", txtPDesc.Text.Trim());
							cm.Parameters.AddWithValue("@BrandID", cbBrand.SelectedValue);
							cm.Parameters.AddWithValue("@CategoryID", cbCate.SelectedValue);
							cm.Parameters.AddWithValue("@Price", double.Parse(txtPrice.Text.Trim()));
							cm.Parameters.AddWithValue("@ReOrder", UDReOrder.Value);
							
							cm.ExecuteNonQuery();
							
							MessageBox.Show("Record has been successfully updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Clear();
				product.LoadProduct();
				this.Dispose();
				cn.Close();
			}
		}
	}
}
