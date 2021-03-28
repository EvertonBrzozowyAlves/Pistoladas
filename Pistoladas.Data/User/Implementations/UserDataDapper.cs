using Pistoladas.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Pistoladas.Data.Providers.Dapper;
using Pistoladas.Models.Entities.MethodModels.UserModel;

namespace Pistoladas.Data.User.Implementations
{
    public class UserDataDapper : DataBaseOperationsDapper, IUserData
    {
        public UserGetByIdResponse GetById(UserGetByIdRequest request)
        {
            return GetSingleOrDefaultAsync<UserGetByIdResponse>($"PROC_USERS_{nameof(GetById)}", request).Result;
        }

        public IEnumerable<UsersGetAllActiveResponse> GetAllActive(UsersGetAllActiveRequest request)
        {
            return ListAsync<UsersGetAllActiveResponse>($"PROC_USERS_{nameof(GetAllActive)}", request).Result;
        }
    }
}