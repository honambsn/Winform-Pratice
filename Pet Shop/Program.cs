using Pet_Shop.Models;
using Pet_Shop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


using Pet_Shop._Repositories;
using Pet_Shop.Presenters;


namespace Pet_Shop
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//string sqlConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\honam\\Documents\\petshop.mdf;Integrated Security=True;Connect Timeout=30";
			string sqlConnectionString = ConfigurationManager.ConnectionStrings["sqlConnectionString"].ConnectionString;
			IPetView view = new PetView();
			IPetRepository repository = new PetRepository(sqlConnectionString);
			new PetPresenter(view, repository);
			//Application.Run(new PetView());
			Application.Run((Form)view);
		}
	}
}
