using Pistoladas.Data.User;
using Pistoladas.Models.Entities.MethodModels.UserModel;
using Pistoladas.Models.Exceptions.User;
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
        public async void GetById_ShouldReturnUserGetByIdResponse(int userId)
        {
            var result = await _data.GetById(new UserGetByIdRequest()
            {
                UserId = userId
            });
            
            Assert.IsType<UserGetByIdResponse>(result);
        }
        
        [Theory]
        [InlineData(0)]
        [InlineData(long.MaxValue)]
        public async void GetById_ShouldThrowUserNotFoundException(long userId)
        {
            await Assert.ThrowsAnyAsync<UserNotFoundException>(() => _data.GetById(new UserGetByIdRequest()
            {
                UserId = userId
            }));
        }

        [Fact]
        public async void Add_ShouldReturnUserAddResponse()
        {
            var result = await _data.Add(new UserAddRequest()
            {
                Email = "teste@everton.com",
                MobilePhone = "11999999999",
                Name = "Teste"
            });
            
            Assert.IsType<UserAddResponse>(result);
        }
    }
}