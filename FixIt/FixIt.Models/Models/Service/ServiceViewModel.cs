using FixIt.Models.Models.ServiceRequest;
using FixIt.Models.Models.ServiceType;
using System.Collections.Generic;

namespace FixIt.Models.Models.Service
{
    public class ServiceViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public int ServiceTypeId { get; set; }
        public virtual ServiceTypeModel? ServiceType { get; set; }
        public int TimesRequested { get; set; }


        public virtual IEnumerable<ServiceRequestViewModel>? ServiceRequests { get; set; }
        public string? ServiceTypeName => ServiceType?.Name;
    }
}
