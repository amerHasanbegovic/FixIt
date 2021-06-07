using System;

namespace FixIt.Data.Models
{
    public class Job
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int ServiceRequestId { get; set; }
        public virtual ServiceRequest ServiceRequest { get; set; }
        public string JobDescription { get; set; }
        public int JobStatusId { get; set; }
        public virtual JobStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? FinishedDate { get; set; }
        public bool? Paid { get; set; }
    }
}
