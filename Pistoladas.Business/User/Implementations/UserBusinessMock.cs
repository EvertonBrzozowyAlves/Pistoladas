using Pistoladas.Models.Entities.User;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pistoladas.Business.User.Implementations
{
    public class UserBusinessMock : IUserBusiness
    {
        public Task<IEnumerable<UserModel>> GetAllActiveAsync()
        {
            throw new NotImplementedException();
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
