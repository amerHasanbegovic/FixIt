using FixIt.Models.Models.Service;
using FixIt.Models.Models.User;
using FixIt.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FixIt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController
    {
        protected readonly IUserService _service;
        protected readonly IRecommendService<ServiceViewModel> _recommendService;
        public UserController(IUserService service, IRecommendService<ServiceViewModel> recommendService)
        {
            _service = service;
            _recommendService = recommendService;
        }

        [HttpGet]
        public IEnumerable<UserViewModel> Get([FromQuery] UserSearchModel model = null)
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

        [HttpGet("{id}/recommend")]
        public async Task<IEnumerable<ServiceViewModel>> Recommend(string id)
        {
            return await _recommendService.Recommend(id);
        }
    }
}
