using System;
using System.ComponentModel.DataAnnotations;

namespace FixIt.Models.Models.ServiceRating
{
    public class ServiceRatingInsertModel
    {
        [Required]
        public int ServiceId { get; set; }
        [Required]
        public string? UserId { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public DateTime RatingDate { get; set; }
    }
}
