using System;
using System.ComponentModel.DataAnnotations;

namespace FixIt.Models.Models.ServiceRequest
{
    public class ServiceRequestInsertModel
    {
        public DateTime RequestDate { get; set; }
        [Required]
        public int ServiceId { get; set; }
        [Required]
        public string? UserId { get; set; }
        [Required]
        public int PaymentId { get; set; }
        public string? JobDescription { get; set; }
    }
}
