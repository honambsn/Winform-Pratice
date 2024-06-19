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
			moduleForm.ShowDialog();
			LoadOrder();
		}

		private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string colName = dgvOrder.Columns[e.ColumnIndex].Name;
			//if (colName == "Edit")
			//{
			//	OrderModuleForm formModule = new OrderModuleForm();
			//	formModule.lblOid.Text = dgvOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
			//	formModule.dtOrder.Text = dgvOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
			//	formModule.txtPId.Text = dgvOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
			//	formModule.textCid.Text = dgvOrder.Rows[e.RowIndex].Cells[4].Value.ToString();
			//	formModule.UDQty.Value = Convert.ToInt32( dgvOrder.Rows[e.RowIndex].Cells[5].Value.ToString());
			//	formModule.txtPrice.Text = dgvOrder.Rows[e.RowIndex].Cells[6].Value.ToString();


			//	//formModule.txtPass.Text = dgvOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
			//	//formModule.txtPhone.Text = dgvOrder.Rows[e.RowIndex].Cells[4].Value.ToString();


			//	formModule.btnInsert.Enabled = false;
			//	formModule.btnUpdate.Enabled = true;
			//	formModule.ShowDialog();
			//}
			if (colName == "Delete")
			{
				if (MessageBox.Show("Are u sure to delete this order?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					con.Open();
					cm = new SqlCommand("DELETE FROM tbOrder WHERE orderid LIKE '" + dgvOrder.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
					cm.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Record has been successfully deleted");


					cm = new SqlCommand("UPDATE tbProduct SET pqty = ( pqty + @pqty) WHERE pid LIKE '" + dgvOrder.Rows[e.RowIndex].Cells[3].Value.ToString() + "'", con);
					cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(dgvOrder.Rows[e.RowIndex].Cells[5	].Value.ToString()));

					con.Open() ;
					cm.ExecuteNonQuery() ;
					con.Close();
				}
			}
			LoadOrder();
		}
	}
}
