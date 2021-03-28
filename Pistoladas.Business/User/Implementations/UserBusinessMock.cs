using System;
using System.Collections.Generic;
using Pistoladas.Models.Entities.MethodModels.UserModel;

namespace Pistoladas.Business.User.Implementations
{
    public class UserBusinessMock : IUserBusiness
    {
        public UserGetByIdResponse GetById(UserGetByIdRequest request)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsersGetAllActiveResponse> GetAllActive(UsersGetAllActiveRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
