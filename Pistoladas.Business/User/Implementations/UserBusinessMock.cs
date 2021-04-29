using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Pistoladas.Models.Entities.MethodModels.UserModel;

namespace Pistoladas.Business.User.Implementations
{
    public class UserBusinessMock : IUserBusiness
    {
        public Task<UserGetByIdResponse> GetById(UserGetByIdRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UsersGetAllActiveResponse>> GetAllActive(UsersGetAllActiveRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<UserAddResponse> Add(UserAddRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<UsersGetActiveCountResponse> GetActiveCount(UsersGetActiveCountRequest request)
        {
            throw new NotImplementedException();
        }

        public long ActiveUsersSimpleMajority(long currentActiveUsersCount)
        {
            throw new NotImplementedException();
        }
    }
}
