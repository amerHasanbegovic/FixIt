using AutoMapper;
using FixIt.Data.Models;
using FixIt.Models.Models.Service;
using FixIt.Models.Models.ServiceType;
using FixIt.Models.Models.User;

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

            //serviceType
            CreateMap<ServiceType, ServiceTypeViewModel>();
            CreateMap<ServiceTypeInsertModel, ServiceType>();
        }
    }
}
