using System.Collections.Generic;

namespace FixIt.Services.Interfaces
{
    public interface IBaseCRUDService<T>
    {
        IEnumerable<T> Get();
        T GetById(int id);
        //T Insert();
        //T Update(int id)
        //T Delete(int id)
    }
}
