using System.Collections.Generic;
using System.Threading.Tasks;
using Pistoladas.Models.Entities.MethodModels.UserModel;

namespace Pistoladas.Models.Interfaces
{
    public interface IUser
    {
        Task<UserGetByIdResponse> GetById(UserGetByIdRequest request);
        Task<IEnumerable<UsersGetAllActiveResponse>> GetAllActive(UsersGetAllActiveRequest request);
        Task<UserAddResponse> Add(UserAddRequest request);
        Task<UsersGetActiveCountResponse> GetActiveCount(UsersGetActiveCountRequest request);


    }
}