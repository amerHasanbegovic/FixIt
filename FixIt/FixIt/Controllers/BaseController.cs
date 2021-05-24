using FixIt.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FixIt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TMap> : ControllerBase
    {
        protected readonly IBaseCRUDService<TMap> _service;

        public BaseController(IBaseCRUDService<TMap> service)
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
    }
}
