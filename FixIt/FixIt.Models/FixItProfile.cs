using AutoMapper;
using FixIt.Data.Models;
using FixIt.Models.ViewModels;

namespace FixIt.Models
{
    public class FixItProfile : Profile
    {
        public FixItProfile()
        {
            CreateMap<User, UserViewModel>();
        }
    }
}
