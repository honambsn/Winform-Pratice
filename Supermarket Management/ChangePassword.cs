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
	public partial class ChangePassword : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;
		Cashier cashier;
		public ChangePassword(Cashier cash)
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			cashier = cash;
			btnNext.Visible = true;
			lbUsername.Text = cashier.lblUsername.Text;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			try
			{
				string oldpass = dbcon.getPassword(lbUsername.Text);
				if (oldpass != txtPass.Text)
				{
					MessageBox.Show("Old password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				else
				{
					txtPass.Visible = false;
					btnNext.Visible = false;


					txtNewPass.Visible = true;
					txtConfirmPass.Visible = true;
					btnSave.Visible = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void picClose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to close this form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Dispose();
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
				cn.Open();
				if (txtNewPass.Text != txtConfirmPass.Text)
				{
					MessageBox.Show("New password and confirm password do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				else
				{
					try
					{
						if (MessageBox.Show("Are you sure you want to change your password?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
						{
							using (SqlCommand cmd = new SqlCommand("UPDATE Users SET password = @password WHERE username = @username", cn))
							{
								cmd.Parameters.AddWithValue("@password", txtNewPass.Text);
								cmd.Parameters.AddWithValue("@username", lbUsername.Text);
								cmd.ExecuteNonQuery();
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					finally
					{
						MessageBox.Show("Password has been successfully changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				btnNext.PerformClick();
			}
		}

		private void txtConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				btnSave.PerformClick();
			}
		}
	}
}
