using AutoMapper;
using FixIt.Database;
using FixIt.Database.Models;
using FixIt.Models.Models.User;
using FixIt.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FixIt.Services.Services
{
    public class UserService : IUserService
    {
        protected readonly ApplicationDbContext _applicationDbContext;
        protected readonly IMapper _mapper;
        public UserService(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }

        public IEnumerable<UserViewModel> Get(UserSearchModel model = null)
        {
            var res = _applicationDbContext.Set<User>().AsQueryable();

            if (!string.IsNullOrEmpty(model.FirstOrLastName))
                res = res.Where(x => x.Firstname.ToLower().Contains(model.FirstOrLastName.ToLower())
                    || x.Lastname.ToLower().Contains(model.FirstOrLastName.ToLower()));

            if (model?.RegisterDateFrom != null && model?.RegisterDateTo == null)
                res = res.Where(x => x.MemberSince >= model.RegisterDateFrom);

            if (model?.RegisterDateTo != null && model?.RegisterDateFrom == null)
                res = res.Where(x => x.MemberSince <= model.RegisterDateTo);

            if (model?.RegisterDateFrom != null && model?.RegisterDateTo != null)
                res = res.Where(x => x.MemberSince >= model.RegisterDateFrom && x.MemberSince <= model.RegisterDateTo);

            res = res.Where(x => x.Email != null);
            var list = res.ToList();
            return _mapper.Map<IEnumerable<UserViewModel>>(list);
        }

        public UserViewModel GetById(string id)
        {
            var res = _applicationDbContext.Set<User>()
                .Include(x => x.City)
                .Include(x => x.Sex)
                .Include(x => x.ServiceRequests).ThenInclude(x => x.Service)
                .Include(x => x.ServiceRequests).ThenInclude(x => x.Payment).ThenInclude(x => x.PaymentType)
                .FirstOrDefault(x => x.Id == id);
            return _mapper.Map<UserViewModel>(res);
        }

        public UserViewModel Update(string id, UserUpdateModel model)
        {
            var entity = _applicationDbContext.Set<User>().Find(id);
            _mapper.Map(model, entity);
            _applicationDbContext.SaveChanges();
            return _mapper.Map<UserViewModel>(entity);
        }
    }
}
