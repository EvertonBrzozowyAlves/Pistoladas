using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Pistoladas.Data.Providers.Dapper;
using Pistoladas.Models.Entities.MethodModels.User;
using Pistoladas.Models.Exceptions.User;

namespace Pistoladas.Data.User.Implementations
{
    public class UserData : DataBaseOperationsDapper, IUserData
    {
        private readonly ILogger<UserData> _logger;
        public UserData(ILogger<UserData> logger)
        {
            _logger = logger;
        }
        
        public async Task<GetByIdResponse> GetById(GetByIdRequest request)
        {
            try
            {
                var databaseResponse = await GetSingleOrDefaultAsync<GetByIdResponse>($"PROC_USERS_{nameof(GetById)}", request);
                if (databaseResponse == null)
                {
                    throw new UserNotFoundException();
                }

                return databaseResponse;
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
                return await ListAsync<GetAllActiveResponse>($"PROC_USERS_{nameof(GetAllActive)}", request);
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
                await ExecuteNonQueryAsync($"PROC_USERS_{nameof(Add)}", request);
                return new AddResponse();
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
                return await GetSingleOrDefaultAsync<GetActiveCountResponse>($"PROC_USERS_{nameof(GetActiveCount)}", request);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
        }
    }
}