using System;

namespace FixIt.Models.Models.ServiceRequest
{
    public class ServiceRequestInsertModel
    {
        public DateTime RequestDate { get; set; }
        public int ServiceId { get; set; }
        public string? UserId { get; set; }
        public int PaymentId { get; set; }
        public string? JobDescription { get; set; }
    }
}
