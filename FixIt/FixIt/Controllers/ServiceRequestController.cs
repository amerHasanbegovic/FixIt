using FixIt.Models.Models.ServiceRequest;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class ServiceRequestController : BaseController<ServiceRequestViewModel, ServiceRequestInsertModel, object, object>
    {
        public ServiceRequestController(IBaseCRUDService<ServiceRequestViewModel, ServiceRequestInsertModel, object, object> service) : base(service)
        {
        }
    }
}
