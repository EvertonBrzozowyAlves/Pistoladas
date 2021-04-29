using Pistoladas.Models.Interfaces;

namespace Pistoladas.Business.User
{
    public interface IUserBusiness : IUser
    {
        long ActiveUsersSimpleMajority(long currentActiveUsersCount);
    }
}
