using AutoMapper;
using FixIt.Database;
using FixIt.Database.Models;
using FixIt.Models.Models.Payment;
using FixIt.Services.Interfaces;

namespace FixIt.Services.Services
{
    public class PaymentService : BaseCRUDService<Payment, PaymentViewModel, PaymentInsertModel, object, object>, IPaymentService
    {
        public PaymentService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
    }
}
