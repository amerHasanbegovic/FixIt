﻿using System;

namespace FixIt.Models.Models.Employee
{
    public class EmployeeInsertModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int ProfessionId { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public byte[] Photo { get; set; }
        public string PhoneNumber { get; set; }
        public string Biography { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual int SexId { get; set; }
    }
}
