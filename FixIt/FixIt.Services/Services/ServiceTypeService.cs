using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Models.Models.ServiceType;
using FixIt.Services.Interfaces;

namespace FixIt.Services.Services
{
    public class ServiceTypeService : BaseCRUDService<ServiceType, ServiceTypeModel, ServiceTypeModel, ServiceTypeModel>, IServiceTypeService
    {
        public ServiceTypeService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
    }
}
