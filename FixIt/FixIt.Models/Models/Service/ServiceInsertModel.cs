using System.ComponentModel.DataAnnotations;

namespace FixIt.Models.Models.Service
{
    public class ServiceInsertModel
    {
        [Required(ErrorMessage = "Service name is required!")]
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Service price is required!")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Type is required!")]
        public int ServiceTypeId { get; set; }
    }
}
