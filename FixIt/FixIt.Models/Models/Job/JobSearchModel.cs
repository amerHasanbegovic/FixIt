namespace FixIt.Models.Models.Job
{
    public class JobSearchModel
    {
        //search by user/employee first or last name
        public string Query { get; set; }
        public int JobStatusId { get; set; }
    }
}
