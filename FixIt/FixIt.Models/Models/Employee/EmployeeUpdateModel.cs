using System;
using System.ComponentModel.DataAnnotations;

namespace FixIt.Models.Models.Employee
{
    public class EmployeeUpdateModel
    {
        [Required]
        public string? Firstname { get; set; }
        [Required]
        public string? Lastname { get; set; }
        [Required]
        public int ProfessionId { get; set; }
        public string? Address { get; set; }
        [Required]
        public int CityId { get; set; }
        public byte[]? Photo { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        public string? Biography { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public int SexId { get; set; }
    }
}
