using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.MethodModels.UserModel
{
    public class UserGetByIdRequest : BaseRequest
    {
        public long UserId { get; set; }
    }
}
