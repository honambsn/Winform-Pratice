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
	public partial class OrderForm : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Management System\dbIMS.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
		SqlCommand cm = new SqlCommand();
		SqlDataReader dr;
		public OrderForm()
		{
			InitializeComponent();
			LoadOrder();
		}
		public void LoadOrder()
		{
			//int i = 0;
			//dgvProduct.Rows.Clear();
			//cm = new SqlCommand("SELECT * FROM tbOrder", con);
			//con.Open();
			//dr = cm.ExecuteReader();
			//while (dr.Read())
			//{
			//	i++;
			//	//dgvOrder.Rows.Add(i, dr[0].ToString(),Convert.ToDateTime(dr[1].ToString()).ToString("dd/MM/yyyy"), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
			//	dgvProduct.Rows.Add(i, dr[0].ToString(), Convert.ToDateTime(dr[1].ToString()).ToString("dd/MM/yyyy"), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
			//}
			//dr.Close();
			//con.Close();
			int i = 0;
			dgvOrder.Rows.Clear();
			cm = new SqlCommand("SELECT * from tbOrder", con);
			con.Open();
			dr = cm.ExecuteReader();
			while (dr.Read())
			{
				i++;
				dgvOrder.Rows.Add(i, dr[0].ToString(), Convert.ToDateTime(dr[1].ToString()).ToString("dd/MM/yyyy"), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
			}
			dr.Close();
			con.Close();

		}
		private void productButton1_Click(object sender, EventArgs e)
		{
			OrderModuleForm moduleForm = new OrderModuleForm();
			moduleForm.btnInsert.Enabled = true; 
			moduleForm.btnUpdate.Enabled = false;
			moduleForm.ShowDialog();
		}
	}
}
