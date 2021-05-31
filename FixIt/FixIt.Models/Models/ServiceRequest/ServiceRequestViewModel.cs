using FixIt.Models.Models.Payment;
using FixIt.Models.Models.Service;
using FixIt.Models.Models.User;
using System;

namespace FixIt.Models.Models.ServiceRequest
{
    public class ServiceRequestViewModel
    {
        public int Id { get; set; }
        public DateTime RequestDate { get; set; }
        public int ServiceId { get; set; }
        public virtual ServiceViewModel Service { get; set; }
        public string UserId { get; set; }
        public virtual UserViewModel User { get; set; }
        public int PaymentId { get; set; }
        public virtual PaymentViewModel Payment { get; set; }
        public string JobDescription { get; set; }
    }
}
