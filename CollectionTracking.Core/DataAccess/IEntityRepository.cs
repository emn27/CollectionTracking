using CollectionTracking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CollectionTracking.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null, string columnName = null);
        T Get(Expression<Func<T, bool>> filter, string columnName = null);
        T Add(T entity);
        T Update(T entity, Expression<Func<T, bool>> filter = null);
        void Delete(T entity, Expression<Func<T, bool>> filter = null);
        void Delete(int id, Expression<Func<T, bool>> filter = null);
    }
}
