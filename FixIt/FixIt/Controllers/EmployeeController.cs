using FixIt.Models.Models.Employee;
using FixIt.Services.Interfaces;

namespace FixIt.Controllers
{
    public class EmployeeController : BaseController<EmployeeViewModel, EmployeeInsertModel, EmployeeUpdateModel>
    {
        public EmployeeController(IBaseCRUDService<EmployeeViewModel, EmployeeInsertModel, EmployeeUpdateModel> service) : base(service)
        {
        }
    }
}
