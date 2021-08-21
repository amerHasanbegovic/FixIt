using System.Collections.Generic;
using System.Threading.Tasks;

namespace FixIt.Services.Interfaces
{
    public interface IRecommendService<T> where T : class
    {
        Task<List<T>> Recommend(string userId);
    }
}
