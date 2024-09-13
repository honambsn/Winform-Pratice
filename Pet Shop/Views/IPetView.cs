using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Shop.Views
{
	public interface IPetView
	{
		//Properties-fields
		int PetId { get; set; }
		string PetName { get; set; }
		string PetType { get; set; }
		string PetColour { get; set; }

		string SearchValue { get; set; }
		bool IsEdit { get; set; }
		bool IsSuccessfull { get; set; }
		string Message { get; set; }


		//Events
		event EventHandler SearchEvent;
		event EventHandler AddNewEvent;
		event EventHandler EditEvent;
		event EventHandler DelelteEvent;
		event EventHandler SaveEvent;
		event EventHandler CancelEvent;

		//Methods
		void SetPetListBingdingSource(BindingSource petList);
		void Show();

		
	}
}
