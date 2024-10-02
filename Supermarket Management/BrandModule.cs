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
	public partial class BrandModule : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();

		//SqlConnection con = new SqlConnection(@"");
		public BrandModule()
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			drawCenter();
		}

		private void drawCenter()
		{
			int xPos = this.label1.Location.X;
			int yPos = (this.panel1.Height - this.label1.Height) / 2;

			this.label1.Location = new Point(xPos, yPos);
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			
			if (MessageBox.Show("Are you sure you want to close this form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Close();
			}


		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if(MessageBox.Show("Are u sure u want to save this test?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					cn.Open();
					cm = new SqlCommand("INSERT INTO Brand (BrandName) VALUES(@BrandName)", cn);
					cm.Parameters.AddWithValue("@BrandName", txtBrand.Text.Trim()); // Use the correct parameter name
					cm.ExecuteNonQuery();
					MessageBox.Show("Record has been saved successfully", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{

				Clear();
				cn.Close();
			}
		}
		
		public void Clear()
		{
			txtBrand.Clear();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			try
			{
				if(MessageBox.Show("Are you sure you want to cancel this brand?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Clear();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{

			}
		}
	}
}
