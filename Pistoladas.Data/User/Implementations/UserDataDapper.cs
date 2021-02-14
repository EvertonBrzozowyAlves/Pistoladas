using Pistoladas.Models.Entities.User;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Pistoladas.Data.Providers.Dapper;

namespace Pistoladas.Data.User.Implementations
{
    public class UserDataDapper : DataBaseOperationsDapper<UserModel>, IUserData
    {
        public async Task<IEnumerable<UserModel>> GetAllActiveAsync()
        {
            return await List("PROC_USERS_LST"); 
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
