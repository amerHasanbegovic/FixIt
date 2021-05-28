using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Models.Models.User;
using FixIt.Services.Interfaces;

namespace FixIt.Services.Services
{
    public class UserService : BaseCRUDService<User, UserViewModel, object, object, UserSearchModel>, IUserService
    {
        public UserService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
    }
}
