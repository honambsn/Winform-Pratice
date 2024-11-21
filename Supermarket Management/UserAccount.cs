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
		MainForm main;
		public string username;
		string name;
		string role;
		string accstatus;
		public UserAccount(MainForm mn)
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			main = mn;
			LoadUser();
		}

		public void LoadUser()
		{
			int i = 0;
			dgvUser.Rows.Clear();
			cm = new SqlCommand("select * from Users", cn);

			if (cn.State == ConnectionState.Closed)
				cn.Open();

			dr = cm.ExecuteReader();

			while (dr.Read())
			{
				i++;
				dgvUser.Rows.Add(i, dr[0].ToString(), dr[3].ToString(), dr[4].ToString(), dr[2].ToString());
				//username, fullname, accstatus, role
				//dgvLoad.Rows.Add(i, dr[0].ToString(), dr[2].ToString(), dr[4].ToString(), dr[3].ToString());
			}

			dr.Close();
			cn.Close();
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

		private void btnChangeSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (ConnectionState.Closed == cn.State) cn.Open();
				if (txtChangeCurPass.Text != main._pass)
				{
					MessageBox.Show("Current password is incorrect", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				if (txtChangeNewPass.Text != txtChangeRePass.Text)
				{
					MessageBox.Show("New password does not match", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				using (SqlCommand cm = new SqlCommand("UPDATE Users SET password = @password WHERE username = @username", cn))
				{
					cm.Parameters.AddWithValue("@password", txtChangeNewPass.Text);
					cm.Parameters.AddWithValue("@username", lblUsername.Text);
					cm.ExecuteNonQuery();

					MessageBox.Show("Password has been successfully changed", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void UserAccount_Load(object sender, EventArgs e)
		{
			lblUsername.Text = main.lbl_Username.Text;
		}

		private void btnChangeCancel_Click(object sender, EventArgs e)
		{
			ClearCP();
		}

		public void ClearCP()
		{
			txtChangeCurPass.Clear();
			txtChangeNewPass.Clear();
			txtChangeRePass.Clear();
		}

		private void dgvUser_SelectionChanged(object sender, EventArgs e)
		{
			int i = dgvUser.CurrentRow.Index;
			username = dgvUser[1, i].Value.ToString();
			name = dgvUser[2, i].Value.ToString();
			role = dgvUser[4, i].Value.ToString();
			accstatus = dgvUser[3, i].Value.ToString();

			//dgvUser.Rows.Add(i, dr[0].ToString(), dr[3].ToString(), dr[4].ToString(), dr[2].ToString());
			//no username fullname accstatus role

			if (lblUsername.Text == username)
			{
				btnRemove.Enabled = false;
				btnResetPass.Enabled = false;
				lblAccNote.Text = "To change your password, go to change password Page";
			}
			else
			{
				btnRemove.Enabled = true;
				btnResetPass.Enabled = true;
				lblAccNote.Text = "To change the password for " + username + " - " + name + " please click Reset Password.";
			}
			gbUser.Text = "Password for " + username + " - " + name;
			
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if ((MessageBox.Show("Are you sure you want to remove this user: " +username + " - " + role +"?", "User Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
			{
				try
				{
					if (ConnectionState.Closed == cn.State) cn.Open();
					using (SqlCommand cm = new SqlCommand("DELETE FROM Users WHERE username = @username", cn))
					{
						cm.Parameters.AddWithValue("@username", username);
						cm.ExecuteNonQuery();
					}
					MessageBox.Show("User has been successfully removed", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				finally
				{
					LoadUser();
				}
			}
		}

		private void btnResetPass_Click(object sender, EventArgs e)
		{
			ResetPassword reset = new ResetPassword(this);
			reset.ShowDialog();
		}
	}
}
