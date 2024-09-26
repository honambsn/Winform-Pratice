using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			drawCenter();
			customizeDesign();

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
			this.panel_SubRecord.Visible = false;
			this.panelSubStock.Visible = false;
			this.panel_SubSettings.Visible = false;
		}

		private void hideSubMenu()
		{
			if (this.panelSubProduct.Visible == true)
				this.panelSubProduct.Visible = false;
			
			if(this.panelSubStock.Visible == true)
				this.panelSubStock.Visible = false;

			if (this.panel_SubRecord.Visible == true)
				this.panel_SubRecord.Visible = false;

			if(this.panel_SubSettings.Visible == true)
				this.panel_SubSettings.Visible = false;
	
			
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

		private void btn_Dashboard_Click(object sender, EventArgs e)
		{

		}

		private void btn_Product_Click(object sender, EventArgs e)
		{
			showSubMenu(panelSubProduct);
		}

		private void Productbtn_ProductList_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void Productbtn_Category_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void Productbtn_Brand_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void btn_Stock_Click(object sender, EventArgs e)
		{
			showSubMenu(panelSubStock);
		}

		private void Stockbtn_StockEntry_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void Stockbtn_StockAdjustment_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void btn_Supplier_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void btn_Record_Click(object sender, EventArgs e)
		{
			showSubMenu(panel_SubRecord);
		}

		private void Recordbtn_Sale_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void Recordbtn_POS_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void btn_Settings_Click(object sender, EventArgs e)
		{
			showSubMenu(panel_SubSettings);
		}

		private void Settingbtn_User_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void Settingbtn_Store_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void btn_Logout_Click(object sender, EventArgs e)
		{

		}
	}
}
