using System;
using Microsoft.AspNetCore.Mvc;
using Pistoladas.Business.User;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Pistoladas.Models.Entities.MethodModels.UserModel;

namespace Pistoladas.API.Controllers
{
    /// <summary>
    /// Route to work with users.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserBusiness _business;
        private readonly ILogger<UsersController> _logger;

        /// <inheritdoc />
        public UsersController(IUserBusiness business, ILogger<UsersController> logger)
        {
            _business = business;
            _logger = logger;
        }
        
        /// <summary>
        /// Get User by Id
        /// </summary>
        /// <response code="200">Successfully found the user.</response>
        /// <response code="500">Oops! Can't find the user right now.</response>
        /// <returns></returns>
        [ProducesResponseType(typeof(UserGetByIdResponse), 200)]
        [ProducesResponseType(500)]
        [HttpGet]
        [Route("{UserId}")]
        public async Task<ActionResult<UserGetByIdResponse>> GetById([FromRoute] UserGetByIdRequest request)
        {
            try
            {
                var businessResponse =  await _business.GetById(request);
                return Ok(businessResponse);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return StatusCode((int)HttpStatusCode.InternalServerError, e);
            }
        }

        /// <summary>
        /// List all active users
        /// </summary>
        /// <response code="200">Successfully listed the users.</response>
        /// <response code="500">Oops! Can't list all users right now.</response>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        [ProducesResponseType(typeof(IEnumerable<UsersGetAllActiveResponse>), 200)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<IEnumerable<UsersGetAllActiveResponse>>> GetAllActive([FromRoute] UsersGetAllActiveRequest request)
        {
            try
            {
                var businessResponse = await _business.GetAllActive(request);
                return Ok(businessResponse);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return StatusCode((int)HttpStatusCode.InternalServerError, e);
            }
        }
        
        /// <summary>
        /// Add new User
        /// </summary>
        /// <response code="200">Successfully registered the user.</response>
        /// <response code="500">Oops! Can't register a user right now.</response>
        /// <returns></returns>
        [ProducesResponseType(typeof(UserGetByIdResponse), 200)]
        [ProducesResponseType(500)]
        [HttpGet]
        [Route("{UserId}")]
        public async Task<ActionResult<UserAddResponse>> Add([FromRoute] UserAddRequest request)
        {
            try
            {
                var businessResponse =  await _business.Add(request);
                return Ok(businessResponse);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return StatusCode((int)HttpStatusCode.InternalServerError, e);
            }
        }
    }
}
