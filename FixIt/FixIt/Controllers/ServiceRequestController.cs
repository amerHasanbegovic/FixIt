using FixIt.Models.Models.ServiceRequest;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class ServiceRequestController : BaseController<ServiceRequestViewModel, ServiceRequestInsertModel, ServiceRequestUpdateModel, object>
    {
        public ServiceRequestController(IServiceRequestService service) : base(service)
        {

        }
    }
}
