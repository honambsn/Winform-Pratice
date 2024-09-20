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
			cleanViewFields();
		}

		private void SaveEvent(object sender, EventArgs e)
		{
			var model = new PetModel
			{
				Id = view.PetId,
				Name = view.PetName,
				Type = view.PetType,
				Colour = view.PetColour
			};

			try
			{
				new Common.ModelDataValidation().Validate(model);
				if (view.IsEdit)
				{
					repository.Edit(model);
					view.Message = "Pet edited successfully";
				}
				else
				{
					repository.Add(model);
					view.Message = "Pet added successfully";
				}

			}
			catch(Exception ex)
			{
				view.Message = ex.Message;
				view.IsSuccessful = false;
			}
			finally
			{
				view.IsSuccessful = true;
				LoadAllPetList();
				cleanViewFields();
			}
		}

		private void cleanViewFields()
		{
			view.PetId = 0;
			view.PetName = "";
			view.PetType = "";
			view.PetColour = "";
		}

		private void DeleteEvent(object sender, EventArgs e)
		{
			try
			{
				var pet = (PetModel)petsBindingSource.Current;
				repository.Delete(pet.Id);
				view.IsSuccessful = true;
				view.Message = "Pet deleted successfully";

			}
			catch(Exception ex)
			{
				view.Message = ex.Message;
				view.IsSuccessful = false;
			}
			finally
			{
				view.IsSuccessful = true;
				LoadAllPetList();
				cleanViewFields();
			}
		}

		private void EditEvent(object sender, EventArgs e)
		{
			var pet = (PetModel)petsBindingSource.Current;
			view.PetId = Convert.ToInt32(pet.Id.ToString());
			view.PetName = pet.Name;
			view.PetType = pet.Type;
			view.PetColour = pet.Colour;
			view.IsEdit = true;
		}

		private void AddNewEvent(object sender, EventArgs e)
		{
			view.IsEdit = false;
		}

		private void SearchEvent(object sender, EventArgs e)
		{
			bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);	
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
