using Pistoladas.Data.User;
using System.Collections.Generic;
using Pistoladas.Models.Entities.MethodModels.UserModel;

namespace Pistoladas.Business.User.Implementations
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserData _userData;
        public UserBusiness(IUserData userData)
        {
            _userData = userData;
        }

        public UserGetByIdResponse GetById(UserGetByIdRequest request)
        {
            return _userData.GetById(request);
        }

        public IEnumerable<UsersGetAllActiveResponse> GetAllActive(UsersGetAllActiveRequest request)
        {
            return _userData.GetAllActive(request);
        }
    }
}
