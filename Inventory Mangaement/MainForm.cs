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

namespace Inventory_Mangaement
{
	public partial class MainForm : Form
	{

		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");

		public MainForm()
		{
			InitializeComponent();
			//LoadUserData();
		}

		//private void LoadUserData()
		//{
		//	try
		//	{
		//		con.Open();
		//		string query = "SELECT username FROM users WHERE username = @username";

		//		using (SqlCommand cmd = new SqlCommand(query, con))
		//		{
		//			SqlDataReader reader = cmd.ExecuteReader();
		//			if (reader.Read())
		//			{
		//				// Gán giá trị cho TextBox
		//				lbl_username.Text = reader["username"].ToString();
		//			}
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//	}
		//	finally
		//	{
		//		con.Close();
		//	}
		//}

		private void close_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to close?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				//Form1 loginForm = new Form1();
				//loginForm.Show();
				
				//this.Hide();

				Application.Exit();
			}

		}

		private void logout_btn_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				//Form1 loginForm = new Form1();
				//loginForm.Show();

				//this.Hide();

				Form1 loginForm = new Form1();
				loginForm.Show();

				this.Hide();
			}
			
		}
	}
}
