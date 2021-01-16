using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pistoladas.Business.User;
using Pistoladas.Models.Entities.User;
using System.Collections.Generic;
using System.Text.Json;

namespace Pistoladas.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IUserBusiness _userBusiness;

        public UsersController(ILogger<UsersController> logger, IUserBusiness userBusiness)
        {
            _logger = logger;
            _userBusiness = userBusiness;
        }

        [HttpGet]
        [Route("")]
        public string GetAllActive()
        {
            IEnumerable<UserModel> users =  _userBusiness.GetAllActive();
            return JsonSerializer.Serialize(users);
        }
    }
}
