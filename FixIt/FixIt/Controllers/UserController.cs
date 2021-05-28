using FixIt.Models.Models.User;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class UserController : BaseController<UserViewModel, object, object, UserSearchModel>
    {
        public UserController(IBaseCRUDService<UserViewModel, object, object, UserSearchModel> userService) : base(userService)
        {
        }
    }
}
