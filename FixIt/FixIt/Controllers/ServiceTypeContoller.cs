using FixIt.Models.Models.ServiceType;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class ServiceTypeContoller : BaseController<ServiceTypeViewModel, ServiceTypeInsertModel>
    {
        public ServiceTypeContoller(IBaseCRUDService<ServiceTypeViewModel, ServiceTypeInsertModel> service) : base(service)
        {
        }
    }
}
