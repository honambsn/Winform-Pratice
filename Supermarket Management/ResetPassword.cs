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
	public partial class ResetPassword : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;
		UserAccount user;
		public ResetPassword(UserAccount account)
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			user = account;
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("are you sure you want to reset password of: "+ user.username + "?", "Reset Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (txtNewPass.Text == txtRePass.Text)
				{
					try
					{
						if (cn.State == ConnectionState.Closed)
							cn.Open();


						using (SqlCommand cm = new SqlCommand("update Users set password = @password where username = @username", cn))
						{
							cm.Parameters.AddWithValue("@password", txtNewPass.Text);
							cm.Parameters.AddWithValue("@username", user.username);
							cm.ExecuteNonQuery();

							MessageBox.Show("Password has been reset successfully", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
							this.Dispose();
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
				else
					MessageBox.Show("Password does not match", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
			else
			{
				this.Dispose();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}