namespace FixIt.Data.Models
{
    public class Job
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public ServiceRequest ServiceRequest { get; set; }
        public JobDetail JobDetails { get; set; }
        public JobStatus Status { get; set; }
    }
}
