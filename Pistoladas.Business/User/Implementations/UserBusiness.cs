using Pistoladas.Data.User;
using Pistoladas.Models.Entities.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pistoladas.Business.User.Implementations
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserData _userData;
        public UserBusiness(IUserData userData)
        {
            _userData = userData;
        }

        public async Task<IEnumerable<UserModel>> GetAllActiveAsync()
        {
            return await _userData.GetAllActiveAsync();
        }

        public UserModel GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
