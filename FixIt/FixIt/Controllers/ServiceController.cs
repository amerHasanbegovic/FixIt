using FixIt.Models.ViewModels.Service;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class ServiceController : BaseController<ServiceViewModel>
    {
        public ServiceController(IBaseCRUDService<ServiceViewModel> service) : base(service)
        {
        }
    }
}
