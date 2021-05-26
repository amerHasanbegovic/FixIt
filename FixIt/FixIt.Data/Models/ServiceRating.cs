using System;

namespace FixIt.Data.Models
{
    public class ServiceRating
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public int Rating { get; set; }
        public DateTime RatingDate { get; set; }
    }
}
