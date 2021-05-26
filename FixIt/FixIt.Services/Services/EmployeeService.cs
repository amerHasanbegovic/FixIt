using AutoMapper;
using FixIt.Data;
using FixIt.Data.Models;
using FixIt.Models.Models.Employee;
using FixIt.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FixIt.Services.Services
{
    public class EmployeeService : BaseCRUDService<Employee, EmployeeViewModel, EmployeeInsertModel, EmployeeUpdateModel>, IEmployeeService
    {
        public EmployeeService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }
        public override IEnumerable<EmployeeViewModel> Get()
        {
            var res = _applicationDbContext.Set<Employee>()
                .Include(x => x.City)
                .Include(x => x.Profession)
                .Include(x => x.Sex)
                .ToList();
            return _mapper.Map<IEnumerable<EmployeeViewModel>>(res);
        }
        public override EmployeeViewModel GetById(int id)
        {
            var res = _applicationDbContext.Set<Employee>()
                .Include(x => x.City)
                .Include(x => x.Profession)
                .Include(x => x.Sex)
                .FirstOrDefault(x => x.Id == id);
            return _mapper.Map<EmployeeViewModel>(res);
        }
    }
}
