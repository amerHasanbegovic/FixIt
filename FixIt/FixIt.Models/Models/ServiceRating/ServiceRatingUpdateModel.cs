using System;

namespace FixIt.Models.Models.ServiceRating
{
    public class ServiceRatingUpdateModel
    {
        public int ServiceId { get; set; }
        public string? UserId { get; set; }
        public int Rating { get; set; }
        public DateTime RatingDate { get; set; }
    }
}
