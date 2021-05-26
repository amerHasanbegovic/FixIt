using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;

namespace FixIt.Services.Services
{
    public class CityService : BaseCRUDService<City, CityService, object, object>
    {
        public CityService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
    }
}
