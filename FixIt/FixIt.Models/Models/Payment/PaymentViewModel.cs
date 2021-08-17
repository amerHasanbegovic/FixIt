using FixIt.Models.Models.PaymentType;
using System;

namespace FixIt.Models.Models.Payment
{
    public class PaymentViewModel
    {
        public int Id { get; set; }
        public int PaymentTypeId { get; set; }
        public virtual PaymentTypeViewModel? PaymentType { get; set; }
        public double Total { get; set; }
        public string? FullName { get; set; }
        public string? CreditCardNumber { get; set; }
        public string? CVV { get; set; }
        public DateTime? CardExpirationDate { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
