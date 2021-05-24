using System.Collections.Generic;

namespace FixIt.Services.Interfaces
{
    public interface IBaseCRUDService<TMap, TInsert>
    {
        IEnumerable<TMap> Get();
        TMap GetById(int id);
        TMap Insert(TInsert model);
        //TMap Update(int id)
    }
}
