using System;
using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.MethodModels.UserModel
{
    public class UserAddResponse : IBaseResponse
    {
        public Guid UserId { get; set; }
    }
}