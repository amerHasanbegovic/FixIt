using AutoMapper;
using FixIt.Data.Models;
using FixIt.Models.Models.City;
using FixIt.Models.Models.Employee;
using FixIt.Models.Models.PaymentType;
using FixIt.Models.Models.Profession;
using FixIt.Models.Models.Service;
using FixIt.Models.Models.ServiceType;
using FixIt.Models.Models.Sex;
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

            //city
            CreateMap<City, CityViewModel>();

            //sex
            CreateMap<Sex, SexViewModel>();

            //profession
            CreateMap<Profession, ProfessionViewModel>();

            //employee
            CreateMap<Employee, EmployeeViewModel>();
            CreateMap<EmployeeInsertModel, Employee>();
            CreateMap<EmployeeUpdateModel, Employee>();

            //payment type
            CreateMap<PaymentType, PaymentTypeViewModel>();
        }
    }
}
