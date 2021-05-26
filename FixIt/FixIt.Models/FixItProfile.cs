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
            CreateMap<ServiceUpdateModel, Service>();

            //serviceType
            CreateMap<ServiceType, ServiceTypeModel>();
            CreateMap<ServiceTypeModel, ServiceType>();
        }
    }
}
