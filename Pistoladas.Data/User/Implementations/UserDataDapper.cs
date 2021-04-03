﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Pistoladas.Data.Providers.Dapper;
using Pistoladas.Models.Entities.MethodModels.UserModel;
using Pistoladas.Models.Exceptions.User;

namespace Pistoladas.Data.User.Implementations
{
    public class UserDataDapper : DataBaseOperationsDapper, IUserData
    {
        private readonly ILogger<UserDataDapper> _logger;
        public UserDataDapper(ILogger<UserDataDapper> logger)
        {
            _logger = logger;
        }
        
        public async Task<UserGetByIdResponse> GetById(UserGetByIdRequest request)
        {
            try
            {
                var databaseResponse =
                    await GetSingleOrDefaultAsync<UserGetByIdResponse>($"PROC_USERS_{nameof(GetById)}", request);
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

        public async Task<IEnumerable<UsersGetAllActiveResponse>> GetAllActive(UsersGetAllActiveRequest request)
        {
            try
            {
                return await ListAsync<UsersGetAllActiveResponse>($"PROC_USERS_{nameof(GetAllActive)}", request);
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
                await ExecuteNonQueryAsync($"PROC_USERS_{nameof(Add)}", request);
                return new UserAddResponse();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
        }
    }
}