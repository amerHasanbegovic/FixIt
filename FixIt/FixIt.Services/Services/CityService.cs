using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Models.Models.City;
using FixIt.Services.Interfaces;

namespace FixIt.Services.Services
{
    public class CityService : BaseCRUDService<City, CityViewModel, object, object, object>, ICityService
    {
        public CityService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
    }
}
