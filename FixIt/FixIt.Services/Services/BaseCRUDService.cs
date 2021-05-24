using AutoMapper;
using FixIt.Data;
using FixIt.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FixIt.Services.Services
{
    public class BaseCRUDService<T, TMap, TInsert> : IBaseCRUDService<TMap, TInsert> where T: class where TMap: class where TInsert: class
    {
        protected ApplicationDbContext _applicationDbContext;
        protected IMapper _mapper;

        public BaseCRUDService(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }

        public virtual IEnumerable<TMap> Get()
        {
            var res = _applicationDbContext.Set<T>().ToList();
            return _mapper.Map<IEnumerable<TMap>>(res);
        }

        public virtual TMap GetById(int id)
        {
            var res = _applicationDbContext.Set<T>().Find(id);
            return _mapper.Map<TMap>(res);
        }

        public virtual TMap Insert(TInsert model)
        {
            var entity = _mapper.Map<T>(model);
            _applicationDbContext.Add(entity);
            _applicationDbContext.SaveChanges();
            return _mapper.Map<TMap>(entity);
        }
    }
}
