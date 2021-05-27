using FixIt.Models.Models.ServiceRequest;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class ServiceRequestController : BaseController<ServiceRequestViewModel, ServiceRequestInsertModel, object>
    {
        public ServiceRequestController(IBaseCRUDService<ServiceRequestViewModel, ServiceRequestInsertModel, object> service) : base(service)
        {
        }
    }
}
