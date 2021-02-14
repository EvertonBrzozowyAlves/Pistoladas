using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pistoladas.Business.User;
using Pistoladas.Models.Entities.User;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Pistoladas.API.Controllers
{
    /// <summary>
    /// Route to work with users.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IUserBusiness _userBusiness;

        /// <inheritdoc />
        public UsersController(ILogger<UsersController> logger, IUserBusiness userBusiness)
        {
            _logger = logger;
            _userBusiness = userBusiness;
        }

        /// <summary>
        /// List all active users
        /// </summary>
        /// <response code="200">Successfully listed the users.</response>
        /// <response code="500">Oops! Can't list all users right now.</response>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        [ProducesResponseType(typeof(IEnumerable<UserModel>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAllActive()
        {
            try
            {
                var users =  await _userBusiness.GetAllActiveAsync();
                return Ok(JsonSerializer.Serialize(users));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
        
        
    }
}
