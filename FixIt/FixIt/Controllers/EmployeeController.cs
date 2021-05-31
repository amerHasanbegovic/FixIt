using FixIt.Data;
using FixIt.Models.Models.Employee;
using FixIt.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FixIt.Controllers
{
    public class EmployeeController : BaseController<EmployeeViewModel, EmployeeInsertModel, EmployeeUpdateModel, EmployeeSearchModel>
    {
        protected readonly ApplicationDbContext _applicationDbContext;
        protected readonly IEmployeeService employeeService;
        public EmployeeController(IEmployeeService service, ApplicationDbContext applicationDbContext) : base(service)
        {
            _applicationDbContext = applicationDbContext;
            employeeService = service;
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await employeeService.Delete(id);
        }
    }
}
