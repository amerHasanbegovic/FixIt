using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FixIt.Services.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public List<User> Get()
        {
            return _applicationDbContext.Users.ToList();
        }
    }
}
