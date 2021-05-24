using AutoMapper;
using FixIt.Data.Models;
using FixIt.Models.ViewModels.Service;
using FixIt.Models.ViewModels.User;

namespace FixIt.Models
{
    public class FixItProfile : Profile
    {
        public FixItProfile()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<Service, ServiceViewModel>();
        }
    }
}
