using FixIt.Models.Models.ServiceType;

namespace FixIt.Models.Models.Service
{
    public class ServiceViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public int ServiceTypeId { get; set; }
        public virtual ServiceTypeModel ServiceType { get; set; }
    }
}
