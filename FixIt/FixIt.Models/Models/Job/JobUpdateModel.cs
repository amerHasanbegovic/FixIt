namespace FixIt.Models.Models.Job
{
    public class JobUpdateModel
    {
        public int EmployeeId { get; set; }
        public int JobStatusId { get; set; }
        public bool? Paid { get; set; }
    }
}
