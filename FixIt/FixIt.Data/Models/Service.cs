using System;

namespace FixIt.Data.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public ServiceType Type { get; set; }
        public int TimesRequested { get; set; }
    }
}
