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
		public ProductModule()
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
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
			UDReOrder.Value = 0;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if(MessageBox.Show("Are u sure u want to save this product?", "Save product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					cn.Open();
					cm = new SqlCommand("INSERT INTO Product (ProductCode, Barcode, Description, BrandID, CategoryID, Price, ReOrder) VALUES(@ProductCode, @Barcode, @Description, @BrandID, @CategoryID, @Price, @ReOrder)", cn);
					cm.Parameters.AddWithValue("@ProductCode", txtPCode.Text.Trim());
					cm.Parameters.AddWithValue("@Barcode", txtBarcode.Text.Trim());
					cm.Parameters.AddWithValue("@Description", txtPDesc.Text.Trim());
					cm.Parameters.AddWithValue("@BrandID", cbBrand.SelectedValue);
					cm.Parameters.AddWithValue("@CategoryID", cbCate.SelectedValue);
					cm.Parameters.AddWithValue("@Price", txtPrice.Text.Trim());
					cm.Parameters.AddWithValue("@ReOrder", UDReOrder.Value);
					cm.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				MessageBox.Show("Record has been saved successfully", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Clear();
				cn.Close();
			}
		}
	}
}
