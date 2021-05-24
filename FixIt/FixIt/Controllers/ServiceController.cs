using FixIt.Models.ViewModels.Service;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class ServiceController : BaseController<ServiceViewModel, ServiceInsertModel>
    {
        public ServiceController(IBaseCRUDService<ServiceViewModel, ServiceInsertModel> service) : base(service)
        {
        }
    }
}
