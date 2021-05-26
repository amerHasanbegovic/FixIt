using FixIt.Models.Models.City;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class CityController : BaseController<CityViewModel, object, object>
    {
        public CityController(IBaseCRUDService<CityViewModel, object, object> service) : base(service)
        {
        }
    }
}
