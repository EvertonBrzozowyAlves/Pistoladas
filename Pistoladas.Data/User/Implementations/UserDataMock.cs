using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Pistoladas.Models.Entities.MethodModels.UserModel;

namespace Pistoladas.Data.User.Implementations
{
    public class UserDataMock : IUserData
    {
        public Task<UserGetByIdResponse> GetById(UserGetByIdRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UsersGetAllActiveResponse>> GetAllActive(UsersGetAllActiveRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
