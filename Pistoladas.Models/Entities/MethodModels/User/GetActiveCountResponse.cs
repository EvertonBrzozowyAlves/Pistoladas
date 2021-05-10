using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.MethodModels.User
{
    public class GetActiveCountResponse : IBaseResponse
    {
        public long ActiveUsersCount { get; set; }
    }
}