using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpensesTrackingSystem
{
	public partial class DashboardForm : UserControl
	{
		public DashboardForm()
		{
			InitializeComponent();
			CenterPanelInForm();
		}

		private void CenterPanelInForm()
		{
			// Ensure both the Panel and Form are initialized
			if (panel1 == null || this == null)
				return;

			// Calculate the X and Y coordinates to center the Panel
			int centerX = (this.ClientSize.Width - panel1.Width) / 2;
			//int centerY = (this.ClientSize.Height - panel1.Height) / 2;

			// Set the Location property of the Panel
			panel1.Location = new Point(centerX, 15);
		}

	}
}
