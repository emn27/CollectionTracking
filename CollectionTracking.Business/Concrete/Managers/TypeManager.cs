using CollectionTracking.Business.Abstract;
using CollectionTracking.DataAccess.Abstract;
using System.Collections.Generic;
using CollectionTracking.Entities.Concrete;

namespace CollectionTracking.Business.Concrete.Managers
{
    public class TypeManager : ITypeService
    {
        private ITypeDal _typeDal;
        public TypeManager(ITypeDal typeDal)
        {
            _typeDal = _typeDal;
        }
        //List<Type>GetAll(string columnName)
        //{
        //    return _typeDal.GetList(columnName: columnName);
        //}

        public void Add(Type type)
        {
            _typeDal.Add(type);
        }

        public void Update(Type type)
        {
            _typeDal.Update(type, filter: t => t.Id == type.Id);
        }
        public void Delete(int id)
        {
            _typeDal.Delete(id, t => t.Id == id);
        }
    }
}
