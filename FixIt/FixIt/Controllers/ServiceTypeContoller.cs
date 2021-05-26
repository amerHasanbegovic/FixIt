using FixIt.Models.Models.ServiceType;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class ServiceTypeContoller : BaseController<ServiceTypeModel, ServiceTypeModel, ServiceTypeModel>
    {
        public ServiceTypeContoller(IBaseCRUDService<ServiceTypeModel, ServiceTypeModel, ServiceTypeModel> service) : base(service)
        {
        }
    }
}
