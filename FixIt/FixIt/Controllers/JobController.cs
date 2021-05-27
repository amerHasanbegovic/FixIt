using FixIt.Models.Models.Job;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class JobController : BaseController<JobViewModel, JobInsertModel, JobUpdateModel>
    {
        public JobController(IBaseCRUDService<JobViewModel, JobInsertModel, JobUpdateModel> service) : base(service)
        {
        }
    }
}
