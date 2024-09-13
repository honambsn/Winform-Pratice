using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop.Models
{
	public interface IPetRepository
	{
		void Add(PetModel petModel);
		void Edit(PetModel petModel);	
		void Delete(int id);

		IEnumerable<PetModel> GetAll();
		IEnumerable<PetModel> GetByType(string type);
		IEnumerable<PetModel> GetByValue(string type);
	}
}
