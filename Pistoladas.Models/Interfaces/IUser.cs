using System.Collections.Generic;
using Pistoladas.Models.Entities.MethodModels.UserModel;

namespace Pistoladas.Models.Interfaces
{
    public interface IUser
    {
        UserGetByIdResponse GetById(UserGetByIdRequest request);
        IEnumerable<UsersGetAllActiveResponse> GetAllActive(UsersGetAllActiveRequest request);
    }
}