using System;
using System.Collections.Generic;
using Pistoladas.Data.User;
using Pistoladas.Models.Entities.MethodModels.User;
using Pistoladas.Models.Exceptions.User;
using Xunit;

namespace Pistoladas.Tests.Data.User
{
    public class Tests
    {
        private readonly IUserData _data;
        
        public Tests(IUserData data)
        {
            _data = data;
        }
        
        [Theory]
        [InlineData("AC60EFB7-1AA6-EB11-B22B-001A7DDA7110")]
        public async void GetById_ShouldReturnUserGetByIdResponse(Guid userId)
        {
            var result = await _data.GetById(new GetByIdRequest()
            {
                UserId = userId
            });
            
            Assert.IsType<GetByIdResponse>(result);
        }
        
        [Theory]
        [InlineData("00000000-0000-0000-0000-000000000000")]
        public async void GetById_ShouldThrowUserNotFoundException(Guid userId)
        {
            await Assert.ThrowsAnyAsync<UserNotFoundException>(() => _data.GetById(new GetByIdRequest()
            {
                UserId = userId
            }));
        }

        [Fact]
        public async void Add_ShouldReturnUserAddResponse()
        {
            var result = await _data.Add(new AddRequest()
            {
                Email = "teste@everton.com",
                MobilePhone = "11999999999",
                Name = "Teste"
            });
            
            Assert.IsType<AddResponse>(result);
        }
        
        [Fact]
        public async void GetAllActive_ShouldReturnUsersGetAllActiveResponse()
        {
            var result = await _data.GetAllActive(new GetAllActiveRequest());
            
            Assert.IsAssignableFrom<IEnumerable<GetAllActiveResponse>>(result);
        }
        
        [Fact]
        public async void GetActiveCount_ShouldReturnUsersGetActiveCountResponse()
        {
            var result = await _data.GetActiveCount(new GetActiveCountRequest());
            
            Assert.IsType<GetActiveCountResponse>(result);
        }
    }
}