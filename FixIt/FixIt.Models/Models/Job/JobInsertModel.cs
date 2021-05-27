using System;

namespace FixIt.Models.Models.Job
{
    public class JobInsertModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ServiceRequestId { get; set; }
        public string JobDescription { get; set; }
        public int JobStatusId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool? Paid { get; set; }
    }
}
