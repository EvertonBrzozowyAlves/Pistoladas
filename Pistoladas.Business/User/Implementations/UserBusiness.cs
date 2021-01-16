using Pistoladas.Data.User;
using Pistoladas.Models.Entities.User;
using System.Collections.Generic;

namespace Pistoladas.Business.User.Implementations
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserData _userData;
        public UserBusiness(IUserData userData)
        {
            _userData = userData;
        }

        public IEnumerable<UserModel> GetAllActive()
        {
            return _userData.GetAllActive();
        }

        public UserModel GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
