using System;
using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities
{
    public abstract class UserPropertiesModel : BasePropertiesModel
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
    }
}
