using AutoMapper;
using FixIt.Database;
using FixIt.Database.Models;
using FixIt.Models.Models.ServiceRating;
using FixIt.Services.Interfaces;
using System.Linq;

namespace FixIt.Services.Services
{
    public class ServiceRatingService : BaseCRUDService<ServiceRating, ServiceRatingViewModel, ServiceRatingInsertModel, ServiceRatingUpdateModel, object>, IServiceRatingService
    {
        public ServiceRatingService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
        public override ServiceRatingViewModel Insert(ServiceRatingInsertModel model)
        {
            var entity = _mapper.Map<ServiceRating>(model);

            CalculateRating(entity, model.Rating);

            return _mapper.Map<ServiceRatingViewModel>(entity);
        }

        private void CalculateRating(ServiceRating entity, int rating)
        {
            //service
            var service = _applicationDbContext.Set<Service>().Find(entity.ServiceId);
            
            //if user has already rated the service
            var exists = _applicationDbContext.Set<ServiceRating>()
                .FirstOrDefault(x => x.UserId == entity.UserId && x.ServiceId == service.Id);
            if (exists != null)
            {
                exists.Rating = rating;
                _applicationDbContext.Update(exists);
                _applicationDbContext.SaveChanges();
            }
            else
            {
                _applicationDbContext.Add(entity);
                _applicationDbContext.SaveChanges();
            }

            //calculate rating for specific service
            double sum = 0;
            int count = 0;
            foreach (var x in _applicationDbContext.Set<ServiceRating>())
                if (x.ServiceId == entity.ServiceId)
                {
                    sum += x.Rating;
                    count++;
                }
            service.Rating = sum / count;
            _applicationDbContext.Update(service);
            _applicationDbContext.SaveChanges();
        }
    }
}
