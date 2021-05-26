using FixIt.Data.Models;
using FixIt.Models.Models.City;
using System;

namespace FixIt.Models.Models.User
{
    public class UserViewModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public byte[] Photo { get; set; }
        public DateTime MemberSince { get; set; }
        public string Address { get; set; }
        public virtual CityViewModel City { get; set; }
        public Sex Sex { get; set; }
    }
}
