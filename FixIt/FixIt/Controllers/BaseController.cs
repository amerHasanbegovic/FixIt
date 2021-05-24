using FixIt.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FixIt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TMap, TInsert> : ControllerBase
    {
        protected readonly IBaseCRUDService<TMap, TInsert> _service;

        public BaseController(IBaseCRUDService<TMap, TInsert> service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<TMap> Get()
        {
            return _service.Get();
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
    }
}
