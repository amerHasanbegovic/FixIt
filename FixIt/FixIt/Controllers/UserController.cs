using FixIt.Models.ViewModels;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class UserController : BaseController<UserViewModel>
    {
        public UserController(IBaseCRUDService<UserViewModel> userService) : base(userService)
        {
        }
    }
}
