using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Models.Models.Employee;
using FixIt.Services.Interfaces;

namespace FixIt.Services.Services
{
    public class EmployeeService : BaseCRUDService<Employee, EmployeeViewModel, EmployeeInsertModel, EmployeeUpdateModel>, IEmployeeService
    {
        public EmployeeService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
    }
}
