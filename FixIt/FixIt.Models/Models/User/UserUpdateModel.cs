using System.ComponentModel.DataAnnotations;

namespace FixIt.Models.Models.User
{
    public class UserUpdateModel
    {
        [Required]
        public string? Firstname { get; set; }
        [Required]
        public string? Lastname { get; set; }
        public byte[]? Photo { get; set; }
        public string? Address { get; set; }
        public int? CityId { get; set; }
        public int? SexId { get; set; }
    }
}
