using System;
using Microsoft.AspNetCore.Mvc;
using Pistoladas.Business.User;
using System.Collections.Generic;
using Pistoladas.Models.Entities.MethodModels.UserModel;
using Pistoladas.Models.Interfaces;

namespace Pistoladas.API.Controllers
{
    /// <summary>
    /// Route to work with users.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase, IUser
    {
        private readonly IUserBusiness _business;

        /// <inheritdoc />
        public UsersController(IUserBusiness business)
        {
            _business = business;
        }
        
        /// <summary>
        /// Get User by Id
        /// </summary>
        /// <response code="200">Successfully listed the users.</response>
        /// <response code="500">Oops! Can't list all users right now.</response>
        /// <returns></returns>
        [ProducesResponseType(typeof(UserGetByIdResponse), 200)]
        [ProducesResponseType(500)]
        [HttpGet]
        [Route("{id}")]
        public UserGetByIdResponse GetById([FromRoute] UserGetByIdRequest request)
        {
            try
            {
                return _business.GetById(request);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
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
        [ProducesResponseType(typeof(IEnumerable<UserGetByIdResponse>), 200)]
        [ProducesResponseType(500)]
        public IEnumerable<UsersGetAllActiveResponse> GetAllActive([FromRoute] UsersGetAllActiveRequest request)
        {
            try
            {
                return _business.GetAllActive(request);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
