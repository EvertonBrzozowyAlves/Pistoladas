using System;
using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.MethodModels.User
{
    public class GetAllActiveResponse : IBaseResponse
    {
        public Guid UserId { get; set; }
        public bool IsActive { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
    }
}