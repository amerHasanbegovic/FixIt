using System;

namespace FixIt.Data.Models
{
    public class Job
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual User User { get; set; }
        public virtual Service Service { get; set; }
        public virtual Employee Employee { get; set; }
        public ServiceRequest ServiceRequest { get; set; }
        public string JobDescription { get; set; }
        public bool Active { get; set; }
        public bool Finished { get; set; }
        public bool? Paid { get; set; }
    }
}
