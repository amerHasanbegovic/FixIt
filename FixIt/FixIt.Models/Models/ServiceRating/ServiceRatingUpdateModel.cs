using System;
using System.ComponentModel.DataAnnotations;

namespace FixIt.Models.Models.ServiceRating
{
    public class ServiceRatingUpdateModel
    {
        [Required]
        public int ServiceId { get; set; }
        [Required]
        public string? UserId { get; set; }
        [Required]
        public int Rating { get; set; }
        public DateTime RatingDate { get; set; }
    }
}
