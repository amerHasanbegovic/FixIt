using FixIt.Models.Models.Job;

namespace FixIt.Services.Interfaces
{
    public interface IJobService : IBaseCRUDService<JobViewModel, JobInsertModel, JobUpdateModel>
    {
    }
}
