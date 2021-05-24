using FixIt.Models.ViewModels.Service;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class ServicesController : BaseController<ServiceViewModel>
    {
        public ServicesController(IBaseCRUDService<ServiceViewModel> service) : base(service)
        {
        }
    }
}
