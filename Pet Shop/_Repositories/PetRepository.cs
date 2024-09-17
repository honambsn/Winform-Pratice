using Pet_Shop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop._Repositories
{
	public class PetRepository : BaseRepository, IPetRepository
	{
		public PetRepository(string connectionString)
		{
			this.ConnectionString = connectionString;
		}
		public void Add(PetModel petModel)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public void Edit(PetModel petModel)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<PetModel> GetAll()
		{
			var petList = new List<PetModel>();
			using (var connection = new SqlConnection(ConnectionString))
			{
				connection.Open();
				using (var command = new SqlCommand("SELECT * FROM Pet order by Pet_Id desc", connection))
				{
					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							//var pet = new PetModel()
							//{
							//	Id = (int)reader["Id"],
							//	Name = reader["Name"].ToString(),
							//	Type = reader["Type"].ToString(),
							//	//Value = (decimal)reader["Value"]
							//};
							//petList.Add(pet);

							var petModel = new PetModel();
							petModel.Id = (int)reader["Pet_Id"];
							petModel.Name = reader["Pet_Name"].ToString();
							petModel.Type = reader["Pet_Type"].ToString();
							petModel.Colour = reader["Pet_Colour"].ToString();

							petList.Add(petModel);
						}
					}
				}
			}	
			return petList;
		}

		public IEnumerable<PetModel> GetByType(string type)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<PetModel> GetByValue(string value)
		{
			var petList = new List<PetModel>();

			int petId = int.TryParse(value, out _)? Convert.ToInt32(value) : 0;
			string petName = value;

			using (var connection = new SqlConnection(ConnectionString))
			using (var command = new SqlCommand())
			{

				connection.Open();

				command.Connection = connection;
				command.CommandText = "SELECT * FROM Pet where Pet_Id=@id or Pet_Name like @name+'%' order by Pet_Id desc";

				command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = petId;
				command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = petName;
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var petModel = new PetModel();
						petModel.Id = (int)reader["Pet_Id"];
						petModel.Name = reader["Pet_Name"].ToString();
						petModel.Type = reader["Pet_Type"].ToString();
						petModel.Colour = reader["Pet_Colour"].ToString();

						petList.Add(petModel);
					}
				}

			}
			return petList;
		}
	}
}
