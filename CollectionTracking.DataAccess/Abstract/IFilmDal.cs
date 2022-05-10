using CollectionTracking.Core.DataAccess;
using CollectionTracking.Entities.Concrete;
using System.Collections.Generic;

namespace CollectionTracking.DataAccess.Abstract
{
    public interface IFilmDal : IEntityRepository<Film>
    {
        //List<Film> GetAll(string columnName);
        //void Add(Film film);
        //void Update(Film film);
        //void Delete(int id);
    }
}
