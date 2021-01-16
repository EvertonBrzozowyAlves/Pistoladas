using Pistoladas.Data.Dapper;
using Pistoladas.Models.Entities.User;
using System;
using System.Collections.Generic;

namespace Pistoladas.Data.User.Implementations
{
    public class UserDataDapper : DataBaseOperationsDapper, IUserData
    {
        public IEnumerable<UserModel> GetAllActive()
        {
            return List<UserModel>(""); //TODO
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
