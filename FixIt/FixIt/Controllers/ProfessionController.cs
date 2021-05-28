using FixIt.Models.Models.Profession;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class ProfessionController : BaseController<ProfessionViewModel, object, object, object>
    {
        public ProfessionController(IBaseCRUDService<ProfessionViewModel, object, object, object> service) : base(service)
        {
        }
    }
}
