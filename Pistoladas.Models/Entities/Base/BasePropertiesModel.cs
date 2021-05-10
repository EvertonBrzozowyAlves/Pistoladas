using System;

namespace Pistoladas.Models.Entities.Base
{
    public abstract class BasePropertiesModel
    {
        public bool IsActive { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
