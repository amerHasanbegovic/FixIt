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
            //user
            CreateMap<User, UserViewModel>();

            //service
            CreateMap<Service, ServiceViewModel>();
            CreateMap<ServiceInsertModel, Service>();
        }
    }
}
