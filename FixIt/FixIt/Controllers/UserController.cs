using FixIt.Models.ViewModels.User;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class UserController : BaseController<UserViewModel, object>
    {
        public UserController(IBaseCRUDService<UserViewModel, object> userService) : base(userService)
        {
        }
    }
}
