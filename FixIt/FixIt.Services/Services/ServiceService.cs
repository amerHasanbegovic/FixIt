using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Models.Models.Service;
using FixIt.Services.Interfaces;

namespace FixIt.Services.Services
{
    public class ServiceService : BaseCRUDService<Service, ServiceViewModel, ServiceInsertModel, ServiceUpdateModel>, IServiceService
    {
        public ServiceService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
    }
}
