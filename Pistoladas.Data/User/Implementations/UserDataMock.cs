using Pistoladas.Models.Entities.User;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pistoladas.Data.User.Implementations
{
    public class UserDataMock : IUserData
    {
        public async Task<IEnumerable<UserModel>> GetAllActiveAsync()
        {
            var users = new List<UserModel>
            {
                new UserModel("Teste", "teste@gmail.com", "987654321"),
                new UserModel("Teste20", "teste@gmail.com", "123456789"),
                new UserModel("Teste30", "teste@gmail.com", "123789456"),
                new UserModel("Teste40", "teste@gmail.com", "321654987"),
            };
            return users;
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
