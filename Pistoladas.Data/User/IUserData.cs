using Pistoladas.Models.Entities.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pistoladas.Data.User
{
    public interface IUserData
    {
        Task <IEnumerable<UserModel>> GetAllActiveAsync();
        Task<UserModel> GetByIdAsync(int id);
        Task<long> Update(UserUpdateRequestModel model);
    }
}
