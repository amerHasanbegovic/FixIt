using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Models.Models.ServiceRequest;
using FixIt.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FixIt.Services.Services
{
    public class ServiceRequestService : BaseCRUDService<ServiceRequest, ServiceRequestViewModel, ServiceRequestInsertModel, object, object>, IServiceRequestService
    {
        public ServiceRequestService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }

        public override IEnumerable<ServiceRequestViewModel> Get(object search = null)
        {
            var res = _applicationDbContext.Set<ServiceRequest>().AsQueryable();
            var list = res
                .Include(x => x.Service)
                .Include(x => x.User)
                .Include(x => x.Payment).ThenInclude(x => x.PaymentType)
                .ToList();
            return _mapper.Map<IEnumerable<ServiceRequestViewModel>>(list);
        }

        public override ServiceRequestViewModel GetById(int id)
        {
            var res = _applicationDbContext.Set<ServiceRequest>()
                .Include(x => x.Payment).ThenInclude(x => x.PaymentType)
                .Include(x => x.Service).ThenInclude(x => x.ServiceType)
                .Include(x => x.User)
                .FirstOrDefault(x => x.Id == id);
            return _mapper.Map<ServiceRequestViewModel>(res);
        }

        public override ServiceRequestViewModel Insert(ServiceRequestInsertModel model)
        {
            var entity = _mapper.Map<ServiceRequest>(model);
            _applicationDbContext.Add(entity);
            CalculateServiceTimesRequested(entity.ServiceId);
            _applicationDbContext.SaveChanges();
            return _mapper.Map<ServiceRequestViewModel>(entity);
        }

        private void CalculateServiceTimesRequested(int serviceId)
        {
            var entity = _applicationDbContext.Set<Service>().Find(serviceId);
            entity.TimesRequested++;
            _applicationDbContext.Update(entity);
        }
    }
}
