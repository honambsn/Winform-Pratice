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
	public partial class OrderModuleForm : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Management System\dbIMS.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
		SqlCommand cm = new SqlCommand();
		SqlDataReader dr;
		public OrderModuleForm()
		{
			InitializeComponent();
			LoadCustomer();
			LoadProduct();
		}

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Dispose();
			
		}

		public void LoadCustomer()
		{
			int i = 0;
			dgvCustomer.Rows.Clear();
			cm = new SqlCommand("SELECT cid, cname FROM tbCustomer WHERE CONCAT(cid,cname) LIKE '%"+txtSearchCust.Text+"%' ", con);
			con.Open();
			dr = cm.ExecuteReader();
			while (dr.Read())
			{
				i++;
				dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
			}
			dr.Close();
			con.Close();
		}

		public void LoadProduct()
		{
			int i = 0;
			dgvProduct.Rows.Clear();
			cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT (pid,pname, pprice, pdescription, pcategory) LIKE '%" + txtSearchCust.Text + "%'", con);
			con.Open();
			dr = cm.ExecuteReader();
			while (dr.Read())
			{
				i++;
				dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
			}
			dr.Close();
			con.Close();
		}

		private void txtSearchCust_TextChanged(object sender, EventArgs e)
		{
			LoadCustomer();
		}

		private void txtSearchProd_TextChanged(object sender, EventArgs e)
		{
			LoadProduct();
		}


		int qty = 0;


		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			if (Convert.ToInt16(numericUpDown1.Value) > qty) 
			{
				MessageBox.Show("Instock quatity is not enough!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return;
			}
			int total = Convert.ToInt16(txtPrice.Text) * Convert.ToInt16(numericUpDown1.Value);
			txtTotal.Text = total.ToString();
		}

		private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtCId.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtCName.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
		}

		private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtPId.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtPName.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
			qty = Convert.ToInt16(dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString());
		}
	}
}
