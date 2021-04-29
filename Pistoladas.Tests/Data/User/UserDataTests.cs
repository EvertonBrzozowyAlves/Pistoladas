using System;
using System.Collections.Generic;
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
        [InlineData("AC60EFB7-1AA6-EB11-B22B-001A7DDA7110")]
        public async void GetById_ShouldReturnUserGetByIdResponse(Guid userId)
        {
            var result = await _data.GetById(new UserGetByIdRequest()
            {
                UserId = userId
            });
            
            Assert.IsType<UserGetByIdResponse>(result);
        }
        
        [Theory]
        [InlineData("00000000-0000-0000-0000-000000000000")]
        public async void GetById_ShouldThrowUserNotFoundException(Guid userId)
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
        
        [Fact]
        public async void GetAllActive_ShouldReturnUsersGetAllActiveResponse()
        {
            var result = await _data.GetAllActive(new UsersGetAllActiveRequest());
            
            Assert.IsAssignableFrom<IEnumerable<UsersGetAllActiveResponse>>(result);
        }
        
        [Fact]
        public async void GetActiveCount_ShouldReturnUsersGetActiveCountResponse()
        {
            var result = await _data.GetActiveCount(new UsersGetActiveCountRequest());
            
            Assert.IsType<UsersGetActiveCountResponse>(result);
        }
    }
}