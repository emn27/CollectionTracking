using CollectionTracking.Business.Abstract;
using CollectionTracking.Business.Concrete.Managers;
using CollectionTracking.DataAccess.Abstract;
using CollectionTracking.DataAccess.Concrete.AdoNet;
using Ninject.Modules;

namespace CollectionTracking.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IFilmService>().To<FilmManager>().InSingletonScope();
            Bind<IFilmDal>().To<AnFilmDal>().InSingletonScope();
        }
    }
}
