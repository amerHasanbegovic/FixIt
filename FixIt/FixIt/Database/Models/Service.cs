using System;
using System.Collections.Generic;

namespace FixIt.Database.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public int ServiceTypeId { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public int TimesRequested { get; set; }

        public virtual IEnumerable<ServiceRequest> ServiceRequests { get; set; }
    }
}
