using AutoMapper;
using FixIt.Data;
using FixIt.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FixIt.Services.Services
{
    public class BaseCRUDService<T> : IBaseCRUDService<T> where T : class
    {
        protected ApplicationDbContext _applicationDbContext;
        protected IMapper _mapper;

        public BaseCRUDService(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }

        public virtual IEnumerable<T> Get()
        {
            //mapper
            return _applicationDbContext.Set<T>().ToList();
        }

        public virtual T GetById(int id)
        {
            return _applicationDbContext.Set<T>().Find(id);
            //mapper
        }
    }
}
