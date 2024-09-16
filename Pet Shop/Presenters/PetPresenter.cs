using Pet_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Shop.Views;
using System.Windows.Forms;

namespace Pet_Shop.Presenters
{
	public class PetPresenter
	{
		private IPetView view;
		private IPetRepository repository;
		private BindingSource petsBindingSource;
		private IEnumerable<PetModel> petList;


		public PetPresenter(IPetView view, IPetRepository repository)
		{
			this.view = view;
			this.repository = repository;
			this.petsBindingSource = new BindingSource();

			//subscribe event handler methods to view events
			this.view.SearchEvent += SearchEvent;
			this.view.AddNewEvent += AddNewEvent;
			this.view.EditEvent += EditEvent;
			this.view.DelelteEvent += DeleteEvent;
			this.view.SaveEvent += SaveEvent;
			this.view.CancelEvent += CancelEvent;

			//set pets binding source
			this.view.SetPetListBingdingSource(petsBindingSource);

			//load pets list
			LoadAllPetList();

			//show view
			this.view.Show();
		}

		private void LoadAllPetList()
		{
			petList = repository.GetAll();
			petsBindingSource.DataSource = petList;	
		}

		private void CancelEvent(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void SaveEvent(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void DeleteEvent(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void EditEvent(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void AddNewEvent(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void SearchEvent(object sender, EventArgs e)
		{
			bool emptyValue = string.IsNullOrWhiteSpace(view.SearchValue);	
			if (emptyValue == false)
			{
				petList = repository.GetByValue(this.view.SearchValue);
			}
			else
			{
				petList = repository.GetAll();
				//petsBindingSource.DataSource = petList.Where(p => p.PetName.Contains(view.SearchValue));
			}

			petsBindingSource.DataSource = petList;
		}
	}

}
