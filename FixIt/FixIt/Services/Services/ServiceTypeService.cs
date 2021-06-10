using AutoMapper;
using FixIt.Database;
using FixIt.Database.Models;
using FixIt.Models.Models.ServiceType;
using FixIt.Services.Interfaces;

namespace FixIt.Services.Services
{
    public class ServiceTypeService : BaseCRUDService<ServiceType, ServiceTypeModel, ServiceTypeModel, ServiceTypeModel, object>, IServiceTypeService
    {
        public ServiceTypeService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
    }
}
