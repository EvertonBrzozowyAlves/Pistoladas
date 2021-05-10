using System;
using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.MethodModels.User
{
    public class GetByIdRequest : IBaseRequest
    {
        public Guid UserId { get; set; }
    }
}
