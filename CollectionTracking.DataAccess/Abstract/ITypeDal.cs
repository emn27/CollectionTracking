using CollectionTracking.Core.DataAccess;
using CollectionTracking.Entities.Concrete;

namespace CollectionTracking.DataAccess.Abstract
{

    public interface ITypeDal : IEntityRepository<Type>
    {
        //List<Entities.Concrete.Type> GetAll();
        //void Add(Entities.Concrete.Type type);
        //void Update(Entities.Concrete.Type type);
        //void Delete(int id);  
    }
}
