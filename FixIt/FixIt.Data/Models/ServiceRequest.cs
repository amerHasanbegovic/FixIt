using System;

namespace FixIt.Data.Models
{
    public class ServiceRequest
    {
        public int Id { get; set; }
        public DateTime RequestDate { get; set; }
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public int PaymentId { get; set; }
        public virtual Payment Payment { get; set; }
    }
}