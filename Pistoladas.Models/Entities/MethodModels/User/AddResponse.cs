using System;
using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.MethodModels.User
{
    public class AddResponse : IBaseResponse
    {
        public Guid UserId { get; set; }
    }
}