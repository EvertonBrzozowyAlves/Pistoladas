using Pistoladas.Models.Entities.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pistoladas.Data.User
{
    public interface IUserData
    {
        Task <IEnumerable<UserModel>> GetAllActiveAsync();
        UserModel GetById(int id);
    }
}
