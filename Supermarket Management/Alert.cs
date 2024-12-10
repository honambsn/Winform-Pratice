using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Supermarket_Management
{
	public partial class Alert : Form
	{
		private Random random;
		private int tempIndex;
		MainForm main;
		public Alert(MainForm mn)
		{
			InitializeComponent();
			random = new Random();
			Color color = SlelectThemeColor();
			panel1.BackColor = color;
			main = mn;
		}

		public enum enmAction
		{
			wait,
			start,
			close
		}

		private Alert.enmAction action;
		private int x, y;

		private void timer1_Tick(object sender, EventArgs e)
		{
			switch (this.action)
			{
				case enmAction.wait:
					timer1.Interval = 15000;
					action = enmAction.close;
					break;
				case Alert.enmAction.start:
					this.timer1.Interval = 1;
					this.Opacity += 0.1;
					if (this.x < this.Location.X)
						this.Left--;
					else
					{
						if (this.Opacity == 1.0)
						{
							action = Alert.enmAction.wait;
						}
					}
					break;
				case Alert.enmAction.close:
					timer1.Interval = 1;
					this.Opacity -= 0.1;
					this.Left -= 3;
					if (base.Opacity == 0.0)
						base.Close();
					break;
			}
		}

		public void showAlert(string msg)
		{
			this.Opacity = 0.0;
			this.StartPosition = FormStartPosition.Manual;
			string fname;
			for (int i = 1; i < 10; i++)
			{
				fname = "alert" + i.ToString();
				Alert frm = (Alert)Application.OpenForms[fname];
				if (frm == null)
				{
					this.Name = fname;
					this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
					this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
					this.Location = new Point(this.x, this.y);
					break;
				}
			}
			this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
			this.lblMsg.Text = msg;

			this.Show();
			this.action = Alert.enmAction.start;
			this.timer1.Interval = 1;
			this.timer1.Start();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			timer1.Interval = 1;
			action = Alert.enmAction.close;
		}

		private void btnReOrder_Click(object sender, EventArgs e)
		{
			StockIn stock = new StockIn();
			main.openChildForm(stock);
			ProductStockIn stockIn = new ProductStockIn(stock);
			stock.ProductForSupplier(lblPCode.Text);
			stockIn.addStockIn(lblPCode.Text);

		}

		private Color SlelectThemeColor()
		{
			int index = random.Next(ThemeColor.ColorList.Count);
			while (tempIndex == index)
			{
				index = random.Next(ThemeColor.ColorList.Count);
			}
			tempIndex = index;
			string color = ThemeColor.ColorList[index];
			return ColorTranslator.FromHtml(color);
		}
	}
}
