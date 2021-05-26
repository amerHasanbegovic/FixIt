using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Models.Models.Profession;

namespace FixIt.Services.Services
{
    public class ProfessionService : BaseCRUDService<Profession, ProfessionViewModel, object, object>
    {
        public ProfessionService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
    }
}
