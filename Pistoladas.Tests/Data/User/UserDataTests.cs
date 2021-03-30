using Pistoladas.Data.User;
using Pistoladas.Models.Entities.MethodModels.UserModel;
using Xunit;

namespace Pistoladas.Tests.Data.User
{
    public class UserDataTests
    {
        private readonly IUserData _data;
        
        public UserDataTests(IUserData data)
        {
            _data = data;
        }
        
        [Theory]
        [InlineData(1)]
        public void GetById_ShouldReturnUser(int userId)
        {
            var result = _data.GetById(new UserGetByIdRequest()
            {
                UserId = userId
            });
            
            Assert.IsType<UserGetByIdResponse>(result);
        }
        
        [Theory]
        [InlineData(0)]
        [InlineData(long.MaxValue)]
        public void GetById_ShouldReturnNull(long userId)
        {
            var result = _data.GetById(new UserGetByIdRequest()
            {
                UserId = userId
            });
            
            Assert.Null(result);
        }
    }
}