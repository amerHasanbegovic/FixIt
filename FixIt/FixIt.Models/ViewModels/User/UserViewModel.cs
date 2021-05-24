using FixIt.Data.Models;
using System;

namespace FixIt.Models.ViewModels.User
{
    public class UserViewModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public byte[] Photo { get; set; }
        public DateTime MemberSince { get; set; }
        public string Address { get; set; }
        public City City { get; set; }
        public Sex Sex { get; set; }
    }
}
