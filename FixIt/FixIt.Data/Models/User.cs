﻿using Microsoft.AspNetCore.Identity;
using System;

namespace FixIt.Data.Models
{
    public class User : IdentityUser
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
