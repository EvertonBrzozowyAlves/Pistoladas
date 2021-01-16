using Pistoladas.Models.Entities.User;
using System.Collections.Generic;

namespace Pistoladas.Data.User
{
    public interface IUserData
    {
        IEnumerable<UserModel> GetAllActive();
        UserModel GetById(int id);
    }
}
