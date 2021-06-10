using FixIt.Models.Models.User;
using System.Collections.Generic;

namespace FixIt.Services.Interfaces
{
    public interface IUserService 
    {
        UserViewModel GetById(string id);
        IEnumerable<UserViewModel> Get(UserSearchModel model);
        UserViewModel Update(string id, UserUpdateModel model);
    }
}
