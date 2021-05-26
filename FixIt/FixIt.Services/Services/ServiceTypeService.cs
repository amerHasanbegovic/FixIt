﻿using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Models.Models.ServiceType;
using FixIt.Services.Interfaces;

namespace FixIt.Services.Services
{
    public class ServiceTypeService : BaseCRUDService<ServiceType, ServiceTypeViewModel, ServiceTypeInsertModel, ServiceTypeUpdateModel>, IServiceTypeService
    {
        public ServiceTypeService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
    }
}