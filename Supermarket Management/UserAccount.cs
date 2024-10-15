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
	public partial class UserAccount : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;
		public UserAccount()
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
		}

		public void Clear()
		{
			txtCreateUsrname.Clear();
			txtCreatePass.Clear();
			txtCreateRePass.Clear();
			cbCreateRole.Text = "";
			txtCreateFullName.Clear();
		}

		private void btnCreateSave_Click(object sender, EventArgs e)
		{
			try
			{
				if(ConnectionState.Closed == cn.State) cn.Open();

				if(txtCreatePass.Text.Trim() != txtCreateRePass.Text.Trim())
				{
					MessageBox.Show("Password does not match", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				using (SqlCommand cm = new SqlCommand("INSERT INTO Users(username, password, role, name) VALUES (@username, @password, @role, @name)", cn))
				{
					cm.Parameters.AddWithValue("@username", txtCreateUsrname.Text.Trim());
					cm.Parameters.AddWithValue("@password", txtCreatePass.Text.Trim());
					cm.Parameters.AddWithValue("@role", cbCreateRole.Text);
					cm.Parameters.AddWithValue("@name", txtCreateFullName.Text);
					cm.ExecuteNonQuery();	
				}

				MessageBox.Show("User has been successfully created", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				Clear();
			}
		}

		private void btnCreateCancel_Click(object sender, EventArgs e)
		{
			Clear();
		}
	}
}
