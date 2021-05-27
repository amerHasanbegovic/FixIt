using FixIt.Models.Models.Payment;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class PaymentController : BaseController<PaymentViewModel, PaymentInsertModel, object>
    {
        public PaymentController(IBaseCRUDService<PaymentViewModel, PaymentInsertModel, object> service) : base(service)
        {
        }
    }
}
