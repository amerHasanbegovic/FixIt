using System;
using System.ComponentModel.DataAnnotations;

namespace FixIt.Models.Models.Payment
{
    public class PaymentInsertModel
    {
        [Required]
        public double Total { get; set; }
        [Required]
        public int PaymentTypeId { get; set; }
        public string? FullName { get; set; }
        public string? CreditCardNumber { get; set; }
        public string? CVV { get; set; }
        public DateTime? CardExpirationDate { get; set; }
        [Required]
        public DateTime PaymentDate { get; set; }
    }
}
