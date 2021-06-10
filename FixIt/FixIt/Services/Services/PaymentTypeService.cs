using AutoMapper;
using FixIt.Database;
using FixIt.Database.Models;
using FixIt.Models.Models.PaymentType;
using FixIt.Services.Interfaces;

namespace FixIt.Services.Services
{
    public class PaymentTypeService : BaseCRUDService<PaymentType, PaymentTypeViewModel, object, object, object>, IPaymentTypeService
    {
        public PaymentTypeService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
    }
}
