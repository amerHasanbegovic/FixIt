using System;
using System.Collections.Generic;

namespace FixIt.Database.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int ProfessionId { get; set; }
        public virtual Profession Profession { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public byte[] Photo { get; set; }
        public string PhoneNumber { get; set; }
        public string Biography { get; set; }
        public DateTime BirthDate { get; set; }
        public int SexId { get; set; }
        public virtual Sex Sex { get; set; }

        public virtual IEnumerable<Job> Jobs { get; set; }
    }
}
