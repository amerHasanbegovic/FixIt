using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Models.Models.Sex;
using FixIt.Services.Interfaces;

namespace FixIt.Services.Services
{
    public class SexService : BaseCRUDService<Sex, SexViewModel, object, object, object>, ISexService
    {
        public SexService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
    }
}
