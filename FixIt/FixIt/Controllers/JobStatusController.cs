using FixIt.Models.Models.JobStatus;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class JobStatusController : BaseController<JobStatusViewModel, object, object>
    {
        public JobStatusController(IBaseCRUDService<JobStatusViewModel, object, object> service) : base(service)
        {
        }
    }
}
