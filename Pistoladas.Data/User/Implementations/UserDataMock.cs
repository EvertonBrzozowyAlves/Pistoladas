using System.Collections.Generic;
using Pistoladas.Models.Entities.MethodModels.UserModel;

namespace Pistoladas.Data.User.Implementations
{
    public class UserDataMock : IUserData
    {
        public UserGetByIdResponse GetById(UserGetByIdRequest request)
        {
            return new()
            {
                Email = "teste@gmail.com",
                Name = "Teste",
                MobilePhone = "987654321",
                UserId = 1
            };
        }

        public IEnumerable<UsersGetAllActiveResponse> GetAllActive(UsersGetAllActiveRequest request)
        {
            return new List<UsersGetAllActiveResponse>()
            {
                new UsersGetAllActiveResponse()
                {

                },
                new UsersGetAllActiveResponse()
                {

                },
            };
        }
    }
}
