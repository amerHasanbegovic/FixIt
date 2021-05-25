using System;

namespace FixIt.Data.Models
{
    public class ServiceRequest
    {
        public int Id { get; set; }
        public DateTime RequestDate { get; set; }
        public Service Service { get; set; }
        public User User { get; set; }
        public Payment Payment { get; set; }
    }
}