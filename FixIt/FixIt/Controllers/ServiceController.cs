using FixIt.Models.Models.Service;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class ServiceController : BaseController<ServiceViewModel, ServiceInsertModel, ServiceUpdateModel, ServiceSearchModel>
    {
        public ServiceController(IServiceService service) : base(service)
        {

        }
    }
}
