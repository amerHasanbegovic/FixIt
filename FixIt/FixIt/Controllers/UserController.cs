using FixIt.Models.ViewModels;
using FixIt.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FixIt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController<UserViewModel>
    {
        public UserController(IBaseCRUDService<UserViewModel> userService) : base(userService)
        {
        }
    }
}
