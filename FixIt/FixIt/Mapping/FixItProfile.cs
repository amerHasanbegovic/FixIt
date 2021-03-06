using AutoMapper;
using FixIt.Database.Models;
using FixIt.Models.Models.City;
using FixIt.Models.Models.Employee;
using FixIt.Models.Models.Job;
using FixIt.Models.Models.JobStatus;
using FixIt.Models.Models.Payment;
using FixIt.Models.Models.PaymentType;
using FixIt.Models.Models.Profession;
using FixIt.Models.Models.Service;
using FixIt.Models.Models.ServiceRating;
using FixIt.Models.Models.ServiceRequest;
using FixIt.Models.Models.ServiceType;
using FixIt.Models.Models.Sex;
using FixIt.Models.Models.User;

namespace FixIt.Mapping
{
    public class FixItProfile : Profile
    {
        public FixItProfile()
        {
            //user
            CreateMap<User, UserViewModel>();
            CreateMap<UserUpdateModel, User>();

            //service
            CreateMap<Service, ServiceViewModel>();
            CreateMap<ServiceInsertModel, Service>();
            CreateMap<ServiceUpdateModel, Service>();

            //service type
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

            //job status
            CreateMap<JobStatus, JobStatusViewModel>();

            //service rating
            CreateMap<ServiceRating, ServiceRatingViewModel>();
            CreateMap<ServiceRatingInsertModel, ServiceRating>();
            CreateMap<ServiceRatingUpdateModel, ServiceRating>();

            //payment
            CreateMap<Payment, PaymentViewModel>();
            CreateMap<PaymentInsertModel, Payment>();

            //Service request
            CreateMap<ServiceRequest, ServiceRequestViewModel>();
            CreateMap<ServiceRequestInsertModel, ServiceRequest>();

            //job
            CreateMap<Job, JobViewModel>();
            CreateMap<JobInsertModel, Job>();
            CreateMap<JobUpdateModel, Job>();
        }
    }
}
