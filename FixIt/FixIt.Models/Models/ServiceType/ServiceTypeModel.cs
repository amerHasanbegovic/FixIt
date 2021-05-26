using System.ComponentModel.DataAnnotations;

namespace FixIt.Models.Models.ServiceType
{
    public class ServiceTypeModel
    {
        [Required(ErrorMessage = "Service type name is required!")]
        public string Name { get; set; }
    }
}
