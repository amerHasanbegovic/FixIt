using System;

namespace FixIt.Data.Models
{
    public class JobDetail
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string JobDescription { get; set; }
        public bool? Paid { get; set; }

    }
}
