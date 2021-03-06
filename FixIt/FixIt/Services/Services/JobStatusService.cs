using AutoMapper;
using FixIt.Database;
using FixIt.Database.Models;
using FixIt.Models.Models.JobStatus;
using FixIt.Services.Interfaces;

namespace FixIt.Services.Services
{
    public class JobStatusService : BaseCRUDService<JobStatus, JobStatusViewModel, object, object, object>, IJobStatusService
    {
        public JobStatusService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
    }
}
