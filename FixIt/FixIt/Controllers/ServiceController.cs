using FixIt.Data;
using FixIt.Models.Models.Service;
using FixIt.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await serviceService.Delete(id);
        }
    }
}
