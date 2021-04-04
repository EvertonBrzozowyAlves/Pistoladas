using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.MethodModels.UserModel
{
    public class UserUpdateRequest : IBaseRequest
    {
        public long UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
    }
}
