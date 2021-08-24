using System;
using System.ComponentModel.DataAnnotations;

namespace FixIt.Models.Models.Job
{
    public class JobUpdateModel
    {
        [Required]
        public int? EmployeeId { get; set; }
        [Required]
        public int? JobStatusId { get; set; }
        public bool? Paid { get; set; }
        public DateTime? FinishedDate { get; set; }
    }
}
