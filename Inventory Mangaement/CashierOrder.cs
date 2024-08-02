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
	public partial class CashierOrder : UserControl
	{
		public CashierOrder()
		{
			InitializeComponent();
			displayAllAvailableProducts();
		}

		public void displayAllAvailableProducts()
		{
			AddProductData apData = new AddProductData();
			List<AddProductData> listData = apData.allAvailableProducts();

			dataGridView1.DataSource = listData;
		}
	}
}
