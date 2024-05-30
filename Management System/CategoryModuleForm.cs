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

namespace Management_System
{
	public partial class CategoryModuleForm : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Management System\dbIMS.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
		SqlCommand cm = new SqlCommand();
		public CategoryModuleForm()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Are u sure to save this category?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					cm = new SqlCommand("INSERT INTO tbCategory(catname)VALUES(@catname)", con);
					cm.Parameters.AddWithValue("@catname", txtCatName.Text);
					con.Open();
					cm.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Category has been successfully added");
					Clear();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void Clear()
		{
			txtCatName.Clear();
			

		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
			btnSave.Enabled = false;
			btnUpdate.Enabled = false;
		}

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Are u sure to update this Category?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					cm = new SqlCommand("UPDATE tbCategory SET catname = @catname WHERE catid LIKE '" + lblCatId.Text + "' ", con);
					//cm = new SqlCommand("UPDATE tbUser SET fullname = @fullname, password=@password, phone=@phone WHERE username LIKE '" + txtUserName.Text + "' ", con);
					cm.Parameters.AddWithValue("@catname", txtCatName.Text);
					con.Open();
					cm.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Category has been successfully updated!");
					this.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
