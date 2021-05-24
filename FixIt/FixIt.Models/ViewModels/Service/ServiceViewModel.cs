using FixIt.Data.Models;

namespace FixIt.Models.ViewModels.Service
{
    public class ServiceViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public int TypeId { get; set; }
    }
}
