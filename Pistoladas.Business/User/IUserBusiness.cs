using Pistoladas.Models.Entities;
using Pistoladas.Models.Entities.User;
using System.Collections.Generic;

namespace Pistoladas.Business.User
{
    public interface IUserBusiness
    {
        IEnumerable<UserModel> GetAllActive();
        UserModel GetById(int id);
    }
}
