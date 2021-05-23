using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Services.Interfaces;

namespace FixIt.Services.Services
{
    public class UserService : BaseCRUDService<User>, IUserService
    {
        public UserService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
    }
}
