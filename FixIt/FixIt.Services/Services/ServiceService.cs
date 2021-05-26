using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Models.Models.Service;
using FixIt.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FixIt.Services.Services
{
    public class ServiceService : BaseCRUDService<Service, ServiceViewModel, ServiceInsertModel, ServiceUpdateModel>, IServiceService
    {
        public ServiceService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
        public override IEnumerable<ServiceViewModel> Get()
        {
            var res = _applicationDbContext.Set<Service>().Include(x => x.ServiceType).ToList();
            return _mapper.Map<IEnumerable<ServiceViewModel>>(res);
        }
        public override ServiceViewModel GetById(int id)
        {
            var res = _applicationDbContext.Set<Service>().Include(x => x.ServiceType).ToList();
            return _mapper.Map<ServiceViewModel>(res);
        }
    }
}
