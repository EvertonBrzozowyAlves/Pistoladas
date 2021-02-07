using Pistoladas.Models.Entities.User;
using System;
using System.Collections.Generic;
using Pistoladas.Data.Providers.Dapper;

namespace Pistoladas.Data.User.Implementations
{
    public class UserDataDapper : DataBaseOperationsDapper<UserModel>, IUserData
    {
        public IEnumerable<UserModel> GetAllActive()
        {
            return List(""); //TODO
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
