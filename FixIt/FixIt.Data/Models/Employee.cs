using System;

namespace FixIt.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public virtual Profession Profession { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public virtual City City { get; set; }
        public byte[] Photo { get; set; }
        public string PhoneNumber { get; set; }
        public string Biography { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual Sex Sex { get; set; }
    }
}
