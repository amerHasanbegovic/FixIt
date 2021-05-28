using FixIt.Models.Models.Employee;

namespace FixIt.Services.Interfaces
{
    public interface IEmployeeService : IBaseCRUDService<EmployeeViewModel, EmployeeInsertModel, EmployeeUpdateModel, EmployeeSearchModel>
    {
    }
}
