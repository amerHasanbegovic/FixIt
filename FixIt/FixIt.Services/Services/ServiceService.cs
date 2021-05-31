﻿using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Models.Models.Service;
using FixIt.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FixIt.Services.Services
{
    public class ServiceService : BaseCRUDService<Service, ServiceViewModel, ServiceInsertModel, ServiceUpdateModel, ServiceSearchModel>, IServiceService
    {
        public ServiceService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }

        public async Task Delete(int id)
        {
            var entity = _applicationDbContext.Set<Service>().Find(id);
            _applicationDbContext.Remove(entity);
            await _applicationDbContext.SaveChangesAsync();
        }

        public override IEnumerable<ServiceViewModel> Get(ServiceSearchModel model)
        {
            var query = _applicationDbContext.Set<Service>().AsQueryable();
            if (!string.IsNullOrEmpty(model.Name))
                query = query.Where(x => x.Name.ToLower().Contains(model.Name.ToLower()));

            var res = query.ToList();
            return _mapper.Map<IEnumerable<ServiceViewModel>>(res);
        }
        public override ServiceViewModel GetById(int id)
        {
            var res = _applicationDbContext.Set<Service>().Include(x => x.ServiceType).FirstOrDefault(x => x.Id == id);
            return _mapper.Map<ServiceViewModel>(res);
        }
    }
}
