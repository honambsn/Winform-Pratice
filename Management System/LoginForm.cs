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
	public partial class LoginForm : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Management System\dbIMS.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
		SqlCommand cm = new SqlCommand();
		SqlDataReader dr;
		public LoginForm()
		{
			InitializeComponent();
		}

		private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
		{
			if(checkBoxPass.Checked== false)
			{
				txtPass.UseSystemPasswordChar = true;

			}
			else
			{
				txtPass.UseSystemPasswordChar = false;
			}
		}

		private void lblClear_Click(object sender, EventArgs e)
		{
			txtPass.Clear();
			txtName.Clear();
		}

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Exit application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			try
			{
				cm = new SqlCommand("SELECT * FROM tbUser WHERE username=@username and password =@password", con);
				cm.Parameters.AddWithValue("@username", txtName.Text);
				cm.Parameters.AddWithValue("@password", txtPass.Text);
				con.Open();
				dr = cm.ExecuteReader();
				dr.Read();
				if (dr.HasRows)
				{
					MessageBox.Show("Welcome " + dr["fullname"].ToString() + " | ", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
					MainForm main = new MainForm();
					this.Hide();
					main.ShowDialog();
				}
				else
				{
					MessageBox.Show("Invalid username or password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				con.Close();
			} catch (Exception ex) 
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
