using System;

namespace FixIt.Data.Models
{
    public class ServiceRating
    {
        public int Id { get; set; }
        public Service Service { get; set; }
        public User User { get; set; }
        public int Rating { get; set; }
        public DateTime RatingDate { get; set; }
    }
}
