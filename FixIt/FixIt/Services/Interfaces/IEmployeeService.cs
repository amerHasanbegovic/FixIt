using FixIt.Models.Models.Employee;
using System.Threading.Tasks;

namespace FixIt.Services.Interfaces
{
    public interface IEmployeeService : IBaseCRUDService<EmployeeViewModel, EmployeeInsertModel, EmployeeUpdateModel, EmployeeSearchModel>
    {
        Task Delete(int id);
    }
}
