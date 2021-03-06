using System.Collections.Generic;

namespace FixIt.Services.Interfaces
{
    public interface IBaseCRUDService<TMap, TInsert, TUpdate, TSearch>
    {
        IEnumerable<TMap> Get(TSearch search);
        TMap GetById(int id);
        TMap Insert(TInsert model);
        TMap Update(int id, TUpdate model);
    }
}
