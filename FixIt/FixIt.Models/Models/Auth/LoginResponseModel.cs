using System;

namespace FixIt.Models.Models.Auth
{
    public class LoginResponseModel
    {
        public string? token { get; set; }
        public DateTime? expiration { get; set; }
    }
}
