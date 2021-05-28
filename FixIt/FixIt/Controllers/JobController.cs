using FixIt.Models.Models.Job;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class JobController : BaseController<JobViewModel, JobInsertModel, JobUpdateModel, JobSearchModel>
    {
        public JobController(IJobService service) : base(service)
        {

        }
    }
}
