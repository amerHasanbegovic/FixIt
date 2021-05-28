using FixIt.Models.Models.User;

namespace FixIt.Services.Interfaces
{
    public interface IUserService : IBaseCRUDService<UserViewModel, object, object, UserSearchModel>
    {
    }
}
