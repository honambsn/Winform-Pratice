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
	public partial class CashierCustomer : UserControl
	{
		public CashierCustomer()
		{
			InitializeComponent();
			displayCustomer();
		}

		public void refreshData()
		{
			if (InvokeRequired)
			{
				Invoke((MethodInvoker)refreshData);
				return;
			}

			displayCustomer();
		}

		public void displayCustomer()
		{
			CustomerData cData = new CustomerData();

			List<CustomerData> listData = cData.allCustomer();

			dataGridView1.DataSource = listData;

		}
	}
}
