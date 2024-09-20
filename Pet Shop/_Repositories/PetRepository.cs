using Pet_Shop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
			try 
			{
				using (var connection = new SqlConnection(ConnectionString))
				{
					connection.Open();
					using (var command = new SqlCommand("INSERT INTO Pet (Pet_Name, Pet_Type, Pet_Colour) VALUES (@name, @type, @colour)", connection))
					{
						command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = petModel.Name;
						command.Parameters.AddWithValue("@type", SqlDbType.NVarChar).Value = petModel.Type;
						command.Parameters.AddWithValue("@colour", SqlDbType.NVarChar).Value = petModel.Colour;

						command.ExecuteNonQuery();
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
			}
		}

		public void Delete(int id)
		{
			try
			{
				using (var connection = new SqlConnection(ConnectionString))
				{
					connection.Open();
					using (var command = new SqlCommand("DELETE FROM Pet WHERE Pet_Id = @id", connection))
					{
						command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
						command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
			}
		}

		public void Edit(PetModel petModel)
		{
			try
			{
				using (var connection = new SqlConnection(ConnectionString))
				{
					connection.Open();
					using (var command = new SqlCommand("UPDATE Pet SET Pet_Name = @name, Pet_Type = @type, Pet_Colour = @colour WHERE Pet_Id = @id", connection))
					{
						command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = petModel.Name;
						command.Parameters.AddWithValue("@type", SqlDbType.NVarChar).Value = petModel.Type;
						command.Parameters.AddWithValue("@colour", SqlDbType.NVarChar).Value = petModel.Colour;
						command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = petModel.Id;

						command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
			}
		}

		public IEnumerable<PetModel> GetAll()
		{
			var petList = new List<PetModel>();
			using (var connection = new SqlConnection(ConnectionString))
			{
				connection.Open();
				using (var command = new SqlCommand("SELECT * FROM Pet order by Pet_Id asc", connection))
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
			var petList = new List<PetModel>();

			// Ensure the type is not null or empty
			string petType = type;

			using (var connection = new SqlConnection(ConnectionString))
			using (var command = new SqlCommand())
			{
				connection.Open();

				command.Connection = connection;
				// Update the SQL query to only search by Pet_Type
				command.CommandText = "SELECT * FROM Pet WHERE Pet_Type LIKE @petType + '%' ORDER BY Pet_Id ASC";

				// Add the parameter for the type search
				command.Parameters.AddWithValue("@petType", SqlDbType.NVarChar).Value = petType;

				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var petModel = new PetModel
						{
							Id = (int)reader["Pet_Id"],
							Name = reader["Pet_Name"].ToString(),
							Type = reader["Pet_Type"].ToString(),
							Colour = reader["Pet_Colour"].ToString()
						};

						petList.Add(petModel);
					}
				}
			}

			return petList;
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
				command.CommandText = "SELECT * FROM Pet where Pet_Id=@id or Pet_Name like @name+'%' or Pet_Type LIKE @value + '%' or Pet_Colour like @value+'%' order by Pet_Id asc";

				command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = petId;
				command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = petName;
				command.Parameters.AddWithValue("@value", SqlDbType.NVarChar).Value = value;
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
