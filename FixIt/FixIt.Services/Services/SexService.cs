using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Models.Models.Sex;

namespace FixIt.Services.Services
{
    public class SexService : BaseCRUDService<Sex, SexViewModel, object, object>
    {
        public SexService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
    }
}
