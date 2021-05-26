using FixIt.Models.Models.ServiceRating;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class ServiceRatingController : BaseController<ServiceRatingViewModel, ServiceRatingInsertModel, ServiceRatingUpdateModel>
    {
        public ServiceRatingController(IBaseCRUDService<ServiceRatingViewModel, ServiceRatingInsertModel, ServiceRatingUpdateModel> service) : base(service)
        {
        }
    }
}
