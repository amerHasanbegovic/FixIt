using AutoMapper;
using FixIt.Database;
using FixIt.Database.Models;
using FixIt.Models.Models.Service;
using FixIt.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FixIt.Services.Services
{
    public class ServiceService : BaseCRUDService<Service, ServiceViewModel, ServiceInsertModel, ServiceUpdateModel, ServiceSearchModel>, IServiceService
    {
        public ServiceService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }

        public override IEnumerable<ServiceViewModel> Get(ServiceSearchModel model)
        {
            var query = _applicationDbContext.Set<Service>().AsQueryable();
            if (!string.IsNullOrEmpty(model.Name))
                query = query.Where(x => x.Name.ToLower().Contains(model.Name.ToLower()));

            var res = query
                .Include(x => x.ServiceType)
                .Include(x => x.ServiceRequests)
                .ToList();
            return _mapper.Map<IEnumerable<ServiceViewModel>>(res);
        }
        public override ServiceViewModel GetById(int id)
        {
            var res = _applicationDbContext.Set<Service>().Include(x => x.ServiceType).FirstOrDefault(x => x.Id == id);
            return _mapper.Map<ServiceViewModel>(res);
        }
    }
}
