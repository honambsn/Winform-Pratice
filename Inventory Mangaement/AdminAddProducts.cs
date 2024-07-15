using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Mangaement
{
	public partial class AdminAddProducts : UserControl
	{
		public AdminAddProducts()
		{
			InitializeComponent();
			drawCenter();
		}

		private void drawCenter()
		{
			// Form dimensions
			this.Width = 1080;
			this.Height = 675;

			// Panel margins and distance
			int marginLR = 15; // Left and right margin
			int marginTB = 30; // Top and bottom margin
			int panelDistance = 30; // Distance between panels

			// Panel 1 dimensions and location
			int panel1Height = (this.ClientSize.Height - marginTB * 2 - panelDistance) * 2 / 3;
			int panel1Width = this.ClientSize.Width - marginLR * 2;
			Panel panel1 = new Panel
			{
				Width = panel1Width,
				Height = panel1Height,
				Location = new Point(marginLR, marginTB)
			};

			// Panel 2 dimensions and location
			int panel2Height = (this.ClientSize.Height - marginTB * 2 - panelDistance) * 1 / 3;
			int panel2Width = this.ClientSize.Width - marginLR * 2;
			Panel panel2 = new Panel
			{
				Width = panel2Width,
				Height = panel2Height,
				Location = new Point(marginLR, panel1.Location.Y + panel1.Height + panelDistance),
				BackColor = Color.LightGreen // Example background color
			};

			// Add panels to the form
			this.Controls.Add(panel1);
			this.Controls.Add(panel2);

		}




	}

}
