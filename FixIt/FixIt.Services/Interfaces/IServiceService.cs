using FixIt.Models.Models.Service;
using System.Threading.Tasks;

namespace FixIt.Services.Interfaces
{
    public interface IServiceService : IBaseCRUDService<ServiceViewModel, ServiceInsertModel, ServiceUpdateModel, ServiceSearchModel>
    {
        Task Delete(int id);
    }
}
