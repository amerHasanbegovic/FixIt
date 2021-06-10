using System;

namespace FixIt.Models.Models.User
{
    public class UserSearchModel
    {
        public string? FirstOrLastName { get; set; }
        public DateTime? RegisterDateFrom { get; set; }
        public DateTime? RegisterDateTo { get; set; }
    }
}
