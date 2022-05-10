using CollectionTracking.Core.Configuration;
using CollectionTracking.Core.DataAccess.AdoNet;
using CollectionTracking.DataAccess.Abstract;
using CollectionTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CollectionTracking.DataAccess.Concrete.AdoNet
{
    public class AnFilmDal : AnEntityRepositoryBase<Film>
    {
        //    private SqlConnection _connection;
        //    private string _connectionString = CoreConfig.CollectionTracking;

        //    public AnFilmDal()
        //    {
        //        _connection = new SqlConnection(_connectionString);
        //    }

        //    private void ConnectionControl()
        //    {
        //        if (_connection.State == ConnectionState.Closed)
        //        {
        //            _connection.Open();
        //        }
        //    }

        //    public List<Film> GetAll(string columnName)
        //    {
        //        //ConnectionControl();
        //        //string commandText = "Select * From Film";
        //        //SqlCommand command = new SqlCommand(commandText, _connection);
        //        //SqlDataReader dataReader = command.ExecuteReader();
        //        //List<Film> films = new List<Film>();
        //        //while (dataReader.Read())
        //        //{
        //        //    Film film = new Film
        //        //    {
        //        //        Id = Convert.ToInt32(dataReader["Id"]),
        //        //        Name = dataReader["Name"].ToString(),
        //        //        Type = dataReader["Type"].ToString(),
        //        //        PublishDate = DateTime.Parse(dataReader["PublishDate"].ToString())
        //        //    };
        //        //    films.Add(film);
        //        //}

        //        //dataReader.Close();
        //        //_connection.Close();
        //        //return films;
        //    }

        //    public void Add(Film film)
        //    {
        //        ConnectionControl();
        //        SqlCommand command = new SqlCommand("Insert into Film values(@name,@type,@publishDate)", _connection);
        //        command.Parameters.AddWithValue("@name", film.Name);
        //        command.Parameters.AddWithValue("@type", film.Type);
        //        command.Parameters.AddWithValue("@publishDate", film.PublishDate);
        //        command.ExecuteNonQuery();
        //        _connection.Close();
        //    }

        //    public void Update(Film film)
        //    {
        //        ConnectionControl();
        //        SqlCommand command = new SqlCommand("Update Film set Name=@name,Type=@type,PublishDate=@publishDate where Id=@id", _connection);
        //        command.Parameters.AddWithValue("@name", film.Name);
        //        command.Parameters.AddWithValue("@type", film.Type);
        //        command.Parameters.AddWithValue("@publishDate", film.PublishDate);
        //        command.Parameters.AddWithValue("@id", film.Id);
        //        command.ExecuteNonQuery();
        //        _connection.Close();
        //    }

        //    public void Delete(int id)
        //    {
        //        ConnectionControl();
        //        SqlCommand command = new SqlCommand("Delete from Film where Id=@id", _connection);
        //        command.Parameters.AddWithValue("@id", id);
        //        command.ExecuteNonQuery();
        //        _connection.Close();
        //    }
        //}
    }
}