using Pistoladas.Models.Entities.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pistoladas.Business.User
{
    public interface IUserBusiness
    {
       Task<IEnumerable<UserModel>> GetAllActiveAsync();
        UserModel GetById(int id);
    }
}
