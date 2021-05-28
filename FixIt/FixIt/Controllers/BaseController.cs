using FixIt.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FixIt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TMap, TInsert, TUpdate, TSearch> : ControllerBase
    {
        protected readonly IBaseCRUDService<TMap, TInsert, TUpdate, TSearch> _service;

        public BaseController(IBaseCRUDService<TMap, TInsert, TUpdate, TSearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<TMap> Get([FromQuery] TSearch search)
        {
            return _service.Get(search);
        }

        [HttpGet("{id}")]
        public TMap GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public TMap Insert(TInsert model)
        {
            return _service.Insert(model);
        }

        [HttpPut("{id}")]
        public TMap Update(int id, TUpdate model)
        {
            return _service.Update(id, model);
        }
    }
}
