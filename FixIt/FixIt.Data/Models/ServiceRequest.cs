using System;

namespace FixIt.Data.Models
{
    public class ServiceRequest
    {
        public int Id { get; set; }
        public DateTime RequestDate { get; set; }
        public virtual Service Service { get; set; }
        public virtual User User { get; set; }
        public virtual Payment Payment { get; set; }
    }
}