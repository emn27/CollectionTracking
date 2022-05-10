using CollectionTracking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace CollectionTracking.Core.DataAccess.AdoNet
{
    public class AnEntityRepositoryBase<TEntity> : AbstractRepository, IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        protected string TableName { get; }
        public string _query = string.Empty;
        public AnEntityRepositoryBase()
        {
            _connection = new SqlConnection();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, string columnName = null)
        {
            ConnectionControl();
            if (string.IsNullOrEmpty(columnName))
            {
                columnName = "*";
                _query = $"Select {columnName} From {TableName} where {filter}";
            }
            _query = $"Select {columnName} From {TableName} where {filter}";
            SqlCommand command = new SqlCommand(_query, _connection);
            SqlDataReader reader = command.ExecuteReader();
            TEntity entity = null;
            while (reader.Read())
            {
                entity = new TEntity()
                {
                    Id = Convert.ToInt32(reader["Id"])
                };
            }
            reader.Close();
            _connection.Close();
            return entity;
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null, string columnName = null)
        {
            ConnectionControl();
            if (string.IsNullOrEmpty(columnName))
            {
                columnName = "*";
            }

            if (columnName != "*")
            {
                if (filter != null)
                {
                    _query = $"Select {columnName} From {TableName} where {filter}";
                }
                _query = $"Select {columnName} From {TableName}";
            }
            else
            {
                if (filter != null)
                {
                    _query = $"Select {columnName}, From {TableName} where {filter}";
                }
                _query = $"Select {columnName}, From {TableName}";
            }

            SqlCommand command = new SqlCommand(_query, _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<TEntity> entities = new List<TEntity>();

            while (reader.Read())
            {
                TEntity entity = new TEntity()
                {
                    Id = Convert.ToInt32(reader["Id"])
                };
                entities.Add(entity);
            }
            reader.Close();
            _connection.Close();
            return entities;
        }

        public TEntity Add(TEntity entity)
        {
            ConnectionControl();
            List<TEntity> entities = new List<TEntity>();
            foreach (var item in entities)
            {
                entities.Add(entity);
                if (entities.Count == -1)
                {
                    _query = $"Insert Into {TableName} Values(@{item},)";
                }
                _query = $"Insert Into {TableName} Values(@{item},)";
            }
            SqlCommand command = new SqlCommand(_query, _connection);
            foreach (var item in entities)
            {
                command.Parameters.AddWithValue($"@{item}", item);
            }
            command.ExecuteNonQuery();
            _connection.Close();
            return entity;
        }

        public void Delete(int id, Expression<Func<TEntity, bool>> filter)
        {
            ConnectionControl();
            _query = $"Delete From {TableName} Where {filter}";
            SqlCommand command = new SqlCommand(_query, _connection);
            command.Parameters.AddWithValue($"@Id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public TEntity Update(TEntity entity, Expression<Func<TEntity, bool>> filter = null)
        {
            ConnectionControl();
            List<TEntity> entities = new List<TEntity>();
            foreach (var item in entities)
            {
                entities.Add(entity);
                if (entities.Count == -1)
                {
                    if (filter == null)
                    {
                        _query = $"Update {TableName} Set @{item} = {item}";
                    }
                    _query = $"Update {TableName} Set @{item} = {item} Where {filter}";
                }
                else
                {
                    if (filter == null)
                    {
                        _query = $"Update {TableName} Set @{item} = {item},";
                    }
                    _query = $"Update {TableName} Set @{item} = {item}, Where {filter}";
                }
            }
            SqlCommand command = new SqlCommand(_query, _connection);
            foreach (var item in entities)
            {
                command.Parameters.AddWithValue($"@{item}", item);
            }
            command.ExecuteNonQuery();
            _connection.Close();
            return entity;
        }

        public void Delete(TEntity entity, Expression<Func<TEntity, bool>> filter = null) => throw new NotImplementedException();
    }
}
