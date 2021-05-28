using FixIt.Models.Models.Sex;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class SexController : BaseController<SexViewModel, object, object, object>
    {
        public SexController(IBaseCRUDService<SexViewModel, object, object, object> service) : base(service)
        {
        }
    }
}
