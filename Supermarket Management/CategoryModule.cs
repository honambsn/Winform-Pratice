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
	public partial class CategoryModule : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		Category category;
		public CategoryModule(Category cate)
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			this.category = cate;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Are u sure u want to save this Category?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					cn.Open();
					cm = new SqlCommand("INSERT INTO Category (CategoryName) VALUES(@CategoryName)", cn);
					cm.Parameters.AddWithValue("@CategoryName", txtCategory.Text.Trim()); // Use the correct parameter name
					cm.ExecuteNonQuery();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				//category.LoadBrand();
				MessageBox.Show("Record has been saved successfully", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Clear();
				cn.Close();
			}
		}

		public void Clear()
		{
			txtCategory.Clear();
			btnUpdate.Enabled = false;
			btnSave.Enabled = true;
			txtCategory.Focus();
		}

		private void picClose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to close this form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Close();
			}
		}
	}
}
