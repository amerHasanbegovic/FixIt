using FixIt.Data.Models;
using System.Collections.Generic;

namespace FixIt.Services.Interfaces
{
    public interface IUser
    {
        List<User> Get();
    }
}
