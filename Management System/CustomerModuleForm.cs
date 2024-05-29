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
	public partial class CustomerModuleForm : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Management System\dbIMS.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
		SqlCommand cm = new SqlCommand();
		public CustomerModuleForm()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Are u sure to save this customer?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					cm = new SqlCommand("INSERT INTO tbCustomer(cname,cphone)VALUES(@cname,@cphone)", con);
					cm.Parameters.AddWithValue("@cname", txtCName.Text);
					cm.Parameters.AddWithValue("@cphone", txtCPhone.Text);
					con.Open();
					cm.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("User has been successfully added");
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
			txtCName.Clear();
			txtCPhone.Clear();
			
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
			btnSave.Enabled =false;
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
				if (MessageBox.Show("Are u sure to update this Customer?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					cm = new SqlCommand("UPDATE tbCustomer SET cname = @cname,cphone = @cphone WHERE cid LIKE '" + lblCId.Text + "' ", con);
					//cm = new SqlCommand("UPDATE tbUser SET fullname = @fullname, password=@password, phone=@phone WHERE username LIKE '" + txtUserName.Text + "' ", con);
					cm.Parameters.AddWithValue("@cname", txtCName.Text);
					cm.Parameters.AddWithValue("@cphone", txtCPhone.Text);
					con.Open();
					cm.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Customer has been successfully updated!");
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
