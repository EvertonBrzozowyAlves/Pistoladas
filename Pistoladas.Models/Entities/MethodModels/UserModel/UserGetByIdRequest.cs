using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.MethodModels.UserModel
{
    public class UserGetByIdRequest : IBaseRequest
    {
        public long UserId { get; set; }
    }
}
