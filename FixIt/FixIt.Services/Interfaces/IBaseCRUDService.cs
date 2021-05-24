using System.Collections.Generic;

namespace FixIt.Services.Interfaces
{
    public interface IBaseCRUDService<TMap>
    {
        IEnumerable<TMap> Get();
        TMap GetById(int id);
        //T Insert();
        //T Update(int id)
        //T Delete(int id)
    }
}
