using FixIt.Models.Models.City;
using FixIt.Models.Models.Job;
using FixIt.Models.Models.Profession;
using FixIt.Models.Models.Sex;
using System;
using System.Collections.Generic;

namespace FixIt.Models.Models.Employee
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int ProfessionId { get; set; }
        public virtual ProfessionViewModel? Profession { get; set; }
        public DateTime HireDate { get; set; }
        public string? Address { get; set; }
        public int CityId { get; set; }
        public virtual CityViewModel? City { get; set; }
        public byte[]? Photo { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Biography { get; set; }
        public DateTime BirthDate { get; set; }
        public int SexId { get; set; }
        public virtual SexViewModel? Sex { get; set; }

        public string EmployeeFullNameAndProfession => $"{Firstname} {Lastname} - {Profession?.Name}";
        public string EmployeeFullName => $"{Firstname} {Lastname}";

        public virtual IEnumerable<JobViewModel>? Jobs { get; set; }

    }
}
