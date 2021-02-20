using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.User
{
    public class UserGetByIdRequestModel : RequestModel
    {
        public long UserId { get; set; }
    }
}
