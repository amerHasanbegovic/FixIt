using AutoMapper;
using FixIt.Database;
using FixIt.Database.Models;
using FixIt.Models.Models.Service;
using FixIt.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FixIt.Services.Services
{
    public class RecommendService : IRecommendService<ServiceViewModel>
    {
        private ApplicationDbContext _applicationDbContext;
        private IMapper _mapper;

        public RecommendService(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }
        public async Task<List<ServiceViewModel>> Recommend(string userId)
        {
            var userServiceRatings = await _applicationDbContext.ServiceRatings
                .Where(x => x.UserId.Equals(userId)).ToListAsync();

            var recommendedServices = new List<Tuple<double, Service>>();

            var reviewList1 = new List<ServiceRating>();
            var reviewList2 = new List<ServiceRating>();

            foreach (var rating in userServiceRatings)
            {
                var currentServiceReviews = await _applicationDbContext.ServiceRatings
                    .Where(s => s.ServiceId == rating.ServiceId).ToListAsync();
                var serviceReviews = await GetReviews(rating.ServiceId);

                foreach (var review in serviceReviews)
                {
                    foreach (var currentReview in currentServiceReviews)
                    {
                        if (review.Value.Where(x => x.UserId.Equals(currentReview.UserId)).Count() > 0)
                        {
                            reviewList1.Add(currentReview);
                            reviewList2.Add(review.Value.Where(x => x.UserId.Equals(currentReview.UserId)).FirstOrDefault());
                        }
                    }

                    double similarity = GetSimilarity(reviewList1, reviewList2);
                    if (similarity > 0.5)
                    {
                        var service = await _applicationDbContext.Services
                            .Include(x => x.ServiceType)
                            .Where(x => x.Id == review.Key)
                            .FirstOrDefaultAsync();

                        recommendedServices.Add(new Tuple<double, Service>(similarity, service));
                    }
                    reviewList1.Clear();
                    reviewList2.Clear();
                }
            }

            var query = recommendedServices.Distinct().Take(3).OrderBy(x => x.Item1).Select(x => x.Item2).AsQueryable();
            var result = query.ToList();
            return _mapper.Map<List<ServiceViewModel>>(result);
        }

        private double GetSimilarity(List<ServiceRating> reviewList1, List<ServiceRating> reviewList2)
        {
            if (reviewList1.Count() == reviewList2.Count())
            {
                double numerator = 0, denominator1 = 0, denominator2 = 0;
                for (int i = 0; i < reviewList1.Count; i++)
                {
                    numerator += reviewList1[i].Rating * reviewList2[i].Rating;
                    denominator1 += Math.Pow(reviewList1[i].Rating, 2);
                    denominator2 += Math.Pow(reviewList2[i].Rating, 2);
                }
                denominator1 = Math.Sqrt(denominator1);
                denominator2 = Math.Sqrt(denominator2);

                double denominator = denominator1 * denominator2;
                if (denominator == 0) return 0;

                return numerator / denominator;
            }
            return 0;
        }

        private async Task<Dictionary<int, List<ServiceRating>>> GetReviews(int serviceId)
        {
            var serviceDictionary = new Dictionary<int, List<ServiceRating>>();
            var services = await _applicationDbContext.Services
                .Where(x => x.Id != serviceId).ToListAsync();

            foreach (var service in services)
            {
                var serviceReviews = await _applicationDbContext.ServiceRatings
                    .Where(x => x.ServiceId == service.Id)
                    .OrderBy(y => y.UserId)
                    .ToListAsync();

                if (serviceReviews != null)
                    serviceDictionary.Add(service.Id, serviceReviews);
            }
            return serviceDictionary;
        }
    }
}
