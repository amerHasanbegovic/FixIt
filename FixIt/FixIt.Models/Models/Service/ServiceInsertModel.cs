using System.ComponentModel.DataAnnotations;

namespace FixIt.Models.Models.Service
{
    public class ServiceInsertModel
    {
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int ServiceTypeId { get; set; }
    }
}
