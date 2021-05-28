using FixIt.Models.Models.ServiceType;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class ServiceTypeController : BaseController<ServiceTypeModel, ServiceTypeModel, ServiceTypeModel, object>
    {
        public ServiceTypeController(IBaseCRUDService<ServiceTypeModel, ServiceTypeModel, ServiceTypeModel, object> service) : base(service)
        {
        }
    }
}
