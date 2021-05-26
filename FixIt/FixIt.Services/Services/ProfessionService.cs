using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Models.Models.Profession;
using FixIt.Services.Interfaces;

namespace FixIt.Services.Services
{
    public class ProfessionService : BaseCRUDService<Profession, ProfessionViewModel, object, object>, IProfessionService
    {
        public ProfessionService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
    }
}
