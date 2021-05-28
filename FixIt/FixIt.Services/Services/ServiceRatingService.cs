using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Models.Models.ServiceRating;
using FixIt.Services.Interfaces;

namespace FixIt.Services.Services
{
    public class ServiceRatingService : BaseCRUDService<ServiceRating, ServiceRatingViewModel, ServiceRatingInsertModel, ServiceRatingUpdateModel, object>, IServiceRatingService
    {
        public ServiceRatingService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
    }
}
