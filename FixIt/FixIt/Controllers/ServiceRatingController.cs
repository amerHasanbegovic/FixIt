using FixIt.Models.Models.ServiceRating;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class ServiceRatingController : BaseController<ServiceRatingViewModel, ServiceRatingInsertModel, ServiceRatingUpdateModel, object>
    {
        public ServiceRatingController(IServiceRatingService service) : base(service)
        {

        }
    }
}
