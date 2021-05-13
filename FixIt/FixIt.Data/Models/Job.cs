namespace FixIt.Data.Models
{
    public class Job
    {
        public int Id { get; set; }
        public virtual Employee Employee { get; set; }
        public ServiceRequest ServiceRequest { get; set; }
        public JobStatus Status { get; set; }
    }
}
