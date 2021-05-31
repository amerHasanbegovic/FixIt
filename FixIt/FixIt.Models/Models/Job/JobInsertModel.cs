using System;
using System.ComponentModel.DataAnnotations;

namespace FixIt.Models.Models.Job
{
    public class JobInsertModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee is required!")]
        public int EmployeeId { get; set; }
        public int ServiceRequestId { get; set; }
        public string JobDescription { get; set; }

        [Required(ErrorMessage = "Job status is required!")]
        public int JobStatusId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool? Paid { get; set; }
    }
}
