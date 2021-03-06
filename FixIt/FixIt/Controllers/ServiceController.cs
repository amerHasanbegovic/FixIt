using FixIt.Database;
using FixIt.Models.Models.Service;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class ServiceController : BaseController<ServiceViewModel, ServiceInsertModel, ServiceUpdateModel, ServiceSearchModel>
    {
        protected readonly ApplicationDbContext _applicationDbContext;
        protected readonly IServiceService serviceService;
        public ServiceController(IServiceService service, ApplicationDbContext applicationDbContext) : base(service)
        {
            _applicationDbContext = applicationDbContext;
            serviceService = service;
        }
    }
}
