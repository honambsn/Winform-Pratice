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
	public partial class Brand : Form
	{
		SqlConnection cn = new SqlConnection();
		SqlCommand cm = new SqlCommand();
		DBConnect dbcon = new DBConnect();
		public Brand()
		{
			InitializeComponent();
			cn = new SqlConnection(dbcon.myConnection());
			drawCenter();
		}

		private void drawCenter()
		{
			//int xPos = (this.panel1.Width - this.label1.Width) / 2;
			int xPos = this.label1.Location.X;
			int yPos = (this.panel1.Height - this.label1.Height) / 2;

			this.label1.Location = new Point(xPos, yPos);

			//xPos = (this.panel1.Width - this.button1.Width) / 2;
			xPos = this.btnAdd.Location.X;
			yPos = (this.panel1.Height - this.btnAdd.Height) / 2;
			this.btnAdd.Location = new Point(xPos, yPos);
		}
	}
}
