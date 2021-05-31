using FixIt.Models.Models.City;
using FixIt.Models.Models.Sex;
using System;

namespace FixIt.Models.Models.User
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public byte[] Photo { get; set; }
        public DateTime MemberSince { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public virtual CityViewModel City { get; set; }
        public SexViewModel Sex { get; set; }
    }
}
