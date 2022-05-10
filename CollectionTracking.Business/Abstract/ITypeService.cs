using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTracking.Business.Abstract
{
    public interface ITypeService
    {
        List<Type> GetAll(string columnName);
        void Add(Type type);
        void Update(Type type);
        void Delete(int id);
    }
}
