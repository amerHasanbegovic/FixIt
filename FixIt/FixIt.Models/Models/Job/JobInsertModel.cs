using System;
using System.ComponentModel.DataAnnotations;

namespace FixIt.Models.Models.Job
{
    public class JobInsertModel
    {
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public int ServiceRequestId { get; set; }
        public string? JobDescription { get; set; }
        [Required]
        public int JobStatusId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool? Paid { get; set; }
    }
}
