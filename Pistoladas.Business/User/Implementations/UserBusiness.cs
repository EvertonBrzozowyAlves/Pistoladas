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
        private readonly IUserData _data;
        private readonly ILogger<UserBusiness> _logger;
        public UserBusiness(IUserData data, ILogger<UserBusiness> logger)
        {
            _data = data;
            _logger = logger;
        }

        public async Task<UserGetByIdResponse> GetById(UserGetByIdRequest request)
        {
            try
            {            
                return await _data.GetById(request);
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
                return await _data.GetAllActive(request);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
        }

        public async Task<UserAddResponse> Add(UserAddRequest request)
        {
            try
            {
                return await _data.Add(request);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
        }

        public async Task<UsersGetActiveCountResponse> GetActiveCount(UsersGetActiveCountRequest request)
        {
            try
            {
                return await _data.GetActiveCount(request);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
        }
    }
}
