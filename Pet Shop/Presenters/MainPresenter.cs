using Pet_Shop._Repositories;
using Pet_Shop.Models;
using Pet_Shop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop.Presenters
{
	public class MainPresenter
	{
		private IMainView mainView;
		private readonly string sqlConnectionString;

		public MainPresenter(IMainView mainView, string sqlConnectionString)
		{
			this.mainView = mainView;
			this.sqlConnectionString = sqlConnectionString;
			this.mainView.ShowPetView += ShowPetsView;
		}

		private void ShowPetsView(object sender, EventArgs e)
		{
			IPetView view = new PetView();
			IPetRepository repository = new PetRepository(sqlConnectionString);
			new PetPresenter(view, repository);
		}
	}
}
