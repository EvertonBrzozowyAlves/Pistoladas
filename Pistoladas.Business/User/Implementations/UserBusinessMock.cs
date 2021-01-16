using Pistoladas.Models.Entities.User;
using System;
using System.Collections.Generic;

namespace Pistoladas.Business.User.Implementations
{
    public class UserBusinessMock : IUserBusiness
    {
        public IEnumerable<UserModel> GetAllActive()
        {
            throw new NotImplementedException();
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
