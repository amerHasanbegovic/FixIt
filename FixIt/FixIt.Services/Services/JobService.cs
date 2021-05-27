using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Models.Models.Job;
using FixIt.Services.Interfaces;

namespace FixIt.Services.Services
{
    public class JobService : BaseCRUDService<Job, JobViewModel, JobInsertModel, JobUpdateModel>, IJobService
    {
        public JobService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
    }
}
