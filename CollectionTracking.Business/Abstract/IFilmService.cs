using CollectionTracking.Entities.Concrete;
using System.Collections.Generic;

namespace CollectionTracking.Business.Abstract
{
    public interface IFilmService
    {
        List<Film> GetAll(string columnName);
        void Add(Film film);
        void Update(Film film);
        void Delete(int id);
    }
}