using System.Linq;
using System.Threading.Tasks;
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
            Task databaseResult = null;
            try
            {
                var teste =  Task.Run(() => _data.GetById(new UserGetByIdRequest()
                {
                    UserId = userId
                }));

                databaseResult = Task.WhenAll(teste);
                await databaseResult;
            }
            catch
            {
                if (databaseResult?.Exception != null)
                {
                    var exception = databaseResult.Exception.InnerExceptions.First();
                    Assert.IsType<UserNotFoundException>(exception);
                }
            }

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