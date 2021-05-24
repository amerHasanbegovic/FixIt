using FixIt.Models.Models.ServiceType;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class ServiceTypeContoller : BaseController<ServiceTypeViewModel, ServiceTypeInsertModel, ServiceTypeUpdateModel>
    {
        public ServiceTypeContoller(IBaseCRUDService<ServiceTypeViewModel, ServiceTypeInsertModel, ServiceTypeUpdateModel> service) : base(service)
        {
        }
    }
}
