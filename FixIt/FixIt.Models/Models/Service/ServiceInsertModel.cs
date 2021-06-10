namespace FixIt.Models.Models.Service
{
    public class ServiceInsertModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int ServiceTypeId { get; set; }
    }
}
