using FixIt.Models.Models.Sex;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class SexContoller : BaseController<SexViewModel, object, object>
    {
        public SexContoller(IBaseCRUDService<SexViewModel, object, object> service) : base(service)
        {
        }
    }
}
