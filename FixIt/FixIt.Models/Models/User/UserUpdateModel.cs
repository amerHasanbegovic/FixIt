namespace FixIt.Models.Models.User
{
    public class UserUpdateModel
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public byte[]? Photo { get; set; }
        public string? Address { get; set; }
        public int? CityId { get; set; }
        public int? SexId { get; set; }
    }
}
