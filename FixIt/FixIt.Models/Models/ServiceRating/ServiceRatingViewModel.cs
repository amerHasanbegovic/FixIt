using FixIt.Models.Models.Service;
using FixIt.Models.Models.User;
using System;

namespace FixIt.Models.Models.ServiceRating
{
    public class ServiceRatingViewModel
    {
        public int ServiceId { get; set; }
        public virtual ServiceViewModel? Service { get; set; }
        public string? UserId { get; set; }
        public virtual UserViewModel? User { get; set; }
        public int Rating { get; set; }
        public DateTime RatingDate { get; set; }
    }
}
