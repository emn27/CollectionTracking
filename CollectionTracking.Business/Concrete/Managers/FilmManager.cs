using CollectionTracking.Business.Abstract;
using CollectionTracking.DataAccess.Abstract;
using CollectionTracking.Entities.Concrete;
using System.Collections.Generic;

namespace CollectionTracking.Business.Concrete.Managers
{
    public class FilmManager : IFilmService
    {
        private IFilmDal _filmDal;
        public FilmManager(IFilmDal filmDal)
        {
            _filmDal = filmDal;
        }

        public List<Film> GetAll(string columnName)
        {
            return _filmDal.GetList(columnName: columnName);
        }

        public void Add(Film film)
        {
            _filmDal.Add(film);
        }

        public void Update(Film film)
        {
            _filmDal.Update(film, filter: f => f.Id == film.Id);
        }

        public void Delete(int id)
        {
            _filmDal.Delete(id, f => f.Id == id);
        }
    }
}