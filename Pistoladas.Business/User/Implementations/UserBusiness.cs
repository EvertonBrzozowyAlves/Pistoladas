using System;
using Pistoladas.Data.User;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Pistoladas.Models.Entities.MethodModels.UserModel;

namespace Pistoladas.Business.User.Implementations
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserData _userData;
        private readonly ILogger<UserBusiness> _logger;
        public UserBusiness(IUserData userData, ILogger<UserBusiness> logger)
        {
            _userData = userData;
            _logger = logger;
        }

        public async Task<UserGetByIdResponse> GetById(UserGetByIdRequest request)
        {
            try
            {            
                return await _userData.GetById(request);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
        }

        public async Task<IEnumerable<UsersGetAllActiveResponse>> GetAllActive(UsersGetAllActiveRequest request)
        {
            try
            {
                return await _userData.GetAllActive(request);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
        }
    }
}
