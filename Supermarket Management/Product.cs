﻿using System;
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
	public partial class Product : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		SqlDataReader dr;
		public Product()
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			LoadProduct();
		}


		//Version 1
		//public void LoadProduct()
		//{
		//	int i = 0;
		//	dgvProduct.Rows.Clear();
		//	if (cn.State == ConnectionState.Open)
		//	{
		//		cn.Close();
		//	}
		//	cn.Open();
		//	cm = new SqlCommand("SELECT p.ProductCode, p.Barcode, p.Description, p.BrandID, p.CategoryID, p.Price, p.qty, p.ReOrder " +
		//		   "FROM Product AS p " +
		//		   "INNER JOIN Brand AS b ON b.id = p.BrandID " +
		//		   "INNER JOIN Category AS c ON c.id = p.CategoryID", cn);

		//	dr = cm.ExecuteReader();

		//	while (dr.Read())
		//	{
		//		i++;
		//		dgvProduct.Rows.Add(i, dr["ProductCode"].ToString(), dr["Barcode"].ToString(), dr["Description"].ToString(), dr["BrandID"].ToString(), dr["CategoryID"].ToString(), dr["Price"].ToString(), dr["ReOrder"].ToString());
		//	}
		//	dr.Close();
		//	cn.Close();
		//}

		//Version 2 (better)
		public void LoadProduct()
		{
			dgvProduct.Rows.Clear(); // Xóa các hàng hiện có
			int i = 0; // Khởi tạo chỉ số hàng

			// Đảm bảo kết nối đang mở trước khi thực thi lệnh
			if (cn.State != ConnectionState.Open)
			{
				cn.Open();
			}

			// Định nghĩa lệnh SQL
			using (SqlCommand cm = new SqlCommand("SELECT p.ProductCode, p.Barcode, p.Description, p.BrandID, p.CategoryID, p.Price, p.qty, p.ReOrder " +
												   "FROM Product AS p " +
												   "INNER JOIN Brand AS b ON b.id = p.BrandID " +
												   "INNER JOIN Category AS c ON c.id = p.CategoryID", cn))
			{
				using (SqlDataReader dr = cm.ExecuteReader())
				{
					while (dr.Read())
					{
						i++;
						// Thêm hàng vào DataGridView
						dgvProduct.Rows.Add(i,
											dr["ProductCode"].ToString(),
											dr["Barcode"].ToString(),
											dr["Description"]?.ToString() ?? string.Empty, // Xử lý giá trị null
											dr["BrandID"].ToString(),
											dr["CategoryID"].ToString(),
											dr["Price"].ToString(),
											//											dr["qty"] != DBNull.Value ? dr["qty"].ToString() : "0", // Xử lý giá trị null
											dr["ReOrder"].ToString());
					}
				}
			}

			// Đảm bảo kết nối được đóng
			if (cn.State == ConnectionState.Open)
			{
				cn.Close();
			}
		}


		private void btnAdd_Click(object sender, EventArgs e)
		{
			ProductModule productModule = new ProductModule(this);
			productModule.ShowDialog();
		}

		private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string colname = dgvProduct.Columns[e.ColumnIndex].Name;
			if (colname == "Edit")
			{
				try
				{
					ProductModule product = new ProductModule(this);

					var cells = new (Action<string> setText, int index)[]
					{
					(text => product.txtPCode.Text = text, 1),
					(text => product.txtBarcode.Text = text, 2),
					(text => product.txtPDesc.Text = text, 3),
					(text => product.cbBrand.Text = text, 4),
					(text => product.cbCate.Text = text, 5),
					(text => product.txtPrice.Text = text, 6),
					};

					for (int i = 0; i < cells.Length; i++)
					{
						var cellValue = dgvProduct.Rows[e.RowIndex].Cells[cells[i].index].Value;
						if (cellValue != null)
							cells[i].setText(cellValue.ToString());
					}

					var reorderCellValue = dgvProduct.Rows[e.RowIndex].Cells[7].Value;
					if (reorderCellValue != null && int.TryParse(reorderCellValue.ToString(), out int reorderValue))
					{
						product.UDReOrder.Value = reorderValue;
					}
					else
					{
						product.UDReOrder.Value = 0;
					}

					product.txtPCode.Enabled = false;
					product.btnSave.Enabled = false;
					product.btnUpdate.Enabled = true;
					product.ShowDialog();
					MessageBox.Show("Record has been successfully updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					LoadProduct();
				}
			}
			else if (colname == "Delete")
			{
				if (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
				{
					try
					{
						// Ensure the connection is open
						if (cn.State != ConnectionState.Open)
							cn.Open();

						using (SqlCommand cm = new SqlCommand("DELETE FROM Product WHERE ProductCode = @ProductCode", cn))
						{
							// Use parameterized query to prevent SQL injection
							cm.Parameters.AddWithValue("@ProductCode", dgvProduct[1, e.RowIndex].Value.ToString());

							cm.ExecuteNonQuery();
							MessageBox.Show("Record has been successfully deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally
					{
						LoadProduct();
						if (cn.State == ConnectionState.Open)
							cn.Close();
					}
				}
			}

		}
	}
}
