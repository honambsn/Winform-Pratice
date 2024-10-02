using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Management
{
	internal class DBConnect
	{
		private string con;
		public string myConnection()
		{
			con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\honam\Documents\pos.mdf;Integrated Security=True;Connect Timeout=30";
			return con;
		}
	}
}
