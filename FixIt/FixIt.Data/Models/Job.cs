using System;

namespace FixIt.Data.Models
{
    public class Job
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int ServiceRequestId { get; set; }
        public virtual ServiceRequest ServiceRequest { get; set; }
        public int JobDetailsId { get; set; }
        public virtual JobDetail JobDetails { get; set; }
        public int JobStatusId { get; set; }
        public virtual JobStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
