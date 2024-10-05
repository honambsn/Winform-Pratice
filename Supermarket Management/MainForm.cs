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
	public partial class MainForm : Form
	{
		SqlConnection con = new SqlConnection();
		SqlCommand cmd = new SqlCommand();
		DBConnect dbcon = new DBConnect();

		public MainForm()
		{
			InitializeComponent();
			drawCenter();
			customizeDesign();
			con = new SqlConnection(dbcon.myConnection());
			con.Open();
			MessageBox.Show("Connection Established");
		}

		#region panelSlide
		private void drawCenter()
		{
			int xPos = (this.panelLogo.Width - this.pictureBox1.Width) / 2;
			int yPos = this.pictureBox1.Location.Y;

			this.pictureBox1.Location = new Point(xPos, yPos);

			xPos = (this.panelLogo.Width - this.lbl_Role.Width) / 2;
			yPos = this.lbl_Role.Location.Y;

			this.lbl_Role.Location = new Point(xPos, yPos);


			xPos = (this.panelLogo.Width - this.lbl_Username.Width) / 2;
			yPos = this.lbl_Username.Location.Y;

			this.lbl_Username.Location = new Point(xPos, yPos);


			xPos = (this.panelTitle.Width - this.lbl_Title.Width) / 2;
			yPos = (this.panelTitle.Height - this.lbl_Title.Height) / 2;

			this.lbl_Title.Location = new Point(xPos, yPos);
		}

		private void customizeDesign()
		{
			this.panelSubProduct.Visible = false;
			this.panelSubStock.Visible = false;
			this.panelSubSetting.Visible = false;
			this.panelSubRecord.Visible = false;
		}

		private void hideSubMenu()
		{
			if (this.panelSubProduct.Visible == true)
				this.panelSubProduct.Visible = false;
			
			if(this.panelSubRecord.Visible == true)
				this.panelSubRecord.Visible = false;

			if (this.panelSubSetting.Visible == true)
				this.panelSubSetting.Visible = false;

			if(this.panelSubRecord.Visible == true)
				this.panelSubRecord.Visible = false;

		}

		private void showSubMenu(Panel subMenu)
		{
			if (subMenu.Visible == false)
			{
				hideSubMenu();
				subMenu.Visible = true;
			}
			else
				subMenu.Visible = false;
		}



		#endregion panelSlide

		private Form activeForm = null;
		public void openChildForm(Form childForm)
		{
			if(activeForm != null)
			{
				activeForm.Close();
			}

			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			lbl_Title.Text = childForm.Text;
			panelMain.Controls.Add(childForm);

			panelMain.Tag = childForm;
			childForm.Show();
		}

		private void btn_Product_Click(object sender, EventArgs e)
		{
			showSubMenu(panelSubProduct);
		}

		private void Product_List_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void Product_Category_Click(object sender, EventArgs e)
		{
			openChildForm(new Category());
			hideSubMenu();
		}

		private void Product_Brand_Click(object sender, EventArgs e)
		{
			openChildForm(new Brand());
			hideSubMenu();
		}

		private void btn_Stock_Click(object sender, EventArgs e)
		{
			showSubMenu(panelSubStock);
		}

		private void Stock_Entry_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void Stock_Adjusment_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void btn_Record_Click(object sender, EventArgs e)
		{
			showSubMenu(panelSubRecord);
		}

		private void Record_Sale_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void Record_POS_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void btn_Setting_Click(object sender, EventArgs e)
		{
			showSubMenu(panelSubSetting);
		}

		private void Setting_User_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void Setting_Store_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void btn_Supplier_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void btn_Dashboard_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void btn_Logout_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}
	}
}
