using FixIt.Models.Models.JobStatus;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class JobStatusController : BaseController<JobStatusViewModel, object, object, object>
    {
        public JobStatusController(IBaseCRUDService<JobStatusViewModel, object, object, object> service) : base(service)
        {
        }
    }
}
