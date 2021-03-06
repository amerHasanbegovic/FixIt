using AutoMapper;
using FixIt.Database;
using FixIt.Database.Models;
using FixIt.Models.Models.Employee;
using FixIt.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FixIt.Services.Services
{
    public class EmployeeService : BaseCRUDService<Employee, EmployeeViewModel, EmployeeInsertModel, EmployeeUpdateModel, EmployeeSearchModel>, IEmployeeService
    {
        public EmployeeService(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext, mapper)
        {
        }

        public async Task Delete(int id)
        {
            var entity = _applicationDbContext.Set<Employee>().Find(id);
            _applicationDbContext.Remove(entity);
            await _applicationDbContext.SaveChangesAsync();
        }

        public override IEnumerable<EmployeeViewModel> Get(EmployeeSearchModel model = null)
        {
            var query = _applicationDbContext.Set<Employee>().AsQueryable();

            if (!string.IsNullOrEmpty(model?.FirstOrLastName))
                query = query.Where(x => x.Firstname.ToLower().Contains(model.FirstOrLastName.ToLower())
                || x.Lastname.ToLower().Contains(model.FirstOrLastName.ToLower()));

            if (model?.ProfessionId != 0)
                query = query.Where(x => x.ProfessionId == model.ProfessionId);

            var res = query
                .Include(x => x.Profession)
                .ToList();

            return _mapper.Map<IEnumerable<EmployeeViewModel>>(res);
        }
        public override EmployeeViewModel GetById(int id)
        {
            var res = _applicationDbContext.Set<Employee>()
                .Include(x => x.City)
                .Include(x => x.Profession)
                .Include(x => x.Sex)
                .Include(x => x.Jobs).ThenInclude(x => x.ServiceRequest).ThenInclude(x => x.Service)
                .Include(x => x.Jobs).ThenInclude(x => x.Status)
                .FirstOrDefault(x => x.Id == id);
            return _mapper.Map<EmployeeViewModel>(res);
        }
    }
}
