using Pistoladas.Models.Entities.User;
using System.Collections.Generic;
using System.Threading.Tasks;
using Pistoladas.Data.Providers.Dapper;

namespace Pistoladas.Data.User.Implementations
{
    public class UserDataDapper : DataBaseOperationsDapper<UserModel>, IUserData
    {
        public async Task<IEnumerable<UserModel>> GetAllActiveAsync()
        {
            return await ListAsync("PROC_USERS_List");
        }

        public async Task<UserModel> GetByIdAsync(int id)
        {
            return await GetSingleOrDefaultAsync("PROC_USERS_GetById", new UserGetByIdRequestModel {UserId = id});
        }
        
        public async Task<long> Update(UserUpdateRequestModel model)
        {
            return await ExecuteNonQueryAsync("PROC_USERS_Update", model);
        }
    }
}