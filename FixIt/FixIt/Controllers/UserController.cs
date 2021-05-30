using FixIt.Models.Models.User;
using FixIt.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FixIt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController
    {
        protected readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<UserViewModel> Get(UserSearchModel model = null)
        {
            return _service.Get(model);
        }

        [HttpGet("{id}")]
        public UserViewModel GetById(string id)
        {
            return _service.GetById(id);
        }
        
        [HttpPut("{id}")]
        public UserViewModel Update(string id, UserUpdateModel model)
        {
            return _service.Update(id, model);
        }
    }
}
