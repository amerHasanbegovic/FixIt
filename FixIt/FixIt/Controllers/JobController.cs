using FixIt.Database;
using FixIt.Models.Models.Job;
using FixIt.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FixIt.Controllers
{
    public class JobController : BaseController<JobViewModel, JobInsertModel, JobUpdateModel, JobSearchModel>
    {
        protected readonly ApplicationDbContext _applicationDbContext;
        protected readonly IJobService jobService;
        public JobController(IJobService service, ApplicationDbContext applicationDbContext) : base(service)
        {
            _applicationDbContext = applicationDbContext;
            jobService = service;
        }

        [Authorize]
        [HttpGet("serviceRequest/{id}")]
        public JobViewModel GetByServiceRequestId(int id)
        {
            return jobService.GetByServiceRequestId(id);
        }
    }
}
