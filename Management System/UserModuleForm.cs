﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Management_System
{
	public partial class UserModuleForm : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Management System\dbIMS.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
		SqlCommand cm = new SqlCommand();
		public UserModuleForm()
		{
			InitializeComponent();
		}

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtPass.Text != txtRepass.Text)
				{
					MessageBox.Show("Password incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				if (MessageBox.Show("Are u sure to save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					cm = new SqlCommand("INSERT INTO tbUser(username,fullname,password,phone)VALUES(@username,@fullname,@password,@phone)", con);
					cm.Parameters.AddWithValue("@username", txtUserName.Text);
					cm.Parameters.AddWithValue("@fullname", txtFullName.Text);
					cm.Parameters.AddWithValue("@password", txtPass.Text);
					cm.Parameters.AddWithValue("@phone", txtPhone.Text);
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

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
			btnSave.Enabled = true;
			btnUpdate.Enabled = false;
		}

		public void Clear()
		{
			txtUserName.Clear();
			txtFullName.Clear();
			txtPass.Clear();
			txtRepass.Clear();
			txtPhone.Clear();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{

			try
			{
				if (txtPass.Text != txtRepass.Text)
				{
					MessageBox.Show("Password incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				if (MessageBox.Show("Are u sure to update this user?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					cm = new SqlCommand("UPDATE tbUser SET fullname = @fullname,password = @password,phone = @phone WHERE username LIKE '"+ txtUserName.Text+"' ", con);
					//cm = new SqlCommand("UPDATE tbUser SET fullname = @fullname, password=@password, phone=@phone WHERE username LIKE '" + txtUserName.Text + "' ", con);
					cm.Parameters.AddWithValue("@fullname", txtFullName.Text);
					cm.Parameters.AddWithValue("@password", txtPass.Text);
					cm.Parameters.AddWithValue("@phone", txtPhone.Text);
					con.Open();
					cm.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("User has been successfully updated!");
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
