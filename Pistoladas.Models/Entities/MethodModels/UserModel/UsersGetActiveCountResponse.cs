using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.MethodModels.UserModel
{
    public class UsersGetActiveCountResponse : IBaseResponse
    {
        public long ActiveUsersCount { get; set; }
    }
}