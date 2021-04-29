using Pistoladas.Business.User;
using Xunit;

namespace Pistoladas.Tests.Business.User
{
    public class Tests
    {
        private readonly IUserBusiness _business;
        
        public Tests(IUserBusiness business)
        {
            _business = business;
        }
        
        [Theory]
        [InlineData(20)]
        [InlineData(0)]
        public void ActiveUsersSimpleMajority_ShouldReturnInlineDataValueDividedByTwoPlusOne(long activeUserCount)
        {
            var result = _business.ActiveUsersSimpleMajority(activeUserCount);
            var expected = activeUserCount / 2 + 1;
            Assert.Equal(expected, result);
        }
    }
}