using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.MethodModels.UserModel
{
    public class UserAddRequest : IBaseRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
    }
}