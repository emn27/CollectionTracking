using CollectionTracking.Core.Entities;

namespace CollectionTracking.Entities.Concrete
{
    public class Type : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
