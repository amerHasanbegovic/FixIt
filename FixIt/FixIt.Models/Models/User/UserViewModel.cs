using FixIt.Models.Models.City;
using FixIt.Models.Models.ServiceRequest;
using FixIt.Models.Models.Sex;
using System;
using System.Collections.Generic;

namespace FixIt.Models.Models.User
{
    public class UserViewModel
    {
        public string? Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public byte[]? Photo { get; set; }
        public DateTime MemberSince { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public virtual CityViewModel? City { get; set; }
        public virtual SexViewModel? Sex { get; set; }

        public virtual IEnumerable<ServiceRequestViewModel>? ServiceRequests { get; set; }
    }
}
