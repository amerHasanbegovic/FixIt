using System;

namespace FixIt.Data.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public int PaymentTypeId { get; set; }
        public virtual PaymentType PaymentType { get; set; }
#nullable enable
        public string? FullName { get; set; }
#nullable enable
        public string? CreditCardNumber { get; set; }
#nullable enable
        public string? CVV { get; set; }
#nullable enable
        public DateTime PaymentDate { get; set; }
    }
}