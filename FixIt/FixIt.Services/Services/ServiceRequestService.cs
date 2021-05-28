using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Models.Models.ServiceRequest;
using FixIt.Services.Interfaces;

namespace FixIt.Services.Services
{
    public class ServiceRequestService : BaseCRUDService<ServiceRequest, ServiceRequestViewModel, ServiceRequestInsertModel, object, object>, IServiceRequestService
    {
        public ServiceRequestService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
    }
}
