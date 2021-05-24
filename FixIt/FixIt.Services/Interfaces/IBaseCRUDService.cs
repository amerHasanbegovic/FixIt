using System.Collections.Generic;

namespace FixIt.Services.Interfaces
{
    public interface IBaseCRUDService<TMap>
    {
        IEnumerable<TMap> Get();
        TMap GetById(int id);
        //TMap Insert();
        //TMap Update(int id)
    }
}
