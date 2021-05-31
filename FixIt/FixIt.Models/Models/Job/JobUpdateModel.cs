using System.ComponentModel.DataAnnotations;

namespace FixIt.Models.Models.Job
{
    public class JobUpdateModel
    {
        [Required(ErrorMessage = "Employee is required!")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Job status is required!")]
        public int JobStatusId { get; set; }
        public bool? Paid { get; set; }
    }
}
