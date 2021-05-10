using System;
using Pistoladas.Data.User;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Pistoladas.Models.Entities.MethodModels.User;

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

        public async Task<GetByIdResponse> GetById(GetByIdRequest request)
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

        public async Task<IEnumerable<GetAllActiveResponse>> GetAllActive(GetAllActiveRequest request)
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

        public async Task<AddResponse> Add(AddRequest request)
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

        public async Task<GetActiveCountResponse> GetActiveCount(GetActiveCountRequest request)
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

        public long ActiveUsersSimpleMajority(long currentActiveUsersCount)
        {
            return currentActiveUsersCount / 2 + 1;
        }
    }
}
