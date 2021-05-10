using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Pistoladas.Models.Entities.MethodModels.User;

namespace Pistoladas.Business.User.Implementations
{
    public class UserBusinessMock : IUserBusiness
    {
        public Task<GetByIdResponse> GetById(GetByIdRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetAllActiveResponse>> GetAllActive(GetAllActiveRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<AddResponse> Add(AddRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<GetActiveCountResponse> GetActiveCount(GetActiveCountRequest request)
        {
            throw new NotImplementedException();
        }

        public long ActiveUsersSimpleMajority(long currentActiveUsersCount)
        {
            throw new NotImplementedException();
        }
    }
}
