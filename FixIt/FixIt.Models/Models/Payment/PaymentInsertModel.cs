using System;

namespace FixIt.Models.Models.Payment
{
    public class PaymentInsertModel
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public int PaymentTypeId { get; set; }
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
