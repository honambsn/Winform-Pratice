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
	public partial class UserProperties : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;
		UserAccount account;

		public string username;
		public UserProperties(UserAccount user)
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			account = user;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to close this form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Dispose();
			}
		}

		private void btnApply_Click(object sender, EventArgs e)
		{
			try
			{
				if ((MessageBox.Show("Are you sure you want to update user properties?", "Update User Properties", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
				{
					if (cn.State == ConnectionState.Closed)
						cn.Open();

					using (SqlCommand cm = new SqlCommand("update Users set name = @name, role = @role, isactivate = @isactivate where username = @username", cn))
					{
						cm.Parameters.AddWithValue("@name", txtName.Text);
						cm.Parameters.AddWithValue("@role", cbRole.Text);
						cm.Parameters.AddWithValue("@isactivate", cbActivate.Text);
						cm.Parameters.AddWithValue("@username", username);
						cm.ExecuteNonQuery();
						MessageBox.Show("User properties has been updated successfully", "Update User Properties", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				account.LoadUser();
				this.Dispose();
			}
		}
	}
}
