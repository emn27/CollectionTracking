using CollectionTracking.Core.Entities;
using System;

namespace CollectionTracking.Entities.Concrete
{
    public class Film : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
