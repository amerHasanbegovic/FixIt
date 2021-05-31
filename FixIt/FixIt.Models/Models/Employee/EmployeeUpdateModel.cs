using System;
using System.ComponentModel.DataAnnotations;

namespace FixIt.Models.Models.Employee
{
    public class EmployeeUpdateModel
    {
        [Required(ErrorMessage = "First name is required!")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Last name is required!")]
        public string Lastname { get; set; }
        
        [Required(ErrorMessage = "Profession is required!")]
        public int ProfessionId { get; set; }
        
        [Required(ErrorMessage = "Address is required!")]
        public string Address { get; set; }
        
        [Required(ErrorMessage = "City name is required!")]
        public int CityId { get; set; }
        public byte[] Photo { get; set; }
        
        [Required(ErrorMessage = "Phone number is required!")]
        public string PhoneNumber { get; set; }
        public string Biography { get; set; }
        public DateTime BirthDate { get; set; }
        
        [Required(ErrorMessage = "Sex is required!")]
        public int SexId { get; set; }
    }
}
