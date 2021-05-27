using FixIt.Models.Models.PaymentType;
using System;

namespace FixIt.Models.Models.Payment
{
    public class PaymentViewModel
    {
        public int PaymentTypeId { get; set; }
        public virtual PaymentTypeViewModel PaymentType { get; set; }
        public double Total { get; set; }
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
