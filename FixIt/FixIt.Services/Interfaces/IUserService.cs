using FixIt.Data.Models;
using System.Collections.Generic;

namespace FixIt.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> Get();
    }
}
