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
	public partial class Login : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;

		public string _pass = "";
		public bool _isactive;
		public Login()
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			txtName.Focus();
		}

		private void picClose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to close this form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				//this.Dispose();
				Application.Exit();
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string _username = "", _name = "", _role = "";
			try
			{
				bool found;

				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}

				cn.Open();

				//using("select * from Users where username = @username and password = @password", cn)
				using (SqlCommand cm = new SqlCommand("select * from Users where username = @username and password = @password", cn))
				{
					cm.Parameters.AddWithValue("@username", txtName.Text);
					cm.Parameters.AddWithValue("@password", txtPass.Text);
					
					dr = cm.ExecuteReader();
					dr.Read();
					if (dr.HasRows)
					{
						found = true;
						_username = dr["username"].ToString();
						_name = dr["name"].ToString();
						_role = dr["role"].ToString();
						_pass = dr["password"].ToString();
						_isactive = bool.Parse(dr["isactive"].ToString());
					}
					else
					{
						found = false;
					}
					dr.Close();

					if (found)
					{
						if (!_isactive)
						{
							MessageBox.Show("Your account is inactive. Please contact the administrator.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;
						}
						if (_role == "Cashier")
						{
							MessageBox.Show("Welcome " + _name + "!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
							txtName.Clear();
							txtPass.Clear();
							this.Hide();
							Cashier cashier = new Cashier();
							cashier.lblUsername.Text = _username;
							cashier.lblName.Text = _name + " | " + _role;
							cashier.ShowDialog();
						}
						else
						{
							MessageBox.Show("Your account is inactive. Please contact the administrator.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							txtName.Clear() ;
							txtPass.Clear();
							this.Hide();
							MainForm main = new MainForm();
							main.lbl_Username.Text = _username;
							main.lblName.Text = _name;
							main.ShowDialog();

						}
					}
					else
					{
						MessageBox.Show("Invalid username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to close this form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				//this.Dispose();
				Application.Exit();
			}
		}

		private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				btnLogin.PerformClick();
			}
		}
	}
}
