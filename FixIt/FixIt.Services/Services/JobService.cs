using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Models.Models.Job;
using FixIt.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FixIt.Services.Services
{
    public class JobService : BaseCRUDService<Job, JobViewModel, JobInsertModel, JobUpdateModel, JobSearchModel>, IJobService
    {
        public JobService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
        public override IEnumerable<JobViewModel> Get(JobSearchModel model)
        {
            var query = _applicationDbContext.Set<Job>().AsQueryable();

            if (!string.IsNullOrEmpty(model.Query))
                query = query.Where(x =>
                x.Employee.Firstname.ToLower().Contains(model.Query.ToLower()) ||
                x.Employee.Lastname.ToLower().Contains(model.Query.ToLower()) ||
                x.ServiceRequest.User.Firstname.ToLower().Contains(model.Query.ToLower()) ||
                x.ServiceRequest.User.Lastname.ToLower().Contains(model.Query.ToLower()) ||
                x.JobDescription.ToLower().Contains(model.Query.ToLower()));

            if (model?.JobStatusId != 0)
                query = query.Where(x => x.JobStatusId == model.JobStatusId);

            var res = query
                .Include(x => x.Employee)
                .Include(x => x.Status)
                .Include(x => x.ServiceRequest).ThenInclude(x => x.User)
                .Include(x => x.ServiceRequest).ThenInclude(x => x.Service)
                .ToList();

            return _mapper.Map<IEnumerable<JobViewModel>>(res);
        }
        public override JobViewModel GetById(int id)
        {
            var res = _applicationDbContext.Set<Job>()
                .Include(x => x.Employee)
                .Include(x => x.Status)
                .Include(x => x.ServiceRequest).ThenInclude(x => x.User)
                .Include(x => x.ServiceRequest).ThenInclude(x => x.Service)
                .Include(x => x.ServiceRequest).ThenInclude(x => x.Payment)
                .FirstOrDefault(x => x.Id == id);

            return _mapper.Map<JobViewModel>(res);
        }

        public override JobViewModel Insert(JobInsertModel model)
        {
            var entity = _mapper.Map<Job>(model);
            _applicationDbContext.Add(entity);
            SetServiceRequestProcessedTrue(entity.ServiceRequestId);
            _applicationDbContext.SaveChanges();
            return _mapper.Map<JobViewModel>(entity);
        }

        private void SetServiceRequestProcessedTrue(int serviceRequestId)
        {
            var entity = _applicationDbContext.Set<ServiceRequest>().Find(serviceRequestId);
            entity.Processed = true;
            _applicationDbContext.Update(entity);
        }
    }
}
