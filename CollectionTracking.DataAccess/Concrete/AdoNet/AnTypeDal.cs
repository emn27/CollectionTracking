using CollectionTracking.Core.DataAccess.AdoNet;
using CollectionTracking.Entities.Concrete;

namespace CollectionTracking.DataAccess.Concrete.AdoNet
{
    public class AnTypeDal : AnEntityRepositoryBase<Type>
    {
        //private SqlConnection _connection;
        //private string _connectionString = CoreConfig.CollectionTracking;

        //public AnTypeDal()
        //{
        //    _connection = new SqlConnection(_connectionString);
        //}

        //private void ConnectionControl()
        //{
        //    if (_connection.State==ConnectionState.Closed)
        //    {
        //        _connection.Open();
        //    }
        //}

        //public void Add(Entities.Concrete.Type type)
        //{
        //    ConnectionControl();
        //    SqlCommand command = new SqlCommand("Insert into Type values(@name,@id)", _connection);
        //    command.Parameters.AddWithValue("@Name", type.Name);
        //    command.ExecuteNonQuery();
        //    _connection.Close();
        //}

        //public void Delete(int id)
        //{
        //    ConnectionControl();
        //    SqlCommand command = new SqlCommand("Delete from type where @Id = id", _connection);
        //    command.Parameters.AddWithValue("@id", id);
        //    command.ExecuteNonQuery();
        //    _connection.Close();
        //}

        //public List<Entities.Concrete.Type> GetAll()
        //{
        //    ConnectionControl();
        //    string commandText = "Select * from Type";
        //    SqlCommand command = new SqlCommand(commandText, _connection);
        //    SqlDataReader reader = command.ExecuteReader();
        //    List<Entities.Concrete.Type> types = new List<Entities.Concrete.Type>();
        //    while (reader.Read())
        //    {
        //        Entities.Concrete.Type type = new Entities.Concrete.Type
        //        {
        //            Id = Convert.ToInt32(reader["Id"]),
        //            Name = reader["Name"].ToString()
        //        };
        //        types.Add(type);
        //    }

        //    reader.Close();
        //    _connection.Close();
        //    return types;
        //}

        //public void Update(Entities.Concrete.Type type)
        //{
        //    ConnectionControl();
        //    SqlCommand command = new SqlCommand("Update type set Name = @name where Id=@id" , _connection);
        //    command.Parameters.AddWithValue("@name", type.Name);
        //    command.Parameters.AddWithValue("@id", type.Id);
        //    command.ExecuteNonQuery();
        //    _connection.Close();
        //}
    }
}
