using FixIt.Models.Models.ServiceRating;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class ServiceRatingController : BaseController<ServiceRatingViewModel, ServiceRatingInsertModel, ServiceRatingUpdateModel, object>
    {
        public ServiceRatingController(IBaseCRUDService<ServiceRatingViewModel, ServiceRatingInsertModel, ServiceRatingUpdateModel, object> service) : base(service)
        {
        }
    }
}
